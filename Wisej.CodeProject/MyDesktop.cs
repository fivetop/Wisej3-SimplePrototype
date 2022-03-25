using System;
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

namespace Wisej.CodeProject
{
    public partial class MyDesktop : Desktop
	{
		private Popups.StartPopup startPopup;
		public event EventHandler ExampleCreated;

		Main MainWin { get; set; }
		BackgroundTasks example2 { get; set; }

		public static SignalRClient signalRClient { get; set; } = new SignalRClient();


		public MyDesktop()
		{
			InitializeComponent();

/*
			string connStr = @"Data Source=E:\0 신사업\demo\webPA\newrep\wisej\0 use\0 CodeProject\Wisej.CodeProject\bin\simplepaw.db;Pooling=true;FailIfMissing=false";

			try 
			{ 
				conn = new SQLiteConnection(connStr);
				conn.Open();

				// 테이블 유무 검사
				SQLiteCommand command = new SQLiteCommand(conn);
				command.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type = 'table';";
				command.CommandType = CommandType.Text;
				int RowCount = 0;
				RowCount = Convert.ToInt32(command.ExecuteScalar());

				// 데이터 조회
				String SelectSQL = "SELECT * FROM sqlite_master WHERE type='table';";
				SQLiteCommand cmd = new SQLiteCommand(SelectSQL, conn);
				//var rdr = cmd.ExecuteScalar();
				//var rdr = cmd.ExecuteReaderAsync();
				SQLiteDataReader rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					Console.WriteLine($"{rdr.GetString(0)} {rdr.GetString(1)} {rdr.GetString(2)}");
				}
				command.Dispose();

				DataContext db = new DataContext(conn);

				//var t2 = db.GetTable<UserTrees>();
			}
			catch (Exception e1)
			{
				Console.WriteLine(e1.Message);
			}

*/
			this.startPopup = new Popups.StartPopup()
			{
				Alignment = Placement.TopLeft
			};
			this.startPopup.ExampleCreated += StartPopup_ExampleCreated;

			this.customWallpaper1.RotationInterval = 5000;

			Application.Session["isloggedon"] = "true";
			Application.Session["user"] = "Admin";

		}

		internal void RcvSigR(SignalRMsg msg)
        {
			AlertBox.Show(msg.message);
			switch (msg.Msgtype)
			{
				case eSignalRMsgType.eEM:
					break;
				case eSignalRMsgType.eEM_FIRE:
					break;
				case eSignalRMsgType.eEM_PRESET_SW:
					break;
				case eSignalRMsgType.ePlay:
					break;
				case eSignalRMsgType.ePlayEnd:
					break;
				case eSignalRMsgType.ePlaying:
					break;
				case eSignalRMsgType.eStop:
					break;
			}
			MainWin.RcvSigR(msg);
		}

        private void MyDesktop_ItemClick(object sender, DesktopTaskBarItemClickEventArgs e)
		{
			panel1.TabIndex = 100; // .Show();

			try
			{
				switch (e.Item.Name)
				{
					case "desktopDateTime":
					case "desktopStart":
						MainWin.WindowState = FormWindowState.Minimized;
						example2.WindowState = FormWindowState.Minimized;

						break;
					case "desktopTaskBarItemCompras":
						break;
					default:

						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error en la aplicación." + ex.Message);
			}
		}

		private void justGage1_Click(object sender, EventArgs e)
		{
		}

		private void StartPopup_ExampleCreated(object sender, EventArgs e)
		{
		}


		private void MyDesktop_Load(object sender, EventArgs e)
		{

			// start gage background task.
			SatrtUpdatingGageItem();

			MainWin = new Main();
			example2 = new Examples.BackgroundTasks();
			MainWin.Show(); // .Active = true; // .Activate();
			example2.Show();
			MainWin.WindowState = FormWindowState.Minimized;
			example2.WindowState = FormWindowState.Minimized;

			signalRClient.owner = this;
			signalRClient.ConnectToSignalR();

			var t1 = Application.Session["user"];
			AlertBox.Show("Log-In : " + t1);

		}

		private void MyDesktop_SizeChanged(object sender, EventArgs e)
		{
			if (MainWin == null)
				return;
			MainWin.WindowState = FormWindowState.Maximized;
			example2.WindowState = FormWindowState.Maximized;
		}

		private void SatrtUpdatingGageItem()
		{
			Application.StartTask(() =>
			{

				while (!Application.IsTerminated)
				{
					this.justGage1.Value = Program.CPU;
					Application.Update(this);
					Thread.Sleep(1000);
				}
			});
		}

		// 환경설정
        private void button1_Click(object sender, EventArgs e)
        {
			var win1 = new MSet();
			win1.Show();
		}


		// 휴일 관리
		private void button2_Click(object sender, EventArgs e)
        {
			var win1 = new MHoliday();
			win1.Show();

		}

		// 그룹 관리
		private void button3_Click(object sender, EventArgs e)
        {
			var win1 = new MGroup();
			win1.Show();

		}

		// 음원관리 
		private void button4_Click(object sender, EventArgs e)
        {
			var win1 = new MMusic();
			win1.Show();
		}

		// 알람 이벤트 
		private void button5_Click(object sender, EventArgs e)
        {
			var win1 = new MEvent();
			win1.Show();

		}

		// 방송 이력 
		private void button6_Click(object sender, EventArgs e)
        {
			sendSigR("Hello Server..");
			//AlertBox.Show(msg1.em_status);
		}

		// 비상방송 이력 
		private void button7_Click(object sender, EventArgs e)
        {

        }

		// 스피커 볼륨 조정 
        private void button8_Click(object sender, EventArgs e)
        {
			var win1 = new Window1();
			win1.Show();

		}

		// 장비 내역 
		private void button9_Click(object sender, EventArgs e)
        {
			var win1 = new SimpleChatClient();
			win1.Show();

		}
		// 사용자 관리 
		private void button10_Click(object sender, EventArgs e)
        {
			var win1 = new MUser();
			win1.Show();

		}

        private void MyDesktop_Resize(object sender, EventArgs e)
        {
			//MyDesktop.AutoHideTaskbar = true

		}

        private void MyDesktop_Activated(object sender, EventArgs e)
        {
			if (MainWin == null)
				return;
			this.MyDesktop_SizeChanged(null,null);

			MainWin.Invalidate(); // .re .re .WindowState = FormWindowState.Minimized;
			//example1.WindowState = FormWindowState.Minimized;
			example2.WindowState = FormWindowState.Minimized;
			this.ResizeRedraw = true;
			this.Invalidate();
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
    }
}
