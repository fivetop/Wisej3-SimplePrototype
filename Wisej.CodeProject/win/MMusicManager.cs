using System;
using System.IO;
using Wisej.Web;

namespace Wisej.CodeProject.win
{
    public partial class MMusicManager : Wisej.Web.UserControl
    {
        public MMusicManager()
        {
            InitializeComponent();
        }

		private void MMusicManager_Load(object sender, EventArgs e)
		{

			this.mupload1.CreateControl();

			this.mbutton2.Eval(
	   String.Format(@"
            this.uploadButton = Wisej.Core.getComponent(""id_{0}"");
            this.addListener(""execute"", function(e)
              {{
                 this.uploadButton.upload();
              }});", this.mupload1.Handle));

			this.musicsTableAdapter.Fill(this.dataSet1.Musics);
		}

		private void DeleteRecord()
		{
			// this method shows server-side modal.

			try
			{
				var row = this.mdataGridView1.CurrentRow?.Index ?? -1;
				if (row > -1)
				{
					if (MessageBox.Show(
						"Are you sure you want to delete this record?",
						icon: MessageBoxIcon.Question,
						buttons: MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
					{
						this.mbindingSource1.RemoveCurrent();
						var count = this.musicsTableAdapter.Update(this.dataSet1.Musics);
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
				this.mbindingSource1.EndEdit();
				var count = this.musicsTableAdapter.Update(this.dataSet1.Musics);
				//this.mdataGridView1.Tools["Save"].Enabled = false;

				AlertBox.Show("Saved!");
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
				this.mbindingSource1.AddNew();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void mbutton1_Click(object sender, EventArgs e)
		{
			SaveData();
		}

		private void mbutton2_Click(object sender, EventArgs e)
		{
			//this.upload1.UploadFiles();
			//AddNewRecord();
		}

		private void mbutton3_Click(object sender, EventArgs e)
		{
			DeleteRecord();
		}

		private void mupload1_Uploaded(object sender, UploadedEventArgs e)
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
