using gClass;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Timers;
using System.Windows.Threading;

namespace pa
{
    class SpeakerChecker
    {
        public System.Timers.Timer T1chktimer = new System.Timers.Timer(1000 * 5);
        public System.Timers.Timer T2chktimer = new System.Timers.Timer(1000 * 5);
        int T1chktimer_cnt = 0;

        System.Diagnostics.Process process = null;

        public SpeakerChecker()
        {
        }

        bool processFlag = false;

        public void wireshark()
        {
            if (processFlag == true) return;
            processFlag = true;
            g.Log("WireShark Running......");
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
            g.Log("Device Check : Running.."); // opencap
            // 타이머 가동 
            T1chktimer = new System.Timers.Timer(1000);
            T1chktimer.Elapsed += T1chktimer_Elapsed;
            T1chktimer.AutoReset = false;
            T1chktimer.Start();

            T2chktimer = new System.Timers.Timer(5000);
            T2chktimer.Elapsed += T2chktimer_Elapsed;
            //T2chktimer.AutoReset = true;
            if (LScap.g.LSpcapStart() == false)
            { 
                g.Log("Card initial err.."); // opencap
            }
        }

        #region // 통신 처리, 스피터 상태 파악 


        private void T2chktimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            T2chktimer.Stop();
            wireshark();
        }

        public event EventHandler OnAliveChk;
        public event EventHandler OnSpeakerCheck;

        private void T1chktimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            T1chktimer_cnt++;
            T1chktimer.Start();

            if (T1chktimer_cnt == 2)
            {
                this.OnSpeakerCheck?.Invoke(null, null);
            }
            if (T1chktimer_cnt > 15)
            {
                T1chktimer_cnt = 0;
                this.OnAliveChk?.Invoke(null, null);
            }
        }
        #endregion
    }
}
