using Wisej.Web;
using System.Threading;
using Wisej.CodeProject.Examples;
using Wisej.CodeProject.Setup;
using Wisej.ChatServer;
using Wisej.CodeProject.SignalR;
using System.Collections.Generic;
using static Wisej.CodeProject.DataSet1;
using System.Linq;
using Microsoft.Ajax.Utilities;
using DataClass;
using System.Drawing;
using System;

namespace Wisej.CodeProject
{
	//시그날 알 클라이언트 처리용 
    public partial class MyDesktop : Desktop
    {
		#region // Signal R  

		internal void RcvSigR(SignalRMsg msg1)
		{
			LabelON(9,true);
			AlertBox.Show(msg1.message);
			
			this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
			evdataGridView1.Refresh();

			switch (msg1.Msgtype)
			{
				case eSignalRMsgType.eEM:
					break;
				case eSignalRMsgType.eEM_FIRE:
					if (msg1.seqno == 1)
						LabelON(1, true);
					else
						LabelON(1, false);
					break;
				case eSignalRMsgType.eEM_PRESET_SW:
					presetdisp(msg1);
					break;
				case eSignalRMsgType.ePlay:
					break;
				case eSignalRMsgType.ePlayEnd:
					this.btnStart.Enabled = true;
					this.btnStop.Enabled = false;
					break;
				case eSignalRMsgType.ePlaying:
					break;
				case eSignalRMsgType.eStop:
					break;
				case eSignalRMsgType.eLoginUser:
					break;
				case eSignalRMsgType.eLogoutUser:
					break;
				case eSignalRMsgType.eFindDSP:
					if(msg1.state == 1)
						bSDeviceManager.reLoad();
					else
						AlertBox.Show("DSP 혹은 버철사운드를 확인 바랍니다..", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
					break;
			}
			playItems = msg1.play8sig;
			if (playItems != null)
				PlayItemDisplay();
		}


		// 프리셋 메시지 올 경우 화면 출력용 
        private void presetdisp(SignalRMsg msg1)
        {
			if (msg1.state == 1)
			{
				switch (msg1.seqno)
				{
					case 0: radioButton1.Checked = true; break;
					case 1: radioButton2.Checked = true; break;
					case 2: radioButton3.Checked = true; break;
					case 3: radioButton4.Checked = true; break;
					case 4: radioButton5.Checked = true; break;
				}
			}
			else
			{
				switch (msg1.seqno)
				{
					case 0: radioButton1.Checked = false; break;
					case 1: radioButton2.Checked = false; break;
					case 2: radioButton3.Checked = false; break;
					case 3: radioButton4.Checked = false; break;
					case 4: radioButton5.Checked = false; break;
				}
			}
		}

		// 8채널과 링크 출력용 
        public void LabelON(int id, bool v)
		{
			if(bslamp1 != null)
				bslamp1.LabelOn(id, v);
		}

		internal void sendSigR(string v)
		{
			SignalRMsg msg1 = new SignalRMsg();
			msg1.message = v;
			if (signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
				signalRClient.proxy.Invoke("MessageC2S2", msg1);
		}

		internal Guid sendSigR(eSignalRMsgType v1, List<AssetsRow> selAsset, List<MusicsRow> selMusic, Guid guid)
		{
			SignalRMsg msg1 = new SignalRMsg();
			msg1.user = Application.Session["user"];

			switch (v1)
			{
				case eSignalRMsgType.ePlay:
					msg1.Guid = Guid.NewGuid();
					msg1.message = "Play";
					msg1.Msgtype = v1;
					//msg1.assetsRows = selAsset;
					//var t1 = selMusic.Select(p => new { p.MusicId }).ToList();
					var t1 = selMusic.Select(p => new { p.MusicId });
					msg1.musicsRows = t1.Select(p => p.MusicId).ToList();

					var t2 = selAsset.Select(p => new { p.AssetId });
					msg1.assetsRows = t2.Select(p => p.AssetId).ToList();
					break;
				case eSignalRMsgType.eStop:
					msg1.Guid = guid;
					msg1.message = "Stop";
					msg1.Msgtype = v1;
					break;
			}

			try
			{
				if (signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
					signalRClient.proxy.Invoke("MessageC2S2", msg1);
			}
			catch (Exception e1)
			{
			}
			return msg1.Guid;
		}

		// 8채널 출력용 
		private void PlayItemDisplay()
		{
			bslamp1.LabelOn(2, playItems[2].p_run);
			bslamp1.LabelOn(3, playItems[3].p_run);
			bslamp1.LabelOn(4, playItems[4].p_run);
			bslamp1.LabelOn(5, playItems[5].p_run);
			bslamp1.LabelOn(6, playItems[6].p_run);
			bslamp1.LabelOn(7, playItems[7].p_run);
			bslamp1.LabelOn(8, playItems[8].p_run);
		}

		internal void sendSigR(eSignalRMsgType eVolume, string device_name = "", string dsp = "", int dsp_ch = 0)
		{
			SignalRMsg msg1 = new SignalRMsg();
			msg1.user = Application.Session["user"];

			switch (eVolume)
			{
				case eSignalRMsgType.eVolume:
					msg1.Guid = Guid.NewGuid();
					msg1.message = "Volume";
					msg1.Msgtype = eVolume;
					break;

				case eSignalRMsgType.eOutChMove:
					msg1.Guid = Guid.NewGuid();
					msg1.message = device_name;
					msg1.Msgtype = eVolume;
					msg1.state = dsp_ch;
					msg1.user_data = dsp;
					break;

				case eSignalRMsgType.eScanAll:
					msg1.Guid = Guid.NewGuid();
					msg1.Msgtype = eVolume;
					msg1.message = "Scan All";
					break;
			}

			try
			{
				if (isSignalR())
					signalRClient.proxy.Invoke("MessageC2S2", msg1);
			}
			catch (Exception e1)
			{
			}
		}

		public bool isSignalR()
		{
			if (signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
				return true;
			else
				return false;

		}

		#endregion
	}
}