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
using Wisej.CodeProject;
using Wisej.CodeProject.DataSet1TableAdapters;
using static Wisej.CodeProject.DataSet1;

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
        // GPIO 타이머 5초 마다 상태 점검 처리 
        public int GPIOResponse { get; set; }
        public DBSqlite dBSqlite { get; set; } = new DBSqlite();
        DataSet1 ds1 { get; set; }
        TableAdapterManager Tam { get; set; }

        WireSharkRunning wireShark { get; set; } = new WireSharkRunning();

        int em_status { get; set; } = 0;  // 화재 1,2 시험 알람 3,4 가스 5,6  
        int Alarm { get; set; } = 0; // 계속적인 발생을 관리 
        bool TestAlarm { get; set; } = false;

        public AThreadClass AThread { get; set; } = new AThreadClass();


        public  DeviceDataTable _DanteDevice { get; set; }
        public MainWindow()
        {
            g.mainWindow = this;
            InitializeComponent();
            DataContext = this;

            g.Log("Emergency Server Start..");
            Title = "EM Svr "+ gl.version;

            dBSqlite.DBInit();
            ds1 = dBSqlite.ds1;
            Tam = dBSqlite.Tam;

            _DanteDevice = ds1.Device;

            MakeSpeakerIP();
            ReadMusic();


            g._BaseData = ds1.Simplepa.FirstOrDefault();
            if (g._BaseData == null)
                dBSqlite.Init();
            g.Log("DataBase Initial..");

            //BSqlite.DBCopy();
        }


        public void MakeSpeakerIP()
        {
            foreach (var t1 in ds1.Assets)
            {
                if (t1.DeviceName == "")
                {
                    t1.state = ""; // "Off-Line";
                    continue;
                }
                var t2 = _DanteDevice.FirstOrDefault(p => p.name == t1.DeviceName || p.DeviceName == t1.DeviceName);
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
            Tam.AssetsTableAdapter.Update(ds1.Assets);
        }


        // 음원 폴더에서 가져와 디비 생성 
        // 듀레이션은 시간이 걸리므로 타이머 쓰레드 처리 
        public void ReadMusic()
        {
            // 폴더에서 자동으로 파일 확인후 디비에 등록 처리
            //_BaseData.music.Clear();

            Tam.MusicsTableAdapter.Fill(ds1.Musics);

            var directoryInfo = new DirectoryInfo(gl.appPathServer + "Music");
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles("*.mp3");

                foreach (var fileInfo in files)
                {
                    var mu1 = TagLib.File.Create(fileInfo.FullName);
                    var m3 = ds1.Musics.FirstOrDefault(p => p.FileName == fileInfo.Name);
                    if (m3 != null)
                    {
                    }
                    else
                    {
                        MusicsRow m1 = ds1.Musics.NewMusicsRow();
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
                        ds1.Musics.Rows.Add(m1);
                        Tam.MusicsTableAdapter.Update(ds1.Musics);
                    }
                }
            }
        }


        #region // 메인 윈도우 처리 
        // 종료시 처리 
        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //g.Info("Em Server 종료 처리중...");

            AThread.Stop();
            Thread.Sleep(1000);

            BSThreadClass.Stop();
            Thread.Sleep(500);

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

        public void Init()
        {
            g.Load("SimplePA EM Server가 로딩중입니다..");
            g.dsp.OnReceiveMessage += Dsp_OnReceiveMessage;

            // 시리얼 통신 처리 
            g.Log("GPIO & P type Serial Initial..");
            //OpenP();
            g.Log("R type Serial Initial..");
            OpenR();
            _tray = new TrayIcon();

            DSPDeviceCheck();
            g.Log("MultiSound/Alive Inter Message Initial..");
            IPC();

            AliveTimerJob();
            AliveMessage = GlobalMessage.Register("Alive");


            g.Log("DSP Thread Initial..");
            // DSP thread start
            BSThreadClass.Start();

            g.Log("Volume Initial..");
            // 볼륨 초기화 처리  
            InitVolume();

            g.Log("multiBS Thread running..");
            // 다중 방송 초기화 처리 
            InitMultiBS();
            gl.NetWorkCardFind();
            g.Log("Network Card : " + gl.NetworkCardNo.ToString() + ":" + gl.NetworkCardmDNS.ToString() + ":" + gl.NetworkCardName );

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
                    AThread.OnGetDevice += AThread_OnGetDevice;
                    AThread.DeviceChktime = 40; // 장비가 많아지면 시간 늘리기 
                    AThread.Start();
                    wireShark.CheckStart();

                    LSmDNSW.Resolver.intfindx = gl.NetworkCardmDNS;
                    LSmDNSW.g.resolver.OnEventNewDevice += Resolver_OnEventNewDevice;
                }
            }
            g.Log("Initialize OK..");
        }

        private void Resolver_OnEventNewDevice(object o)
        {
        }

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

        bool firsttime = true;
        // 템플릿에서 엘레먼트 가져오기 
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.MinHeight = this.ActualHeight;
            this.MinWidth = this.ActualWidth/2;

            if (firsttime)
            {
                Init();
                firsttime = false;
                // 초기 화면 열리면서 한번 수행 
                // GPIO 상태 받아오기
                sendErr(0xFF);
            }
//            if (App.Current.MainWindow.Visibility == Visibility.Visible)
//                _tray.MinimizeToTray();
        }


        private void MetroWindow_Deactivated(object sender, EventArgs e)
        {
//            if(App.Current.MainWindow.Visibility == Visibility.Visible)
//                _tray.MinimizeToTray();
        }

        private void _Status_MouseDoubleClick_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        }

        // 설정 종료후 컴포트 재설정 처리 
        private void _Status_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SetupWindow window = new SetupWindow();
            window.ShowDialog();
            OpenP();
            OpenR();
        }

        private void _mlog_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (App.Current.MainWindow.Visibility == Visibility.Visible)
                _tray.MinimizeToTray();
        }
        #endregion

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

        Guid testGuid;
        private async void _Status7_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            testGuid = Guid.NewGuid();
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = "Play";
            msg1.user = "Admin";
            msg1.Guid = testGuid;
            msg1.Msgtype = eSignalRMsgType.ePlay;
            msg1.assetsRows.Add(1);
            msg1.musicsRows.Add(5);
            await g.mainWindow.RcvSigR(msg1);
        }

        private void _Status8_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = "Stop";
            msg1.user = "Admin";
            msg1.Guid = testGuid;
            msg1.Msgtype = eSignalRMsgType.eStop;
            g.mainWindow.RcvSigR(msg1);
        }
    }
}
