using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace pa
{
    // v2 update
    public class ExtProcess
    {
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        public int id;
        public int chno;
        private string pName;

        public ExtProcess()
        {
        }

        public ExtProcess(int id, int chno)
        {
            this.id = id;
            this.chno = chno;
            Open();
        }

        public ExtProcess(string v)
        {
            this.pName = v;
        }

        public void Open()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"LSNAudio.exe");
            startInfo.UseShellExecute = false;
            startInfo.Arguments = chno.ToString() + " " + id.ToString();
            {
                //Console.WriteLine("Process ==> "+chno.ToString() + " " + id.ToString());
                process.StartInfo = startInfo;
                process.Start();
            }
        }


        public void OpenT()
        {
            Kill();
            ProcessStartInfo startInfo = new ProcessStartInfo(@"LSNAudio.exe");
            startInfo.UseShellExecute = false;
            try
            {
                startInfo.Arguments = "PreMusic 종료종소리.mp3";
                startInfo.Arguments = "PreMusic Amaryllis.mp3";
                {
                    //Console.WriteLine("Process ==> "+chno.ToString() + " " + id.ToString());
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
            catch (Exception e)
            {
                process.StartInfo.Arguments = "PreMusic 종료종소리.mp3";
                process.Start();
            }
        }

        public void Start()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(this.pName);
            startInfo.UseShellExecute = false;
            startInfo.Arguments = chno.ToString() + " " + id.ToString();
            {
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        public void Kill()
        {
            try 
            { 
                if (process.HasExited == false)
                    process.Kill();
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
    }
}
