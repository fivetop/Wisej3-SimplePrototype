using DataClass;
using gClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using simplepa2;
using simplepa2.DataSet1TableAdapters;
using static simplepa2.DataSet1;
using System.Net;

namespace pa
{
    //
    // 리시브 시그날알 처리 
    //

    public partial class MainWindow : Window
    {
        internal async Task<bool> RcvSigR(SignalRMsg msg)
        {
            if (msg.EMNAME != g._EMClient.EM_NAME)
            {
                if (msg.EMNAME != "ALL")
                    return false;
            }
            switch (msg.Msgtype)
            {
                case eSignalRMsgType.eEM:
                    break;
                case eSignalRMsgType.eEM_FIRE:
                    break;
                case eSignalRMsgType.eEM_PRESET_SW:
                    break;
                // 1. 빈 채널 받고, 2. 디비 만들고, 3. 빈채널 셋팅하고
                // 4. 스피커 셋팅하고 , 5. 방송 처리 
                case eSignalRMsgType.ePlay:
                    List<AssetBase> play = new List<AssetBase>();
                    play = dBAccess.db2List(msg);

                    int chno = msg.chno;
                    g.playItems[chno] = new PlayItem();
                    g.playItems[chno].p_run = true;
                    g.playItems[chno].idno = 100000 + msg.seqno;
                    g.playItems[chno].state = "대기";
                    g.playItems[chno].chno = chno;
                    g.playItems[chno].Play = play;

                    PlayItem p = g.playItems[chno];
                    // 스피커 셋팅후 플레이 처리 
                    g.DSP_MakeGroupSpeaker(p.Play, 1, BS_DSP_STATE.MUL_BS, p.chno);
                    PlayChildProcess(p.chno, p.idno);

                    string line1 = string.Join(",", msg.assetsRows.ToArray());
                    string line2 = string.Join(",", msg.musicsRows.ToArray());

                    string line = line1 + " : " + line2;
                    string l1 = "다원방송시작";
                    g.Log(l1 + p.chno.ToString() + " : " + line);
                    dBAccess.Eventbss(l1,  g._EMClient.EM_NAME + " " +msg.chno.ToString() + "번 채널", line);
                    SendSigR("PLAYCHECK", eSignalRMsgType.ePlayCheck, msg.seqno, msg.chno);

                    // window3 처리 
                    break;
                case eSignalRMsgType.ePlayEnd:
                    break;
                case eSignalRMsgType.ePlaying:
                    break;
                case eSignalRMsgType.eStop:
                    //g.chno = getplay(msg.Guid);
                    MBSStop(msg.chno, 1);
                    SendSigR("STOP", eSignalRMsgType.eStop, msg.seqno, msg.chno);
                    g.playItems[msg.chno] = new PlayItem();
                    g.Log("다원방송중지" + msg.chno.ToString() + " : " + msg.seqno.ToString());
                    dBAccess.Eventbss("다원방송중지", g._EMClient.EM_NAME + " " + msg.chno.ToString() + "번 채널", msg.seqno.ToString());
                    break;
                case eSignalRMsgType.eVolume:
                    // db 처리 선행 필요 
                    dBAccess.DBRead();
                    _DanteDevice = dBAccess.Device;
                    InitVolume();
                    g.Log("eVolume");
                    break;
                case eSignalRMsgType.eOutChMove:
                    dBAccess.DBRead();
                    _DanteDevice = dBAccess.Device;
                    SpeakerAssignDSP(msg.message, msg.user_data1, msg.state, msg.user_data4);
                    g.Log("eOutChMove" + " : " + msg.message + " : " + msg.user_data1 + " : " + msg.state.ToString() + " : " + msg.user_data4.ToString());
                    break;
                case eSignalRMsgType.eInChMove:
                    dBAccess.DBRead();
                    _DanteDevice = dBAccess.Device;
                    MoveInputChannel(msg.user_data1, msg.state, msg.message, msg.user_data4);
                    g.Log("eInChMove" + " : " + msg.user_data1 + " : " + msg.state.ToString() + " : " + msg.message + " : " + msg.user_data4.ToString());
                    break;
                case eSignalRMsgType.eScanAll:
                    if (ScanAll())
                    {
                        SendSigR(eSignalRMsgType.eReturn, "Server : 전체스캔 처리중 입니다. 약 5분정도 소요될 예정입니다");
                        g.Log("eScanAll");
                    }
                    else
                    {
                        SendSigR(eSignalRMsgType.eReturn, "Server : 처리(진행)중 입니다.");
                    }
                    break;
                case eSignalRMsgType.eFileDown:
                    g.Log("eFileDown FileName : " + msg.user_data1);
                    downloadFile(msg.user_data1);
                    break;
                case eSignalRMsgType.eScanEM:
                    if (dBAccess.EMServerUpdate())
                    {
                        SendSigR(eSignalRMsgType.eScanEM, "처리 완료 입니다.");
                        g.Log("eScanEM : 처리 완료 입니다.");
                    }
                    else
                    {
                        SendSigR(eSignalRMsgType.eScanEM, "재실행이 필요합니다.");
                        g.Log("eScanEM : 재실행이 필요합니다.");
                    }
                    break;
                case eSignalRMsgType.eScheduleDown:
                    g.Log("Schedule Down");
                    makeDBSchdule();
                    MakePlayList(_db); // 예약방송 업데이트
                    break;
            }
            return true;
        }


        private void ChSet(int chno)
        {
        }

        // 빈채널 찾기 
        private int EmptyChFind()
        {
            int rlt = 0;
            for (int i = 2; i < 9; i++)
            {
                PlayItem pl1 = g.playItems[i];
                if (pl1.p_run)
                    continue;
                if (pl1.idno != 0)
                    continue;
                if (pl1.state != "대기")
                    continue;
                rlt = i;
                break;
            }
            return rlt;
        }


        internal static void SendSigR(string t1, eSignalRMsgType v1, int s1, int s2) // s1 = seq, s2=state
        {
            SignalRMsg msg1 = new SignalRMsg();

            msg1.EMNAME = g._EMClient.EM_NAME;
            msg1.message = t1;
            msg1.Msgtype = v1;
            msg1.seqno = s1;
            msg1.state = s2;

            switch (v1)
            {
                case eSignalRMsgType.eEM:
                    break;
                case eSignalRMsgType.eEM_FIRE:
                    break;
                case eSignalRMsgType.eEM_PRESET_SW:
                    break;
                case eSignalRMsgType.ePlay:
                    break;
                case eSignalRMsgType.eStop:
                    break;
                case eSignalRMsgType.ePlaying:
                    msg1.message = "ePlaying";
                    // 예약방송 btree update 필요 
                    break;
                case eSignalRMsgType.ePlayEnd:
                    msg1.message = "ePlayEnd";
                    g.mainWindow.dBAccess.BSTreeCDelete(msg1.seqno, msg1.state);
                    break;
                case eSignalRMsgType.eLoginUser:
                    msg1.EMNAME = g._EMClient.EM_NAME;
                    break;
                case eSignalRMsgType.eLogoutUser:
                    msg1.EMNAME = g._EMClient.EM_NAME;
                    break;
                case eSignalRMsgType.eFindDSP:
                    msg1.EMNAME = g._EMClient.EM_NAME;
                    break;
            }
            signalRClient.MessageC2S2(msg1);
            //g.Log(v1 + ";" + s1.ToString() + ";" + s2.ToString());
        }
        internal static void SendSigR(eSignalRMsgType v1, string r1, int state = 0) // s1 = seq, s2=state
        {
            SignalRMsg msg1 = new SignalRMsg();

            msg1.EMNAME = g._EMClient.EM_NAME;
            msg1.message = r1;
            msg1.Msgtype = v1;
            msg1.state = state;
            signalRClient.MessageC2S2(msg1);
            //g.Log(v1 + ";" + s1.ToString() + ";" + s2.ToString());
        }


        private void downloadFile(string url)
        {
            // url 등록 필요  romee
            return;
            string file = System.IO.Path.GetFileName(url);
            WebClient cln = new WebClient();
            cln.DownloadFile(url, file);
        }

    }
}
