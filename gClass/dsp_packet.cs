using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gClass
{
	public class Dante_DSP_PACKET
	{
		public string hd = "271d";
		public string sz = "0036";
		public string seq = "001f";
		public string r1 = "30100000010100";
		public string ch = "0200";
		public string r2 = "20";
		public string sz2 = "0027";
		public string r3 = "0210021183018302830603100311";
		public string n1 = "112345";
		public string n2 = "DSP-88D-13719a";
		public byte[] bytes = { };
		public string pkt = "";
		public int seqn = 0;

		public Dante_DSP_PACKET()
		{
		}

        #region // dante controller 
        public string make()
		{
			string ret = "";
			string l1 = "";
			string l2 = "";
			int len = 0;
			int len2 = 0;

			seq = String.Format("{0:x4}", seqn);

			byte[] t2 = Encoding.UTF8.GetBytes(n1);
			byte[] t3 = Encoding.UTF8.GetBytes(n2);

			string t2s = bytetostring(t2) + "00";
			string t3s = bytetostring(t3) + "00";

			l2 = r2 + sz2 + r3 + t2s + t3s;
			len2 = l2.Length / 2;
			sz2 = String.Format("{0:x4}", len2);

			l1 = seq + r1 + ch + r2 + sz2 + r3 + t2s + t3s;
			len = (l1.Length + 8) / 2;

			sz = String.Format("{0:x4}", len);


			ret = hd + sz + l1;
			pkt = ret;
			return ret;
		}

		public string make_DSPin()
		{
			string ret = "";
			string l1 = "";
			string l2 = "";
			int len = 0;
			int len2 = 0;

			seq = String.Format("{0:x4}", seqn);

			byte[] t2 = Encoding.UTF8.GetBytes(n1);
			byte[] t3 = Encoding.UTF8.GetBytes(n2);

			string t2s = bytetostring(t2) + "00";
			string t3s = bytetostring(t3) + "00";

			l2 = r2 + sz2 + r3 + t2s + t3s;
			len2 = l2.Length / 2;
			sz2 = String.Format("{0:x4}", len2-1);

			l1 = seq + r1 + ch + r2 + sz2 + r3 + t2s + t3s;
			len = (l1.Length + 8) / 2;

			sz = String.Format("{0:x4}", len);


			ret = hd + sz + l1;
			pkt = ret;
			return ret;
		}

		public string makeOff()
		{
			string ret = "";
			string l1 = "";
			int len = 0;

			seq = String.Format("{0:x4}", seqn);

			l1 = seq + r1 + ch;
			len = (l1.Length + 8) / 2;

			sz = String.Format("{0:x4}", len);

			ret = hd + sz + l1;
			pkt = ret;
			return ret;
		}

		public static string bytetostring(byte[] t)
		{
			string ret = string.Empty;

			ret = string.Concat(Array.ConvertAll(t, byt => byt.ToString("x2")));
			return ret;
		}

        #endregion
    }

}
