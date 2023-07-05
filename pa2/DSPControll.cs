using DataClass;
using gClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace pa
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

        public static List<DSPMatrix> rcv = new List<DSPMatrix>();

        public System.Timers.Timer retry = new System.Timers.Timer(500);

        public DSPControll()
        {
			makePacket();

			udpc1 = new udpClient();
			udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
			udpc1.buf2.Clear();
			udpc1.rcv();

            retry.Elapsed += Retry_Elapsed;
        }

        public delegate void ResultMessageHandler(string message);
        public event ResultMessageHandler OnResult;


        private void Retry_Elapsed(object sender, ElapsedEventArgs e)
        {
            retry.Stop();

            foreach (var t1 in rcv)
            {
                var t2 = gl.SvsR.FirstOrDefault(p => p.min == t1.min && p.mout == (t1.mout + 1) && p.mstate == t1.mstate);
                if (t2 != null)
                {
                    gl.SvsR.Remove(t2);
                }
            }
            rcv.Clear();

            // retry 처리 
            try
            {
				if (gl.SvsR.Count == 0)
				{
					Console.WriteLine("DSP Metrix check OK..");
					OnResult?.Invoke("1");
					return;
				}
                foreach (var t1 in gl.SvsR)
                {
                    Matrix(t1.min, t1.mout, t1.mstate, t1.ip);
                    Console.WriteLine(t1.toString());
                }
                foreach (var t1 in gl.SvsR)
                {
                    Matrix(t1.min, t1.mout, t1.mstate, t1.ip);
                }
                foreach (var t1 in gl.SvsR)
                {
                    Matrix(t1.min, t1.mout, t1.mstate, t1.ip);
                }
                OnResult?.Invoke("0");
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            //gl.SvsR.Clear();
            retry.Start();
        }

        public void Close()
		{
			udpc1.Close();
		}

		// 통신전 버퍼 클리어 
		public void BufferClear()
		{
			lock (gl.QueueLock)
			{ 
				udpc1.buf2.Clear();
				gl.SvsR.Clear();
			}
		}

		public delegate void ReceiveMessageHandler(string message);
		public event ReceiveMessageHandler OnReceiveMessage;

		private void Udpc1_OnReceiveMessage(string message)
        {
            //OnReceiveMessage(message);
            if (message.Length > 24)
                return;

            if (message.Contains("B322") == false)
                return;
            ///*
            DSPMatrix dmc = new DSPMatrix();
            string s1 = "0x" + message.Substring(16, 2);
            string s2 = "0x" + message.Substring(18, 2);
            string s3 = "0x" + message.Substring(20, 2);
            dmc.min = Convert.ToInt32(s1, 16);
            dmc.mout = Convert.ToInt32(s2, 16);
            dmc.mstate = Convert.ToInt32(s3, 16);
            rcv.Add(dmc);
            Console.WriteLine(dmc.toString());
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

		// 특정 채널만 뮤트 오프 처리 
		public void DSPmuteInOFF(string v, int ch)
		{
			var str1 = muteInOFF[ch-1];
			byte[] bytes1 = gl.hexatobyte(str1);
			udpc1.send(v, 50000, bytes1);
			Thread.Sleep(sleeptime);
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
		public void makeVolumn(int chno, long v1, string ip)
		{
			//var d1 = gl.danteDevice._DanteDevice.First(p => p.ip_dspctrl == ip && p.device == 2);
			//if (d1 == null) return;

			int v2 = (int)v1;
			int no = 0;
			no = chno - 1;

			string str1 = "B321C100270101";
			string str2 = String.Format("{0:x4}", no);
			string str3 = str1 + str2 + "00" + vol[v2];

			byte[] bytes1 = gl.hexatobyte(str3);
			udpc1.send(ip, 50000, bytes1);
			Thread.Sleep(sleeptime);
			
			//Console.WriteLine(str3);
		}

		// IN ch no / vol 
		public void makeInVolumn(int chno, int v1, string ip)
		{
			//var d1 = gl.danteDevice._DanteDevice.First(p => p.ip_dspctrl == ip && p.device == 2);
			//if (d1 == null) return;

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
			//var d1 = gl.danteDevice._DanteDevice.First(p => p.ip_dspctrl == ip && p.device == 2);
			//if (d1 == null) return;

			int no = 0;
			no = m_out - 1;

			string str1 = "B3217D00A6000100";
			string str2 = String.Format("{0:x2}", m_in); // in
			string str3 = String.Format("{0:x2}", no); // out
			string str4 = String.Format("{0:x2}", onoff); // on off
			string str5 = str1 + str2 + str3 + str4 + "00";

			byte[] bytes1 = gl.hexatobyte(str5);
			udpc1.send(ip, 50000, bytes1);
			Thread.Sleep(sleeptime);

            lock (gl.QueueLock)
            {
                DSPMatrix dm = new DSPMatrix();
                dm.min = m_in;
                dm.mout = m_out;
                dm.mstate = onoff;
                dm.ip = ip;
                if (gl.SvsR.Exists(p => p.min == dm.min && p.mout == dm.mout && p.mstate == dm.mstate && p.ip == dm.ip) == false)
                    gl.SvsR.Add(dm);
            }

            str1 = "B3227D00A6000100";
            str5 = str1 + str2 + str3 + str4 + "00";
            bytes1 = gl.hexatobyte(str5);
            udpc1.send(ip, 50000, bytes1);
            Thread.Sleep(10); // *2
        }
	}
}
