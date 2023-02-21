using DataClass;
using gClass;
using pa.classes;
using pa.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Threading;
using simplepa2;
using simplepa2.DataSet1TableAdapters;
using static simplepa2.DataSet1;
using System.Timers;

namespace pa
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public ObservableCollection<string> mlog { get; set; } = new ObservableCollection<string>(); // 로그 처리용 
        private TrayIcon _tray { get; set; } // 트래이 제어용 
        SerialPort spP { get; set; } = new SerialPort(); // P형 화재 수신기 통신용 
        SerialPort spR { get; set; } = new SerialPort(); // R형 화재 수신기 통신용 
        private bool alarmtest { get; set; } = false;
        EM_MODE eM_MODE { get; set; } = EM_MODE.전체복구;
        pktr run_pktr { get; set; }

        public uint AliveMessage { get; set; }
        System.Timers.Timer AliveTimer { get; set; } = new System.Timers.Timer(1000 * 60 * 5);

        public DBAccess dBAccess { get; set; } = new DBAccess();

        public EMServerRow EMServerRow { get; set; }
        WireSharkRunning wireShark { get; set; } = new WireSharkRunning();

        int em_status { get; set; } = 0;  // 화재 1,2 시험 알람 3,4 가스 5,6  
        int Alarm { get; set; } = 0; // 계속적인 발생을 관리 
        bool TestAlarm { get; set; } = false;

        public AThreadClass AThread { get; set; } = new AThreadClass();
        public DeviceDataTable _DanteDevice { get; set; }

        static System.Timers.Timer Devicetimer { get; set; } = new System.Timers.Timer(10000);
        public AThread aThread { get; set; } = new AThread();
        public BThread bThread { get; set; } = new BThread();

        int SelfTest { get; set; } = 0;

        public static SignalRClient signalRClient { get; set; } = new SignalRClient();

        // 예약 방송 관리 타이머 
        System.Timers.Timer T1Reservedtimer = new System.Timers.Timer(1000); // (1000*60);


        public MainWindow()
        {
            g.mainWindow = this;
            InitializeComponent();
            DataContext = this;

            g.Log("Emergency Server Start..");
            Title = "EM Svr "+ gl.version;
        }

        #region // 초기화 처리 

        bool firsttime = true;
        System.Timers.Timer Initialtimer { get; set; } = new System.Timers.Timer(2000);

        // 템플릿에서 엘레먼트 가져오기 
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.MinHeight = this.ActualHeight;
            this.MinWidth = this.ActualWidth / 2;

            if (firsttime)
            {
                if (g._EMClient.Jigsangbalhwa == 1)
                    _chk직상발화.IsChecked = true;
                else
                    _chk직상발화.IsChecked = false;

                Initial_P1();

                firsttime = false;
                signalRClient.eRcvSigR += SignalRClient_eRcvSigR1;
                signalRClient.eConnect += SignalRClient_eConnect;
                signalRClient.eDisConnect += SignalRClient_eDisConnect;
                signalRClient.ConnectToSignalR();

                Initialtimer.Elapsed += Initialtimer_Elapsed; ;
                Initialtimer.AutoReset = true;
                Initialtimer.Start();

            }
            //            if (App.Current.MainWindow.Visibility == Visibility.Visible)
            //                _tray.MinimizeToTray();
        }

        // 서버가 없으면 로컬의 데이터로 비상방송 처리 되게 로직 구성 
        // 만일 디비가 있다면 로컬은 무시하고 서버 데이터로 재구성 
        // 내부에서는 gl.danteDevice._DanteDevice 만사용 

        private void Initial_P1()
        {
            gl.XMLDanteDevice(true);

            // 다중방송 준비 
            g.Log("MultiSound/Alive Inter Message Initial..");
            IPC();
            AliveTimerJob();
            AliveMessage = GlobalMessage.Register("Alive");

            // 시리얼 통신 처리 
            g.Log("GPIO & P type Serial Initial..");
            OpenP();
            g.Log("R type Serial Initial..");
            OpenR();
            // 네트웍 살려 놓기 처리 
            Network_Initial();
            // 다중 방송 초기화 처리 // 시험을 위해 막음 - 서비스시 오픈 처리 
            InitMultiBS();
        }


        private void Initialtimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Initialtimer.Stop();

            if (!DBcheck())
            {
                Initialtimer.Start();
                return;
            }
            g.Log("SignalR Hub Connected ..");

            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                Initial_P3();
                // 초기 화면 열리면서 한번 수행 
                // GPIO 상태 받아오기
                sendErr(0xFF);
            }));
        }

        private bool DBcheck()
        {
            if (signalRClient.State != Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                return false;

            dBAccess.DBInit();
            if (dBAccess.Simplepa == null)
                return false;

            EMServerRow = dBAccess.EMServerGet();
            if (EMServerRow == null)
                return false;
            _DanteDevice = dBAccess.Device;
            g.Log("DB Check..");
            return true;
        }

        private void DB2LocalData()
        {
            foreach (var t1 in _DanteDevice)
            {
                var t2 = gl.danteDevice._DanteDevice.FirstOrDefault(p=>p.DeviceName == t1.DeviceName);

                if (t2 == null)
                {
                    Device d1 = new Device();
                    d1.DeviceName = t1.DeviceName;
                    d1.chspk = t1.chspk;
                    d1.EMNAME = t1.EMNAME;
                    d1.ip_dspctrl = t1.ip_dspctrl;
                    d1.DanteModelName = t1.DanteModelName;
                    d1.device = t1.device;
                    d1.ip = t1.ip;
                    d1.ip_dspctrl = t1.ip_dspctrl;
                    d1.name = t1.name;

                    //gl.danteDevice._DanteDevice.Add(d1);
                    //gl.XMLDanteDevice(false);
                }
                else 
                {
                    t2.chspk = t1.chspk;
                    t2.EMNAME = t1.EMNAME;
                    t2.dsp_chno = t1.dsp_chno;
                    gl.XMLDanteDevice(false);
                }
            }
        }


        // 서버 연결후 처리 
        public void Initial_P3()
        {
            MakeSpeakerIP();
            ReadMusic();
            _tray = new TrayIcon();
            //BSqlite.DBCopy();

            gl.XMLDanteDevice(true);

            //DBCopy();

            g.Log("DataBase Initial..");
            //g.Load("SimplePA EM Server가 로딩중입니다..");
            g.dsp.OnReceiveMessage += Dsp_OnReceiveMessage;
            // ComPort_Initial();
            DSPDeviceCheck();

            g.Log("Volume Initial..");
            // 볼륨 초기화 처리  
            g.Log("multiBS Thread running..");
            InitVolume();
            // 다중 방송 초기화 처리 // 시험을 위해 막음 - 서비스시 오픈 처리 
            //InitMultiBS();
            //Network_Initial();
            g.Log("DSP Thread Initial..");
            // DSP thread start
            BSThreadClass.Start();
            UI_Initial();
            //Networkcard_initial();
            aThread.Start();
            bThread.Start();

            systemcheck();

            // 처음 한번은 디비 맟추기 처리 
            makeDB();
            MakePlayList(_db); // 예약방송 업데이트

            T1Reservedtimer.Elapsed += T1Reservedtimer_Elapsed;
            T1Reservedtimer.Start();

            g.Log("Initialize OK..");
            dBAccess.Dbupdate<EMServerRow>("EMServers", EMServerRow, EMServerRow.EMServerId);
        }


        int test_timer = 0;
        bool T1Reservedtimer_ON = false;


        private void T1Reservedtimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (playList.child.Count < 1)
                return;
            if (T1Reservedtimer_ON)
                return;
            T1Reservedtimer_ON = true;


            DateTime today1 = DateTime.Now;
            DateTime sup = DateTime.Now;
            DateTime sdn = DateTime.Now;

            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                DateTime t1 = DateTime.Now;
                //if (t1.Minute == 0 && t1.Second == 1)
                if (t1.Hour == 0 && t1.Minute == 0 && t1.Second == 1)
                {
                    // 새벽 0시에 스케쥴 조정 처리 
                    makeDB();
                    MakePlayList(_db); // 예약방송 업데이트
                    g.Log("Update Schedule..");
                }
                // 한달에 한번 자동으로 타임 서버 연동하기 
                if (t1.Day == 1 && t1.Hour == 0 && t1.Minute == 0 && t1.Second == 1)
                {
                    //gl.call_time();
                }
            }));


            try
            {
                today1 = DateTime.Now;
                sup = new DateTime(today1.Year, today1.Month, today1.Day) + new TimeSpan(today1.Hour, today1.Minute, today1.Second);
                sdn = new DateTime(today1.Year, today1.Month, today1.Day) + new TimeSpan(today1.Hour, today1.Minute - 1, 59);
                // 시험용 1시간 
                if (test_timer == 1)
                {
                    //sdn = new DateTime(today1.Year, today1.Month, today1.Day) + new TimeSpan(today1.Hour, today1.Minute - 59, 59);
                    sdn = new DateTime(today1.Year, today1.Month, today1.Day) + new TimeSpan(today1.Hour, today1.Minute - 50, 59);
                    test_timer = 0;
                }

                var tpl1 = playList.child.Where(e1 => ((e1.kind == "예약방송") || (e1.kind == "정규방송"))
                            && (e1.state == "대기")
                            && (e1.Start < sup && e1.Start > sdn)).OrderBy(e1 => e1.Start);
                var pl2 = tpl1.ToList();

                if (pl2.Count == 0)
                {
                    T1Reservedtimer_ON = false;
                    return;
                }

                foreach (PlayItem pl3 in pl2)
                {
                    int chno = pl3.chno;
                    if (g.playItems[chno].state == "방송중")
                        return;
                    g.playItems[chno] = pl3;
                    g.Log(": 예약 : " + pl3.idno.ToString());
                }
                Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                {
                    g.mainWindow.MultiBS();
                }));
            }
            catch (Exception e1)
            {
                T1Reservedtimer_ON = false;
            }
            T1Reservedtimer_ON = false;
        }

        public SchduleMemList _db { get; set; } = new SchduleMemList(); //디비 

        public void makeDB()
        {
            // 디비투 이기종 테이블 리스트 복제 
            var s1 = Helper.DataTableToList<SchduleMem>(dBAccess.schdules);
            var sc1 = Helper.DataTableToList<simplepa2.Controller.SchduleC>(dBAccess.schduleCs);

            foreach (var t1 in s1)
            {
                SchduleMem mem = new SchduleMem();
                mem = t1;
                TimeSpan st = new TimeSpan();
                TimeSpan.TryParseExact(mem.tss, @"hh\:mm", null, out st);
                TimeSpan et = new TimeSpan();
                TimeSpan.TryParseExact(mem.tse, @"hh\:mm", null, out et);
                mem.tss1 = st;
                mem.tse1 = et;
                mem.schduleC = sc1.Where(p => p.SchduleId == t1.SchduleId).ToList();
                _db.child.Add(mem);
            }
        }

        public static PlayList playList = new PlayList();

        public static void MakePlayList(SchduleMemList _db)
        {
            DateTime t1 = DateTime.Now;
            DateTime t2 = new DateTime(t1.Year, t1.Month, t1.Day, 0, 0, 0);

            string st1 = "";

            List<SchduleMem> list1 = new List<SchduleMem>();

            switch (t1.DayOfWeek)
            {
                case DayOfWeek.Monday: list1 = _db.child.Where(e1 => (e1.day1 == true)).ToList(); break;
                case DayOfWeek.Tuesday: list1 = _db.child.Where(e1 => (e1.day2 == true)).ToList(); break;
                case DayOfWeek.Wednesday: list1 = _db.child.Where(e1 => (e1.day3 == true)).ToList(); break;
                case DayOfWeek.Thursday: list1 = _db.child.Where(e1 => (e1.day4 == true)).ToList(); break;
                case DayOfWeek.Friday: list1 = _db.child.Where(e1 => (e1.day5 == true)).ToList(); break;
                case DayOfWeek.Saturday: list1 = _db.child.Where(e1 => (e1.day6 == true)).ToList(); break;
                case DayOfWeek.Sunday: list1 = _db.child.Where(e1 => (e1.day7 == true)).ToList(); break;
            }
            var list2 = list1.Where(e1 => e1.week == true).OrderBy(e1 => e1.tss);

            foreach (SchduleMem e1 in list2)
            {
                t2 = new DateTime(t1.Year, t1.Month, t1.Day, e1.tss1.Hours, e1.tss1.Minutes, e1.tss1.Seconds);
                var tt1 = playList.child.Find(p => p.Start == t2 && p.kind == "정규방송");
                if (tt1 != null)
                {
                    playList.child.Add(tt1);
                    continue;
                }
                PlayItem play1 = new PlayItem();
                play1.kind = "정규방송";
                play1.Start = t2;
                play1.Name = e1.Name;
                play1.idno = e1.SchduleId;
                play1.chno = e1.chno;
                TimeSpan st = new TimeSpan();
                TimeSpan.TryParseExact(e1.duration, @"hh\:mm\:ss", null, out st);
                play1.duration = st;
                playList.child.Add(play1);
            }

            var list3 = _db.child.Where(e1 => (e1.week == false) && (e1.stime.DayOfWeek == t1.DayOfWeek)).OrderBy(e1 => e1.tss1);

            foreach (SchduleMem e1 in list3)
            {
                DateTime dt1 = e1.stime;
                DateTime sup = new DateTime(dt1.Year, dt1.Month, dt1.Day) + new TimeSpan(23, 59, 59);
                DateTime sdn = new DateTime(dt1.Year, dt1.Month, dt1.Day) + new TimeSpan(0, 0, 0);

                t2 = new DateTime(t1.Year, t1.Month, t1.Day, e1.stime.Hour, e1.stime.Minute, e1.stime.Second);
                if (!(sup > t2 && t2 > sdn))
                    continue;

                var tt1 = playList.child.Find(p => p.Start == t2 && p.kind == "예약방송");
                if (tt1 != null)
                {
                    playList.child.Add(tt1);
                    continue;
                }

                var tt2 = playList.child.Find(p => p.Start == t2 && p.kind == "정규방송");
                PlayItem play1 = new PlayItem();
                play1.kind = "예약방송";
                play1.Start = t2;
                play1.Name = e1.Name;
                play1.idno = e1.SchduleId;
                play1.chno = e1.chno;
                TimeSpan st = new TimeSpan();
                TimeSpan.TryParseExact(e1.duration, @"hh\:mm\:ss", null, out st);
                play1.duration = st;
                playList.child.Add(play1);
            }
        }


        private void Network_Initial()
        {
            gl.NetWorkCardFind();
            g.Log("Network Card : " + gl.NetworkCardNo.ToString() + ":" + gl.NetworkCardmDNS.ToString() + ":" + gl.NetworkCardName);


            List<string> cl = new List<string>();

            foreach (var t1 in gl.networkCardList)
            {
                cl.Add(t1.NetworkCardNo.ToString() + ":" + t1.NetworkCardmDNS.ToString() + ":" + t1.NetworkCardName + ":" + t1.ipv4);
            }
            _combo.ItemsSource = cl.ToList();

            var t3 = gl.networkCardList.Find(p => p.NetworkCardName == gl.NetworkCardName); // cl.f .Find(p=>p.in);
            if (t3 == null)
            {
                // 캡처 카드 인덱스 찾기 
                _combo.SelectedIndex = 0;
                return;
            }
            else
            {
                // 캡처 카드 인덱스 찾기 
                _combo.SelectedItem = t3.NetworkCardNo.ToString() + ":" + t3.NetworkCardmDNS.ToString() + ":" + t3.NetworkCardName + ":" + t3.ipv4;
            }

            try
            {
                Resolver.intfindx = t3.NetworkCardmDNS;
                Resolver.localIP = t3.ipv4;
                g.resolver = new Resolver();
                g.resolver.OnEventNewDevice += Resolver_OnEventNewDevice;
                g._EMClient.net_dante = t3.ipv4;
            }
            catch (Exception e1)
            {
            }

            if (gl.NetworkCardName != "이더넷")
            {
                if (LScap.g.LSpcapStart() == false)
                {
                    g.Log("Card initial err.."); // opencap
                }
                else
                {
                    g.Log("Device Check Thread running..");
                    AThread.OnSpeakerCheck += AThread_OnSpeakerCheck;
                    AThread.OnAliveChk += AThread_OnAliveChk;
                    AThread.DeviceChktime = 40; // 장비가 많아지면 시간 늘리기 
                    AThread.Start();
                    wireShark.CheckStart();
                }
            }
        }

        private int systemcheck()
        {
            var a1 = dBAccess.Assets.ToList();
            if (a1.Count() < 1)
            {
                g.Log("선번장이 없습니다. 선번장을 확인바랍니다.");
                return 1;
            }

            var d1 = _DanteDevice.Where(p => p.device == 2);

            if (d1.Count() < 1)
            {
                g.Log("검출된 DSP 가 없습니다. 1.Network Scan 버튼으로 확인바랍니다.");
                return 2;
            }
            return 3;
        }

        private void UI_Initial()
        {
            List<string> dsp_name = new List<string>();
            List<int> dsp_vol = new List<int>() { };

            for (int i = 1; i < 33; i++)
            {
                dsp_vol.Add(i);
            }
            ComboBoxColumn.ItemsSource = null;
            ComboBoxColumn.ItemsSource = dsp_vol;

            if (_DanteDevice != null)
            { 
                foreach (var t1 in _DanteDevice)
                {
                    if (t1.device != 2)
                        continue;
                    dsp_name.Add(t1.DeviceName);
                }
                ComboBoxColumn1.ItemsSource = null;
                ComboBoxColumn1.ItemsSource = dsp_name;

                foreach (var t1 in _DanteDevice)
                {
                    t1.path = sel(t1.DeviceName, t1.chspk);
                }
                var t2 = _DanteDevice.Where(p => p.device == 0).ToList();
                _lv2.ItemsSource = null;
                _lv2.ItemsSource = t2.ToList();
            }
        }

        private void Networkcard_initial()
        {
        }

        private void SignalRClient_eDisConnect(object sender, EventArgs e)
        {
            g.Log("SignalR Disconnected!");
        }

        private void SignalRClient_eConnect(object sender, EventArgs e)
        {
            g.Log("SignalR Connected!");
            DBcheck();
            SendSigR(eSignalRMsgType.eEM, "EM Info : " + g._EMClient.EM_NAME, 1);
        }

        private void SignalRClient_eRcvSigR1(object sender, SignalRMsg e)
        {
            RcvSigR(e);
        }

        private void MetroWindow_Deactivated(object sender, EventArgs e)
        {
            //            if(App.Current.MainWindow.Visibility == Visibility.Visible)
            //                _tray.MinimizeToTray();
        }

        #endregion

        #region // 종료 처리 
        
        // 종료시 처리 
        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SendSigR(eSignalRMsgType.eEM, "EM Info : " + g._EMClient.EM_NAME);
            signalRClient.HubDisconnect();

            Devicetimer.Stop();

            aThread.Stop();
            //Thread.Sleep(1000);

            bThread.Stop();
            //Thread.Sleep(1000);

            //g.Info("Em Server 종료 처리중...");

            AThread.Stop();
            //Thread.Sleep(1000);

            BSThreadClass.Stop();
            //Thread.Sleep(500);

            //e.Cancel = true; // alt F4 막기 
            if (spP.IsOpen) spP.Close();

            if (spR.IsOpen) spR.Close();

            foreach (ExtProcess p1 in BSpro)
            {
                p1.Kill();
            }
            BSpro.Clear();

            if (_tray != null)
            {
                _tray.Dispose();
                _tray = null;
            }
            LScap.g.LSpcapStop();// .LSpcap .CloseCap();
            Thread.Sleep(1000);
        }

        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region // 유틸 처리 
        // IP 가 없는 디바이스 삭제 처리 
        private void DSPDeviceCheck()
        {
            List<DeviceRow> dsp1 = new List<DeviceRow>();
            dsp1 = _DanteDevice.Where(p => p.device == 2).ToList();

            try
            {
                if (dsp1[0].ip == "")
                    dsp1.RemoveAt(0);
            }
            catch (Exception e1)
            {
                g.Log("Check Dante Devices.." + e1.Data);
            }

        }

        int[,] MatrixState { get; set; } = new int[32, 32];

        List<string> mbuf = new List<string>();

        private void Dsp_OnReceiveMessage(string message)
        {
            //Console.WriteLine(message);

            mbuf.Add(message);
            return;
        }

        private void _mlog_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //if (App.Current.MainWindow.Visibility == Visibility.Visible)
            //    _tray.MinimizeToTray();
        }
        private void AliveTimerJob()
        {
            AliveTimer.Elapsed += AliveTimer_Elapsed; ;
            AliveTimer.AutoReset = true;
            AliveTimer.Start();
        }

        private void AliveTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                // Checker Timer 501 
                // PA 601
                // PA_EM
                GlobalMessage.Send(AliveMessage, 701, 701);
                //Console.WriteLine("Alive message..");
            }));
        }

        #endregion

        #region // 시험 버튼 유틸 처리 


        private void _but2_Click(object sender, RoutedEventArgs e)
        {
            LoopbackWindow window = new LoopbackWindow();
            window.ShowDialog();

        }

        int tscnt = 0;

        // GPIO 시험 
        private void _but3_Click(object sender, RoutedEventArgs e)
        {
            //EMMappingWindow window = new EMMappingWindow();
            //window.ShowDialog();

            switch (tscnt)
            {
                case 0:
                    // 예약 방송 시험 
                    //PlayChildProcess(3, 100001);
                    break;
                case 1:
                    checkPreset("110", 2, "111");
                    //checkPreset("111", 2, "110");
                    break;
                case 2:
                    checkPreset("1110", 3, "1111");
                    //checkPreset("1111", 3, "1110");
                    break;
                case 3:
                    checkPreset("11110", 4, "11111");
                    //checkPreset("11111", 4, "11110");
                    break;
                case 4:
                    checkPreset("111110", 5, "111111");
                    //checkPreset("111111", 5, "111110");
                    break;
                case 5:
                    checkPreset("1111110", 6, "1111111");
                    //checkPreset("1111111", 6, "1111110");
                    break;
                case 6:
                    checkPreset("11111110", 7, "11111111");
                    checkPreset("111111111", 8, "111111110");
                    break;
                case 7:
                    pktr pktr1 = new pktr("00-00-00N=");
                    Fire_Alarm(1, "3", "0", pktr1.tot, pktr1);
                    break;
                case 8:
                    pktr pktr2 = new pktr("00-00-00R1");
                    Fire_Alarm(2, "3", "0", pktr2.tot, pktr2);
                    break;
                case 9:
                    tscnt = -1;
                    break;
            }
            tscnt++;

        }

        Guid testGuid;
        private async void _but4_Click(object sender, RoutedEventArgs e)
        {
            checkPreset("11111110", 7, "11111111");
            //checkPreset("111111111", 8, "111111110");


            /*
            testGuid = Guid.NewGuid();
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = "Play";
            msg1.EMNAME = g._EMClient.EM_NAME;
            msg1.Guid = testGuid;
            msg1.Msgtype = eSignalRMsgType.ePlay;
            msg1.assetsRows.Add(1);
            msg1.musicsRows.Add(5);
            await g.mainWindow.RcvSigR(msg1);
            */
            /*
            PlayChildProcess(2, 100034);
            */

        }

        private void _but5_Click(object sender, RoutedEventArgs e)
        {
            checkPreset("111111111", 8, "111111110");
            /*
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = "Stop";
            msg1.EMNAME = g._EMClient.EM_NAME;
            msg1.Guid = testGuid;
            msg1.Msgtype = eSignalRMsgType.eStop;
            g.mainWindow.RcvSigR(msg1);
            */
        }

        // 오디오 처리용 
        System.Timers.Timer testimer = new System.Timers.Timer(1000); // 1000

        int test = 0;
        bool first = true;

        private void _but6_Click(object sender, RoutedEventArgs e)
        {
            ///*
            g._EMClient.WebAPIURL = "http://localhost:9921/api/";
            dBAccess.DBInit();
            EMServerRow = dBAccess.EMServerGet();
            _DanteDevice = dBAccess.Device;


            SignalRMsg msg1 = new SignalRMsg();
            msg1.Msgtype = eSignalRMsgType.eVolume;
            msg1.user = "AAA";
            msg1.EMNAME = "ALL";
            g.mainWindow.RcvSigR(msg1);

/*
            gl.XMLDanteDevice(true);
            NetworkInit();
            initUI();
            //*/

            /*
            SignalRMsg msg1 = new SignalRMsg();
            msg1.Msgtype = eSignalRMsgType.eScanAll;
            msg1.message = "Scan All";
            msg1.EMNAME = "ALL";
            g.mainWindow.RcvSigR(msg1);
            //*/
            //dBAccess.RemoveEMServer("EMServers", EMServerRow.EMServerId);
            //dBAccess.Dbsave<EMServerRow>("EMServers", EMServerRow);

            //SendSigR("PLAYING", eSignalRMsgType.ePlaying, 1, 0);
            //SendSigR("PLAYEND", eSignalRMsgType.ePlayEnd, 0, 0);

            //SendSigR("Hello Client", eSignalRMsgType.eEM, 0, 0);

            //alarmtest = !alarmtest;

            /*
            if (first)
            {
                testimer.Elapsed += Testimer_Elapsed;
                first = false;
            }
            if (alarmtest)
            {
                //sendErr(0xB1); // err
                testimer.Start();

            }
            else
            {
                //sendErr(0xC1);// off
                testimer.Stop();
                //BSThreadClass.AddData(i.ToString());
            }
            // */
        }

        private void _but7_Click(object sender, RoutedEventArgs e)
        {

/*
            // 채널 인 시험 
            SignalRMsg msg1 = new SignalRMsg();
            msg1.Msgtype = eSignalRMsgType.eInChMove;
            msg1.user = "AAA";
            msg1.EMNAME = "ALL";
            msg1.message = "DESKTOP-KVOOQ6I";
            msg1.state = 2;
            msg1.user_data1 = "169.254.217.51";
            msg1.user_data4 = 16;
            g.mainWindow.RcvSigR(msg1);
*/
            // 채널 아웃 시험 
/*
            SignalRMsg msg1 = new SignalRMsg();
            msg1.Msgtype = eSignalRMsgType.eOutChMove;
            msg1.user = "AAA";
            msg1.EMNAME = "ALL";
            msg1.message = "DPCB-30-93d87c";
            msg1.state = 18;
            msg1.user_data1 = "DSP-16D-011652";
            msg1.user_data4 = 1;
            g.mainWindow.RcvSigR(msg1);
*/
        }

        private void _ts8_Click(object sender, RoutedEventArgs e)
        {
            // 채널 인 시험 
            SignalRMsg msg1 = new SignalRMsg();
            msg1.Msgtype = eSignalRMsgType.eInChMove;
            msg1.user = "AAA";
            msg1.EMNAME = "ALL";
            msg1.message = "DESKTOP-V67ISKJ";
            msg1.state = 2;
            msg1.user_data1 = "169.254.208.133";
            msg1.user_data4 = 16;
            g.mainWindow.RcvSigR(msg1);

        }


        public void MakeSpeakerIP()
        {
            foreach (var t1 in dBAccess.Assets)
            {
                if (t1.DeviceName == "")
                {
                    t1.state = ""; // "Off-Line";
                    continue;
                }
                var t2 = _DanteDevice.FirstOrDefault(p => p.DeviceName == t1.DeviceName && p.chspk == t1.ch);
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
//            Tam.AssetsTableAdapter.Update(Ds1.Assets);
        }

        // 음원 폴더에서 가져와 디비 생성 
        // 듀레이션은 시간이 걸리므로 타이머 쓰레드 처리 
        public void ReadMusic()
        {
            // 폴더에서 자동으로 파일 확인후 디비에 등록 처리
            //_BaseData.music.Clear();

//            Tam.MusicsTableAdapter.Fill(Ds1.Musics);

            var directoryInfo = new DirectoryInfo(gl.appPathServer + "Music");
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles("*.mp3");

                foreach (var fileInfo in files)
                {
                    var mu1 = TagLib.File.Create(fileInfo.FullName);
                    var m3 = dBAccess.Musics.FirstOrDefault(p => p.FileName == fileInfo.Name);
                    if (m3 != null)
                    {
                    }
                    else
                    {
                        MusicsRow m1 = dBAccess.Musics.NewMusicsRow();
                        string str1 = "00:00:00";
                        var r1 = mu1.Properties.Duration;
                        m1.FileName = fileInfo.Name;
                        m1.FileContent = "";
                        m1.deletable = "N";
                        Thread.Sleep(50);
                        str1 = r1.ToString(@"hh\:mm\:ss");
                        if (str1 == "00:00:00")
                            str1 = "00:00:01";
                        m1.duration = str1;
                        dBAccess.Musics.Rows.Add(m1);
                        //Tam.MusicsTableAdapter.Update(Ds1.Musics);
                    }
                }
            }
        }

        #endregion

        private void _chk직상발화_Click(object sender, RoutedEventArgs e)
        {
            if (_chk직상발화.IsChecked == true)
                g._EMClient.Jigsangbalhwa = 1;
            else
                g._EMClient.Jigsangbalhwa = 0;
            g.XMLEMClient(false);

        }

    }
}
