
using DataClass;
using System;
using System.Collections.Generic;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2
{
	public partial class Simplepa3 : Page
	{
		public Simplepa3()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {

        }


		#region // Signal R  

		internal void RcvSigR(SignalRMsg msg1)
		{
		}


		// 프리셋 메시지 올 경우 화면 출력용 
		private void presetdisp(SignalRMsg msg1)
		{
		}

		// 8채널과 링크 출력용 
		public void LabelON(int id, bool v)
		{
		}

		internal void sendSigR(string v)
		{
		}

		internal Guid sendSigR(eSignalRMsgType v1, List<AssetsRow> selAsset, List<MusicsRow> selMusic, Guid guid)
		{
			return guid;
		}

		// 8채널 출력용 
		private void PlayItemDisplay()
		{
		}

		internal void sendSigR(eSignalRMsgType eVolume, string device_name = "", string dsp = "", int dsp_ch = 0, int device_ch = 0)
		{
		}

		public bool isSignalR()
		{
				return false;

		}

		#endregion

	}
}
