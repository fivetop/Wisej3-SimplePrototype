using System;
using Wisej.Web;
using System.Threading;
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
using simplepa2.UI.Views;

namespace simplepa2
{
    public partial class Simple : Page
	{
		private System.Threading.Timer timer;

		//private Popups.StartPopup startPopup;
		//public event EventHandler ExampleCreated;
		//public static SignalRClient signalRClient { get; set; } = new SignalRClient();
		//public List<PlayItem> playItems { get; set; } = new List<PlayItem>(new PlayItem[9]);
		public DBController dBSqlite { get; set; } = new DBController();

		public Simple()
		{
			InitializeComponent();

			string t1 = Application.Session["user"];
			if (t1 == null)
			{
				Application.Session["isloggedon"] = "true";
				Application.Session["user"] = "Admin";
				Application.Session["user_name"] = "관리자";
			}
		}

		// 초기화 처리 
		private void MyDesktop_Load(object sender, EventArgs e)
		{

			dBSqlite.DBInit();
			SatrtUpdatingItem();

			var t1 = Application.Session["user"];
			var t2 = Application.Session["user_name"];

			AlertBox.Show("Log-In : " + t2 + t1);

			//Application.LoadTheme("LSMaterial-3"); //"Material-3" 
			//Application.Theme.Colors["navbar-background"] = "blue";
			AddBSPage(); // 방송 설정 처리 

			//tableLayoutPanel_Top1.Size = new Size(440,58);

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

		#region // main initial 


		//BindingList<Bsroom> dataSource = new BindingList<Bsroom>();

		private void Main_Load(object sender, EventArgs e)
		{
			LabelON(9,false);
		}

		View_BBSGroupManage2 aGroup = new View_BBSGroupManage2();
		ASchedule aSchedule = new ASchedule();

		View_DashBoard2 view_DashBoard = new View_DashBoard2();
		View_BBSAnchor2 view_BBSAnchor = new View_BBSAnchor2();
		View_BBCAsset2 bSAsset = new View_BBCAsset2();
		View_BBCDevice2 bSDeviceManager = new View_BBCDevice2();

		View_BBCInput2 bSInManager = new View_BBCInput2();
		View_BBCOutput2 bSOutManage = new View_BBCOutput2();
		View_BBCMusic2 bSLevelManager = new View_BBCMusic2();
		View_BBCEmergency2 bSEMManager = new View_BBCEmergency2();

		MSetupManager mSetupManager = new MSetupManager();
		View_GroupManager2 mGroupManager = new View_GroupManager2();
		View_BBSHolidayManage2 mHolidayManager = new View_BBSHolidayManage2();
		View_BBSMusicManage2 mMusicManager = new View_BBSMusicManage2();
		View_SystemAccount2 mUserManager = new View_SystemAccount2();

		private void AddBSPage()
        {
			TabPage tabClients = new TabPage(menu_string[0]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(view_DashBoard);
			view_DashBoard.Dock = DockStyle.Fill;
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[1]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(view_BBSAnchor);
			view_BBSAnchor.Dock = DockStyle.Fill;
			//BStabControl.TabPages.Add(tabClients);
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[2]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(aGroup);
			aGroup.Dock = DockStyle.Fill;
			//BStabControl.TabPages.Add(tabClients);
			MaintabControl.TabPages.Add(tabClients);
			
			tabClients = new TabPage(menu_string[4]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(aSchedule);
			aSchedule.Dock = DockStyle.Fill;
			//BStabControl.TabPages.Add(tabClients);
			MaintabControl.TabPages.Add(tabClients);

			tabClients = new TabPage(menu_string[5]);
			tabClients.Name = "tabClients";
			tabClients.Controls.Add(bSAsset);
			bSAsset.Dock = DockStyle.Fill;
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


			MaintabControl.SelectedIndexChanged += BStabControl_SelectedIndexChanged;
		}

		string[] menu_string = {"댓쉬보드", "앵커방송", "그룹방송", "프리셋", "예약방송",
			"선번장관리" , "장비관리", "입력관리", "출력관리", "음량관리" , "비상방송",
			"시스템설정", "그룹관리","휴일관리", "음원관리", "사용자관리"
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
				case "방송운영": break;
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

			}
		}

		private void BStabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
			bSInManager.reDraw(); 
			bSOutManage.reDraw(); 
			bSLevelManager.reDraw();
			bSEMManager.reDraw();
		}


		#endregion

		#region // button 

		// 백그라운드 처리용 
		private void SatrtUpdatingItem()
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

		bool show = false;
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



		#region // Signal R  
		// 프리셋 메시지 올 경우 화면 출력용 
		// 8채널과 링크 출력용 
		public void LabelON(int id, bool v)
		{
			if (id == 9 && v == false)
			{
				//AlertBox.Show("SignalR Client Disconnected.");
				AlertBox.Show("<b>SignalR Client</b> Disconnected.", icon: MessageBoxIcon.Warning, alignment: ContentAlignment.MiddleCenter);

			}
		}


		internal void RcvSigR(SignalRMsg msg1)
		{
			string addinfo = "";

			LabelON(9, true);

			Wisej.Web.Application.Update(this, () =>
			{
				AlertBox.Show(msg1.message + ":" + addinfo);
				gweb.Log(msg1.message + ":" + addinfo);
				System.Diagnostics.Debug.WriteLine(msg1.message);
			});


			switch (msg1.Msgtype)
			{
				case eSignalRMsgType.eEM:
					if (msg1.state == 1)
						addinfo = "ONLINE";
					else
						addinfo = "OFFLINE";
					dBSqlite.Eventsyslog(addinfo, msg1.EMNAME, addinfo);
					dBSqlite.EMServerupdate(msg1.EMNAME, addinfo);
					break;
				case eSignalRMsgType.eEM_FIRE:
					if (msg1.seqno == 1)
						LabelON(1, true);
					else
						LabelON(1, false);
					break;
				case eSignalRMsgType.eEM_PRESET_SW:
					//presetdisp(msg1);
					break;
				case eSignalRMsgType.ePlay:
					break;
				case eSignalRMsgType.ePlayEnd:
					view_BBSAnchor.refresh();
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
					{
						dBSqlite.LinkAssetDevice();
						bSDeviceManager.reDraw();
					}
					else
						AlertBox.Show("DSP 혹은 버철사운드를 확인 바랍니다..", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
					break;
			}
			//view_Dashboard.Refresh();
			//this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);

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


		#endregion
	}
}
