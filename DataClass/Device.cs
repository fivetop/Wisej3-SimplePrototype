using DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{

	[Serializable]
	public class Device
	{
		[Key]
		public int DeviceId { get; set; }   // Event (1)   <-- 건수 표시
		public Guid id { get; set; }
		public int device { get; set; } // 0 speaker , 1 amp , 2 dsp , 3 avio 
		public string ip { get; set; }
		public string ip_dspctrl { get; set; } // DSP Controller IP 
		public string name { get; set; }
		public string DeviceName { get; set; }
		public string ModelName { get; set; }
		public string DanteModelName { get; set; }
		public string dsp_off_ch1 { get; set; }
		public string dsp_off_ch2 { get; set; }
		public long chspk { get; set; }
		public List<String> domain { get; set; }
		public List<String> dsp_out_ch1 = new List<String>();
		public List<String> dsp_out_ch2 = new List<String>();
		public List<DanteDeviceChnnel> ch { get; set; }
		public List<String> ptrdomain { get; set; }
		public List<String> srvdomain { get; set; }
		public List<String> txtdomain { get; set; }
		public List<String> Connect { get; set; }

		public string dsp_name { get; set; } // 스피커에 할당된 DSP 
		public int dsp_chno { get; set; } // 스피커에 할당된 DSP 채널번호
		public int dsp_vol { get; set; }  // 스피커에 할당된 일반 볼륨 
		public int dsp_vol_em { get; set; } // 스피커에 할당된 비상 방송 볼륨 
		public string path { get; set; } // 스피커에 위치 출력용 
		public int floor_em { get; set; } // 스피커에 할당된 비상 방송 층 
		public string emData { get; set; } // P형 R형 연계용

		public List<DSPChnnel> DSPChnnels { get; set; }

		public Device()
		{
			id = Guid.NewGuid();

			device = 0; // 0 speaker , 1 amp , 2 dsp , 3 avio 
			ip = "";
			ip_dspctrl = "";
			name = "";

			DeviceName = "";
			ModelName = "";
			DanteModelName = "";

			Connect = new List<String>();
			ptrdomain = new List<String>();
			srvdomain = new List<string>();
			txtdomain = new List<String>();
			domain = new List<String>();
			ch = new List<DanteDeviceChnnel>();

			dsp_name = "";
			dsp_chno = 0;
			dsp_vol = 5;
			dsp_vol_em = 9;

			dsp_off_ch1 = "";
			dsp_off_ch2 = "";
		}

		public int dsp_ch_cnt()
		{
			return dsp_out_ch1.Count();
		}
		// DSP Ch No write 
		public void makeDanteDeviceChannel()
		{
			if (name.Contains("DESKTOP"))
				device = 5;
			if (name.Contains("DMIC"))
				device = 4;
			if (name.Contains("AVIO"))
				device = 3;
			if (name.Contains("DSP"))
				device = 2;
			if (name.Contains("DBCP"))
				device = 0;
			if (name.Contains("DPCB"))
				device = 0;

			if (domain.Count < 1) return;
			ch.Clear();

			try
			{
				foreach (string s1 in domain)
				{
					DanteDeviceChnnel d1 = makeChNo(s1); // new DanteDeviceChnnel();
														 //DeviceName = as2[1];
					if (d1.chno != "" && d1.chname.Count > 0)
					{
						var ch1 = ch.Find(p => p.chno == d1.chno);
						if (ch1 == null)
							ch.Add(d1);
						else
						{
							if (ch1.chname.Contains(d1.chname[0]) == false)
								ch1.chname.Add(d1.chname[0]);
						}
					}
				}
			}
			catch (Exception e1)
			{
			}
		}

		public void FindSoundCard()
		{

			if (ptrdomain.Count < 1) return;
			try
			{
				foreach (string s1 in ptrdomain)
				{
					if (s1.Contains("Dante Virtual Soundcard") == true)
					{
						device = 9;
						string[] as1 = s1.Split('.');
						if (as1[8] == "_netaudio-arc")
							DanteModelName = as1[7];
						Console.WriteLine("Detect Dante Virtual Soundcard : " + DanteModelName);
					}
				}
			}
			catch (Exception e1)
			{
			}
		}

		// make dsp channel packet 
		public void makeDSPChannelpacket()
		{
			if (device != 2)
				return;

			dsp_out_ch1.Clear();
			dsp_out_ch2.Clear();
			dsp_off_ch1 = "";
			dsp_off_ch2 = "";

			Dante_DSP_PACKET t1 = new Dante_DSP_PACKET();

			foreach (DanteDeviceChnnel d1 in ch)
			{
				int chno = int.Parse(d1.chno);

				t1 = new Dante_DSP_PACKET();
				t1.seqn = 0x1f + chno;
				t1.ch = "0100";
				t1.n1 = d1.chname[0];
				t1.n2 = DeviceName; //  "DSP-88D-13719a";
				t1.r3 = "0000000000000000000000000000";
				t1.make();
				dsp_out_ch1.Add(t1.pkt);
			}

			foreach (DanteDeviceChnnel d1 in ch)
			{
				int chno = int.Parse(d1.chno);

				t1 = new Dante_DSP_PACKET();
				t1.seqn = 0x2f + chno;
				t1.ch = "0200";
				t1.n1 = d1.chname[0];
				t1.n2 = DeviceName;
				t1.r3 = "0000000000000000000000000000";
				t1.make();
				dsp_out_ch2.Add(t1.pkt);
			}

			t1 = new Dante_DSP_PACKET();
			t1.seqn = 0x4f;
			t1.r1 = "30140000000100";
			t1.ch = "000001";
			dsp_off_ch1 = t1.makeOff();

			t1 = new Dante_DSP_PACKET();
			t1.seqn = 0x5f;
			t1.r1 = "30140000000100";
			t1.ch = "000002";
			dsp_off_ch2 = t1.makeOff();

		}

		// SPeaker or POE AMP
		public void makeDanteDeviceChannelSP()
		{
			if (device > 1) return;

			if (name.Contains("DESKTOP"))
				device = 5;
			if (name.Contains("DMIC"))
				device = 4;
			if (name.Contains("AVIO"))
				device = 3;
			if (name.Contains("DSP"))
				device = 2;
			if (name.Contains("PoE"))
				device = 1;
			if (name.Contains("DBCP"))
				device = 0;

			ch.Clear();

			foreach (string s1 in ptrdomain)
			{
				DanteDeviceChnnel d1 = makeChNo(s1); // new DanteDeviceChnnel();
													 //DeviceName = as2[1];

				if (d1.chname.Count > 0)
				{
					string[] as2 = d1.chname[0].Split(' ');
					if (as2.Count() < 2)
						continue;
					if (d1.chno == "" || d1.chno == null)
						d1.chno = as2[1];
					var ch1 = ch.Find(p => p.chno == d1.chno);
					if (ch1 == null)
						ch.Add(d1);
					else
					{
						if (ch1.chname.Contains(d1.chname[0]) == false)
							ch1.chname.Add(d1.chname[0]);
					}
				}
			}
			// 스피커일경우 최종 없으면 처리하기 
			if (DeviceName == "")
				DeviceName = name;
		}

		private DanteDeviceChnnel makeChNo(string s1)
		{
			DanteDeviceChnnel d1 = new DanteDeviceChnnel();

			string[] as1 = s1.Split('.');

			foreach (string s2 in as1)
			{
				if (s2.Contains("id="))
				{
					string[] as2 = s2.Split('=');
					if (as2.Count() < 2)
						continue;
					d1.chno = as2[1];
				}
				if (s2.Contains("@"))
				{
					string[] as2 = s2.Split('@');
					if (as2.Count() < 2)
						continue;
					d1.chname.Add(as2[0]);

					if (DeviceName == "")
						DeviceName = as2[1];

				}
			}
			return d1;
			//throw new NotImplementedException();
		}

		/*


				public void makeDSPChannelpacket()
				{
					// hex stream 
					//271d003601403010000001010002002000270210021183018302830603100311313132333435004453502d3838442d31333731396100

					List<string> SpeakerGroup = new List<string>();
					List<string> dsp_ch = new List<string>();

					//            dsp_ch.Add("1학년1반");
					//            dsp_ch.Add("2학년1반");
					//            dsp_ch.Add("112345");
					dsp_ch.Add("OUT9");
					dsp_ch.Add("OUT10");
					dsp_ch.Add("OUT11");
					dsp_ch.Add("OUT12");
					dsp_ch.Add("OUT13");
					dsp_ch.Add("OUT14");
					dsp_ch.Add("OUT15");
					dsp_ch.Add("OUT16");

					string str1;
					// 단테 스피커 변경 
					str1 = "271d003601403010000001010002002000270210021183018302830603100311313132333435004453502d3838442d31333731396100";



		//				str1 = "271d0035002030100000010100020020002600000000000000000000000000004f55543132004453502d3838442d31333731396100";
						str1 = "271d0035002a30100000010100020020002600000000000000000000000000004f55543133004453502d3838442d31333731396100";
						str1 = "271d0035003430100000010100020020002600000000000000000000000000004f55543134004453502d3838442d31333731396100";
						str1 = "271d0035003e30100000010100020020002600000000000000000000000000004f55543135004453502d3838442d31333731396100";
						str1 = "271d0035004830100000010100020020002600000000000000000000000000004f55543136004453502d3838442d31333731396100";
		//				str1 = "271d003b004830100000010100010020002c000000000000000000000000000032ed9599eb858431ebb098004453502d3838442d31333731396100";
		//				str1 = "271d003600513010000001010001002000270000000000000000000000000000313132333435004453502d3838442d31333731396100";
		//				str1 = "271d0035005a30100000010100010020002600000000000000000000000000004f55543132004453502d3838442d31333731396100";
		//				str1 = "271d0035006430100000010100010020002600000000000000000000000000004f55543133004453502d3838442d31333731396100";
		//				str1 = "271d0035006e30100000010100010020002600000000000000000000000000004f55543134004453502d3838442d31333731396100";
		//				str1 = "271d0035007930100000010100010020002600000000000000000000000000004f55543135004453502d3838442d31333731396100";
		//				str1 = "271d003b00c530100000010100010020002c000000000000000000000000000031ed9599eb858431ebb098004453502d3838442d31333731396100";
		//				str1 = "271d003b00cf30100000010100020020002c000000000000000000000000000032ed9599eb858431ebb098004453502d3838442d31333731396100";
		//                        2729003b003e30100000010100010020002c000000000000000000000000000032ed9599eb858431ebb098004453502d3838442d31333731396100
		//			              ??  /
		//             271d003b012730100000010100010020002c000000000000000000000000000031ed9599eb858431ebb098004453502d3838442d31333731396100
		//             271d003b012d30100000010100010020002c000000000000000000000000000031ed9599eb858431ebb098004453502d3838442d31333731396100
		ch17
		27290033001f30100000010100010020002300000000000000000000000000003031004445534b544f502d475430544a425600
		2729003300cd30100000010100010020002300000000000000000000000000003032004445534b544f502d475430544a425600
		ch18
		2729003300ea30100000010100020020002300000000000000000000000000003031004445534b544f502d475430544a425600
		2729003300f830100000010100020020002300000000000000000000000000003032004445534b544f502d475430544a425600
				271d 0010 008e 30140000000100 000001
				271d0010008e30140000000100000001
				271d001000b330140000000100000002
				271d001000c930140000000100000001
				27290010009530140000000100000001
				27290010009a30140000000100000001

					for (int i = 1; i<dsp_ch.Count; i++)
					{
						Dante_DSP_PACKET t1 = new Dante_DSP_PACKET();
				t1.seqn = i + 0x2f;
						t1.ch = "0200";
						t1.n1 = dsp_ch[i];
						t1.n2 = "DSP-88D-13719a";
						t1.r3 = "0000000000000000000000000000";
						t1.make();
						SpeakerGroup.Add(t1.pkt);
					}

					for (int i = 1; i<dsp_ch.Count; i++)
					{
						Dante_DSP_PACKET t1 = new Dante_DSP_PACKET();
			t1.seqn = i + 0x3f;
						t1.ch = "0100";
						t1.n1 = dsp_ch[i];
						t1.n2 = "DSP-88D-13719a";
						t1.r3 = "0000000000000000000000000000";
						t1.make();
						SpeakerGroup.Add(t1.pkt);
					}
				}



		*/


	}

}
