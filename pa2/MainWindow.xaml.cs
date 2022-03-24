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
        TableAdapterManager dm1 { get; set; }

        SpeakerChecker speakerChecker { get; set; } = new SpeakerChecker();

        public MainWindow()
        {
            g.mainWindow = this;
            InitializeComponent();
            DataContext = this;

            g.Log("Emergency Server Start..");
            Title = "EM Svr "+ gl.version;

            dBSqlite.DBInit();
            ds1 = dBSqlite.ds1;
            dm1 = dBSqlite.dm1;

            dBSqlite.MakeSpeakerIP();
            dBSqlite.ReadMusic();

            g._BaseData = ds1.Simplepa.FirstOrDefault();
            if (g._BaseData == null)
                dBSqlite.Init();
            g.Log("DataBase Initial..");

            //BSqlite.DBCopy();
        }


        #region // 메인 윈도우 처리 
        // 종료시 처리 
        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BSThreadClass.Stop();

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
            g.Log("SpeakerCheck/MultiSound/Alive Inter Message Initial..");
            IPC();

            AliveTimerJob();
            AliveMessage = GlobalMessage.Register("Alive");


            g.Log("DSP Thread Initial..");
            // DSP thread start
            BSThreadClass.Start();

            g.Log("Volume Initial..");
            // 볼륨 초기화 처리  
            InitVolume();

            g.Log("multiBS Initial..");
            // 다중 방송 초기화 처리 
            InitMultiBS();
            gl.NetWorkCardFind();
            g.Log("Network Card : " + gl.NetworkCardNo.ToString() + ":" + gl.NetworkCardmDNS.ToString() + ":" + gl.NetworkCardName );
            g.Log("Initialize OK..");

            if (gl.NetworkCardName != "이더넷")
            { 
                speakerChecker.CheckStart();
            }
            //g.Log("LScap No : " + speakerChecker.card.ToString());
            speakerChecker.OnAliveChk += SpeakerChecker_OnAliveChk;
            speakerChecker.OnSpeakerCheck += SpeakerChecker_OnSpeakerCheck;
        }

        // IP 가 없는 디바이스 삭제 처리 
        private void DSPDeviceCheck()
        {
            List<Device> dsp1 = new List<Device>();
            dsp1 = gl.danteDevice._DanteDevice.Where(p => p.device == 2).ToList();

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
            this.MinWidth = this.ActualWidth;

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

        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            speakerChecker.Close();
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

        private async void _Status7_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = "Play";
            msg1.user = "Admin";
            msg1.Guid = new Guid();
            msg1.Msgtype = eSignalRMsgType.ePlay;
            msg1.assetsRows.Add(1);
            msg1.musicsRows.Add(5);
            await g.mainWindow.RcvSigR(msg1);
        }

        private void _Status8_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = "Stop";
            msg1.Msgtype = eSignalRMsgType.eStop;
            g.mainWindow.RcvSigR(msg1);
        }

        #region // 스피커 온라인 감시 처리 

        // 상태가 변경되었을 경우만 디스플레이
        private void SpeakerCheck(string str2, int v)
        {
            var t4 = ds1.Assets.Where(p => p.ip == str2);
            if (t4.Count() == 0)
                return;

            var t3 = ds1.Assets.First(p => p.ip == str2);
            if (t3 == null)
                return;

            if (v == 1)
            {
                if (t3.state == "On-Line") return;
                t3.state = "On-Line";
                g.Log("On-Line :" + str2);
            }
            else
            {
                if (t3.state == "") return;
                t3.state = "";
                t3.state_old = "";
                g.Log("Off-Line:" + str2);
            }

            dBSqlite.EventvmIP(t3);
            //updateAlarmEvent();
            //if (MainTabControl.SelectedIndex == 5)
            //    _T6.dispFloorMap();
        }

        bool check1 = false; // 재 실행 방지 
        bool check2 = false; // 재 실행 방지 

        private void SpeakerChecker_OnSpeakerCheck(object sender, EventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                if (check1 || check2) return;
                check1 = true;

                try
                {
                    LScap.g.capData.Clear();
                    LSmDNS.Resolver.intfindx = gl.NetworkCardmDNS;
                    LSmDNS.g.GetCard();
                    LSmDNS.g.GetMain();
                }
                catch (Exception e1)
                {
                    //Console.WriteLine(e1.Message);
                }
                check1 = false;
            }));
        }

        private void SpeakerChecker_OnAliveChk(object sender, EventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                if (check2) return;
                check2 = true;
                var t2 = LScap.g.capData;

                try
                {
                    g.Log("Device Check : " + t2.Count.ToString());
                    foreach (var t1 in ds1.Assets)
                    {
                        if (t1.state != t1.state_old)
                            t1.state_old = t1.state;
                        t1.state = ""; // "Off-Line";
                    }

                    foreach (var t3 in ds1.Assets)
                    {
                        var t4 = t2.Contains(t3.ip);
                        if (t4)
                        {
                            //g.Log("Alive IP.. : " + t3.ip);
                            t3.state = "On-Line";
                            // 올드가 오프라인이면 
                            if (t3.state_old == "")
                            {
                                SpeakerCheck(t3.ip, 1);
                            }
                        }
                        else
                        {
                            // 온라인이었다가 오프라인이면 
                            if (t3.state != t3.state_old)
                            {
                                SpeakerCheck(t3.ip, 0);
                            }
                        }
                    }

                    if (t2.Count < 2)
                    {
                        speakerChecker.T2chktimer.Start();
                        //LSCap.Refresh();
                    }

                }
                catch (Exception e1)
                {
                    //Console.WriteLine(e1.Message);

                }
                check2 = false;
            }));
        }
        #endregion

    }
}
