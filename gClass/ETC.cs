using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace gClass
{
    public class ETC
    {
		// NAudio 사용 
		// .Net Framework 4.0 Fix 필요 ==> 다른버젼 에러 발생  


		public byte[] hexatobyte(string str1)
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

	// 예약 방송 중복 점검을 위한 
	public class timerevent
	{
		public TimeSpan t1 { get; set; } // 남은시간
		public PlayItem item1 { get; set; } // 남은시간
		public PlayItem item2 { get; set; } // 남은시간
		public timerevent()
		{
			t1 = new TimeSpan(0, 0, 0);
			item1 = new PlayItem();
			item2 = new PlayItem();
		}
	}


}
