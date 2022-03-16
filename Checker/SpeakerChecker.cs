using gClass;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Timers;
using System.Windows.Threading;

namespace Checker
{
    class SpeakerChecker
    {
        public System.Timers.Timer T1chktimer = new System.Timers.Timer(1000 * 5);
        public System.Timers.Timer T2chktimer = new System.Timers.Timer(1000 * 5);
        int T1chktimer_cnt = 0;
        public event EventHandler OnSpeakerChecker;

        System.Diagnostics.Process process = null;

        public int card { get; set; } = 0;
        public int mdnsno { get; set; } = 0;
        public SpeakerChecker()
        {


            if (System.IO.File.Exists("inifile.ini") == false)
            {
                System.IO.File.WriteAllText("inifile.ini", "11");
            }
            string ini2 = System.IO.File.ReadAllText("inifile.ini");
            mdnsno = int.Parse(ini2);

        }

        bool processFlag = false;

        public void wireshark()
        {
            if (processFlag == true) return;
            processFlag = true;
            Console.WriteLine("WireShark Running......");
            if (process != null)
            {
                if (process.HasExited == false)
                {
                    process.Kill();
                    process = null;
                }
            }
            process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\Wireshark\tshark.exe"); // -q -Q
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(5000);

            if (process.HasExited == false)
            { 
                process.Kill();
                process = null;
            }
            processFlag = false;
        }


        public void Close()
        {
            T1chktimer.Stop();
            LScap.g.LSpcapStop();// .LSpcap .CloseCap();
        }

        public void CheckStart()
        {
            T1chktimeron();

            if(LScap.g.LSpcapStart() == false)
                g.Log("Card initial err.."); // opencap
        }

        #region // 통신 처리, 스피터 상태 파악 


        private void T1chktimeron()
        {
            // 타이머 가동 
            T1chktimer = new System.Timers.Timer(1000);
            T1chktimer.Elapsed += T1chktimer_Elapsed;
            T1chktimer.AutoReset = false;
            T1chktimer.Start();

            T2chktimer = new System.Timers.Timer(5000);
            T2chktimer.Elapsed += T2chktimer_Elapsed;
            //T2chktimer.AutoReset = true;
        }

        private void T2chktimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            T2chktimer.Stop();
            wireshark();
        }

        private void T1chktimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            T1chktimer_cnt++;
            T1chktimer.Start();

            if (T1chktimer_cnt == 2)
            {
                g.MainWindow.SpeakerCheck();
            }
            if (T1chktimer_cnt > gl._BaseData.SpeakerTimer)
            {
                T1chktimer_cnt = 0;
                g.MainWindow.AliveChk();
                this.OnSpeakerChecker?.Invoke(null, null);

            }
        }



        #endregion


    }
}
