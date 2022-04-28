using gClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gClass
{
    public class DSPControll
    {
		static udpClient udpc1 = null;
		int sleeptime = 10;

		public List<string> muteInON = new List<string>();
		public List<string> muteInOFF = new List<string>();
		public List<string> muteOutON = new List<string>();
		public List<string> muteOutOFF = new List<string>();
		public List<string> vol = new List<string>();

		// 앰프 메트릭스 명령후 실행 안됨 메트릭스 찾기 
		public object QueueLock { get; set; } = new object();
		// 실행 안됨 명령 모음 
		public List<string> SvsR { get; set; } = new List<string>();
		// 실행할 메트릭스 카운트
		public int MetrixCount { get; set; } = 0;

		public DSPControll()
        {
			makePacket();

			udpc1 = new udpClient();
			udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
			udpc1.buf2.Clear();
			udpc1.rcv();

		}

		public void Close()
		{
			udpc1.Close();
		}

		// 통신전 버퍼 클리어 
		public void BufferClear()
		{
			lock (QueueLock)
			{ 
				udpc1.buf2.Clear();
				SvsR.Clear();
				MetrixCount = 0;
			}
		}

		public delegate void ReceiveMessageHandler(string message);
		public event ReceiveMessageHandler OnReceiveMessage;

		private void Udpc1_OnReceiveMessage(string message)
        {
			//Console.WriteLine(message);
			lock (QueueLock)
			{
				if (SvsR.Count == 0)
					return;
				try
				{
					foreach (byte[] b1 in udpc1.buf2)
					{
						string m1 = gl.bytetostring(b1);
						string m2 = m1.ToUpper();
						string m3 = gl.RePlaceAt(m2, 6, 2, "00");
						if (SvsR.Remove(m3))
						{
							//if(gl.SvsR.Count > 0)
							//	Console.WriteLine(gl.MetrixCount.ToString() +" / "+ gl.SvsR.Count().ToString());
						}
					}
				}
				catch (Exception e1)
				{
					return;
				}
				//SvsR.LastOrDefault
				//udpc1.buf2.Clear();
			}
		}


		#region // DSP 뮤트 볼륨 초기화 처리 
		public void makePacket()
		{
			// 볼륨 처리 
			vol.Add("E0E3");
			vol.Add("38E6");
			vol.Add("90E8");
			vol.Add("E8EA");
			vol.Add("40ED");
			vol.Add("F0F1");
			vol.Add("A0F6");
			vol.Add("50FB");
			vol.Add("0000");
			vol.Add("9001");
			vol.Add("B004");

			// 뮤트 in 처리 
			for (int i = 0; i < 32; i++)
			{
				string str1 = "B32105002B0102";
				string str2 = String.Format("{0:x4}", i);
				string str3 = str1 + str2 + "000100";
				muteInON.Add(str3);
			}

			for (int i = 0; i < 32; i++)
			{
				string str1 = "B32105002B0102";
				string str2 = String.Format("{0:x4}", i);
				string str3 = str1 + str2 + "000000";
				muteInOFF.Add(str3);
			}

			// 뮤트 out 처리 
			for (int i = 0; i < 32; i++)
			{
				string str1 = "B3210700270102";
				string str2 = String.Format("{0:x4}", i);
				string str3 = str1 + str2 + "000100";
				muteOutON.Add(str3);
			}

			for (int i = 0; i < 32; i++)
			{
				string str1 = "B3210700270102";
				string str2 = String.Format("{0:x4}", i);
				string str3 = str1 + str2 + "000000";
				muteOutOFF.Add(str3);
			}

		}

		#endregion

		public void DSPmuteInON(string v)
		{ 
			foreach (var str1 in muteInON)
            { 
                byte[] bytes1 = gl.hexatobyte(str1);
				udpc1.send(v, 50000, bytes1);
                Thread.Sleep(sleeptime);
            }
		}

		public void DSPmuteInOFF(string v)
		{
			foreach (var str1 in muteInOFF)
			{
				byte[] bytes1 = gl.hexatobyte(str1);
				udpc1.send(v, 50000, bytes1);
				Thread.Sleep(sleeptime);
			}

		}

		public void DSPmuteOutON(string v)
		{
			foreach (var str1 in muteOutON)
			{
				byte[] bytes1 = gl.hexatobyte(str1);
				udpc1.send(v, 50000, bytes1);
				Thread.Sleep(sleeptime);
			}

		}

		public void DSPmuteOutOFF(string v)
		{
			foreach (var str1 in muteOutOFF)
			{
				byte[] bytes1 = gl.hexatobyte(str1);
				udpc1.send(v, 50000, bytes1);
				Thread.Sleep(sleeptime);
			}

		}

		// Out ch no / vol 
		public void makeVolumn(int chno, int v1, string ip)
		{
			var d1 = gl.danteDevice._DanteDevice.First(p => p.ip_dspctrl == ip && p.device == 2);
			if (d1 == null) return;

			int no = 0;
			no = chno - 1;

			string str1 = "B321C100270101";
			string str2 = String.Format("{0:x4}", no);
			string str3 = str1 + str2 + "00" + vol[v1];

			byte[] bytes1 = gl.hexatobyte(str3);
			udpc1.send(ip, 50000, bytes1);
			Thread.Sleep(sleeptime);
			
			//Console.WriteLine(str3);
		}

		// IN ch no / vol 
		public void makeInVolumn(int chno, int v1, string ip)
		{
			var d1 = gl.danteDevice._DanteDevice.First(p => p.ip_dspctrl == ip && p.device == 2);
			if (d1 == null) return;

			int no = 0;
			no = chno - 1;
			// B32194002B0101001F0079FB
			// B32102002B0101001E00E6FD
			//string str1 = "B321C100270101";
			string str1 = "B32102002B0101";
			string str2 = String.Format("{0:x4}", no);
			string str3 = str1 + str2 + "00" + vol[v1];

			byte[] bytes1 = gl.hexatobyte(str3);
			udpc1.send(ip, 50000, bytes1);
			Thread.Sleep(sleeptime);

			//Console.WriteLine(str3);
		}

		public void Matrix(int m_in, int m_out, int onoff, string ip)
		{
			var d1 = gl.danteDevice._DanteDevice.First(p => p.ip_dspctrl == ip && p.device == 2);
			if (d1 == null) return;

			int no = 0;
			no = m_out - 1;

			string str1 = "B3217D00A6000100";
			string str2 = String.Format("{0:x2}", m_in); // in
			string str3 = String.Format("{0:x2}", no); // out
			string str4 = String.Format("{0:x2}", onoff); // on off
			string str5 = str1 + str2 + str3 + str4 + "00";

			lock (QueueLock)
			{
				string str6 = str5.ToUpper();
				//Console.WriteLine(str6);
				SvsR.Add(str6);
				MetrixCount++;
			}
			byte[] bytes1 = gl.hexatobyte(str5);
			udpc1.send(ip, 50000, bytes1);
			Thread.Sleep(sleeptime);


		}
	}
}
