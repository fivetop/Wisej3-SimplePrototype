using gClass;
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

            gl.NetWorkCardFind();

            Console.WriteLine(gl.NetworkCardNo.ToString() + ":" + gl.NetworkCardmDNS.ToString() + ":" + gl.NetworkCardName);

            g.OpenCap();
            Console.ReadLine();
            g.CloseCap();
        }

    }
}
