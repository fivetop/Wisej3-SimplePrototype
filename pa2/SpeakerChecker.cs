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
    // 프로그램 실행후 5초뒤에 와이어샥 한번 실행하기 
    class WireSharkRunning
    {
        public System.Timers.Timer T2chktimer = new System.Timers.Timer(1000 * 5);
        bool processFlag = false;
        System.Diagnostics.Process process = null;

        // 초기에 한번만 수행 
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

        public void CheckStart()
        {
            T2chktimer = new System.Timers.Timer(5000);
            T2chktimer.Elapsed += T2chktimer_Elapsed;
        }

        private void T2chktimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            T2chktimer.Stop();
            //wireshark();
        }
    }
}
