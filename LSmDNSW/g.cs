using CosineKitty.ZeroConfigWatcher;
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
using Wisej.CodeProject;

namespace LSmDNSW
{
	static public class g
	{
		// new DomainName("_services._dns-sd._udp.local"); 
		static public string _netaudio_arc = "_netaudio-arc._udp.local";
		//static public string _netaudio_dbc = "_netaudio-dbc._udp.local";
		static public string _netaudio_chan = "_netaudio-chan._udp.local";
		static public string _netaudio_cmc = "_netaudio-cmc._udp.local";

		static public Resolver resolver { get; set; } = new Resolver();

		static public MainWindow MainWindow { get; set; } = null;

		static public DBSqlite dBSqlite { get; set; } = new DBSqlite();

		static public AThread aThread { get; set; } = new AThread();

		static public BThread bThread { get; set; } = new BThread();


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
			try
			{
				g.resolver = new Resolver();
				g.resolver.ResolveServiceName3(g._netaudio_arc);
			}
			catch (Exception e)
			{
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


		static bool findDSP = false;

		// DSP Control IP 는  239.16.0.8 에서 확인 요
		// 처음 설치시 한번 필요 
		public static void FindDSP()
		{
			if (findDSP)
				return;

			findDSP = true;
			List<string> t21 = new List<string>();
			List<string> t31 = new List<string>();

			LScap.g.capData1.Clear();
			LScap.g.capData2.Clear();
			LScap.g.OpenCap();

			string str1 = "a55a100000000000011200010000000000000000000000000000000000000000";
			byte[] b1 = gl.hexatobyte(str1);

			AThreadData aThreadData = new AThreadData();
			aThreadData.ip = "239.16.0.8";
			aThreadData.b1 = b1;
			aThreadData.LocalIP = Resolver.localIP;
			aThreadData.intfindx = Resolver.intfindx;
			bThread.AddData(aThreadData);
			Thread.Sleep(5000);

			LScap.g.CloseCap();
			var t2 = LScap.g.capData1;
			var t3 = LScap.g.capData2;
			foreach (var t1 in t2)
			{
				t21.Add(t1);
				g.Log(t1);
			}
			foreach (var t1 in t3)
			{
				t31.Add(t1);
				g.Log(t1);
			}

			foreach (var t5 in gl.danteDevice._DanteDevice)
			{
				if (t5.device == 9)
				{
					g.Log("--------------------------------------------------------------------------------");
					g.Log("Find Sound Card  : " + t5.ip_dspctrl + " " + t5.DeviceName);
					g.Log("--------------------------------------------------------------------------------");
				}
				for (int i = 0; i < t31.Count; i++)
				{
					if (t5.name == t31[i])
					{
						t5.ip_dspctrl = t21[i];

						if (t5.ch.Count > 1)
						{
							g.Log("--------------------------------------------------------------------------------");
							g.Log("Find DSP Controller IP : " + t5.ip_dspctrl + " " + t31[i]);
							g.Log("--------------------------------------------------------------------------------");
						}
					}
				}
			}
			findDSP = false;
		}

	}

}
