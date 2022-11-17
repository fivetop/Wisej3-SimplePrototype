using DataClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_BBSAnchor : Wisej.Web.UserControl
    {
        public View_BBSAnchor()
        {
            InitializeComponent();
        }

        private void View_BBSAnchor_Load(object sender, EventArgs e)
        {
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            this.dataGridView2.RowCount = 10;

            this.assetsTableAdapter.Fill(this.dataSet1.Assets);

        }


		public List<AssetsRow> SelAsset { get; set; } = new List<AssetsRow>();
		public List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();
		Guid guid { get; set; } = Guid.Empty;

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
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Error, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Hand, true, ContentAlignment.MiddleCenter);
				AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Question, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Stop, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Warning, true, ContentAlignment.MiddleCenter);
				return;
			}

			guid = gweb.mainFrame.sendSigR(eSignalRMsgType.ePlay, SelAsset, SelMusic, Guid.Empty);
			this.btnStart.Enabled = false;
			this.btnStop.Enabled = true;

		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
			if (guid != Guid.Empty)
			{
				gweb.mainFrame.sendSigR(eSignalRMsgType.eStop, null, null, guid);
				guid = Guid.Empty;
			}
		}

		private void Win_EventMusic(object sender, EventArgs e)
		{
			this.dataGridView2.DataSource = SelMusic;
			this.dataGridView2.Refresh();

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
