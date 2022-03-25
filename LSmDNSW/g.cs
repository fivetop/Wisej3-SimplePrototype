using DataClass;
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

namespace LSmDNSW
{
	static public class g
	{
		static public List<byte[]> cmd = new List<byte[]>();

		// new DomainName("_services._dns-sd._udp.local"); 
		static public string _netaudio_arc = "_netaudio-arc._udp.local";
		//static public string _netaudio_dbc = "_netaudio-dbc._udp.local";
		static public string _netaudio_chan = "_netaudio-chan._udp.local";
		static public string _netaudio_cmc = "_netaudio-cmc._udp.local";

		static public Resolver resolver;

		static public MainWindow MainWindow = null;

		static public DBSqlite dBSqlite { get; set; } = new DBSqlite();

		// 동수. 계단수, 층수 초기화 필요 
		static public EmSpeakerPositionList _emspl { get; set; } = new EmSpeakerPositionList();

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
			if(gl.networkCardList.Count < 1)
				gl.BestInterfaceIndex();

			var t2 = gl.networkCardList.Find(p => p.NetworkCardName == gl.NetworkCardName); // cl.f .Find(p=>p.in);

			if (t2 == null)
			{
				t2 = gl.networkCardList[0];
			}
			Resolver.intfindx = t2.NetworkCardmDNS;
			Resolver.localIP = t2.ipv4;
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

	}

}
