using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using gClass;
using System.Diagnostics;
using System.Net.NetworkInformation;
using LSmDNS;

namespace LSmDNSW
{
    public class Program2
    {

		static udpClient udpc1 = null;
        static bool running = false;
        static System.Timers.Timer timer = new System.Timers.Timer(10000);
        static int case1 = 0;

        public static void Main2(string[] args)
        {

            if (System.IO.File.Exists("inifile.ini") == false)
            {
                System.IO.File.WriteAllText("inifile.ini", "1");
            }
            string ini = System.IO.File.ReadAllText("inifile.ini");
            int card = int.Parse(ini);

            //g.XMLDanteDevice(true);
            //Main2();
            //return;
            //g.Log("Select Interface No..");

            LSmDNS.Resolver.intfindx = card;
            g.Log("Start LS mDNS Server !!");
            g.Log("Help : ?");
            BestInterfaceIndex();

            g.resolver = new LSmDNS.Resolver();
            g.resolver.OnReceiveMessage += Resolver_OnReceiveMessage;
            //g.resolver.StartListening();

            bool loop = true;

            while (loop)
            {
                try
                { 
                    var key1 =  Console.ReadKey().KeyChar;

                    switch (key1)
                    {
                        case 'X':
                            loop = false;
                            break;
                        case '?':
                            g.Log("");
                            g.Log("Help : ?");
                            g.Log("T:Timer Start (10s)...");
                            g.Log("S:Save Data (Detect Dante Devices)...");
                            g.Log("L:List (Dante Devices)...");
                            g.Log("N:Network Interface ..");
                            //g.Log("R:Run Test (Dante Speaker Lotate Test)...");
                            //g.Log("A:Test A");
                            g.Log("X:Server Exit...");
                            break;
                        case 'T':
                            g.Log("");
                            g.Log("T:Timer Start...");
                            timer.Elapsed += Timer_Elapsed;
                            timer.AutoReset = true;
                            timer.Start();
                            break;
                        case 'S':
                            g.Log("");
                            g.Log("S:Save Data...");
                            g.division();
                            gl.XMLDanteDevice(false);
                            SpeakerAssignDSP();
                            DSPinputChannelAssign();
                            //g.XMLDanteDevice(true);
                            gl.XMLDanteDevice(false);
                            break;
                        case 'L':
                            g.Log("L:List");
                            g.division();
                            foreach (Device t2 in gl.danteDevice._DanteDevice)
                            {
                                g.Log(t2.ip.ToString() + " : " + t2.DeviceName + " : " + t2.name + " : " + t2.device.ToString() + " : " + t2.ip_dspctrl);
                            }
                            break;
                        case 'R':
                            timer.Stop();
                            gl.XMLDanteDevice(true);
                            g.Log("R:Run Test");
                            Main2();
                            break;
                        case 'N':
                            timer.Stop();
                            g.Log("N:Network interface");
                            BestInterfaceIndex();
                            //g.danteDevice._DanteDevice.Clear();
                            //g.GetMain();
                            break;
                        case 'A':
                            timer.Stop();
                            g.Log("A:Test A");
                            //g.danteDevice._DanteDevice.Clear();
                            //g.GetMain();
                            break;
                        case 'B':
                            break;
                        default:
                            Console.WriteLine("");
                            break;

                    }
                }
                catch (Exception e1)
                {
                    g.Log(e1.Message);
                }
            }
        }

        public static void Main3()
        {

            if (System.IO.File.Exists("inifile.ini") == false)
            {
                System.IO.File.WriteAllText("inifile.ini", "1");
            }
            string ini = System.IO.File.ReadAllText("inifile.ini");
            int card = int.Parse(ini);

            LSmDNS.Resolver.intfindx = card;
            g.Log("Start LS mDNS Server !!");
            g.Log("Help : ?");
            BestInterfaceIndex();

            g.resolver = new LSmDNS.Resolver();
            g.resolver.OnReceiveMessage += Resolver_OnReceiveMessage;
            //g.resolver.StartListening();

        }

        public static int BestInterfaceIndex()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet) continue;
                if (nic.Supports(NetworkInterfaceComponent.IPv4) == false) continue;
                IPInterfaceProperties properties = nic.GetIPProperties();
                IPv4InterfaceProperties v4_props = properties.GetIPv4Properties();
                g.Log("Interface No : " + v4_props.Index +" : " + nic.Name);

                foreach (var t1 in properties.UnicastAddresses)
                {
                    if (t1.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        g.Log(t1.Address.ToString());

                    }
                }
                //return v4_props.Index;
            }
            return 0;
        }


        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Interval = 1000 * 60;
            switch (case1)
            {
                case 0:
                    case1 = 1;
                    g.Log("process 1 -- _netaudio_arc");
                    //resolver.ResolveServiceName(g._netaudio_arc);
                    g.resolver.ResolveServiceName2(g._netaudio_arc);
                    break;
                case 1:
                    case1 = 2;
                    g.Log("process 2 -- _netaudio_chan");
                    g.resolver.ResolveServiceName(g._netaudio_chan);
                    break;
                case 2:
                    case1 = 3;
                    g.Log("process 3 -- _netaudio_cmc");
                    g.resolver.ResolveServiceName(g._netaudio_cmc);
                    break;
                case 3:
                    case1 = 0;
                    g.Log("process 4 -- Find DSP");
                    FindDSP();
                    break;
            }
            //timer.Close();
            //timer.Dispose();
            g.resolver.GetDevice();
            GC.Collect();
        }

        private static void Resolver_OnReceiveMessage(string message)
        {
            //if (resolver.rcvAddress() == false)
            //    return;
            if (running == false)
            {
                running = true;
                //resolver.GetDevice();
                //g.Log("Rcv Packet..");
                running = false;
            }
        }

        private static void FindDSP()
        {
            LScap.g.capData1.Clear();
            LScap.g.capData2.Clear();
            LScap.g.OpenCap();

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\Wireshark\tshark.exe");
            startInfo.UseShellExecute = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(1000);

            udpc1 = new udpClient();
            udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
            udpc1.buf2.Clear();
            udpc1.rcv();

            string str1 = "a55a100000000000011200010000000000000000000000000000000000000000";
            byte[] bytes1 = g.etc.hexatobyte(str1);
            udpc1.send("239.16.0.8", 6001, bytes1);
            Thread.Sleep(1000);

            if (process.HasExited == false)
                process.Kill();

            var t2 = LScap.g.capData1;
            var t3 = LScap.g.capData2;
            LScap.g.CloseCap();

            Thread.Sleep(500);
            udpc1.Close();

            foreach (var t1 in t2)
                g.Log(t1);
            foreach (var t1 in t3)
                g.Log(t1);

            foreach (Device t5 in gl.danteDevice._DanteDevice)
            {
                for(int i = 0; i < t3.Count; i++)
                {
                    if (t5.name == t3[i])
                    {
                        t5.ip_dspctrl = t2[i];
                        g.Log("Find DSP Controller IP : " + t5.ip_dspctrl +" "+ t3[i]);
                    }
                }
            }
            //_lv1.ItemsSource = null;
            //_lv1.ItemsSource = t3;
        }

        // DSP 각 채널에 스피커를 할당한다. 
        private static void SpeakerAssignDSP()
        {
            List<Device> dsp1 = new List<Device>();

            for (int i = 0; i < gl.danteDevice._DanteDevice.Count; i++)
            {
                var t1 = gl.danteDevice._DanteDevice[i];
                if (t1.device != 2)
                    continue;
                dsp1.Add(gl.danteDevice._DanteDevice[i]);
            }

            if (dsp1.Count < 1)
                return;
            udpc1 = new udpClient();
            udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
            udpc1.buf2.Clear();
            udpc1.rcv();
            /*
                        // 스피커 분리 처리
                        for (int i = 0; i < g.danteDevice._DanteDevice.Count; i++)
                        {
                            var t1 = g.danteDevice._DanteDevice[i];
                            if (t1.device != 0)
                                continue;

                            if (t1.ip == "")
                                continue;
                            byte[] b1 = g.etc.hexatobyte(dsp1.dsp_off_ch1);
                            udpc1.send(t1.ip, 4440, b1);
                            Thread.Sleep(50);
                        }
            */

            var sst1 = gl.danteDevice._DanteDevice.Where(p=>p.device == 0);
            Console.WriteLine("Assign Speaker :" + sst1.Count().ToString());
            int chno = 0;
            int dspno = 0;
            // 스피커에 DSP 채널 할당하고 이동 처리 
            for (int i = 0; i < gl.danteDevice._DanteDevice.Count; i++)
            {
                var t1 = gl.danteDevice._DanteDevice[i];
                if (t1.device != 0)
                    continue;

                if (t1.ip == "")
                    continue;
                chno++;
                // DSP 채널이 없으면 다음 DSP 로 할당 
                if (dsp1[dspno].dsp_out_ch1.Count < chno)
                {
                    chno = 1;
                    dspno++;
                }
                if (dsp1.Count < (dspno +1))
                {
                    g.Log("DSP channel check!!");
                    return;
                }
                t1.dsp_chno = chno;
                t1.dsp_name = dsp1[dspno].name;
                t1.ip_dspctrl = dsp1[dspno].ip_dspctrl;
                Console.WriteLine("Speaker Assign DSP Name Ch :" + t1.dsp_name +" : "+ chno.ToString());

                byte[] b1 = g.etc.hexatobyte(dsp1[dspno].dsp_out_ch1[chno - 1]);
                udpc1.send(t1.ip, 4440, b1);
                Thread.Sleep(2000);
            }

            Thread.Sleep(500);
            udpc1.Close();

        }

        private static void DSPinputChannelAssign()
        {
            udpc1 = new udpClient();
            udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
            udpc1.buf2.Clear();
            udpc1.rcv();

            var sst1 = gl.danteDevice._DanteDevice.First(p => p.device == 9);
            if (sst1 == null)
            { 
                Console.WriteLine("Check Virtual Sound Card..");
                return;
            }

            string[] chno = { "01", "03", "05", "07", "09", "11", "13", "15" };

            for (int i = 0; i < gl.danteDevice._DanteDevice.Count; i++)
            {
                var t1 = gl.danteDevice._DanteDevice[i];
                if (t1.device != 2)
                    continue;
                if (t1.ip == "")
                    continue;

                for (int j = 0; j < 8; j++)
                {
                    Dante_DSP_PACKET tt1 = new Dante_DSP_PACKET();
                    tt1.hd = "2729";
                    tt1.seqn = 0x1f + j;
                    tt1.ch = "0100";
                    tt1.ch = String.Format("{0:x2}", j + 1) + "00";
                    tt1.n1 = chno[j];
                    tt1.n2 = sst1.DanteModelName; //  "DESKTOP-GT0TJBV"; //  "DSP-88D-13719a";
                    tt1.r3 = "0000000000000000000000000000";

                    Console.WriteLine("DSP Input Move : " + t1.ip + "/"+chno[j]);
                    string str2 = tt1.make_DSPin();
                    byte[] b1 = g.etc.hexatobyte(str2);
                    udpc1.send(t1.ip, 4440, b1);
                    Thread.Sleep(3000);

                }
            }
        }


        static void Main2()
		{
			udpc1 = new udpClient();
			udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
			udpc1.buf2.Clear();
			udpc1.rcv();

            Device d1 = new Device();
            byte[] b1 = { };

            for (int i = 0; i < gl.danteDevice._DanteDevice.Count; i++)
            {
                var t1 = gl.danteDevice._DanteDevice[i];
                if (t1.device != 2)
                    continue;
                d1 = gl.danteDevice._DanteDevice[i];
            }

            // speaker on 
            for (int i = 0; i < d1.dsp_out_ch1.Count; i++)
			{
                b1 = g.hexatobyte(d1.dsp_out_ch1[i]);
                //udpc1.send("169.254.48.123", 4440, b1);
                udpc1.send("169.254.146.28", 4440, b1);
                udpc1.send("169.254.226.255", 4440, b1);
                udpc1.send("169.254.217.255", 4440, b1);
                udpc1.send("169.254.214.255", 4440, b1);
                Thread.Sleep(500);
				Console.ReadKey();

			}

            // off speaker 
            b1 = g.hexatobyte(d1.dsp_off_ch1);
            udpc1.send("169.254.146.28", 4440, b1);
            udpc1.send("169.254.226.255", 4440, b1);
            udpc1.send("169.254.217.255", 4440, b1);
            udpc1.send("169.254.214.255", 4440, b1);

            Thread.Sleep(500);
			udpc1.Close();
		}



		private static void Udpc1_OnReceiveMessage(string message)
		{
			Console.WriteLine("Rcv.." + udpc1.buf2.Count.ToString());
		}


	}
}
