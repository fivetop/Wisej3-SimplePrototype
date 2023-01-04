using System;
using System.IO;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBSMusicManage2 : Wisej.Web.UserControl
    {
		string strFileUploadPath;
		Stream stream;
		String filename;

		public View_BBSMusicManage2()
        {
            InitializeComponent();
        }

		private void MMusicManager_Load(object sender, EventArgs e)
		{
			strFileUploadPath = @"C:\SimplePA2" + "\\Music\\";

			this.mupload1.CreateControl();

			this.mbutton2.Eval(
	   String.Format(@"
            this.uploadButton = Wisej.Core.getComponent(""id_{0}"");
            this.addListener(""execute"", function(e)
              {{
                 this.uploadButton.upload();
              }});", this.mupload1.Handle));

			this.musicsTableAdapter.Fill(this.dataSet1.Musics);
			gweb.mainFrame.dBSqlite.MusicSave();
			this.musicsTableAdapter.Fill(this.dataSet1.Musics);
		}

        internal void reDraw()
        {
            this.musicsTableAdapter.Fill(this.dataSet1.Musics);
        }

        private void SaveData()
		{
			try
			{
				this.mbindingSource1.EndEdit();
				var count = this.musicsTableAdapter.Update(this.dataSet1.Musics);
				AlertBox.Show("Saved!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void mbutton2_Click(object sender, EventArgs e)
		{
            mupload1.Text = "";
            if (filename == "" || filename == null)
                return;
            SaveStreamAsFile(strFileUploadPath, stream, filename);
            DBInsert(strFileUploadPath + filename);
            reDraw();
        }

		private void mupload1_Uploaded(object sender, UploadedEventArgs e)
		{
			stream = e.Files[0].InputStream;
			filename = e.Files[0].FileName;
		}


        private void SaveStreamAsFile(string filePath, Stream inputStream, string fileName)
        {
            //validation each saved file because another process could delete 
            //the directory
            DirectoryInfo info = new DirectoryInfo(filePath);
            if (!info.Exists)
            {
                info.Create();
            }

            string path = Path.Combine(filePath, fileName);
            using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
            {
                inputStream.CopyTo(outputFileStream);
            }
        }


        private void DBInsert(string strFileUploadPath)
        {
            gweb.mainFrame.dBSqlite.DBInit();

        }

    }
}
