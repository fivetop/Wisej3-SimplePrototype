using DataClass;
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
/*
			this.mupload1.CreateControl();

			this.mbuttonAdd.Eval(
	   String.Format(@"
            this.uploadButton = Wisej.Core.getComponent(""id_{0}"");
            this.addListener(""execute"", function(e)
              {{
                 this.uploadButton.upload();
              }});", this.mupload1.Handle));
*/
			this.musicsTableAdapter.Fill(this.dataSet1.Musics);
			gweb.dBSqlite.MusicSave();
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

        private void mbuttonAdd_Click(object sender, EventArgs e)
        {
            if (filename == "" || filename == null)
                return;

            if (SaveStreamAsFile(strFileUploadPath, stream, filename) == false)
            {
                AlertBox.Show ("파일이 존재 합니다.");
                return;
            }
            DBInsert(strFileUploadPath + filename);
            reDraw();


            if (gweb.mainFrame.isSignalR())
            {
                gweb.mainFrame.sendSigR(eSignalRMsgType.eFileDown, filename); // dsp, dsp_chno
            }
            else
            {
                AlertBox.Show("Signal R 음원파일 전송이 취소되었습니다. - 서버 상태를 확인바랍니다.");
            }

        }

        private void mupload1_Uploaded(object sender, UploadedEventArgs e)
		{
			stream = e.Files[0].InputStream;
			filename = e.Files[0].FileName;
		}


        private bool SaveStreamAsFile(string filePath, Stream inputStream, string fileName)
        {
            //validation each saved file because another process could delete 
            //the directory
            DirectoryInfo info = new DirectoryInfo(filePath);
            if (!info.Exists)
            {
                info.Create();
            }

            string path = Path.Combine(filePath, fileName);

            if (File.Exists(path))
                return false;

            using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
            {
                inputStream.CopyTo(outputFileStream);
            }
            return true;
        }


        private void DBInsert(string path)
        {
            gweb.dBSqlite.DBInit();
            gweb.dBSqlite.MusicFileSave(strFileUploadPath, filename, "");
        }

    }
}
