using simplepa2.UI.Widget;
using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Base;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_DashBoard2 : Wisej.Web.UserControl
    {
		
		private Widget_BBSMultiDeck widget_bbsMultiDeck;

		private Timer timer = new Timer();


		public View_DashBoard2()
        {
            InitializeComponent();


		}

		public void startTimer()
		{
			timer.Interval = 5000;
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			//reDraw();
		}

		internal void reDraw()
		{
			//if (this.ActiveControl == null) return;
			try 
			{ 
				if (Eventbs.DataSource == null) return;
				Eventbs.Filter = "alarm=0";
				Eventbs.Sort = "write_time DESC";
				reDraw2();
				Main_Load();
				// split 위치 설정 세로, 가로,  세로
				split_위치();
				// BBS Widget UI 셋업
				initMultiBBSWidgetUISetup();
				evdataGridView1.Refresh();
			}
			catch (Exception e1)
			{
			}

		}

		internal void reDraw2()
		{
			try
			{
				this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
				this.eventdeviceTableAdapter.Fill(this.dataSet1.Eventdevice);
				this.assetsTableAdapter.Fill(this.dataSet1.Assets);
				this.bsTreeTableAdapter1.Fill(this.dataSet1.BSTree);
			}
			catch (Exception e1)
			{ 
			}
		}

		private void View_DashBoard_Load(object sender, EventArgs e)
        {
			reDraw();
			
		}


		private void Main_Load()
		{
			DevicelistView1.Items.Clear();
			// 장비 아이콘 보이기 
			DevicelistView1.View = View.LargeIcon;

			foreach (var t3 in  gweb.dBSqlite.Ds1.Device)
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
		}



		private void initMultiBBSWidgetUISetup()
        {
			if(widget_bbsMultiDeck == null)
            {
				widget_bbsMultiDeck = new Widget_BBSMultiDeck();
				this.split_TopFrame.Panel1.Controls.Add(widget_bbsMultiDeck);
			}			
        }

		#region //Split 모양 및 이벤트 처리
		// split 위치 설정 세로, 가로,  세로
		private void split_위치()
		{
			// Main 화면 
			Cookie d1 = Application.Cookies.Get("d1");
			Cookie d2 = Application.Cookies.Get("d2");
			Cookie d3 = Application.Cookies.Get("d3");
			if (d1 != null)
			{
				split_TopFrame.SplitterDistance = 790;
				split_MainFrame.SplitterDistance = int.Parse(d1.Value);
				split_BottomFrame.SplitterDistance = int.Parse(d3.Value);
			}
		}

		private void splitContainer5_SplitterMoved(object sender, SplitterEventArgs e)
		{
			Application.Cookies.Add("d2", "790", DateTime.Now.AddDays(7));
			Application.Cookies.Add("d1", split_MainFrame.SplitterDistance.ToString(), DateTime.Now.AddDays(7));
			Application.Cookies.Add("d3", split_BottomFrame.SplitterDistance.ToString(), DateTime.Now.AddDays(7));
		}
		#endregion


		/*
				private void Main_Load()
				{
					DevicelistView1.Items.Clear();
					// 장비 아이콘 보이기 
					DevicelistView1.View = View.LargeIcon;
					//DevicelistView1.View = View.Tile;
					//DevicelistView1.View = View.SmallIcon;
					//DevicelistView1.ar .AutoResizeColumn(1 ,ColumnHeaderAutoResizeStyle.ColumnContent);

					//DevicelistView1.View = View.Details;
					//DevicelistView1.BeginUpdate();
					foreach (var t3 in  gweb.mainFrame.dBSqlite.Ds1.Device)
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
					//DevicelistView1.EndUpdate();
				}



		 */

	}
}
