using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

// asset 을 베이스로 그룹 데이터를 표현 
// 변경된 부분만 그룹으로 저장 

namespace simplepa2.UI.Views
{
    public partial class View_GroupManager2 : Wisej.Web.UserControl
    {
        public View_GroupManager2()
        {
            InitializeComponent();
        }

		#region // 기본 처리 
		private void MGroupManager_Load(object sender, EventArgs e)
		{
			reDraw();
		}

		public void reDraw()
		{
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);

			comp_Site1.dataSet = gweb.dBSqlite.EMServerWithWholeColLoad(1);
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
		private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
		{
			string selectedItem = sender as string;
			IEnumerable<AssetGroupsRow> t1;

			if (selectedItem == "") return;
			gbindingSource2.Filter = ("emServer = '" + selectedItem + "'");
			t1 = this.dataSet1.AssetGroups.Where(p => p.EMNAME == selectedItem).DistinctBy(p => p.Name);

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

		#endregion

		#region // add, update, delete

		private void UpGroup()
		{
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);
			string gname = gtextBox1.Text;
			string emname = comp_Site1.selectedItem;

			try
			{
				if (this.gdataGridView1.RowCount < 1) return;

				foreach (var r1 in this.gdataGridView1.Rows)
				{
					var s1 = r1.DataBoundItem;
					var k1 = (AssetsRow)((System.Data.DataRowView)s1).Row;
					if (s1 == null) continue;
					if (k1 == null) continue;
					if (k1.AssetId < 1) continue;
					if (k1.emServer != emname) continue;

					var d1 = this.dataSet1.AssetGroups.FirstOrDefault(p => p.Name == gname && p.AssetId == k1.AssetId && p.EMNAME == emname);
					if (k1.chk != 1)
					{
						if (d1 == null) continue; 
						d1.Delete();
						this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
						this.dataSet1.AcceptChanges();
					}
					else
					{
						if (d1 != null) continue;
						var m1 = this.dataSet1.AssetGroups.NewAssetGroupsRow();
						m1.AssetId = k1.AssetId;
						m1.Name = gname;
						m1.EMNAME = k1.emServer;
						this.dataSet1.AssetGroups.Rows.Add(m1);
						this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
						this.dataSet1.AcceptChanges();
					}
				}

			}
			catch (Exception e1)
			{
				gweb.Log(e1.Message);
			}
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);
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
			if (MessageBox.Show("삭제하시겠습니까?", icon: MessageBoxIcon.Question,buttons: MessageBoxButtons.YesNo) == DialogResult.No)
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
			catch (Exception e1)
			{
				gweb.Log(e1.Message);
			}
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
		#endregion

		#region // not use
		/*
		var t1 = this.gdataGridView1.CurrentRow.DataBoundItem;
		var t2 = (EMBsRow)((System.Data.DataRowView)t1).Row;
		if (t1 == null) return;
		if (t2 == null) return;
		t2.Delete();
		emBsTableAdapter.Update(dataSet1.EMBs);
		eMBsBindingSource.EndEdit();
		comboBox1_SelectedIndexChanged(null, null);
		 * 
		 * 
		try
		{
			var s1 = this.dataSet1.AssetGroups.Where(p => p.Name == gtextBox1.Text).ToList();

			foreach (var s2 in s1)
			{
				s2.Delete();
				this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
				this.dataSet1.AcceptChanges();
			}
		}
		catch (Exception e1)
		{
			gweb.Log(e1.Message);
		}
		*/


		#endregion

	}
}
