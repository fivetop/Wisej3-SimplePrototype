﻿using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Base;
using Wisej.Web;

namespace simplepa2.win
{
    public partial class View_DashBoard : Wisej.Web.UserControl
    {
		
		BindingList<bsroom> dataSource = new BindingList<bsroom>();

		public View_DashBoard()
        {
            InitializeComponent();
        }

		internal void reDraw()
		{
            Main_Load();
            // split 위치 설정 세로, 가로,  세로
            split_위치();
		}

		private void View_DashBoard_Load(object sender, EventArgs e)
        {
			reDraw();

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



		private void Main_Load()
		{
			this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);
			this.bSroomTableAdapter.Fill(this.dataSet1.BSroom);


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
			foreach (var t3 in  gweb.mainFrame1.dBSqlite.Ds1.Device)
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
		}

		private void splitContainer5_SplitterMoved(object sender, SplitterEventArgs e)
		{
			Application.Cookies.Add("d1", splitContainer4.SplitterDistance.ToString(), DateTime.Now.AddDays(7));
			Application.Cookies.Add("d2", splitContainer5.SplitterDistance.ToString(), DateTime.Now.AddDays(7));
			Application.Cookies.Add("d3", splitContainer6.SplitterDistance.ToString(), DateTime.Now.AddDays(7));
		}


		/*
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
		
		*/
	}
}