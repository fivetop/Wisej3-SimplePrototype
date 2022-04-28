using System;
using Wisej.Web;
using System.IO;
using System.Drawing;
using System.Configuration;
using System.Web;

namespace Wisej.CodeProject
{
	public partial class MMusic : Form
	{
		public MMusic()
		{
			InitializeComponent();
		}

		private void DataBinding_Load(object sender, EventArgs e)
		{
			this.upload1.CreateControl();

			this.button2.Eval(
	   String.Format(@"
            this.uploadButton = Wisej.Core.getComponent(""id_{0}"");
            this.addListener(""execute"", function(e)
              {{
                 this.uploadButton.upload();
              }});", this.upload1.Handle));

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
			//this.dataGridView1.Tools["Save"].Enabled = true;
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
		}

        private void button1_Click(object sender, EventArgs e)
        {
			SaveData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
			//this.upload1.UploadFiles();
			//AddNewRecord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
			DeleteRecord();
        }

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {
			string strExeDir = Path.GetDirectoryName(Application.ExecutablePath);
			string strFileUploadPath = strExeDir + "\\Uploaded_Files\\";
			if (!Directory.Exists(strExeDir + "\\Uploaded_Files"))
			{
				Directory.CreateDirectory(strExeDir + "\\Uploaded_Files");
				strFileUploadPath = strExeDir + "\\Uploaded_Files\\";
			}
			e.Files[0].SaveAs(strFileUploadPath + e.Files[0].FileName);

			//e.Files[0].SaveAs("C:\\Test-upload" + e.Files[0].FileName);
		}
    }
}
