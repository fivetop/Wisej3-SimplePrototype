using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LScap
{
    public class Program
    {

        static void Main(string[] args)
        {
            string ver = SharpPcap.Version.VersionString;
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("LS Simple Packet Capture v1.0.{0}", ver);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            if (System.IO.File.Exists("inifileCap.ini") == false)
            {
                System.IO.File.WriteAllText("inifileCap.ini", "0");
            }
            string ini = System.IO.File.ReadAllText("inifileCap.ini");
            g.NetworkCardNo = int.Parse(ini);

            g.getCardNo();
            g.OpenCap();
            Console.ReadLine();
            g.CloseCap();
        }

    }
}
