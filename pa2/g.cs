using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using pa.classes;
using System.Diagnostics;

namespace pa
{
    /*
<sms_server>http://sms.nicesms.co.kr/cpsms_utf8/cpsms.aspx</sms_server>
<sms_id>lstest</sms_id>
<sms_pw>FFo0DXm9fvE9LBlkZIsO+IIhNQINR+1SM2KV2uCr3BY=</sms_pw>

* */
    using gClass;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Reflection;
    using Wisej.CodeProject;

    public static class g
    {
        #region // 글로벌 변수 선언 
        static public string appPath { get; set; } = @"C:\SimplePA\";
        static public Device MainDSP { get; set; } = new Device();
        public static signalr _hub { get; set; } = null;

        static public MainWindow mainWindow { get; set; }

        // 현재 방송중인 내용
        static public List<PlayItemSig> play8ch { get; set; } = new List<PlayItemSig>(new PlayItemSig[9]);

        static public PlayItemSig curr_play { get; set; } = new PlayItemSig();

        static public int em_status { get; set; } = 0;  // 화재 1,2 시험 알람 3,4 가스 5,6  
        // 컬러데이터 정의 , 이벤트 처리시 활용 
        public static MakeBasic makeBasic { get; set; } = new MakeBasic();


        // DSP 제어을 위함 
        public static DSPControll dsp { get; set; } = new DSPControll(); // 볼륨과 뮤트 처리용 
        public static int[] MetrixChIn { get; set; } = { 16, 17, 18, 19, 20, 21, 22, 23 }; // 입력채널 번호 

        // 알람 종류 0 없음, 1 시험 알람 , 2 PR 형 알람 
        public static int Alarm { get; internal set; } = 0; // 계속적인 발생을 관리 
        public static bool TestAlarm { get; internal set; } = false;

        #endregion

        #region // XML 처리 
        static public void XMLRead()
        {
            //LoadSQLLiteAssembly();
            if (System.IO.File.Exists("EM_ServerIP.ini") == false)
            {
                System.IO.File.WriteAllText("EM_ServerIP.ini", "127.0.0.1");
            }
            string ini = System.IO.File.ReadAllText("EM_ServerIP.ini");
            gl._BaseData.EMServerIP = ini;
            // 타임서버 연동 처리 
            //SyncLocalTime();

            // 기초디비, 스피커 디비
            gl.XMLSimplePA(true);
            gl._BaseData.EMServerIP = ini;

            gl.XMLDanteDevice(true);
            gl.XMLSimpleMusic(true);
            gl.XMLSimpleSpeaker(true);
            gl.XMLEMList(true);

            g.Log("Start PA");

            // 디렉토리에서 읽기 , 기초디비, 음원디비, 스피커, 스피커 그룹, 층 도면 
            gl.ReadSimplePA();
            makeBasic.ReadMusic(gl._MusicList);
            // 새로만들기 포함 처리 - 디비 변경시 변경 처리 요망 
            makeBasic.ReadAssetList(gl._SpeakerList);
            makeBasic.ReadFloor(gl._FloorBase);
            gl.XMLFloor(false);

            g.Log("Start PA1");
            // 이벤트 기초 데이터 처리를 위한 테스트 모듈 
            //ReadScheduleTestData(); 
            //g._SchTreeList.child = XMLRW(_SchTreeList, true, "BSSchedule.xml").child;
            gl.XMLSchedule(true);
            gl.XMLSimplePAMulti(true);
            gl.XMLAssetGroupList(true);
            
            if (gl._AssetGroupList.child.Count == 0)
            {
                MakePreset();
            }
            gl.XMLBS1Tree(true);
            gl.XMLInfoTree(true);
            gl.XMLFloor(true);
            gl.XMLFloorTree(true);
            gl.XMLSimpleHistory(true);
            UpdateTree();

            g.Log("Start PA2");
            MakeMainDSP();
            MakeSpeakerIP();
            UpdateFloorTree();
            UpdateFloorSpeak();

            g.Log("Start PA3");
            // 초기 셋팅한거 저장하기 
            gl.XMLSimplePA(false);
            gl.XMLEMList(false);
            gl.XMLSimpleMusic(false);
            gl.XMLSimpleSpeaker(false);

            g.Log("Start PA4");

            for (int i = 0; i < 9; i++)
            {
                play8ch[i] = new PlayItemSig();
            }
        }

        public static void LoadSQLLiteAssembly()
        {
            Uri dir = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            FileInfo fi = new FileInfo(dir.AbsolutePath);
            string appropriateFile = Path.Combine(fi.Directory.FullName, GetAppropriateSQLLiteAssembly());
            Assembly.LoadFrom(appropriateFile);
        }

        private static string GetAppropriateSQLLiteAssembly()
        {
            string pa = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            string arch = ((String.IsNullOrEmpty(pa) || String.Compare(pa, 0, "x86", 0, 3, true) == 0) ? "32" : "64");
            return "System.Data.SQLite.x" + arch + ".DLL";
        }

        private static void MakePreset()
        {
        }


        // 층 도면에는 있는데 스피커에는 없는경우 데이터 일치 안됨 => 일치 시키기 
        private static void UpdateFloorSpeak()
        {
            foreach (FloorMap t1 in gl._FloorTreeList.Child)
            {
                if (t1.content != "Speaker1")

                    continue;
                var sAsset = gl._SpeakerList.asset.Find(p => p.path == t1.assetname);
                if (sAsset != null)
                {
                    if(sAsset.floor == "")
                    sAsset.floor =  t1.buildingname + "/" + t1.floor;
                }

            }
        }

        // 층에 있는 스피커 데이터가 파일에 없으면 예전 데이터라 삭제 처리 
        private static void UpdateFloorTree()
        {
            List<FloorMap> a1 = new List<FloorMap>();

            foreach (FloorMap t1 in gl._FloorTreeList.Child)
            {
                if (t1.content != "Speaker1")
                    continue;

                string str1;
                str1 = @"C:\SimplePA\Speaker\" + t1.assetname;
                if (!System.IO.File.Exists(str1))
                {
                    a1.Add(t1);
                }
            }

            foreach (FloorMap t1 in a1)
            {
                gl._FloorTreeList.Child.Remove(t1);
            }

        }

        // 스피커 자산이 추가시 기존 디비 갱신용 
        // child -> AssetList ret 
        // 기존 child 는 참조용 
        private static void UpdateTree()
        {
        }

        private static List<Asset> makeAssetSync(List<Asset> child, List<Asset> assetList)
        {
            List<Asset> ret = new List<Asset>();
            ret = ObjectCopier.Clone(assetList);

            foreach (Asset t1 in child)
            {
                if (t1.chk)
                {
                    var t5 = ret.Where(p => p.path == t1.path).FirstOrDefault();
                    if (t5 != null)
                    {
                        t5.chk = t1.chk;
                    }
                }
            }
            return ret;
        }

        private static void MakeMainDSP()
        {
            var t2 = gl.danteDevice._DanteDevice.Find(p => p.DeviceName == gl._BaseData.ServerIP);
            if (t2 != null)
            {
                if(MainDSP.DeviceName == "")
                    MainDSP = t2;
            }
        }

        private static void MakeSpeakerIP()
        {
            foreach (Asset t1 in gl._SpeakerList.asset)
            {
                if (t1.DeviceName == "")
                {
                    t1.state = ""; // "Off-Line";
                    continue;
                }
                var t2 = gl.danteDevice._DanteDevice.Find(p=>p.name == t1.DeviceName || p.DeviceName == t1.DeviceName);
                if (t2 != null)
                {
                    t1.state = "On-Line";
                    t1.ip = t2.ip;
                    // 4440 포트는 사용치 않을 예정임  2021.01.26 romee
                    //AliveChk(t1.ip);
                }
                else
                {
                    t1.state = ""; // "Off-Line";
                }
            }
            //timeron();
        }


        // 나갈떼 저장 처리용
        static public void XMLWrite()
        {
            gl.XMLSimpleHistory(false);
            gl.XMLSimpleSpeaker(false);
            gl.XMLSimplePA(false);
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

        // 네트웍 상태와 DSP 연결 이상 유무 파악 용 
        public static bool NetworkChk = false;

        static string old_string = "";
        public static void Log(string str1)
        {
            if (gl._BaseData.Reserved4 != "1")
                return;

            if (str1 == old_string)
                return;
            old_string = str1;

            try
            {
                string fn = "svr_" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString();
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
        public static List<AssetBase> GetAssetList(PlayItemSig play1)
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
                SimpleMulti t1 = gl._SimpleMultiListSch.child.Find(p => p.idno == play1.idno);
                ret = ObjectCopier.Clone(t1.gstree.child);
            }
            else if (play1.kind == "정규방송")
            {
                SimpleMulti t1 = gl._SimpleMultiList.child.Find(p => p.idno == play1.idno);
                ret = ObjectCopier.Clone(t1.gstree.child);
            }
            return ret.ToList();
        }

        // 스피커의 현재 상태 체크 
        public static int getSpeakerState(string path)
        {
            var sAsset = gl._SpeakerList.asset.Find(p => p.path == path);
            if (sAsset != null)
            {
                if (sAsset.state == "On-Line")
                    return 1;
            }
            return 0;
        }

        // 다원방송 사용한 메트릭스 초기화 처리 
        // 입출력 채널 초기화 처리 
        public static void DSP_metrix_initial(int chno)
        {
            BSAsset bsa = new BSAsset();
            bsa.id = BS_DSP_STATE.INIT;
            bsa.onoff = 0;
            bsa.chno = chno;
            BSThreadClass.AddData(bsa);
        }

        // 선택된 특정 스피커만 처리 하기  
        public static void DSP_MakeGroupSpeaker(List<AssetBase> child, int v, BS_DSP_STATE k, int chno = 0)
        {
            BSAsset bsa = new BSAsset();

            bsa.onoff = v;
            bsa.id = k;
            bsa.chno = chno;

            if (child != null)
            {
                foreach (AssetBase t1 in child)
                {
                    if (t1.chk) //  = v == 1 ? true : false;
                        bsa.child.Add(t1);
                }
            }
            BSThreadClass.AddData(bsa);
        }

        public static void DSP_EMMakeGroupSpeaker(List<Device> child, int v, BS_DSP_STATE k, int chno = 0)
        {
            BSAsset bsa = new BSAsset();

            bsa.onoff = v;
            bsa.id = k;
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
        public static bool CheckSpace(PlayItemSig curr_play, PlayItemSig sch_play)
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

        internal static void SendR(string v1, eSignalRMsgType t1, int s1, int s2) // s1 = seq, s2=state
        {
            SignalRMsg signalRMsg = new SignalRMsg();
            
            signalRMsg.message = v1;
            signalRMsg.Msgtype = t1;
            signalRMsg.seqno = s1;
            signalRMsg.state = s2;
            signalRMsg.play8sig = g.play8ch;

            if (g._hub != null)
                g._hub.MessageS2C2(signalRMsg);
            g.Log(v1 + ";" + s1.ToString() + ";" + s2.ToString());
        }

#if DEBUG2
        public static void dbcopy(mainEntities db)
        {
            int i = 1;

            /*
            gLibary.ReadXML();

            List<Asset> ab1 = new List<Asset>();
            ab1 = gl._SpeakerList.asset;
            db.Assets.AddRange(gl._SpeakerList.asset);

            List<AssetGroup> ag1 = new List<AssetGroup>();

            for (i = 1; i < 5; i++)
            {
                AssetGroup v3 = new AssetGroup();
                v3.Name = "PRESET" + i.ToString();
                v3.add(ab1);
                ag1.Add(v3);
            }
            db.AssetGroups.AddRange(ag1);

            List<EventVM> e1 = new List<EventVM>();
            e1 = gl._event_list.child;
            db.Eventvm.AddRange(e1);

            List<Holiday> child = new List<Holiday>();
            child = gl._BaseData.holiday;
            db.Holidays.AddRange(child);

            List<FloorBase> f1 = new List<FloorBase>();
            i = 1;
            foreach (var t1 in gl._FloorBase.Child)
            {
                FloorBase fl1 = new FloorBase();
                fl1.FloorBaseId = i++;
                fl1.assetname = t1.assetname;
                fl1.buildingname = t1.buildingname;
                fl1.content = t1.content;
                fl1.filename = t1.filename;
                fl1.floor = t1.floor;
                fl1.floororder = t1.floororder;
                fl1.Id = t1.Id;
                fl1.left = t1.left;
                fl1.logicid = t1.logicid;
                fl1.top = t1.top;
                f1.Add(fl1);
            }
            db.Floorbases.AddRange(f1);

            List<FloorMap> f2 = new List<FloorMap>();
            f2 = gl._FloorTreeList.Child;
            db.Floormaps.AddRange(f2);

            List<InfoTree> i1 = new List<InfoTree>();
            i1 = gl._InfoTreeList.child;
            db.InfoTrees.AddRange(i1);

            List<Music> m1 = new List<Music>();
            m1 = gl._MusicList.music;
            db.Musics.AddRange(m1);

            List<SimpleMulti> s1 = new List<SimpleMulti>();
            s1 = gl._SimpleMultiList.child;
            db.SimpleMultis.AddRange(s1);


            List<UserTree> u1 = new List<UserTree>();
            u1 = gl._BaseData.user;
            db.UserTrees.AddRange(u1);
            */

            Simplepa s2 = new Simplepa();
            s2.SimplePAId = 1;
            //db.Simplepa.AddRange((IEnumerable<Simplepa>)s2);
            db.Simplepa.AddOrUpdate(s2);

            db.SaveChanges();
            //            var db1 = serviceProvider.GetService<LiraryService>();
            //            var t1 = db1.FindUser("1");

            /*
                        List<PlayItem> p1 = new List<PlayItem>();
                        p1 = gl.playHistory.child;
                        db.PlayItems.AddRange(p1);

                        db.SaveChanges();
            */
        }
#endif
    }

}
