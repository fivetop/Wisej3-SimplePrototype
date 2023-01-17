using DataClass;
using System;
using System.IO;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_FilePlayer : Wisej.Web.UserControl
    {
        public string strFileUploadPath;
        public Stream stream;
        public String filename;

        public Comp_FilePlayer()
        {
            InitializeComponent();
        }
        internal void reDraw()
        {
            this.musicsTableAdapter1.Fill(this.dataSet11.Musics);
        }

        private void SaveData()
        {
            try
            {
                this.mbindingSource1.EndEdit();
                var count = this.musicsTableAdapter1.Update(this.dataSet11.Musics);
                AlertBox.Show("Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
            }

        }


        private void bt_musicAdd_Click(object sender, EventArgs e)
        {
            if (filename == "" || filename == null)
                return;

            if (SaveStreamAsFile(strFileUploadPath, stream, filename) == false)
            {
                AlertBox.Show("파일이 존재 합니다.");
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
                AlertBox.Show("클라이언트의 음원 전송이 취소되었습니다. - 서버 상태를 확인바랍니다.");
            }


        }

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
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

        private void Comp_FilePlayer_Load(object sender, EventArgs e)
        {
            strFileUploadPath = @"C:\SimplePA2" + "\\Music\\";

            this.musicsTableAdapter1.Fill(this.dataSet11.Musics);
            gweb.mainFrame.dBSqlite.MusicSave();
            this.musicsTableAdapter1.Fill(this.dataSet11.Musics);
        }

        private void DBInsert(string path)
        {
            gweb.mainFrame.dBSqlite.DBInit();
            gweb.mainFrame.dBSqlite.MusicFileSave(strFileUploadPath, filename, tb_description.Text);
        }

        private void panel21_PanelCollapsed(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: 구현 예정입니다.");
        }
    }
}
