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
using System.ComponentModel;
using Wisej.Base;

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


		// 초기화 처리 
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


			Cookie d1 = Application.Cookies.Get("d1");
			Cookie d2 = Application.Cookies.Get("d2");
			Cookie d3 = Application.Cookies.Get("d3");
			if (d1 != null)
			{ 
				splitContainer4.SplitterDistance = int.Parse(d1.Value);
				splitContainer5.SplitterDistance = int.Parse(d2.Value);
				splitContainer6.SplitterDistance = int.Parse(d3.Value);
			}
		}

		BindingList<bsroom> dataSource = new BindingList<bsroom>();

		private void Main_Load(object sender, EventArgs e)
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			this.dataGridView2.RowCount = 10;

			this.simplepaTableAdapter.Fill(this.dataSet1.Simplepa);
			this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
			this.userTreesTableAdapter.Fill(this.dataSet1.UserTrees);
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);
			this.deviceTableAdapter.Fill(this.dataSet1.Device);
			this.bSroomTableAdapter.Fill(this.dataSet1.BSroom);

			// 자산 1
			var t1 = this.dataSet1.Assets.OrderBy(p => p.seq).ToList();
			listviewCTL1.Dock = DockStyle.Fill;
			listviewCTL1.ListviewCTL_Load2(t1);
			listviewCTL1.UserControlClick += userControlClick;

			// 자산 2
			var t2 = this.dataSet1.Assets.OrderBy(p => p.seq).ToList();
			listviewCTL2.Dock = DockStyle.Fill;
			listviewCTL2.ListviewCTL_Load(t2);
			listviewCTL2.UserControlClick += userControlClick2;

			// 휴일
			hLoadData();

			// 그룹 
			gLoadData();


			// 입장하기 처리
			foreach (var t3 in this.dataSet1.BSroom)
			{
				var t4 = new bsroom();
				t4.bsroomrow = t3;
				t4.bsroomid = "방송 스테이션 " + t3.BSroomid.ToString();
				t4.state_int = t3.state;
				t4.username = t3.user_name;
				dataSource.Add(t4);
			}
			dataRepeater1.DataSource = dataSource;

			// 장비 아이콘 보이기 
			DevicelistView1.BeginUpdate();
			foreach (var t3 in this.dataSet1.Device)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = t3.device.ToString();
				switch (t3.device)
				{
					case 0:
						lvi.ImageIndex = 0;
						break;
					case 2:
						lvi.ImageIndex = 1;
						lvi.BackColor = Color.LightBlue;
						break;
					case 3:
						lvi.ImageIndex = 2;
						break;
					case 4:
						lvi.ImageIndex = 3;
						lvi.BackColor = Color.Red;
						break;
					case 9:
						lvi.ImageIndex = 4;
						lvi.BackColor = Color.LightCyan;
						break;
					default:
						lvi.ImageIndex = 0;
						break;
				}
				DevicelistView1.Items.Add(lvi);
			}
			DevicelistView1.EndUpdate();

		}


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
			var win = new Window1();
			win.Show();
			/*
			var win1 = new SimpleChatClient();
			win1.Show();

			SignalRMsg msg1 = new SignalRMsg();
			msg1.play8sig[2].p_run = true;
			msg1.play8sig[5].p_run = true;
			playItems = msg1.play8sig;
			PlayItemDisplay();
			*/
		}

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

		// 입장하기 
        private void btnBS1_Click(object sender, EventArgs e)
        {
			var nCurr = dataRepeater1.CurrentItemIndex;
			string n = Application.Session["user_name"];
			tabControl1.SelectedIndex = 1;
			dataSource[nCurr].state_int = 1;
			dataSource[nCurr].username = n;
			dataRepeater1.Refresh();
			this.bSroomTableAdapter.Update(this.dataSet1.BSroom);

		}

		// 방송 종료 
		private void btnBS2_Click(object sender, EventArgs e)
        {
			var nCurr = dataRepeater1.CurrentItemIndex;
			dataSource[nCurr].state_int = 0;
			dataSource[nCurr].username = "";
			dataRepeater1.Refresh();
			this.bSroomTableAdapter.Update(this.dataSet1.BSroom);
		}

		// 스플리트 화면 조정 내용 저장 
        private void splitContainer5_SplitterMoved(object sender, SplitterEventArgs e)
        {
			Application.Cookies.Add("d1", splitContainer4.SplitterDistance.ToString(), DateTime.Now.AddDays(7));
			Application.Cookies.Add("d2", splitContainer5.SplitterDistance.ToString(), DateTime.Now.AddDays(7));
			Application.Cookies.Add("d3", splitContainer6.SplitterDistance.ToString(), DateTime.Now.AddDays(7));
		}

		#endregion

		/*
            private void Application_ApplicationExit(object sender, EventArgs e)
            {
                // delete the session-cloned db file.
                this.userTreesTableAdapter.Connection.Close();
                this.userTreesTableAdapter.Connection.Dispose();
                this.userTreesTableAdapter.Adapter.Dispose();
            }
        */


	}
}
