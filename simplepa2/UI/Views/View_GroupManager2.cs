using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_GroupManager2 : Wisej.Web.UserControl
    {
        public View_GroupManager2()
        {
            InitializeComponent();
        }

		private void MGroupManager_Load(object sender, EventArgs e)
		{
			reDraw();
		}

		#region // 기본 처리 
		public void reDraw()
		{
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);

			comp_Site1.dataSet = gweb.mainFrame.dBSqlite.EMServerWithWholeColLoad(1);
			comp_Site1.reDraw();
		}
		#endregion


		#region // 콤보 및 컨트롤 처리 

		private void gcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var asset = gcomboBox1.SelectedItem as string;
			if (asset == null)
				return;
			gtextBox1.Text = asset;

			this.dataSet1.Assets.ForEach(p => p.chk = 0);
			var s1 = this.dataSet1.AssetGroups.Where(p => p.Name == gtextBox1.Text && p.AssetId != 0).ToList();
			var s2 = (from q1 in this.dataSet1.Assets
					  join q2 in s1
					  on q1.AssetId equals q2.AssetId
					  select q1).ToList();

			foreach (var t1 in s2)
			{
				t1.chk = 1;
			}
		}


		#endregion


		private void UpGroup()
		{
			int cnt = 0;
			var s1 = this.dataSet1.AssetGroups.Where(p => p.Name == gtextBox1.Text && p.AssetId != 0).ToList();

			foreach (var s2 in s1)
			{
				s2.Delete();
				//this.dataSet1.AssetGroups.RemoveAssetGroupsRow(s2);
			}

			string s3 = comp_Site1.selectedItem;
			foreach (var t1 in this.dataSet1.Assets)
			{
				if (t1.chk != 1) continue;
				if (t1.emServer != s3) return;

				var m1 = this.dataSet1.AssetGroups.NewAssetGroupsRow();
				m1.AssetId = t1.AssetId;
				m1.Name = gtextBox1.Text;
				m1.EMNAME = t1.emServer;
				this.dataSet1.AssetGroups.Rows.Add(m1);
			}
			this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
			this.dataSet1.AcceptChanges();
		}

		private void AddGroup()
		{
			string str1 = gtextBox1.Text;
			if (str1 == "") return;

			var t1 = this.assetGroupsTableAdapter.Find(str1);
			if (t1 != null)
			{
				AlertBox.Show("동일한 이름이 존재합니다 :" + str1);
				return;
			}
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);

			t1 = this.assetGroupsTableAdapter.Find(str1);

			string s1 = comp_Site1.selectedItem;
			foreach (var a1 in this.dataSet1.Assets)
			{
				if (a1.chk != 1) continue;
				if (a1.emServer != s1) return;
				var m1 = this.dataSet1.AssetGroups.NewAssetGroupsRow();
				m1.AssetId = a1.AssetId;
				m1.Name = gtextBox1.Text;
				m1.EMNAME = a1.emServer;
				this.dataSet1.AssetGroups.Rows.Add(m1);
				this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
			}
			this.dataSet1.AcceptChanges();
			AlertBox.Show("신규 데이터가 등록 되었습니다." + str1);
			reDraw();
		}

		// AssetGroup, AssetBase
		private void DeleteGroup()
		{
			string asset = (string) gcomboBox1.SelectedItem;
			string str1 = asset;

			if (str1 == "PRESET1" || str1 == "PRESET2" || str1 == "PRESET3" || str1 == "PRESET4")
			{
				AlertBox.Show("PRESET1~4 는 예약어 입니다.");
				return;
			}

			// this method shows server-side modal.
			if (MessageBox.Show("삭제하시겠습니까?", icon: MessageBoxIcon.Question,
					buttons: MessageBoxButtons.YesNoCancel) == DialogResult.No)
				return;


			try
			{
				int cnt = 0;
				var s1 = this.dataSet1.AssetGroups.Where(p => p.Name == gtextBox1.Text).ToList();

				foreach (var s2 in s1)
				{
					s2.Delete();
				}
				this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
				this.dataSet1.AcceptChanges();
				gtextBox1.Text = "";
				reDraw();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 1)
				return;
			DataGridViewCheckBoxCell checkedCell = (DataGridViewCheckBoxCell)gdataGridView1.Rows[e.RowIndex].Cells[1];
			gdataGridView1.BeginEdit(true);

			if (Convert.ToBoolean(this.gdataGridView1.Rows[e.RowIndex].Cells[1].Value) == false)
			{
				this.gdataGridView1.Rows[e.RowIndex].Cells[1].Value = true;
			}
			else
			{
				this.gdataGridView1.Rows[e.RowIndex].Cells[1].Value = false;
			}
			gdataGridView1.EndEdit();
		}

		private void gbutton1_Click(object sender, EventArgs e)
		{
			UpGroup();
		}

		private void gbutton2_Click(object sender, EventArgs e)
		{
			AddGroup();
		}

		private void gbutton3_Click(object sender, EventArgs e)
		{
			DeleteGroup();
		}

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
			string selectedItem = sender as string;
			IEnumerable<AssetGroupsRow> t1;

			if (selectedItem == "") return;
			gbindingSource2.Filter = ("emServer = '" + selectedItem + "'");
			t1 = this.dataSet1.AssetGroups.Where(p=>p.EMNAME == selectedItem).DistinctBy(p => p.Name);

			gcomboBox1.Items.Clear();
			foreach (var a1 in t1)
			{
				gcomboBox1.Items.Add(a1.Name);
			}
			if (gcomboBox1.Items.Count > 0)
				gcomboBox1.SelectedIndex = 0;

			disp_gridview();
		}

        private void disp_gridview()
        {
        }
    }
}
