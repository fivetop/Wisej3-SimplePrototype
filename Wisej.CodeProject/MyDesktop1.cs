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
using Wisej.CodeProject.win;
using System;

namespace Wisej.CodeProject
{
	//시그날 알 클라이언트 처리용 
    public partial class MyDesktop : Desktop
    {
		#region // Signal R  

		internal void RcvSigR(SignalRMsg msg1)
		{
			bslamp1.LabelOn(9, true);
			AlertBox.Show(msg1.message);

			switch (msg1.Msgtype)
			{
				case eSignalRMsgType.eEM:
					break;
				case eSignalRMsgType.eEM_FIRE:
					if (msg1.seqno == 1)
						bslamp1.LabelOn(1, true);
					else
						bslamp1.LabelOn(1, false);
					break;
				case eSignalRMsgType.eEM_PRESET_SW:
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
			}
			Main.RcvSigR(msg1);
			playItems = msg1.play8sig;
			if (playItems != null)
				PlayItemDisplay();
		}

		internal void LabelON(bool v)
		{
			bslamp1.LabelOn(9, v);
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