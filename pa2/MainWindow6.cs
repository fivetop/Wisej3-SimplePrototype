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
using Wisej.CodeProject;
using Wisej.CodeProject.DataSet1TableAdapters;
using static Wisej.CodeProject.DataSet1;

namespace pa
{

    public partial class MainWindow : Window
    {
        internal async Task<bool> RcvSigR(SignalRMsg msg)
        {
            int chno = 0;

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
                    chno = EmptyChFind();
                    if (chno == 0) return false;
                    play = dBSqlite.db2List(msg, chno);
                    ChSet(chno);

                    var play8 =  g.play8ch[chno];
                    {
                        play8.chno = chno;
                        play8.idno = 100000 + chno;
                    }

                    // 스피커 셋팅후 플레이 처리 
                    g.DSP_MakeGroupSpeaker(play, 1, BS_DSP_STATE.MUL_BS, 1);
                    PlayChildProcess(chno, 100000 + chno);

                    string line1 = string.Join(",", msg.assetsRows.ToArray());
                    string line2 = string.Join(",", msg.musicsRows.ToArray());

                    string line = line1 + ";" + line2;

                    g.Log("다원방송:" + chno.ToString() + ";" + line);
                    dBSqlite.Eventvm("다원방송 시작", chno.ToString() + "번 채널", line);

                    break;
                case eSignalRMsgType.ePlayEnd:
                    break;
                case eSignalRMsgType.ePlaying:
                    break;
                case eSignalRMsgType.eStop:
                    break;
            }
            return true;
        }

        private void ChSet(int chno)
        {
            g.play8ch[chno] = new PlayItemSig();
            g.play8ch[chno].p_run = true;
            g.play8ch[chno].idno = 100000 + chno;
            g.play8ch[chno].state = "대기";
            g.play8ch[chno].chno = chno;
        }

        // 빈채널 찾기 
        private int EmptyChFind()
        {
            int rlt = 0;
            for (int i = 2; i < 8; i++)
            {
                PlayItemSig pl1 = g.play8ch[i];
                if (pl1.p_run)
                    continue;
                if (pl1.chno != 0 || pl1.idno != 0)
                    continue;
                if (pl1.state != "대기")
                    continue;
                rlt = i;
                break;
            }
            return rlt;
        }

    }
}
