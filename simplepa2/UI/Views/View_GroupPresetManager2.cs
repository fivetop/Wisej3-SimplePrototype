using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_GroupPresetManager2 : Wisej.Web.UserControl
    {
        public View_GroupPresetManager2()
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
			this.assetPresetGroupsTableAdapter1.FillBy(this.dataSet1.AssetPresetGroups);
			var t1 = this.dataSet1.AssetPresetGroups.ToList();

			//gdataGridView1.DataSource = t1;
			comp_Site1.dataSet = gweb.mainFrame.dBSqlite.EMServerWithWholeColLoad(1);
			comp_Site1.reDraw();
		}
		#endregion

		#region // 콤보 및 컨트롤 처리 

		private void gcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string preset = (string)gcomboBox1.SelectedItem;
			string site = comp_Site1.selectedItem;
			if (preset == null || site == null)
				return;

			string f1 = "Name='" + preset + "'";
			string f2 = f1 + " and EMNAME='" + site + "'";
			gbindingSource2.Filter = f2;

			disp_gridview();

		}


		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 1)
				return;
			DataGridViewCheckBoxCell checkedCell = (DataGridViewCheckBoxCell)gdataGridView1.Rows[e.RowIndex].Cells[1];
			//gdataGridView1.BeginEdit(true);

			if (Convert.ToBoolean(this.gdataGridView1.Rows[e.RowIndex].Cells[1].Value) == false)
			{
				this.gdataGridView1.Rows[e.RowIndex].Cells[1].Value = true;
			}
			else
			{
				this.gdataGridView1.Rows[e.RowIndex].Cells[1].Value = false;
			}
		}

		private void gbutton1_Click(object sender, EventArgs e)
		{
			var count = this.assetPresetGroupsTableAdapter1.Update(this.dataSet1.AssetPresetGroups);
		}

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
			string selectedItem = sender as string;
			IEnumerable<AssetPresetGroupsRow> t1;

			if (selectedItem == "") return;
			gbindingSource2.Filter = ("EMNAME = '" + selectedItem + "'");
			t1 = this.dataSet1.AssetPresetGroups.Where(p => p.EMNAME == selectedItem).DistinctBy(p => p.Name);

			gcomboBox1.Items.Clear();
			foreach (var a1 in t1)
			{
				gcomboBox1.Items.Add(a1.Name);
			}
			if (gcomboBox1.Items.Count > 0)
				gcomboBox1.SelectedIndex = 0;
			//disp_gridview();
		}

        private void disp_gridview()
        {
			gbindingSource2.SuspendBinding();
			this.assetPresetGroupsTableAdapter1.FillBy(this.dataSet1.AssetPresetGroups);
			gbindingSource2.ResumeBinding();
		}
		#endregion


		#region // Not use 


		/*
			foreach (var t1 in gdataGridView1.Rows)
			{
				DataGridViewCheckBoxCell checkedCell = (DataGridViewCheckBoxCell)t1.Cells[1]; //DataGridViewCheckBoxCell checkedCell = (DataGridViewCheckBoxCell)gdataGridView1.Rows[e.RowIndex].Cells[1];
				int t2 = (int)t1.Cells[0].Value;
				var dt1 = this.dataSet1.AssetPresetGroups.FirstOrDefault(p=>p.AssetPresetGroupId == t2);
				int rlt = Convert.ToBoolean(checkedCell.Value) == true ? 1 : 0;

				if (dt1.chk == rlt) continue;

				dt1.chk = rlt;
				this.assetPresetGroupsTableAdapter1.Update(this.dataSet1.AssetPresetGroups);
				this.dataSet1.AcceptChanges();
			}
		*/
		#endregion
	}
}
