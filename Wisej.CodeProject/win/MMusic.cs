using System;
using Wisej.Web;
using System.IO;
using System.Drawing;
using System.Configuration;

namespace Wisej.CodeProject
{
	public partial class MMusic : Form
	{
		public MMusic()
		{
			InitializeComponent();
		}

		private string dbFilePath;

		private void DataBinding_Load(object sender, EventArgs e)
		{
			Application.ApplicationExit += Application_ApplicationExit;
			LoadData();
		}

		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			// delete the session-cloned db file.
			this.musicsTableAdapter.Connection.Close();
			this.musicsTableAdapter.Connection.Dispose();
			this.musicsTableAdapter.Adapter.Dispose();
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
						var count = this.musicsTableAdapter.Update(this.dataSet1.Musics);

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
				var count = this.musicsTableAdapter.Update(this.dataSet1.Musics);
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
			this.musicsTableAdapter.Fill(this.dataSet1.Musics);
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

		private void dateTimePicker1_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("You clicked the sun tool. Nice work.");
		}

		private void dataGridView1_Enter(object sender, EventArgs e)
		{
			this.bindingSource1.EndEdit();
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
