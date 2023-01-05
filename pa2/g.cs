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
using static simplepa2.DataSet1;

/*
<sms_server>http://sms.nicesms.co.kr/cpsms_utf8/cpsms.aspx</sms_server>
<sms_id>lstest</sms_id>
<sms_pw>FFo0DXm9fvE9LBlkZIsO+IIhNQINR+1SM2KV2uCr3BY=</sms_pw>

*/

namespace pa
{
    [Serializable]
    public class EMClient
    {
        public string apppath { get; set; } = @"C:\SimplePA2\";
        public string EM_NAME { get; set; } = "서울";
        public string NetworkCardName { get; set; } = "이더넷";
        public int NetworkCardNo { get; set; } = 0;
        public int NetworkCardmDNS { get; set; } = 0;
        public string WebAPIURL { get; set; } = @"http://localhost:9921/api/";
        public string HubURL { get; set; } = @"http://localhost:8080/signalr";
        public string processname { get; set; } = @"pa_em";
        public string processfile { get; set; } = @"pa_em.exe";
        public string GPIOPort { get; set; } = @"COM4";
        public string Rport { get; set; } = @"COM3";
        public int Pport { get; set; } = 0;
        public int Jigsangbalhwa { get; set; } = 0;



        public EMClient()
        {
        }
    }


    public static class g
    {
        #region // 글로벌 변수 선언 
        static public MainWindow mainWindow { get; set; }
        // 현재 방송중인 내용
        static public List<PlayItem> playItems { get; set; } = new List<PlayItem>(new PlayItem[9]);
        // DSP 제어을 위함 
        public static DSPControll dsp { get; set; } = new DSPControll(); // 볼륨과 뮤트 처리용 
        static public EMClient _EMClient { get; set; } = new EMClient(); // 기초 정보

        // mdns ----------------
        // new DomainName("_services._dns-sd._udp.local"); 
        static public string _netaudio_arc = "_netaudio-arc._udp.local";
        //static public string _netaudio_dbc = "_netaudio-dbc._udp.local";
        static public string _netaudio_chan = "_netaudio-chan._udp.local";
        static public string _netaudio_cmc = "_netaudio-cmc._udp.local";

        static public Resolver resolver { get; set; } = null;
        // 동수. 계단수, 층수 초기화 필요 
        static public EmSpeakerPositionList _emspl { get; set; } = new EmSpeakerPositionList();

        #endregion

        #region // mdns =================================
        internal static void division()
        {
            // 디바이스 타입 번호 할당 
            foreach (Device t2 in gl.danteDevice._DanteDevice)
            {
                if (t2.DeviceName == "")
                    t2.DeviceName = t2.name;
                t2.makeDanteDeviceChannel();

            }
            // 1. 채널이름 할당 
            // 2. DSP Ch Out packet -> 271d~~
            // 3. 사운드 카드 찾기 
            foreach (Device t2 in gl.danteDevice._DanteDevice)
            {
                t2.makeDanteDeviceChannelSP();
                t2.makeDSPChannelpacket();
                t2.FindSoundCard();
            }
        }


        #endregion

        #region // XML 처리 
        static public void XMLRead()
        {
            for (int i = 1; i < 9; i++)
            {
                playItems[i] = new PlayItem();
                playItems[i].chno = i;
            }
            g.Log("Start PA");
        }
        #endregion

        #region // 유틸리티 DoWorkWithModal, ReadConfig, GetAssetList, GetMusicList2, GetDuration


        // DanteDevice 
        public static void XMLEMClient(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = AppDomain.CurrentDomain.BaseDirectory + "EMClient.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _EMClient = ser.Deserialize<EMClient>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<EMClient>(_EMClient);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                xmlData = ser.Serialize<EMClient>(_EMClient);
                File.WriteAllText(path, xmlData);
            }
        }

        // 기본 폴더 지정 
        internal static void ReadConfig()
        {
            //파일경로
            string strFile = AppDomain.CurrentDomain.BaseDirectory + @"pa.config";
            FileInfo fileInfo = new FileInfo(strFile);
            //파일 있는지 확인 있을때(true), 없으면(false)
            if (fileInfo.Exists)
            {
                string appPath = File.ReadAllText(@strFile);
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

        public static void DSP_EMMakeGroupSpeaker(List<DeviceRow> child, int v, BS_DSP_STATE k, int chno = 0)
        {
            BSAsset bsa = new BSAsset();

            bsa.onoff = v;
            bsa.bS_DSP_STATE = k;
            bsa.chno = chno;

            if (child != null)
            {
                foreach (DeviceRow t1 in child)
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
        public static void Load(string info)
        {
            g.DoWorkWithModal(progress =>
            {
                progress.Report(info);
                Thread.Sleep(5000);//placeholder for real work;
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
