using Wisej.Web;
using System.Threading;
using simplepa2.Examples;
using simplepa2.Setup;
using Wisej.ChatServer;
using simplepa2.SignalR;
using System.Collections.Generic;
using static simplepa2.DataSet1;
using System.Linq;
using Microsoft.Ajax.Utilities;
using DataClass;
using System.Drawing;
using System;

namespace simplepa2
{
	//시그날 알 클라이언트 처리용 
    public partial class Simple
	{
		#region // Signal R  

		internal void RcvSigR(SignalRMsg msg1)
		{
			string addinfo = "";
			LabelON(9,true);

			//Application.StartTask(() => {
				AlertBox.Show(msg1.message);
				//Application.Update(this);
			//});
			

			switch (msg1.Msgtype)
			{
				case eSignalRMsgType.eEM:
					if (msg1.state == 1)
						addinfo = "ONLINE";
					else
						addinfo = "OFFLINE";
					dBSqlite.Eventvm(addinfo, msg1.EMNAME, addinfo);
					dBSqlite.EMServerupdate(msg1.EMNAME, addinfo);
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
					//this.btnStart.Enabled = true;
					//this.btnStop.Enabled = false;
					view_BBSAnchor.refresh(msg1);
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
					if (msg1.state == 1)
						bSDeviceManager.reDraw();
					else
						AlertBox.Show("DSP 혹은 버철사운드를 확인 바랍니다..", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
					break;
			}
			playItems = msg1.play8sig;
			if (playItems != null)
				PlayItemDisplay();

			this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
			evdataGridView1.Refresh();
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
			if (id == 9 && v == false)
			{
				//AlertBox.Show("SignalR Client Disconnected.");
				AlertBox.Show("<b>SignalR Client</b> Disconnected." , icon: MessageBoxIcon.Warning, alignment: ContentAlignment.MiddleCenter);

			}
		}

		internal void sendSigR(string v)
		{
			SignalRMsg msg1 = new SignalRMsg();
			msg1.message = v;
			//if (signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
			//	signalRClient.proxy.Invoke("MessageC2S2", msg1);
		}

		internal void sendSigR(eSignalRMsgType v1, BSTreeRow bSTreeRow, List<AssetsRow> selAsset, List<MusicsRow> selMusic)
		{
			if (gweb._hub == null)
			{
				AlertBox.Show("가용한 EM Server가 없습니다.");
				return;
			}
			SignalRMsg msg1 = new SignalRMsg();
			msg1.user = Application.Session["user"];
			msg1.EMNAME = bSTreeRow.EMNAME;
			msg1.seqno = bSTreeRow.BSTreeId;
			msg1.chno = bSTreeRow.chno;
			msg1.Msgtype = v1;

			switch (v1)
			{
				case eSignalRMsgType.ePlay:
					var t1 = selMusic.Select(p => new { p.MusicId });
					msg1.musicsRows = t1.Select(p => p.MusicId).ToList();
					var t2 = selAsset.Select(p => new { p.AssetId });
					msg1.assetsRows = t2.Select(p => p.AssetId).ToList();
					msg1.message = "Play";
					break;
				case eSignalRMsgType.eStop:
					msg1.message = "Stop";
					break;
			}

			try
			{
				if (gweb._hub != null)
					gweb._hub.MessageS2C2(msg1);
			}
			catch (Exception e1)
			{
			}
		}

		internal void sendSigR(eSignalRMsgType eVolume, string device_name = "", string dsp = "", int dsp_ch = 0, int device_ch = 0)
		{
			SignalRMsg msg1 = new SignalRMsg();
			msg1.user = Application.Session["user"];
			msg1.EMNAME = "ALL";

			switch (eVolume)
			{
				case eSignalRMsgType.eVolume:
					msg1.message = "Volume";
					msg1.Msgtype = eVolume;
					break;

				case eSignalRMsgType.eOutChMove:
					msg1.message = device_name;
					msg1.Msgtype = eVolume;
					msg1.state = dsp_ch;
					msg1.user_data1 = dsp;
					msg1.user_data4 = device_ch;
					break;

				case eSignalRMsgType.eInChMove:
					msg1.message = device_name; // pc
					msg1.Msgtype = eVolume;
					msg1.state = dsp_ch; // no
					msg1.user_data1 = dsp; // ip
					msg1.user_data4 = device_ch; // dsp ch cnt
					break;

				case eSignalRMsgType.eScanAll:
					msg1.Msgtype = eVolume;
					msg1.message = "Scan All";
					break;
			}

			try
			{
				if (gweb._hub != null)
					gweb._hub.MessageS2C2(msg1);
			}
			catch (Exception e1)
			{
			}
		}

		public bool isSignalR()
		{
			if (gweb._hub == null)
				return false;
			return true;
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


		#endregion
	}
}