using gClass;
using System;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Threading;

namespace Checker
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        SpeakerChecker speakerChecker { get; set; } = new SpeakerChecker();
        long old_wParam { get; set; }
        long old_lParam { get; set; }

        private TrayIcon _tray; // 트래이 제어용 

        public uint RegisterMessage;
        public uint AliveMessage;
        System.Timers.Timer AliveTimer = new System.Timers.Timer(1000 * 60 * 5);

        public MainWindow()
        {
            InitializeComponent();

            Title = "Speaker Checker " + gl.version;

            g.MainWindow = this;

            gl.XMLSimplePA(true);
            gl.XMLSimpleSpeaker(true);
            gl.XMLDanteDevice(true);

            g.Log("Speaker Checker Demon Running..");
            _tray = new TrayIcon();

            speakerChecker.CheckStart();

            RegisterMessage = GlobalMessage.Register("SpeakerCheck");
            ComponentDispatcher.ThreadFilterMessage += ComponentDispatcher_ThreadFilterMessage;

            AliveTimerJob();
            AliveMessage = GlobalMessage.Register("Alive");
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
                GlobalMessage.Send(AliveMessage, 501, 501);
                //Console.WriteLine("Alive message..");
            }));
        }

        private void ComponentDispatcher_ThreadFilterMessage(ref MSG msg, ref bool handled)
        {
            if (RegisterMessage != msg.message)
                return;
            long s1 = msg.wParam.ToInt64();
            long s2 = msg.lParam.ToInt64();

            string str1 = msg.wParam.ToString() + " : " + msg.lParam.ToString() + "\r\n";
            //_out.Inlines.Add(str1);
            if (old_lParam == s2 && s1 == old_wParam)
                return;
            old_wParam = s1;
            old_lParam = s2;

            switch (s1)
            {

                case 200: // Off -> 
                    string str2 = gl.long2IPstring(s2);
                    g.Log("200:"+str2);
                    break;
                case 300: // On -> Off
                    string str3 = gl.long2IPstring(s2);
                    g.Log("300:" + str3);
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            g.Log("LScap No : " + speakerChecker.card.ToString());
            g.Log("LSmDNS No : " + speakerChecker.mdnsno.ToString());
            //LSCap.LSpcap();
            if (App.Current.MainWindow.Visibility == Visibility.Visible)
                _tray.MinimizeToTray();

        }

        public void Log(string log)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                string str1 = log + "\r\n";
                _out.Inlines.Add(str1);

                if (_out.Inlines.Count > 10)
                {
                    _out.Inlines.Clear();
                }
            }));
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            if (App.Current.MainWindow.Visibility == Visibility.Visible)
            {
                if(_tray != null)
                    _tray.MinimizeToTray();
            }

        }

        bool check1 = false;
        bool check2 = false;

        public void SpeakerCheck()
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                if (check1 || check2) return;
                check1 = true;

                try
                {
                    LScap.g.capData.Clear();
                    LSmDNS.Resolver.intfindx = speakerChecker.mdnsno;
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

        public void AliveChk()
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                if (check2) return;
                check2 = true;
                var t2 = LScap.g.capData;

                try
                {
                    g.Log(t2.Count.ToString());
                    foreach (Asset t1 in gl._SpeakerList.asset)
                    {
                        if (t1.state != t1.state_old)
                            t1.state_old = t1.state;
                        t1.state = ""; // "Off-Line";
                    }

                    foreach (var t3 in gl._SpeakerList.asset)
                    {
                        var t4 = t2.Contains(t3.ip);
                        if (t4)
                        {
                            //g.Log("Alive IP.. : " + t3.ip);
                            t3.state = "On-Line";
                            // 올드가 오프라인이면 
                            if (t3.state_old == "")
                            {
                                var ar1 = IPAddress.Parse(t3.ip).GetAddressBytes().Reverse().ToArray();
                                int l1 = BitConverter.ToInt32(ar1, 0);
                                GlobalMessage.Send(g.MainWindow.RegisterMessage, 200, l1);
                                //EventVM vm = new EventVM(t3.ip, t3.path, t3.DeviceName, t3.state);
                                //gl._event_list.child.Insert(0, vm);
                            }
                        }
                        else
                        {
                            // 온라인이었다가 오프라인이면 
                            if (t3.state != t3.state_old)
                            {
                                var ar1 = IPAddress.Parse(t3.ip).GetAddressBytes().Reverse().ToArray();
                                int l1 = BitConverter.ToInt32(ar1, 0);
                                GlobalMessage.Send(g.MainWindow.RegisterMessage, 300, l1);
                                t3.state_old = "";
                                //EventVM vm = new EventVM(t3.ip, t3.path, t3.DeviceName, t3.state);
                                //gl._event_list.child.Insert(0, vm);
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

        private void Window_Closed(object sender, EventArgs e)
        {
            speakerChecker.Close();
        }
    }
}
