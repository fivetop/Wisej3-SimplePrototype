using System;
using Wisej.Web;
using System.Linq;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using static Wisej.CodeProject.DataSet1;
using System.Diagnostics;
using Microsoft.Ajax.Utilities;

namespace Wisej.CodeProject
{
    public partial class MGroup : Form
	{
		// 콤보 처리용 
		DataList DataList { get; set; } = new DataList();
		// 선택된 차일드 

		public MGroup()
		{
			InitializeComponent();
		}

        #region // 기본 처리 
        private void DataBinding_Load(object sender, EventArgs e)
		{
			Application.ApplicationExit += Application_ApplicationExit;
			LoadData();
		}
		private void LoadData()
		{
			this.dataGridView1.DataSource = null;
			this.dataGridView1.DataSource = bindingSource2;
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);

            var t1 = dataSet1.AssetGroups.GroupBy(p => p.Name).Select(x=>x.First()).ToList();
            DataList.lstAssetGroups = t1.ToList();
			bindingSource1.DataSource = DataList;
			this.comboBox1.DataBindings.Clear();
			this.comboBox1.DataBindings.Add(new Wisej.Web.Binding("DataSource", this.bindingSource1, "lstAssetGroups", true, Wisej.Web.DataSourceUpdateMode.OnPropertyChanged));
			//comboBox1.DataSource = DataList.lstAssetGroups;
		}

		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			// delete the session-cloned db file.
			this.assetsTableAdapter.Connection.Close();
			this.assetsTableAdapter.Connection.Dispose();
			this.assetsTableAdapter.Adapter.Dispose();

			this.assetGroupsTableAdapter.Connection.Close();
			this.assetGroupsTableAdapter.Connection.Dispose();
			this.assetGroupsTableAdapter.Adapter.Dispose();
		}
        #endregion

        #region // 그리드 처리 


		#endregion

		#region // 콤보 및 컨트롤 처리 

		private void SetStatusText(string text)
		{
			this.statusBar1.Text = text;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			AssetGroupsRow asset = (AssetGroupsRow) comboBox1.SelectedItem;
			if (asset == null)
				return;
			textBox1.Text = asset.Name;

			this.dataSet1.Assets.ForEach(p => p.chk = 0);
			var s1 = this.dataSet1.AssetGroups.Where(p => p.Name == textBox1.Text && p.AssetId != 0).ToList();
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
			var s1 = this.dataSet1.AssetGroups.Where(p => p.Name == textBox1.Text && p.AssetId != 0).ToList();

			foreach (var s2 in s1)
			{ 
				this.dataSet1.AssetGroups.RemoveAssetGroupsRow(s2);
			}

			foreach (var t1 in this.dataSet1.Assets)
			{
				if (t1.chk != 1) continue;

				var m1 = this.dataSet1.AssetGroups.NewAssetGroupsRow();
				m1.AssetId = t1.AssetId;
				m1.Name = textBox1.Text;
				this.dataSet1.AssetGroups.Rows.Add(m1);
				cnt++;
			}
			this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
			this.dataSet1.AcceptChanges();
			SetStatusText("Update " + cnt.ToString() + " records.");
		}

		private void AddGroup()
        {
			string str1 = textBox1.Text;
			if (str1 == "")
			{
				return;
			}

			var t1 =  this.assetGroupsTableAdapter.Find(str1);
			if (t1 != null)
			{
				AlertBox.Show("동일한 이름이 존재합니다 :" + str1);
				return;
			}
			this.assetGroupsTableAdapter.InsertQuery (str1);
			this.dataSet1.AcceptChanges();
			this.assetGroupsTableAdapter.Fill(this.dataSet1.AssetGroups);

			t1 = this.assetGroupsTableAdapter.Find(str1);

			int cnt = 0;
			foreach (var a1 in this.dataSet1.Assets)
			{
				if (a1.chk != 1) continue;

				var m1 = this.dataSet1.AssetGroups.NewAssetGroupsRow();
				m1.AssetId = a1.AssetId;
				m1.Name = textBox1.Text;
				this.dataSet1.AssetGroups.Rows.Add(m1);
				this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
				cnt++;
			}
			this.dataSet1.AcceptChanges();

			AlertBox.Show("신규 데이터가 등록 되었습니다." + str1);
			SetStatusText("Add " + cnt.ToString() + " records.");
			LoadData();
		}

		// AssetGroup, AssetBase
		private void DeleteGroup()
		{
			AssetGroupsRow asset = (AssetGroupsRow)comboBox1.SelectedItem;
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
				var s1 = this.dataSet1.AssetGroups.Where(p => p.Name == textBox1.Text).ToList();

				foreach (var s2 in s1)
				{
					s2.Delete();
					cnt++;
				}
				this.assetGroupsTableAdapter.Update(this.dataSet1.AssetGroups);
				this.dataSet1.AcceptChanges();
				SetStatusText("Delete " + cnt.ToString() + " records.");

				textBox1.Text = "";
				LoadData();
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

        private void button1_Click(object sender, EventArgs e)
        {
			UpGroup();
		}

		private void button2_Click(object sender, EventArgs e)
        {
			AddGroup();
        }

        private void button3_Click(object sender, EventArgs e)
        {
			DeleteGroup();
        }
    }
}
