using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using DataClass;
using gClass;
using pa.Windows;
using System.ComponentModel;
using System.Threading;
using static Wisej.CodeProject.DataSet1;

/*
<sms_server>http://sms.nicesms.co.kr/cpsms_utf8/cpsms.aspx</sms_server>
<sms_id>lstest</sms_id>
<sms_pw>FFo0DXm9fvE9LBlkZIsO+IIhNQINR+1SM2KV2uCr3BY=</sms_pw>

* */

namespace pa
{
    public static class g
    {
        #region // 글로벌 변수 선언 
        static public string appPath { get; set; } = @"C:\SimplePA\";
        public static signalr _hub { get; set; } = null;
        static public MainWindow mainWindow { get; set; }
        // 현재 방송중인 내용
        static public List<PlayItem> playItems { get; set; } = new List<PlayItem>(new PlayItem[9]);
        // DSP 제어을 위함 
        public static DSPControll dsp { get; set; } = new DSPControll(); // 볼륨과 뮤트 처리용 
        public static SimplepaRow _BaseData { get; set; }
        #endregion

        #region // XML 처리 
        static public void XMLRead()
        {
            for (int i = 1; i < 9; i++)
            {
                playItems[i] = new PlayItem();
                playItems[i].chno = i;
            }
            // 기초디비, 스피커 디비
            gl.XMLDanteDevice(true);
            g.Log("Start PA");
        }
        #endregion

        #region // 유틸리티 DoWorkWithModal, ReadConfig, GetAssetList, GetMusicList2, GetDuration
        // 기본 폴더 지정 
        internal static void ReadConfig()
        {
            //파일경로
            string strFile = AppDomain.CurrentDomain.BaseDirectory + @"pa.config";
            FileInfo fileInfo = new FileInfo(strFile);
            //파일 있는지 확인 있을때(true), 없으면(false)
            if (fileInfo.Exists)
            {
                appPath = File.ReadAllText(@strFile);
            }
        }

        static string old_string = "";
        public static void Log(string str1)
        {
            if (str1 == old_string)
                return;
            old_string = str1;

            try
            {
                string fn = "svr_" + DateTime.Now.ToString("yyyy_MM_dd");
                StreamWriter writer = new StreamWriter(File.Open("C:\\SimplePA\\Log\\" + fn + ".txt", FileMode.Append));
                TextWriterTraceListener listener = new TextWriterTraceListener(writer);
                //Debug.Listeners.Add(listener);
                //Debug.WriteLine(string.Format("{0} : {1}", DateTime.Now, str1));
                //Debug.Flush();
                string st1 = string.Format("{0} : {1}", DateTime.Now, str1);
                writer.WriteLine(st1);
                writer.Close();
                Console.WriteLine(st1);
                if (mainWindow != null)
                {
                    mainWindow.log(st1);
                }
            }
            catch (ObjectDisposedException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        #endregion

        // 방송 디비에서 해당 음원과 지역 데이터를 가져온다. 
        public static List<AssetBase> GetAssetList(PlayItem play1)
        {
            ICollection<AssetBase> ret = new List<AssetBase>();

            if (play1.kind == "그룹방송")
            {
//                InfoTree t1 = gl._BS1TreeList.child.Find(p => p.Id == play1.bsId);
//                ret = ObjectCopier.Clone(t1.gstree.child);
            }
            else if (play1.kind == "프리셋")
            {
//                InfoTree t1 = gl._InfoTreeList.child.Find(p => p.Id == play1.bsId);
//                ret = ObjectCopier.Clone(t1.gstree.child);
            }
            else if (play1.kind == "예약방송")
            {
            }
            else if (play1.kind == "정규방송")
            {
            }
            return ret.ToList();
        }

        // 다원방송 사용한 메트릭스 초기화 처리 
        // 입출력 채널 초기화 처리 
        public static void DSP_metrix_initial(int chno)
        {
            BSAsset bsa = new BSAsset();
            bsa.bS_DSP_STATE = BS_DSP_STATE.INIT;
            bsa.onoff = 0;
            bsa.chno = chno;
            BSThreadClass.AddData(bsa);
        }

        // 선택된 특정 스피커만 처리 하기  
        public static void DSP_MakeGroupSpeaker(List<AssetBase> child, int onoff, BS_DSP_STATE bS_DSP_STATE, int chno = 0)
        {
            BSAsset bsa = new BSAsset();

            bsa.onoff = onoff;
            bsa.bS_DSP_STATE = bS_DSP_STATE;
            bsa.chno = chno;

            if (child != null)
            {
                foreach (var t1 in child)
                {
                    bsa.child.Add(t1);
                }
            }
            BSThreadClass.AddData(bsa);
        }

        public static void DSP_EMMakeGroupSpeaker(List<Device> child, int v, BS_DSP_STATE k, int chno = 0)
        {
            BSAsset bsa = new BSAsset();

            bsa.onoff = v;
            bsa.bS_DSP_STATE = k;
            bsa.chno = chno;

            if (child != null)
            {
                foreach (Device t1 in child)
                {
                    bsa.device.Add(t1);
                }
            }
            BSThreadClass.AddData(bsa);
        }


        // 동일 시간 예약이나 방송 송출시 지역 점검 
        // 같은 지역인지 비교 처리 
        public static bool CheckSpace(PlayItem curr_play, PlayItem sch_play)
        {
            List<AssetBase> cur = g.GetAssetList(curr_play);
            List<AssetBase> res = g.GetAssetList(sch_play);

            // 앵커 방송은 Asset 정보를 현재 선택된 정보로 처리 하기 
            if (cur.Count == 0 && curr_play.kind == "앵커방송")
            {
                // --cur = curr_play.playGroup;
            }
            if (cur.Count == 0 || res.Count == 0)
            {
                g.Log(" 데이터 오류로 취소 됩니다. ");
                return true;
            }

            foreach (var t1 in cur)
            {
                if (t1.chk == false) continue;
                foreach (var t2 in res)
                {
                    // 패스와 체크가 맞으면 동시간대 동 지역임 
                    if (t1.path == t2.path)
                    {
                        g.Log(t1.path + " 지역의 다원 방송 진행으로 취소 됩니다. ");
                        return true;
                    }
                }
            }
            return false;
        }

        internal static void SendSigR(string t1, eSignalRMsgType v1, int s1, int s2) // s1 = seq, s2=state
        {
            SignalRMsg msg1 = new SignalRMsg();

            msg1.user = "Server";
            msg1.message = t1;
            msg1.Msgtype = v1;
            msg1.seqno = s1;
            msg1.state = s2;
            msg1.play8sig = g.playItems;

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
                    break;
                case eSignalRMsgType.ePlayEnd:
                    msg1.message = "ePlayEnd";
                    break;
                case eSignalRMsgType.eLoginUser:
                    msg1.user = "Server";
                    break;
                case eSignalRMsgType.eLogoutUser:
                    msg1.user = "Server";
                    break;
            }

            msg1.play8sig = playItems;
            if (g._hub != null)
                g._hub.MessageS2C2(msg1);
            //g.Log(v1 + ";" + s1.ToString() + ";" + s2.ToString());
        }

        public static void Load(string info)
        {
            g.DoWorkWithModal(progress =>
            {
                progress.Report(info);
                Thread.Sleep(1000);//placeholder for real work;
            });
        }

        public static void Info(string info)
        {
            if (mainWindow.ActualHeight == 0)
                return;
            g.DoWorkWithModal(progress =>
            {
                progress.Report(info);
                Thread.Sleep(300);//placeholder for real work;
                progress.Report(info);
                Thread.Sleep(300);//placeholder for real work;
            });
        }
        public static void DoWorkWithModal(Action<IProgress<string>> work)
        {
            ProgressBarDialog4 splash = new ProgressBarDialog4();

            splash.Loaded += (_, args) =>
            {
                BackgroundWorker worker = new BackgroundWorker();

                Progress<string> progress = new Progress<string>(
                    data => splash._txtStatus.Text = data);

                worker.DoWork += (s, workerArgs) => work(progress);

                worker.RunWorkerCompleted +=
                    (s, workerArgs) => splash.Close();

                worker.RunWorkerAsync();
            };

            try
            {
                splash.ShowDialog();
            }
            catch (Exception e1)
            {
            }
        }

    }

}
