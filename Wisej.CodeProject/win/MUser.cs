using System;
using Wisej.Web;
using System.IO;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Data;

namespace Wisej.CodeProject
{
	public partial class MUser : Form
	{
		int add = 0; // add =1. update =2
		public MUser()
		{
			InitializeComponent();
		}

		private void DataBinding_Load(object sender, EventArgs e)
		{
			var t1 = this.userTreesTableAdapter; // .Connection = new System.Data.SQLite.SQLiteConnection("data source=" + targetPath + ";Pooling=False");

			Application.ApplicationExit += Application_ApplicationExit;
			LoadData();
		}

		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			// delete the session-cloned db file.
			this.userTreesTableAdapter.Connection.Close();
			this.userTreesTableAdapter.Connection.Dispose();
			this.userTreesTableAdapter.Adapter.Dispose();
		}

        private void DeleteRecord()
		{
			// this method shows server-side modal.
			if (textloginid.Text == "" || textusername.Text == "" || maskedTextBox1.Text == "")
			{
				AlertBox.Show("데이터를 확인 바랍니다.");
				return;
			}
			if (textpassword.Text != textpassword2.Text)
			{
				AlertBox.Show("Check Password!");
				return;
			}

			try
			{
				var row = this.dataGridView1.CurrentRow?.Index ?? -1;
				if (row > -1)
				{
					if (MessageBox.Show("삭제 하시겠습니까?",icon:MessageBoxIcon.Question, 
						buttons:MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
					{
						this.bindingSource1.RemoveCurrent();
						var count = this.userTreesTableAdapter.Update(this.dataSet1.UserTrees);
						SetStatusText("Deleted 1 record.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void SaveData()
		{
			try
			{
				if (textloginid.Text == "" || textusername.Text == "" || maskedTextBox1.Text == "")
				{
					AlertBox.Show("데이터를 확인 바랍니다.");
					return;
				}
				if (textpassword.Text != textpassword2.Text)
				{
					AlertBox.Show("Check Password!");
					return;
				}

				if (add == 1)
				{ 
					var t1 = this.dataSet1.UserTrees.Where(p=>p.login_id == textloginid.Text).FirstOrDefault() ;//.Select( .where . Select(); .ffin .GetDataBy(textloginid.Text);
					if (t1 != null)
						return;
				}
				this.bindingSource1.EndEdit();
				var count = this.userTreesTableAdapter.Update(this.dataSet1.UserTrees);

				AlertBox.Show("Saved!");
				SetStatusText("Saved " + count + " records.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void AddNewRecord()
		{
			try
			{
				this.bindingSource1.AddNew();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void SetStatusText(string text)
		{
			this.statusBar1.Text = text;
		}

		private void LoadData()
		{
			this.userTreesTableAdapter.Fill(this.dataSet1.UserTrees);
			SetStatusText("Loaded " + this.bindingSource1.Count + " records.");
		}

        private void button1_Click(object sender, EventArgs e)
        {
			SaveData();
			add = 0;
		}

        private void button2_Click(object sender, EventArgs e)
        {
			if (add == 1) return;
			add = 1;
			AddNewRecord();
		}

		private void button3_Click(object sender, EventArgs e)
        {
			add = 2;
			DeleteRecord();
			add = 0;
		}
	}
}
