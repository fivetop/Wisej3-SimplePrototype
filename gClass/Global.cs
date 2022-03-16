using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace gClass
{
    public static class gl
    {
        // 버젼, 실행 위치  
        static public string version { get; set; } = "Simple PA v1.014";
        static public string appPathServer { get; set; } = @"C:\SimplePA\";
        static public string appPathServer_speaker { get; set; } = @"C:\SimplePA\Speaker\";
        static public string appPathServer_log { get; set; } = @"C:\SimplePA\Log\";
        static public string appPathServer_music { get; set; } = @"C:\SimplePA\Music\";
        static public string appPathServer_image { get; set; } = @"C:\SimplePA\Image";
        // 기초 
        static public SimplePA _BaseData { get; set; } = new SimplePA(); // 기초 정보
        static public SimpleMusic _MusicList { get; set; } = new SimpleMusic(); // 음원 정보
        // logiccal speaker - 고객의 전체 스피커 리스트 처리 
        static public SimpleSpeaker _SpeakerList { get; set; } = new SimpleSpeaker(); // 
        // Group -> Zone -> Speaker 스피커 자산 트리 - 자동 생성 
        // 그룹관리를 위함 -> 메모리, 화면 -> 저장 없음 
        static public List<AssetTree> _AssetTreeList { get; set; } = new List<AssetTree>();
        // 도면파일에서  층별 데이터 생성 빌딩과 층, 도면이름만 있음
        static public SimpleMap _FloorBase { get; set; } = new SimpleMap();
        // 도면/층별/위치 데이터 - 위치 데이터 포함임
        static public SimpleMap _FloorTreeList { get; set; } = new SimpleMap();
        // 그룹 관리를 위한 리스트 
        static public AssetGroupList _AssetGroupList { get; set; } = new AssetGroupList();
        // 안내방송
        static public InfoTreeList _InfoTreeList { get; set; } = new InfoTreeList();
        // 그룹방송
        static public InfoTreeList _BS1TreeList { get; set; } = new InfoTreeList();
        // dante 
        static public DanteDevice danteDevice { get; set; } = new DanteDevice();
        //전체 방송 리스트 
        static public PlayList playList { get; set; } = new PlayList();
        //전체 방송 리스트 
        static public PlayList playHistory { get; set; } = new PlayList();
        // 알람/이벤트 처리
        //public static EventList _event_list { get; set; } = new EventList();
        // 동수. 계단수, 층수 초기화 필요 
        //static public EMEventLIST _emEventList { get; set; } = new EMEventLIST();
        static public EMLIST _emList { get; set; } = new EMLIST(); // 스피커의 층정보 리스트 스피커 수 만큼 

        // 예약방송 이벤트 리스트 
        static public SimpleMultiList _SimpleMultiListSch { get; set; } = new SimpleMultiList();
        // 다원방송
        static public SimpleMultiList _SimpleMultiList { get; set; } = new SimpleMultiList();

        static public EmSpeakerPositionList _emspl { get; set; } = new EmSpeakerPositionList();


        // 앰프 메트릭스 명령후 실행 안됨 메트릭스 찾기 
        public static object QueueLock { get; set; } = new object();
        // 실행 안됨 명령 모음 
        public static List<string> SvsR { get; set; } = new List<string>();
        // 실행할 메트릭스 카운트
        public static int MetrixCount { get; set; } = 0;


        #region // XML 처리 ,   XMLSimplePA, XMLSimpleSpeaker, XMLSchedule, XMLBS1Tree, XMLFloor, XMLLocation, XMLInfoTree, XMLGroupTree, ReadScheduleTestData

        static public void InitSimplePA()
        {
            if (System.IO.File.Exists(gl.appPathServer + @"gclass.ini") == false)
            {
                System.IO.File.WriteAllText(gl.appPathServer + @"gclass.ini", gl.appPathServer);
            }
            gl.appPathServer = System.IO.File.ReadAllText(gl.appPathServer + @"gclass.ini");

            appPathServer_speaker = gl.appPathServer + @"Speaker\";
            appPathServer_log = gl.appPathServer + @"Log\";
            appPathServer_music = gl.appPathServer + @"Music\";
            appPathServer_image = gl.appPathServer + @"Image\";

            var directoryInfo = new DirectoryInfo(appPathServer_speaker);
            directoryInfo.Create();
            directoryInfo = new DirectoryInfo(appPathServer_log);
            directoryInfo.Create();
            directoryInfo = new DirectoryInfo(appPathServer_music);
            directoryInfo.Create();
            directoryInfo = new DirectoryInfo(appPathServer_image);
            directoryInfo.Create();

            MakeBackup();
        }

        // 월단위 백업 실행 
        private static void MakeBackup()
        {
            DateTime dt1 = DateTime.Now;
            string backup = gl.appPathServer + @"Backup\" + dt1.ToString("yyyMM") +@"\";
            var directoryInfo = new DirectoryInfo(backup);
            if (directoryInfo.Exists) return;
            
            directoryInfo.Create();
            System.IO.File.Copy(gl.appPathServer + "SimplePA.xml", backup + "SimplePA.xml");
            System.IO.File.Copy(gl.appPathServer + "DanteDevice.xml", backup + "DanteDevice.xml");
        }

        // 기초 디비 저장 
        static public void XMLSimplePA(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "SimplePA.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _BaseData = ser.Deserialize<SimplePA>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<SimplePA>(_BaseData);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }
        // 음원 저장 
        static public void XMLSimpleMusic(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "SimpleMusic.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _MusicList = ser.Deserialize<SimpleMusic>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<SimpleMusic>(_MusicList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }
        // 스피커 저장 
        static public void XMLSimpleSpeaker(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "SimpleSpeaker.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _SpeakerList = ser.Deserialize<SimpleSpeaker>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<SimpleSpeaker>(_SpeakerList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }
        // 그룹방송 저장용 
        static public void XMLBS1Tree(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;
            path = @appPathServer + "BS1TreeList.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _BS1TreeList = ser.Deserialize<InfoTreeList>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<InfoTreeList>(_BS1TreeList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }

        }
        // 층 저장용 
        static public void XMLFloor(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;
            path = @appPathServer + "FloorBaseList.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _FloorBase = ser.Deserialize<SimpleMap>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<SimpleMap>(_FloorBase);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }
        // 위치 저장용 
        static public void XMLFloorTree(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;
            path = @appPathServer + "FloorTreeList.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _FloorTreeList = ser.Deserialize<SimpleMap>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<SimpleMap>(_FloorTreeList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }
        // 안내방송 저장용 
        static public void XMLInfoTree(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;
            path = @appPathServer + "BSInfo.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _InfoTreeList = ser.Deserialize<InfoTreeList>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<InfoTreeList>(_InfoTreeList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }

        // 그룹 저장용 
        static public void XMLAssetGroupList(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;
            path = @appPathServer + "AssetGroupList.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _AssetGroupList = ser.Deserialize<AssetGroupList>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<AssetGroupList>(_AssetGroupList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }

        // DanteDevice 
        public static void XMLDanteDevice(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "DanteDevice.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    danteDevice = ser.Deserialize<DanteDevice>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<DanteDevice>(danteDevice);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }

        // 스피커 저장 
        static public void XMLSimpleHistory(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "SimpleHistory.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    playHistory = ser.Deserialize<PlayList>(xmlData);
                }
                else
                {
                    var t1 = playList.child.Where(p => p.kind != "예약방송" && p.kind != "정규방송");
                    var t2 = t1.ToList();

                    foreach (PlayItem pl1 in t2)
                    {
                        playHistory.child.Add(pl1);
                    }
                    /*
                    var t3 = playHistory.child.Where(p => p.kind != "예약방송" && p.kind != "정규방송");
                    var t4 = t3.ToList();

                    playHistory.child.Clear();
                    foreach (PlayItem pl1 in t4)
                    {
                        playHistory.child.Add(pl1);
                    }
                    */
                    xmlData = ser.Serialize<PlayList>(playHistory);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }

        // 비상방송 저장 
        static public void XMLEMList(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "EMList.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _emList = ser.Deserialize<EMLIST>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<EMLIST>(_emList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }

        // 예약방송
        static public void XMLSchedule(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;
            path = @appPathServer + "SimpleMultiSch.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _SimpleMultiListSch = ser.Deserialize<SimpleMultiList>(xmlData);

                    foreach (SimpleMulti t1 in _SimpleMultiListSch.child)
                    {
                        t1.tss = new TimeSpan(t1.stm.Hour, t1.stm.Minute, t1.stm.Second);
                        t1.tse = new TimeSpan(t1.etm.Hour, t1.etm.Minute, t1.etm.Second);
                    }
                }
                else
                {
                    xmlData = ser.Serialize<SimpleMultiList>(_SimpleMultiListSch);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log("SimpleMultiSch");
            }
        }

        static public void XMLSimplePAMulti(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "SimpleMulti.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _SimpleMultiList = ser.Deserialize<SimpleMultiList>(xmlData);

                    foreach (SimpleMulti t1 in _SimpleMultiList.child)
                    {
                        t1.tss = new TimeSpan(t1.stm.Hour, t1.stm.Minute, t1.stm.Second);
                        t1.tse = new TimeSpan(t1.etm.Hour, t1.etm.Minute, t1.etm.Second);
                    }
                }
                else
                {
                    xmlData = ser.Serialize<SimpleMultiList>(_SimpleMultiList);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }

        static public void XMLEmSpeakerPositionList(bool rd)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlData = string.Empty;

            path = @appPathServer + "SimpleEmSPList.xml";

            try
            {
                if (rd)
                {
                    xmlData = File.ReadAllText(path);
                    _emspl = ser.Deserialize<EmSpeakerPositionList>(xmlData);
                }
                else
                {
                    xmlData = ser.Serialize<EmSpeakerPositionList>(_emspl);
                    File.WriteAllText(path, xmlData);
                }
            }
            catch (Exception e)
            {
                Log(e.Data.ToString());
            }
        }

        public static void ReadSimplePA()
        {
            if (gl._BaseData.UserName == null)
            {
                gl._BaseData.UserName = "엘에스전선";
                gl._BaseData.ServerIP = "192.168.1.1";
                gl._BaseData.ServerPort = "5001";
                gl._BaseData.Reserved1 = "0";
                gl._BaseData.Reserved2 = "0";
                gl._BaseData.Reserved3 = "0";
                gl._BaseData.Reserved4 = "1";
                gl._BaseData.Reserved5 = "1";
            }

            if (gl._BaseData.holiday.Count == 0)
            {
                DateTime cur = DateTime.Now;

                Holiday h1 = new Holiday(); h1.hDate = new DateTime(cur.Year, 1, 1); h1.Description = "새해";
                gl._BaseData.holiday.Add(h1);
                h1 = new Holiday(); h1.hDate = new DateTime(cur.Year, 3, 1); h1.Description = "삼일절";
                gl._BaseData.holiday.Add(h1);
                h1 = new Holiday(); h1.hDate = new DateTime(cur.Year, 5, 5); h1.Description = "어린이날";
                gl._BaseData.holiday.Add(h1);
                h1 = new Holiday(); h1.hDate = new DateTime(cur.Year, 6, 6); h1.Description = "현충일";
                gl._BaseData.holiday.Add(h1);
                h1 = new Holiday(); h1.hDate = new DateTime(cur.Year, 8, 15); h1.Description = "광복절";
                gl._BaseData.holiday.Add(h1);
                h1 = new Holiday(); h1.hDate = new DateTime(cur.Year, 10, 3); h1.Description = "개천절";
                gl._BaseData.holiday.Add(h1);
                h1 = new Holiday(); h1.hDate = new DateTime(cur.Year, 10, 9); h1.Description = "한글날";
                gl._BaseData.holiday.Add(h1);
                h1 = new Holiday(); h1.hDate = new DateTime(cur.Year, 12, 25); h1.Description = "크리스마스";
                gl._BaseData.holiday.Add(h1);
            }

            /*
            1   1   새해
            1   24  설날
            1   25  설날
            1   26  설날
            1   27  설날대체휴일
            3   1   삼일절
            5   5   어린이날
            4   15  국회의원선거
            4   30  부처님오신날
            6   6   현충일
            8   15  광복절
            9   30  추석
            10  1   추석
            10  2   추석
            10  3   개천절
            10  9   한글날
            12  25  크리스마스
            */
            if (gl._BaseData.user.Count == 0)
            {
                UserTree user = new UserTree();
                user.login_id = "admin";
                user.login_password = "admin";
                user.login_password2 = "admin";
                user.user_name = "admin";
                user.user_group = "A";
                gl._BaseData.user.Add(user);

                UserTree user1 = new UserTree();
                user1.login_id = "user";
                user1.login_password = "user";
                user1.login_password2 = "user";
                user1.user_name = "user";
                user1.user_group = "U";
                gl._BaseData.user.Add(user1);

            }
        }
        #endregion

        #region // 웹 처리 및 타임 처리 
        static private ChromeDriverService _driverService = null;
        static private ChromeOptions _optionsnull = null;
        static private ChromeDriver _driver = null;
        static private ChromeOptions _options;
        static public string chk_play_radio;
        static public bool chk_playing = false;

        static public void Init()
        {
            try
            {
                chk_play_radio = "";
                _driverService = ChromeDriverService.CreateDefaultService();
                _driverService.HideCommandPromptWindow = true;

                _options = new ChromeOptions();
                //_options.AddArgument("disable-gpu");

                _options.AddArguments(new List<string>() {
                    "disable-gpu",
                    "--window-size=400,300",
//                    "--silent-launch",
//                    "--no-startup-window",
//                    "no-sandbox",
                    //"headless",
                });

            }
            catch (Exception exc)
            {
                Log(exc.Message);
                chk_play_radio = "";
            }
        }

        static public void Play_radio(string v)
        {
            if (chk_playing)
                return;
            chk_playing = true;
            if (_driver != null)
                _driver.Quit();
            /*
                        try
                        {
                            var t1 = new RemoteWebDriver(new Uri(v) , _options);
                            t1.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
                            t1.Navigate().GoToUrl(v);
                            var e1 = t1.FindElementByXPath("//*[@id='play_pause_button']");

                        }
                        catch (Exception e1)
                        {
                            g.Log("InterNet Check..." + e1.Message);
                            g.chk_play_radio = "";

                        }
            */

            ///*
            try
            {
                _driver = new ChromeDriver(_driverService, _options);
                _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
                _driver.Navigate().GoToUrl(v);
                var element = _driver.FindElementByXPath("//*[@id='play_pause_button']");
                //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                //*[@id="play_pause_button"]
                //element.Click();
            }
            catch (Exception exc)
            {
                Log("InterNet Check..." + exc.Message);
                chk_play_radio = "";
                if (_driver != null)
                    _driver.Quit();
                _driver = null;

            }
            //*/
            chk_playing = false;
        }

        //  sbs http://www.radio-korea.com/embed/sbs-radio-love-fm-428824
        //  ytn http://www.radio-korea.com/embed/ytn-radio-401695
        //  ebs http://www.radio-korea.com/embed/ebs-fm-428830


        static public void Stop_radio()
        {
            if (_driver != null)
                _driver.Quit();
        }

        static public void call_sbs()
        {
            chk_play_radio = "SBS 인터넷방송";
            Play_radio(gl._BaseData.Reserved7);
            //play_radio(Directory.GetCurrentDirectory() + @"\1sbs.htm");
        }

        static public void call_ytn()
        {
            chk_play_radio = "YTN 인터넷방송";
            Play_radio("http://www.radio-korea.com/embed/ytn-radio-401695");
            //play_radio(Directory.GetCurrentDirectory() + @"\2ebs.htm");
        }

        static public void call_ebs()
        {
            chk_play_radio = "EBS 인터넷방송";
            Play_radio("http://www.radio-korea.com/embed/ebs-fm-428830");
            //play_radio(Directory.GetCurrentDirectory() + @"\3ytn.htm");
        }


        static public void call_play()
        {
            if (_driver == null)
                return;
            try
            {
                var element = _driver.FindElementByXPath("//*[@id='play_pause_button']");
                element.Click();
            }
            catch (Exception e1)
            {
                Log("InterNet Check..." + e1.Message);
            }
        }

        static public bool call_time()
        {
            DateTime reference = new DateTime(0001, 01, 01, 00, 00, 00);
            TimeManager tm = new TimeManager();

            DateTime result = tm.OverHttp();

            if (result > reference)
            {
                //_time.Text = "Connection sucessfully established! \nReceived time: " + result;
                tm.SystemTime(result);
                return true;
            }
            else
            {
                Log("타임서버 연동 : InterNet Check...");
                //_time.Text = "Connection not sucessfully established! \nPleas check your settings.";
                return false;
            }
            return true;
        }
        #endregion

        #region // 로그 및 유틸 
        public static void Log(string str1)
        {
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

        public static string long2IPstring(long s2)
        {
            string ipstr;
            var t1 = BitConverter.GetBytes(s2);
            byte[] t2 = { t1[0], t1[1], t1[2], t1[3] };
            ipstr = new IPAddress(t2.Reverse().ToArray()).ToString();
            return ipstr;
        }

        public static string bytetostring(byte[] t)
        {
            string ret = string.Empty;

            ret = string.Concat(Array.ConvertAll(t, byt => byt.ToString("X2")));
            return ret;
        }

        public static string RePlaceAt(this string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index)).Insert(index, replace);
        }

        public static string sel(string deviceName, string chspk)
        {
            string ret = "통신실";
            if (deviceName == "")
                return ret;
            var ret1 = gl._SpeakerList.asset.FindLast(p => p.DeviceName == deviceName && p.ch == chspk);
            if (ret1 == null)
                return ret;
            ret = ret1.path;
            return ret;
        }

        // 오브젝트 딥 카피 처리용 
        public static class ObjectCopier
        {
            /// <span class="code-SummaryComment"><summary></span>
            /// Perform a deep Copy of the object.
            /// <span class="code-SummaryComment"></summary></span>
            /// <span class="code-SummaryComment"><typeparam name="T">The type of object being copied.</typeparam></span>
            /// <span class="code-SummaryComment"><param name="source">The object instance to copy.</param></span>
            /// <span class="code-SummaryComment"><returns>The copied object.</returns></span>
            public static T Clone<T>(T source)
            {
                if (!typeof(T).IsSerializable)
                {
                    throw new ArgumentException("The type must be serializable.", "source");
                }

                // Don't serialize a null object, simply return the default for that object
                if (Object.ReferenceEquals(source, null))
                {
                    return default(T);
                }

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new MemoryStream();
                using (stream)
                {
                    formatter.Serialize(stream, source);
                    stream.Seek(0, SeekOrigin.Begin);
                    return (T)formatter.Deserialize(stream);
                }
            }
        }
        #endregion


    }


    public class ConnectToSharedFolder : IDisposable
    {
        readonly string _networkName;
        public ConnectToSharedFolder(string networkName, NetworkCredential credentials)
        {
            _networkName = networkName;
            var netResource = new NetResource
            {
                Scope = ResourceScope.GlobalNetwork,
                ResourceType = ResourceType.Disk,
                DisplayType = ResourceDisplaytype.Share,
                RemoteName = networkName
            };
            var userName = string.IsNullOrEmpty(credentials.Domain)
                ? credentials.UserName
                : string.Format(@"{0}\{1}", credentials.Domain, credentials.UserName);
            var result = WNetAddConnection2(
                netResource,
                credentials.Password,
                userName,
                0);
            if (result != 0)
            {
                throw new Win32Exception(result, "Error connecting to remote share");
            }
        }
        ~ConnectToSharedFolder()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            WNetCancelConnection2(_networkName, 0, true);
        }
        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(NetResource netResource,
            string password, string username, int flags);
        [DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags,
            bool force);
        [StructLayout(LayoutKind.Sequential)]
        public class NetResource
        {
            public ResourceScope Scope;
            public ResourceType ResourceType;
            public ResourceDisplaytype DisplayType;
            public int Usage;
            public string LocalName;
            public string RemoteName;
            public string Comment;
            public string Provider;
        }
        public enum ResourceScope : int
        {
            Connected = 1,
            GlobalNetwork,
            Remembered,
            Recent,
            Context
        };
        public enum ResourceType : int
        {
            Any = 0,
            Disk = 1,
            Print = 2,
            Reserved = 8,
        }
        public enum ResourceDisplaytype : int
        {
            Generic = 0x0,
            Domain = 0x01,
            Server = 0x02,
            Share = 0x03,
            File = 0x04,
            Group = 0x05,
            Network = 0x06,
            Root = 0x07,
            Shareadmin = 0x08,
            Directory = 0x09,
            Tree = 0x0a,
            Ndscontainer = 0x0b
        }
    }

}
