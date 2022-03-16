using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace gClass
{
	[Serializable]
	public class DSPChnnel
	{
		public int chno { get; set; }
		public string chname { get; set; }
		public string purpose { get; set; }  // 사용용도 예약/중앙/개별/비상
		public string division { get; set; } // 구분 일반/단테
	}

	[Serializable]
	public class DanteDevice : INotifyPropertyChanged
	{
		public List<Device> _DanteDevice { get; set; }

		public DanteDevice()
		{
			_DanteDevice = new List<Device>();
		}

        public event PropertyChangedEventHandler PropertyChanged;
    }


}
