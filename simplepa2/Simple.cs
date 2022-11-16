using System;
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
using System.ComponentModel;
using Wisej.Base;
using simplepa2.win;
using simplepa2.DataSet1TableAdapters;
using simplepa2.win2;

namespace simplepa2
{
    public partial class Simple : Page
	{
		private System.Threading.Timer timer;

		//private Popups.StartPopup startPopup;
		//public event EventHandler ExampleCreated;

		public static SignalRClient signalRClient { get; set; } = new SignalRClient();
		public List<PlayItem> playItems { get; set; } = new List<PlayItem>(new PlayItem[9]);

		public DBController dBSqlite { get; set; } = new DBController();

		public Simple()
		{
			InitializeComponent();

			for (int i = 1; i < 9; i++)
			{
				playItems[i] = new PlayItem();
				playItems[i].chno = i;
			}

			//this.startPopup = new Popups.StartPopup()
			//{
			//	Alignment = Placement.TopLeft
			//};
			//this.customWallpaper1.RotationInterval = 5000;

			string t1 = Application.Session["user"];
			if (t1 == null)
			{
				Application.Session["isloggedon"] = "true";
				Application.Session["user"] = "Admin";
				Application.Session["user_name"] = "관리자";
			}

			//MaintabControl.AppearanceKey = MaintabControl.TabPages.FlatButtons;
			MaintabControl.ItemSize = new Size(0, 1);
			MaintabControl.SizeMode = TabSizeMode.Fixed;

		}

		// 초기화 처리 
		private void MyDesktop_Load(object sender, EventArgs e)
		{

			dBSqlite.DBInit();
			//this.dataSet1 = dBSqlite.Ds1;
			// start gage background task.
			SatrtUpdatingGageItem();
			signalRClient.owner = this;
			signalRClient.ConnectToSignalR();

			var t1 = Application.Session["user"];
			var t2 = Application.Session["user_name"];

			AlertBox.Show("Log-In : " + t2 + t1);

            //Application.LoadTheme("Blue-1");
			//Application.LoadTheme("Blue-2");
			//Application.LoadTheme("Blue-3");
			//Application.LoadTheme("Classic-2");
			//Application.LoadTheme("Clear-1");
			//Application.LoadTheme("Clear-2");
			//Application.LoadTheme("Clear-3");
			//Application.LoadTheme("Graphite-3");
			Application.LoadTheme("LSMaterial-3"); //"Material-3" 
			//Application.LoadTheme("Vista-2");

			//Application.Theme.Colors["navbar-background"] = "blue";

			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			this.dataGridView2.RowCount = 10;

			this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);
			this.bSroomTableAdapter.Fill(this.dataSet1.BSroom);


			Main_Load(sender, e);
			// split 위치 설정 세로, 가로,  세로
			split_위치();

			// tab padding => 5 탭에 있는 컨트롤 잘 보이게 하기 위함 
			AddBSPage(); // 방송 설정 처리 
			AddSetupPage(); // 환경설정 처리 

			tableLayoutPanel_Top1.Size = new Size(440,58);

			this.timer = Application.StartTimer(1, 1000, () => {
				var now = DateTime.Now;
				this.label_date.Text = now.ToString("yyyy:MM:dd");
				this.label_time.Text = now.ToString("hh:mm:ss");
				Application.Update(this);
			});
		}

		private void Simple_Disposed(object sender, EventArgs e)
		{
			this.timer.Dispose();
		}

		// split 위치 설정 세로, 가로,  세로
		private void split_위치()
        {
			// Main 화면 
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

		#region // main initial 


		BindingList<bsroom> dataSource = new BindingList<bsroom>();

		private void Main_Load(object sender, EventArgs e)
		{
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
			DevicelistView1.View = View.LargeIcon; 
			//DevicelistView1.View = View.Tile;
			//DevicelistView1.View = View.SmallIcon;
			//DevicelistView1.ar .AutoResizeColumn(1 ,ColumnHeaderAutoResizeStyle.ColumnContent);

			//DevicelistView1.View = View.Details;
			DevicelistView1.BeginUpdate();
			foreach (var t3 in dBSqlite.Ds1.Device)
			{
				if (!(t3.device == 0 || t3.device == 2))
					continue;
				ListViewItem lvi = new ListViewItem();
				lvi.Text = t3.DeviceName; // t3.device.ToString();
				lvi.ToolTipText = t3.DeviceName;

				switch (t3.device)
				{
					case 0:
						lvi.ImageIndex = 0;
						break;
					case 2:
						lvi.ImageIndex = 1;
						//lvi.BackColor = Color.LightBlue;
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

			LabelON(9,false);
		}

		AGroup aGroup = new AGroup();
		ASchedule aSchedule = new ASchedule();
		APreset aPreset = new APreset();

		BSDeviceManager bSDeviceManager = new BSDeviceManager();
		BSInManager bSInManager = new BSInManager();
		BSOutManager bSOutManage = new BSOutManager();
		BSLevelManager bSLevelManager = new BSLevelManager();
		BSEMManager bSEMManager = new BSEMManager();

		MSetupManager mSetupManager = new MSetupManager();
		MGroupManager mGroupManager = new MGroupManager();
		MHolidayManager mHolidayManager = new MHolidayManager();
		MMusicManager mMusicManager = new MMusicManager();
		MUserManager mUserManager = new MUserManager();

		a01 A01 = new a01();
		a02 A02 = new a02();
		a03 A03 = new a03();
		a04 A04 = new a04();
		a05 A05 = new a05();
		a06 A06 = new a06();
		a07 A07 = new a07();
		a08 A08 = new a08();

		b01 B01 = new b01();
		b02 B02 = new b02();
		b03 B03 = new b03();
		b04 B04 = new b04();
		b05 B05 = new b05();

		c01 C01 = new c01();
		c02 C02 = new c02();
		c03 C03 = new c03();
		c04 C04 = new c04();


		private void AddBSPage()
        {

			TabPage tabClients = new TabPage(menu_string[2]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(aGroup);
			aGroup.Dock = DockStyle.Fill;
			//BStabControl.TabPages.Add(tabClients);
			MaintabControl.TabPages.Add(tabClients);
			
			tabClients = new TabPage(menu_string[3]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(aPreset);
			aPreset.Dock = DockStyle.Fill;
			//BStabControl.TabPages.Add(tabClients);
			MaintabControl.TabPages.Add(tabClients);
			
			tabClients = new TabPage(menu_string[4]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(aSchedule);
			aSchedule.Dock = DockStyle.Fill;
			//BStabControl.TabPages.Add(tabClients);
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[6]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(bSDeviceManager);
			bSDeviceManager.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[7]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(bSInManager);
			bSInManager.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[8]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(bSOutManage);
			bSOutManage.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[9]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(bSLevelManager);
			bSLevelManager.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[10]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(bSEMManager);
			bSEMManager.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);


			tabClients = new TabPage(menu_string[11]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(mSetupManager);
			mSetupManager.Dock = DockStyle.Fill;
			//SetuptabControl.TabPages.Add(tabClients);
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[12]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(mGroupManager);
			mGroupManager.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[13]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(mHolidayManager);
			mHolidayManager.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[14]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(mMusicManager);
			mMusicManager.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[15]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(mUserManager);
			mUserManager.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);


			tabClients = new TabPage(menu_string[16]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(A01); A01.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[17]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(A02); A02.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[18]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(A03); A03.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[19]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(A04); A04.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[20]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(A05); A05.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[21]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(A06); A06.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[22]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(A07); A07.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[23]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(A08); A08.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);


			tabClients = new TabPage(menu_string[24]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(B01); B01.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[25]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(B02); B02.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[26]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(B03); B03.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[27]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(B04); B04.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[28]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(B05); B05.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);


			tabClients = new TabPage(menu_string[29]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(C01); C01.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[30]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(C02); C02.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[31]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(C03); C03.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);
			tabClients = new TabPage(menu_string[32]); tabClients.Name = "tabClients";
			tabClients.Controls.Add(C04); C04.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			MaintabControl.SelectedIndexChanged += BStabControl_SelectedIndexChanged;
		}

        private void BStabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
			bSDeviceManager.reDraw();
			bSInManager.reDraw(); 
			bSOutManage.reDraw(); 
			bSLevelManager.reDraw();
			bSEMManager.reDraw();
			//bSAsset.reDraw();
		}


        private void AddSetupPage()
        {
		}

		#endregion

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
			Page2 _Page = new Page2();
			_Page.Show();

			//radioButton2.Checked = true;

			/*
			var win = new Window1();
			win.Show();
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
			MaintabControl.SelectedIndex = 1;
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

        private void ubutton2_Click(object sender, EventArgs e)
        {

        }

        private void hdataGridView1_Enter(object sender, EventArgs e)
        {

        }

		#endregion

		#region // tab initial  
		

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
				MessageBox.Show("Error : " + ex.Message);
			}
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

		#endregion


		string[] menu_string = {"댓쉬보드", "앵커방송", "그룹방송", "프리셋", "예약방송", 
			"선번장관리" , "장비관리", "입력관리", "출력관리", "음량관리" , "비상방송",
			"시스템설정", "그룹관리","휴일관리", "음원관리", "사용자관리",
		"A01","A02","A03","A04","A05","A06","A07","A08",
		"B01","B02","B03","B04","B05",
		"C01","C02","C03","C04"
		};


		private void navigationBar1_SelectedItemChanged(object sender, EventArgs e)
        {

			string t1 = this.navigationBar1.SelectedItem.Text;
			
			AlertBox.Show($"Selected {t1}");
			Console.WriteLine(t1);
			//if (this.navigationBar1.SelectedItem.AccessibleName == null)
			//	return;
			//int acc = int.Parse(this.navigationBar1.SelectedItem.AccessibleName);



			switch (t1)
			{
				case "대쉬보드": MaintabControl.SelectedIndex = 0; break;
				case "방송운영":  break;
				case "앵커방송": MaintabControl.SelectedIndex = 1; break;
				case "그룹방송": MaintabControl.SelectedIndex = 2; break;
				case "프리셋": MaintabControl.SelectedIndex = 3; break;
				case "예약방송": MaintabControl.SelectedIndex = 4; break;
				case "방송설정": break;
				case "선번장관리": MaintabControl.SelectedIndex = 5; break;
				case "장비관리": MaintabControl.SelectedIndex = 6; break;
				case "입력관리": MaintabControl.SelectedIndex = 7; break;
				case "출력관리": MaintabControl.SelectedIndex = 8; break;
				case "음량관리": MaintabControl.SelectedIndex = 9; break;
				case "비상방송": MaintabControl.SelectedIndex = 10; break;
				case "환경설정": break;
				case "시스템설정": MaintabControl.SelectedIndex = 11; break;
				case "그룹관리": MaintabControl.SelectedIndex = 12; break;
				case "휴일관리": MaintabControl.SelectedIndex = 13; break;
				case "음원관리": MaintabControl.SelectedIndex = 14; break;
				case "사용자관리": MaintabControl.SelectedIndex = 15; break;
				//case "사이트관리": MaintabControl.SelectedIndex = 8; break;
				//case "Zone관리": MaintabControl.SelectedIndex = 9; break;
				//case "댓쉬보드": MaintabControl.SelectedIndex = 18; break;
				//case "댓쉬보드": MaintabControl.SelectedIndex = 19; break;
				//case "댓쉬보드": MaintabControl.SelectedIndex = 20; break;
				case "A01": MaintabControl.SelectedIndex = 16; break;
				case "A02": MaintabControl.SelectedIndex = 17; break;
				case "A03": MaintabControl.SelectedIndex = 18; break;
				case "A04": MaintabControl.SelectedIndex = 19; break;
				case "A05": MaintabControl.SelectedIndex = 20; break;
				case "A06": MaintabControl.SelectedIndex = 21; break;
				case "A07": MaintabControl.SelectedIndex = 22; break;
				case "A08": MaintabControl.SelectedIndex = 23; break;

				case "B01": MaintabControl.SelectedIndex = 24; break;
				case "B02": MaintabControl.SelectedIndex = 25; break;
				case "B03": MaintabControl.SelectedIndex = 26; break;
				case "B04": MaintabControl.SelectedIndex = 27; break;
				case "B05": MaintabControl.SelectedIndex = 28; break;

				case "C01": MaintabControl.SelectedIndex = 29; break;
				case "C02": MaintabControl.SelectedIndex = 30; break;
				case "C03": MaintabControl.SelectedIndex = 31; break;
				case "C04": MaintabControl.SelectedIndex = 32; break;

			}
		}

    }
}
