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
using System.Drawing;
using Wisej.CodeProject.win;

namespace Wisej.CodeProject
{
    public partial class MyDesktop : Desktop
	{
		private Popups.StartPopup startPopup;
		public event EventHandler ExampleCreated;

		Main Main { get; set; } = new Main();
		Main1 Main1 { get; set; } = new Main1();
		Main2 Main2 { get; set; } = new Main2();
		Main3 Main3 { get; set; } = new Main3();
		Main4 Main4 { get; set; } = new Main4();
		public static SignalRClient signalRClient { get; set; } = new SignalRClient();
		public List<PlayItem> playItems { get; set; } = new List<PlayItem>(new PlayItem[9]);

		public MyDesktop()
		{
			InitializeComponent();
			
			for (int i = 1; i < 9; i++)
			{
				playItems[i] = new PlayItem();
				playItems[i].chno = i;
			}

			this.startPopup = new Popups.StartPopup()
			{
				Alignment = Placement.TopLeft
			};
			this.customWallpaper1.RotationInterval = 5000;

			string t1 = Application.Session["user"];
			if (t1 == null)
			{
				Application.Session["isloggedon"] = "true";
				Application.Session["user"] = "Admin";
				Application.Session["user_name"] = "관리자";
			}

			Main22();
		}

		#region // Main

		bool show = false;
        private void MyDesktop_ItemClick(object sender, DesktopTaskBarItemClickEventArgs e)
		{
			panel1.TabIndex = 100; // .Show();

			try
			{
				switch (e.Item.Name)
				{
					case "desktopDateTime":
						break;
					case "desktopStart":
						if (show)
						{
							Main.WindowState = FormWindowState.Maximized;
						}
						else
						{ 
							Main.WindowState = FormWindowState.Minimized;
							Main1.WindowState = FormWindowState.Minimized;
							Main2.WindowState = FormWindowState.Minimized;
							Main3.WindowState = FormWindowState.Minimized;
							Main4.WindowState = FormWindowState.Minimized;
						}
						show = !show;
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

		private void MyDesktop_Load(object sender, EventArgs e)
		{

			// start gage background task.
			SatrtUpdatingGageItem();

			Main.Show(); // .Active = true; // .Activate();
			Main1.Show();
			Main2.Show();
			Main3.Show();
			Main4.Show();

			Main.WindowState = FormWindowState.Maximized;
			Main1.WindowState = FormWindowState.Maximized;
			Main2.WindowState = FormWindowState.Maximized;
			Main3.WindowState = FormWindowState.Maximized;
			Main4.WindowState = FormWindowState.Maximized;

			Main.Show(); // .Active = true; // .Activate();
			Call("dockWindows");

			signalRClient.owner = this;
			signalRClient.ConnectToSignalR();

			var t1 = Application.Session["user"];
			var t2 = Application.Session["user_name"];

			AlertBox.Show("Log-In : " + t2 + t1);

            Application.LoadTheme("Blue-1");
			//Application.LoadTheme("Blue-2");
			//Application.LoadTheme("Blue-3");
			//Application.LoadTheme("Classic-2");
			//Application.LoadTheme("Clear-1");
			//Application.LoadTheme("Clear-2");
			//Application.LoadTheme("Clear-3");
			//Application.LoadTheme("Graphite-3");
			//Application.LoadTheme("Material-3");
			//Application.LoadTheme("Vista-2");

			Main_Load22(sender, e);
			Main_Load42(sender, e);
			Main_Load62(sender, e);
		}


		private void MyDesktop_SizeChanged(object sender, EventArgs e)
		{
			if (Main == null)
				return;
			//Main.WindowState = FormWindowState.Maximized;
			//Main1.WindowState = FormWindowState.Maximized;
		}

		private void MyDesktop_Resize(object sender, EventArgs e)
		{
			//MyDesktop.AutoHideTaskbar = true

		}

		private void MyDesktop_Activated(object sender, EventArgs e)
		{
			if (Main == null)
				return;
			this.MyDesktop_SizeChanged(null, null);

			//Main.Invalidate(); // .re .re .WindowState = FormWindowState.Minimized;
								  //example1.WindowState = FormWindowState.Minimized;
			//Main1.WindowState = FormWindowState.Minimized;
			//this.ResizeRedraw = true;
			this.Invalidate();
		}

		#endregion

		#region // button 
		private void SatrtUpdatingGageItem()
		{
			Application.StartTask(() =>
			{

				while (!Application.IsTerminated)
				{
					//this.justGage1.Value = Program.CPU;
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
			Page2 p1 = new Page2();
			p1.Show();

			Page2 p2 = new Page2();
			p2.Show();
			//Application.Call("dockTwins");

			//Call("dock2");
			//Call("dockWindows");

			/*
			bslamp1.LabelOn(9, true);
			sendSigR("Hello Server..");
			AlertBox.Show("aaa");
			bslamp1.LabelOn(1, true);
			bslamp1.LabelOn(3, true);
			bslamp1.LabelOn(5, true);
			bslamp1.LabelOn(7, true);
			*/
		}

		// 비상방송 이력 
		private void button7_Click(object sender, EventArgs e)
        {
			SignalRMsg msg1 = new SignalRMsg();
			msg1.play8sig[2].p_run = true;
			msg1.play8sig[5].p_run = true;
			playItems = msg1.play8sig;
			PlayItemDisplay();
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

        #endregion



        private void MyDesktop_WidgetEvent(object sender, WidgetEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
			Main.Close();
			Main1.Close();
			Main2.Close();
			Main3.Close();
			Main4.Close();

			Application.Session["isloggedon"] = "false";
			Application.Session["user"] = "";
			Application.Session["user_name"] = "";

			LoginPage loginPage = new LoginPage();
			loginPage.Show();
			this.Dispose(true);
        }

        private void tabPage1_PanelCollapsed(object sender, EventArgs e)
        {

        }


    }
}
