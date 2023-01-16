using Microsoft.Ajax.Utilities;
using System;
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

		// 콤보 처리용 
		DataListAssetGroup DataList { get; set; } = new DataListAssetGroup();
		// 선택된 차일드 

		#region // 기본 처리 
		public void reDraw()
		{
			this.gdataGridView1.DataSource = null;
			this.gdataGridView1.DataSource = gbindingSource2;
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);

			var t1 = dataSet1.AssetGroups.GroupBy(p => p.Name).Select(x => x.First()).ToList();
			DataList.lstAssetGroups = t1.ToList();
			gbindingSource1.DataSource = DataList;
			this.gcomboBox1.DataBindings.Clear();
			this.gcomboBox1.DataBindings.Add(new Wisej.Web.Binding("DataSource", this.gbindingSource1, "lstAssetGroups", true, Wisej.Web.DataSourceUpdateMode.OnPropertyChanged));
			//comboBox1.DataSource = DataList.lstAssetGroups;
		}

		#endregion


		#region // 콤보 및 컨트롤 처리 

		private void SetStatusText(string text)
		{
		}
		private void gcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			AssetGroupsRow asset = (AssetGroupsRow)gcomboBox1.SelectedItem;
			if (asset == null)
				return;
			gtextBox1.Text = asset.Name;

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
				this.dataSet1.AssetGroups.RemoveAssetGroupsRow(s2);
			}

			foreach (var t1 in this.dataSet1.Assets)
			{
				if (t1.chk != 1) continue;

				var m1 = this.dataSet1.AssetGroups.NewAssetGroupsRow();
				m1.AssetId = t1.AssetId;
				m1.Name = gtextBox1.Text;
				this.dataSet1.AssetGroups.Rows.Add(m1);
				cnt++;
			}
			this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
			this.dataSet1.AcceptChanges();
			SetStatusText("Update " + cnt.ToString() + " records.");
		}

		private void AddGroup()
		{
			string str1 = gtextBox1.Text;
			if (str1 == "")
			{
				return;
			}

			var t1 = this.assetGroupsTableAdapter.Find(str1);
			if (t1 != null)
			{
				AlertBox.Show("동일한 이름이 존재합니다 :" + str1);
				return;
			}
			this.assetGroupsTableAdapter.InsertQuery(str1);
			this.dataSet1.AcceptChanges();
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);

			t1 = this.assetGroupsTableAdapter.Find(str1);

			int cnt = 0;
			foreach (var a1 in this.dataSet1.Assets)
			{
				if (a1.chk != 1) continue;

				var m1 = this.dataSet1.AssetGroups.NewAssetGroupsRow();
				m1.AssetId = a1.AssetId;
				m1.Name = gtextBox1.Text;
				this.dataSet1.AssetGroups.Rows.Add(m1);
				this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
				cnt++;
			}
			this.dataSet1.AcceptChanges();

			AlertBox.Show("신규 데이터가 등록 되었습니다." + str1);
			SetStatusText("Add " + cnt.ToString() + " records.");
			reDraw();
		}

		// AssetGroup, AssetBase
		private void DeleteGroup()
		{
			AssetGroupsRow asset = (AssetGroupsRow)gcomboBox1.SelectedItem;
			string str1 = asset.Name;

			if (str1 == "PRESET1" || str1 == "PRESET2" || str1 == "PRESET3" || str1 == "PRESET4")
			{
				AlertBox.Show("PRESET1~4 는 예약어 입니다.");
				return;
			}

			// this method shows server-side modal.
			if (MessageBox.Show(
					"Are you sure you want to delete this record?", icon: MessageBoxIcon.Question,
					buttons: MessageBoxButtons.YesNoCancel) == DialogResult.No)
				return;


			try
			{
				int cnt = 0;
				var s1 = this.dataSet1.AssetGroups.Where(p => p.Name == gtextBox1.Text).ToList();

				foreach (var s2 in s1)
				{
					s2.Delete();
					cnt++;
				}
				this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
				this.dataSet1.AcceptChanges();
				SetStatusText("Delete " + cnt.ToString() + " records.");

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

        }
    }
}
