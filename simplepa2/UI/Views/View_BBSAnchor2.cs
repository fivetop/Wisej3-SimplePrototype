using DataClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

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
			//throw new NotImplementedException();
			View_BBSAnchor_Load(null, null);
		}

		public void refresh(SignalRMsg msg1)
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			if (bSTreeRow == null) return;
			gweb.mainFrame1.dBSqlite.BSTreeUpdate(bSTreeRow, "대기");
			gweb.mainFrame1.dBSqlite.BSTreeCRemove(bSTreeRow.BSTreeId);
			bSTreeRow = null;
		}

		private void View_BBSAnchor_Load(object sender, EventArgs e)
        {
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            this.dataGridView2.RowCount = 10;

            this.assetsTableAdapter.Fill(this.dataSet1.Assets);

        }


		List<AssetsRow> SelAsset { get; set; } = new List<AssetsRow>();
		List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();

		BSTreeRow bSTreeRow { get; set; } = null;

		// BSTree 에서 해당 지역의 빈채널 선택
		// BSTreeC 에 지역과 음원 저장 
		// 시그날알 호출 처리 

		private void btnStart_Click(object sender, EventArgs e)
		{
			SelAsset.Clear();
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells["chk"].Value.ToString() != "0")
				{
					var t1 = row.DataBoundItem;
					SelAsset.Add((AssetsRow)((System.Data.DataRowView)t1).Row);
				}
			}

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

			int ret = gweb.mainFrame1.dBSqlite.EMServerGetState(SelAsset[0]);

			if (ret == 0)
			{
				AlertBox.Show("해당 지역 서버를 확인 바랍니다.", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
				return;
			}

			// 방송 채널 확보 
			bSTreeRow = gweb.mainFrame1.dBSqlite.BSTreeGetFreeCh(SelAsset[0]);
			// 저장전 기존 데이터 있으면 삭제처리 
			gweb.mainFrame1.dBSqlite.BSTreeCRemove(bSTreeRow.BSTreeId);
			// 지역과 음원 저장 
			gweb.mainFrame1.dBSqlite.BSTreeCSave(bSTreeRow.BSTreeId ,SelAsset, SelMusic);
			// 해당 지역 서버에 명령 처리 
			gweb.mainFrame1.sendSigR(eSignalRMsgType.ePlay, bSTreeRow, SelAsset, SelMusic);
			gweb.mainFrame1.dBSqlite.BSTreeUpdate(bSTreeRow, "방송시작");
			this.btnStart.Enabled = false;
			this.btnStop.Enabled = true;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			if (bSTreeRow == null) return;
			gweb.mainFrame1.sendSigR(eSignalRMsgType.eStop, bSTreeRow, null, null);
			gweb.mainFrame1.dBSqlite.BSTreeUpdate(bSTreeRow, "대기");
			gweb.mainFrame1.dBSqlite.BSTreeCRemove(bSTreeRow.BSTreeId);
			bSTreeRow = null;
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

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 1)
				return;
			DataGridViewCheckBoxCell checkedCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["chk"];
			dataGridView1.BeginEdit(true);

			if (Convert.ToBoolean(this.dataGridView1.Rows[e.RowIndex].Cells["chk"].Value) == false)
			{
				this.dataGridView1.Rows[e.RowIndex].Cells["chk"].Value = true;
			}
			else
			{
				this.dataGridView1.Rows[e.RowIndex].Cells["chk"].Value = false;
			}
			dataGridView1.EndEdit();
		}

		private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
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

    }
}
