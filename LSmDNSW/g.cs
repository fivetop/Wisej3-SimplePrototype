using gClass;
using LSmDNSW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LSmDNS
{
	static public class g
	{
		static public List<byte[]> cmd = new List<byte[]>();
		static public ETC etc = new ETC();

		// new DomainName("_services._dns-sd._udp.local"); 
		static public string _netaudio_arc = "_netaudio-arc._udp.local";
		//static public string _netaudio_dbc = "_netaudio-dbc._udp.local";
		static public string _netaudio_chan = "_netaudio-chan._udp.local";
		static public string _netaudio_cmc = "_netaudio-cmc._udp.local";

		static public LSmDNS.Resolver resolver;

		static public MainWindow MainWindow = null;
		static public void Log(string log)
		{
			DateTime t = DateTime.Now;
			Console.WriteLine(t.ToString() + " : " + log);
			if(g.MainWindow != null)
				g.MainWindow.Log(t.ToString() + " : " + log);
		}

		static int cardno = 0;
		static public void GetCard()
		{
			if (System.IO.File.Exists("inifile.ini") == false)
			{
				System.IO.File.WriteAllText("inifile.ini", "11");
			}
			string ini = System.IO.File.ReadAllText("inifile.ini");
			cardno = int.Parse(ini);

			try
			{
				if(g.networkCardList.Count < 1)
					BestInterfaceIndex();

				var t2 = g.networkCardList.Find(p => p.Index == cardno); // cl.f .Find(p=>p.in);

				if (t2 == null)
				{
					t2 = g.networkCardList[0];
					System.IO.File.WriteAllText("inifile.ini", t2.Index.ToString());
				}
				Resolver.intfindx = t2.Index;
				Resolver.localIP = t2.ipv4;
			}
			catch (Exception e1)
			{
				g.Log(e1.Message + " :card  " + ini);
			}
		}

		static public List<NetworkCard> networkCardList = new List<NetworkCard>();


		static public NetworkInterface[] nics;
		static public int BestInterfaceIndex()
		{
			nics = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface nic in nics)
			{
				if (nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet) continue;
				if (nic.Supports(NetworkInterfaceComponent.IPv4) == false) continue;
				IPInterfaceProperties properties = nic.GetIPProperties();
				IPv4InterfaceProperties v4_props = properties.GetIPv4Properties();
				//g.Log("Interface No : " + v4_props.Index + " : " + nic.Name);

				foreach (var t1 in properties.UnicastAddresses)
				{
					if (t1.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
					{
						//g.Log(t1.Address.ToString());
						networkCardList.Add(new NetworkCard(v4_props.Index, nic.Name, t1.Address.ToString()));

					}
				}
				//return v4_props.Index;
			}
			return 0;
		}

		static public bool GetMain()
		{
			if (g.resolver == null)
			{
				g.resolver = new Resolver();
				//g.resolver.OnReceiveMessage += Resolver_OnReceiveMessage;
				//g.resolver.StartListening();
			}

			try
			{
				g.resolver.ResolveServiceName3(g._netaudio_arc);

				//g.resolver.ResolveServiceName2(g._netaudio_arc);

			}
			catch (System.Threading.ThreadAbortException e)
			{
				Thread.ResetAbort();
			}
			catch (Exception e)
			{
				//Thread.ResetAbort();
				//Console.WriteLine(e.Message);
			}

			return true;
		}
		internal static void division()
		{
			// 디바이스 타입 번호 할당 
			foreach (Device t2 in gl.danteDevice._DanteDevice)
			{
				if (t2.DeviceName == "")
					t2.DeviceName = t2.name;
				t2.makeDanteDeviceChannel();

			}
			// 1. 채널이름 할당 
			// 2. DSP Ch Out packet -> 271d~~
			// 3. 사운드 카드 찾기 
			foreach (Device t2 in gl.danteDevice._DanteDevice)
			{
				t2.makeDanteDeviceChannelSP ();
				t2.makeDSPChannelpacket();
				t2.FindSoundCard();
			}
		}

		public static byte[] hexatobyte(string str1)
		{
			if (str1 == null)
				return null;
			byte[] cvt = new byte[str1.Length / 2];
			int len = cvt.Length;

			for (int i = 0; i < len; i++)
			{
				string s1 = str1.Substring(i * 2, 2);
				cvt[i] = Convert.ToByte(s1, 16);
			}
			return cvt;
		}

	}

}
