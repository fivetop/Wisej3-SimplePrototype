using Microsoft.Ajax.Utilities;
using Nancy.Extensions;
using System;
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

		private void MGroupManager_Load(object sender, EventArgs e)
		{
			reDraw();
		}

		// 콤보 처리용 
		DataListAssetPresetGroup sitename { get; set; } = new DataListAssetPresetGroup();
		DataListAssetPresetGroup presetname { get; set; } = new DataListAssetPresetGroup();
		// 선택된 차일드 

		#region // 기본 처리 
		public void reDraw()
		{
			this.assetPresetGroupsTableAdapter1.FillBy(this.dataSet1.AssetPresetGroups);
			var dt1 = this.dataSet1.AssetPresetGroups.Columns;

			this.gdataGridView1.DataSource = null;
			this.gdataGridView1.DataSource = gbindingSource2;
			//this.gdataGridView1.DataSource = this.dataSet1.AssetPresetGroups;

			var t1 = dataSet1.AssetPresetGroups.GroupBy(p => p.Name).Select(x => x.First()).ToList();
			presetname.lstAssetPresetGroups = t1.ToList();
			var t2 = dataSet1.AssetPresetGroups.GroupBy(p => p.EMNAME).Select(x => x.First()).ToList();
			sitename.lstAssetPresetGroups = t2.ToList();
			gbindingSource1.DataSource = presetname;
			sitebindingSource1.DataSource = sitename;

			this.gcomboBox1.DataBindings.Clear();
			this.gcomboBox1.DataBindings.Add(new Wisej.Web.Binding("DataSource", this.gbindingSource1, "lstAssetPresetGroups", true, Wisej.Web.DataSourceUpdateMode.OnPropertyChanged));

			this.sitecomboBox1.DataBindings.Clear();
			this.sitecomboBox1.DataBindings.Add(new Wisej.Web.Binding("DataSource", this.sitebindingSource1, "lstAssetPresetGroups", true, Wisej.Web.DataSourceUpdateMode.OnPropertyChanged));
		}
		#endregion

		#region // 콤보 및 컨트롤 처리 

		DataView dataView = new DataView();

		private void gcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			AssetPresetGroupsRow preset = (AssetPresetGroupsRow)gcomboBox1.SelectedItem;
			AssetPresetGroupsRow site = (AssetPresetGroupsRow) sitecomboBox1.SelectedItem;
			if (preset == null || site == null)
				return;

			string f1 = "Name='" + preset.Name + "'";
			string f2 = f1 + " and EMNAME='" + site.EMNAME + "'";
			gbindingSource2.Filter = f2;
			dataView = (DataView)gbindingSource2.List;
			this.gdataGridView1.DataSource = dataView.ToTable();
			//this.gdataGridView1.DataSource = this.dataSet1.AssetPresetGroups.Where(x => x.Name == preset.Name && x.EMNAME == site.EMNAME).ToList();
			//			this.assetPresetGroupsTableAdapter1.FillBy(this.dataSet1.AssetPresetGroups);

			//			gbindingSource2.ResetBindings (true);
			//			this.gdataGridView1.DataSource = null;
			//			this.gdataGridView1.DataSource = gbindingSource2;
			//this.assetPresetGroupsTableAdapter1.Fill(this.dataSet1.AssetPresetGroups);
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
			//gdataGridView1.EndEdit();
			//gbindingSource2.ResetBindings(false);
			//gbindingSource2.ResumeBinding(); // .ResetItem(); // .ResetAllowNew();// .ResetBindings(false);
		}
		#endregion

		private void gbutton1_Click(object sender, EventArgs e)
		{
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

		}

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
