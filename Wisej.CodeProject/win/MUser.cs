using System;
using Wisej.Web;
using System.IO;
using System.Drawing;
using System.Configuration;

namespace Wisej.CodeProject
{
	public partial class MUser : Form
	{
		public MUser()
		{
			InitializeComponent();
		}

		private string dbFilePath;

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
			try
			{
				File.Delete(this.dbFilePath);
			}
			catch { }
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.dataGridView1.Tools["Save"].Enabled = true;
		}

		private void dataGridView1_ToolClick(object sender, ToolClickEventArgs e)
		{
			switch (e.Tool.Name)
			{
				case "Save":
					SaveData();
					break;

				case "Add":
					AddNewRecord();
					break;

				case "Delete":
					DeleteRecord();
					break;

				case "Reload":
					LoadData();
					break;
			}
		}

		private void DeleteRecord()
		{
			// this method shows server-side modal.

			try
			{
				var row = this.dataGridView1.CurrentRow?.Index ?? -1;
				if (row > -1)
				{
					if (MessageBox.Show(
						"Are you sure you want to delete this record?", 
						icon:MessageBoxIcon.Question, 
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
				this.bindingSource1.EndEdit();
				var count = this.userTreesTableAdapter.Update(this.dataSet1.UserTrees);
				this.dataGridView1.Tools["Save"].Enabled = false;

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
			this.dataGridView1.CellValueChanged -= new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			this.userTreesTableAdapter.Fill(this.dataSet1.UserTrees);
			this.dataGridView1.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);


			SetStatusText("Loaded " + this.bindingSource1.Count + " records.");
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			this.dataGridView1.Tools["Delete"].Enabled = this.dataGridView1.CurrentRow != null;
		}

		private void dataGridView1_CellToolClick(object sender, DataGridViewToolClickEventArgs e)
		{
			AlertBox.Show("You clicked the sun tool. Nice work.");
		}

		private void textBox3_ToolClick(object sender, ToolClickEventArgs e)
		{
			if (String.IsNullOrEmpty(this.textBox3.Text))
				AlertBox.Show("Cannot send an email to an empty address! ", icon: MessageBoxIcon.Error);
			else
				AlertBox.Show("I'm sending an email to " + this.textBox3.Text);
		}

		private void textBox2_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("This tool button does't do anything.");
		}

		private void dateTimePicker1_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("You clicked the sun tool. Nice work.");
		}

		private void dataGridView1_Enter(object sender, EventArgs e)
		{
			//this.bindingSource1.
			this.bindingSource1.EndEdit();
		}

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
