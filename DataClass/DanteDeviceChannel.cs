using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
	[Serializable]
	public class DanteDeviceChnnel
	{
		[Key]
		public int DanteDeviceChnnelId { get; set; }   // Event (1)   <-- 건수 표시
		public string chno { get; set; }
		public List<string> chname { get; set; }
		public List<String> connect { get; set; }

		public DanteDeviceChnnel()
		{
			chname = new List<string>();
			connect = new List<String>();
		}
	}
}
