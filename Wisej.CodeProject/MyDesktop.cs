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

namespace Wisej.CodeProject
{
    public partial class MyDesktop : Desktop
	{
		private Popups.StartPopup startPopup;
		public event EventHandler ExampleCreated;

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
			//this.customWallpaper1.RotationInterval = 5000;

			string t1 = Application.Session["user"];
			if (t1 == null)
			{
				Application.Session["isloggedon"] = "true";
				Application.Session["user"] = "Admin";
				Application.Session["user_name"] = "관리자";
			}

			this.simplepaTableAdapter.Fill(this.dataSet1.Simplepa);
		}


		bool show = false;
        private void MyDesktop_ItemClick(object sender, DesktopTaskBarItemClickEventArgs e)
		{
			try
			{
				switch (e.Item.Name)
				{
					case "desktopDateTime":
						break;
					case "desktopStart":
						if (show)
						{
						}
						else
						{ 
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

			Main_Load(sender, e);
			Main_Load642(sender, e);
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			this.dataGridView2.RowCount = 10;

			this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
			this.userTreesTableAdapter.Fill(this.dataSet1.UserTrees);
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);
			var t1 = this.dataSet1.Assets.OrderBy(p => p.seq).ToList();
			//listviewCTL1.Dock = DockStyle.Fill;
			//listviewCTL1.ListviewCTL_Load2(t1);
			//listviewCTL1.UserControlClick += userControlClick;
			//listviewCTL2.Dock = DockStyle.Fill;
			//listviewCTL2.ListviewCTL_Load(t1);
			//listviewCTL2.UserControlClick += userControlClick2;

			hLoadData();
			gLoadData();

		}

		/*
			private void Application_ApplicationExit(object sender, EventArgs e)
			{
				// delete the session-cloned db file.
				this.userTreesTableAdapter.Connection.Close();
				this.userTreesTableAdapter.Connection.Dispose();
				this.userTreesTableAdapter.Adapter.Dispose();
			}
		*/


		#region // button 

		// 백그라운드 처리용 
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

		// 시험용  
		private void button7_Click(object sender, EventArgs e)
        {
			var win1 = new SimpleChatClient();
			win1.Show();

			/*
			SignalRMsg msg1 = new SignalRMsg();
			msg1.play8sig[2].p_run = true;
			msg1.play8sig[5].p_run = true;
			playItems = msg1.play8sig;
			PlayItemDisplay();
			*/
		}
        #endregion

		// log out 처리 
        private void button11_Click(object sender, EventArgs e)
        {
			Application.Session["isloggedon"] = "false";
			Application.Session["user"] = "";
			Application.Session["user_name"] = "";

			LoginPage loginPage = new LoginPage();
			loginPage.Show();
			this.Dispose(true);
        }
    }
}
