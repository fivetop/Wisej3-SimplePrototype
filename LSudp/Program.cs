using gClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LSudp
{
    internal class Program
    {
        private static udpClient udpc1 { get; set; } = null;
        static int Main(string[] args)
        {
            string str1 = "a55a100000000000011200010000000000000000000000000000000000000000";
            byte[] b1 = gl.hexatobyte(str1);

            udpc1 = new udpClient();
            udpc1.send("239.16.0.8", 6001, b1);
            //Thread.Sleep(500);
            Console.WriteLine("End...");
            udpc1.Close();
            Environment.Exit(-1);
            return 0;
        }
    }
}
