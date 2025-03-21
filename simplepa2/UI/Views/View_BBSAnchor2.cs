﻿using DataClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;


// 앵커방송 처리 
namespace simplepa2.UI.Views
{
	public partial class View_BBSAnchor2 : Wisej.Web.UserControl
	{
		public View_BBSAnchor2()
		{
			InitializeComponent();
		}

		internal void reDraw()
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			this.dataGridView2.RowCount = 10;

			this.assetsTableAdapter.Fill(this.dataSet1.Assets);
			this.schduleTableAdapter1.Fill(this.dataSet1.Schdule);

			comp_Site1.dataSet = gweb.dBSqlite.EMServerWithWholeColLoad(1);
			comp_Site1.reDraw();
		}

        public void refresh()
        {
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }

        public void refresh2()
        {
            this.schduleTableAdapter1.Fill(this.dataSet1.Schdule);
        }

        // C2S 예약방송 시작 
        // db update -> idno
        internal void UpdateSchedule(int idno, string state)
        {
			if (idno < 200000) return;
			int schid = idno - 200000;
			gweb.dBSqlite.SchduleUpdate(schid, state);
        }

        private void View_BBSAnchor_Load(object sender, EventArgs e)
		{
			reDraw();
		}


		List<AssetsRow> SelAsset { get; set; } = new List<AssetsRow>();
		List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();

		int bSTreeid { get; set; } = 0;

		// 방송 시작
		// 선택내용 확인
		// 해당 지역 서버 확인
		// 사용중인 지역이 있는지 점검
		// 방송 시작
		private void btnStart_Click(object sender, EventArgs e)
		{
			SelAsset = comp_UAsset1.GetSelAssets();

			if (SelAsset.Count() < 1 || SelMusic.Count() < 1)
			{
				AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Error, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Hand, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Question, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Stop, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Warning, true, ContentAlignment.MiddleCenter);
				return;
			}

			int ret = gweb.dBSqlite.EMServerGetState(SelAsset[0]);

			if (ret == 0)
			{
				AlertBox.Show("해당 지역 서버를 확인 바랍니다.", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
				return;
			}

			// 선택한 지역에 방송중인지 점검 
			string ret1 = gweb.dBSqlite.BSTreeCCheck(SelAsset);

			if (ret1 != "")
			{
				AlertBox.Show(ret1 + "님이 방송중인 지역 입니다.", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
				return;
			}

			방송처리로직();
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			방송중지로직();
			bSTreeid = 0;
		}

		// 1. 방송 채널 확보 
		// 2. 저장전 기존 데이터 있으면 삭제처리 
		// 3. 지역과 음원 저장 
		// 4. 해당 지역 서버에 명령 처리 
		// 5. 버튼 상태 변경 
		private async void 방송처리로직()
		{
			bSTreeid = gweb.dBSqlite.BSTreeGetFreeCh(SelAsset[0]);
			if (bSTreeid == 0) return;
			await gweb.dBSqlite.BSTreeCRemove(bSTreeid);
			await gweb.dBSqlite.BSTreeCSave(bSTreeid, SelAsset, SelMusic, gweb.mainFrame.user_name);
			await gweb.dBSqlite.BSTreeUpdate(bSTreeid, "방송시작");
			gweb.mainFrame.sendSigR(eSignalRMsgType.ePlay, bSTreeid, SelAsset, SelMusic);
			this.btnStart.Enabled = false;
			this.btnStop.Enabled = true;
		}

		// 1. 해당지역 서버에 중지 처리 
		// 2. 방송트리 초기화 
		// 3. 방송트리 차일드 지우기 
		private void 방송중지로직()
		{
			if (bSTreeid == 0) return;
			gweb.dBSqlite.BSTreeUpdate(bSTreeid, "대기");
			gweb.dBSqlite.BSTreeCRemove(bSTreeid);
			gweb.mainFrame.sendSigR(eSignalRMsgType.eStop, bSTreeid, null, null);
		}

		private void Win_EventMusic(object sender, EventArgs e)
		{
			this.dataGridView2.DataSource = SelMusic;
			this.dataGridView2.Refresh();

			if (SelMusic.Count == 0)
			{
				this.dataGridView2.DataSource = null;
				this.dataGridView2.RowCount = 10;
			}
		}


		#region // 그리드 처리 

		private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var grid = (DataGridView)sender;
				var ctxMenu = new ContextMenu();
				var menu1 = ctxMenu.MenuItems.Add("음원 추가");
				var menu2 = ctxMenu.MenuItems.Add("선택음원 삭제");
				var menu3 = ctxMenu.MenuItems.Add("인터넷방송추가");
				var menu4 = ctxMenu.MenuItems.Add("미리듣기");
				var position = grid.PointToClient(Cursor.Position);
				ctxMenu.Show((Wisej.Web.Control)sender, position);

				menu1.Click += (s, e1) =>
				{
					PMusicSel win = new PMusicSel();
					win.EventMusic += Win_EventMusic;
					win.SelMusic = SelMusic;
					win.Show();
				};

				menu2.Click += (s, e1) =>
				{
					grid.CurrentCell.Style.ForeColor = Color.Blue;
				};
				menu3.Click += (s, e1) =>
				{
					grid.CurrentCell.Style.BackColor = Color.Beige;
				};

				menu4.Click += (s, e1) =>
				{
					grid.CurrentCell.Style.ForeColor = Color.Blue;
				};
			}

		}
        #endregion

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
			string selectedItem = sender as string;
			IEnumerable<AssetPresetGroupsRow> t1;

			if (selectedItem == "") return;
			assetsBindingSource.Filter = ("emserver = '" + selectedItem + "'");
			schduleBindingSource.Filter = ("emname = '" + selectedItem + "'");
			schduleBindingSource.Sort = "tss";

			comp_UAsset1.Filter = selectedItem;
			comp_UAsset1.assetsBindingSource = assetsBindingSource;
			comp_UAsset1.reDraw2();
		}

    }
}
