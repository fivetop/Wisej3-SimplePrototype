using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
    [Serializable]
    public class DSPMatrix
    {
        public int min { get; set; } = 0;
        public int mout { get; set; } = 0;
        public int mstate { get; set; } = 0;
        public string ip { get; set; } = "";

        public string toString()
        {
            return ip.ToString() + " : " + min.ToString() + " : " + mout.ToString() + " : " + mstate.ToString();
        }

    }

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
