using gClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Threading;

namespace WatchDog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ManageProcess> mpro = new List<ManageProcess>();
        private TrayIcon _tray; // 트래이 제어용 

        int cnt = 0;

        public MainWindow()
        {
            InitializeComponent();

            Title = "Watchdog" + " " + gl.version;

            //mpro.Add(new ManageProcess("pa_em", @"pa_em.exe",0));
            //mpro.Add(new ManageProcess(gl._BaseData.processname, gl._BaseData.processfile ,1));
            //mpro.Add(new ManageProcess("Checker", @"Checker.exe", 0));

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            aTimer.Interval = 10000;
            aTimer.Enabled = true;

            hTimer = new System.Timers.Timer();
            hTimer.Elapsed += new ElapsedEventHandler(OnhTimedEvent);

            //hTimer.Interval = 10 * 1000; // 1시간마다 파일 지우기 처리
            hTimer.Interval = 60 * 60 * 1000; // 1시간마다 파일 지우기 처리
            hTimer.Enabled = true;

            _tray = new TrayIcon();
        }

        private void OnhTimedEvent(object sender, ElapsedEventArgs e)
        {
            hTimer.Stop();
            DirectoryInfo info = new DirectoryInfo(System.IO.Path.GetTempPath());
            FileInfo[] files = info.GetFiles();

            foreach (FileInfo f in files)
            {
                try
                {
                    f.Delete();
                }
                catch (Exception e1)
                { 
                }
            }
            hTimer.Start();

        }

        private System.Timers.Timer aTimer { get; set; }
        private System.Timers.Timer hTimer { get; set; }

        /// <summary>
        /// Event for timer
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                Process[] processlist = Process.GetProcesses();

                foreach (ManageProcess m1 in mpro)
                { 
                    bool find = false;
                    foreach (Process theprocess in processlist)
                    {
                        if (theprocess.ProcessName.Contains("pa"))
                        { 
                            // pa_em
                            // pa
                            // SpeakerCheckerDemon
                        }
                        if (theprocess.ProcessName == m1.ProcessName)
                        {
                            find = true;
                            if (theprocess.Responding)
                            {
                                m1.notrespondingcount = 0;
                            }
                            else
                            {
                                m1.notrespondingcount++;
                                if (m1.notrespondingcount == 5)
                                {
                                    theprocess.Kill();
                                    find = false;
                                    Log("Kill:" + m1.ProcessFile);
                                }
                            }
                        }
                    }
                    if (find == false)
                    {
                        Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
                        {
                            _log.Text = m1.ProcessFile;
                            Log("Run:" + m1.ProcessFile);
                        }));

                        Process newProcess = new Process();
                        newProcess.StartInfo.FileName = m1.ProcessFile;
                        if(m1.view == 1)
                            newProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                        else
                            newProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                        newProcess.Start();
                        //Thread.Sleep(2000);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error" + ex.Message, "Error");
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            //App.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_tray != null)
            {
                _tray.Dispose();
                _tray = null;
            }
            GC.SuppressFinalize(this);

            App.Current.Shutdown();

        }

        static string old_string = "";
        public static void Log(string str1)
        {
            //if (str1 == old_string)
            //    return;
            //old_string = str1;

            try
            {
                string fn = "Watchdog_"+DateTime.Now.Year.ToString();
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

        private void Window_Deactivated(object sender, EventArgs e)
        {
            if (App.Current.MainWindow.Visibility == Visibility.Visible)
            {
                if (_tray != null)
                    _tray.MinimizeToTray();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Log("Running SimplePA Watchdog Process..");
            if (App.Current.MainWindow.Visibility == Visibility.Visible)
            {
                if (_tray != null)
                    _tray.MinimizeToTray();
            }
        }
    }
}
