using DataClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_FilePlayer : Wisej.Web.UserControl
    {
        public string strFileUploadPath;
        public Stream stream;
        public String filename;

        public DataSet1.MusicsRow selectedMusicRow;

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

            SaveFileOnWebServerInMedia(e);
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

        private bool SaveFileOnWebServerInMedia(UploadedEventArgs e)
        {
            try
            {
                string strExeDir = Path.GetDirectoryName(Application.StartupPath+"/Media");
                
                string strFileUploadPath = strExeDir + "\\Media\\";
                if (!Directory.Exists(strExeDir + "\\Media"))
                {
                    Directory.CreateDirectory(strExeDir + "\\Media");
                    strFileUploadPath = strExeDir + "\\Media\\";
                }
                e.Files[0].SaveAs(strFileUploadPath + e.Files[0].FileName);
            } catch (Exception e1)
            {
                MessageBox.Show("LAW TEXT : 파일을 업로드 하는 중 오류가 발생 " + e1.ToString());
            }

            return true;

        }

        private void Comp_FilePlayer_Load(object sender, EventArgs e)
        {
            strFileUploadPath = @"C:\SimplePA2" + "\\Music\\";

            this.musicsTableAdapter1.Fill(this.dataSet11.Musics);
            gweb.dBSqlite.MusicSave();
            this.musicsTableAdapter1.Fill(this.dataSet11.Musics);
        }

        private void DBInsert(string path)
        {
            gweb.dBSqlite.DBInit();
            gweb.dBSqlite.MusicFileSave(strFileUploadPath, filename, tb_description.Text);
        }

        private void mdataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var dgv = (DataGridView)sender;
            var r1 = dgv.Rows[e.RowIndex];
            selectedMusicRow = (r1.DataBoundItem as DataRowView).Row as DataSet1.MusicsRow;

            lb_selectContetns.Text = selectedMusicRow.FileName;
            lb_playTimeEnd.Text = selectedMusicRow.duration;
            lb_playTimeStart.Text = "00:00:00";


            this.audioDefault.SourceURL = "Media/" + selectedMusicRow.FileName;
            // 플레이 되고 있다면 스탑 처리 할 것
        }

        private void panel21_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("LAW TEXT : TODO - Streaming 파일 구현 준비 중 ");
        }


        private void audioDefault_VolumeChanged(object sender, EventArgs e)
        {
            // AlertBox.Show($"Volume Level {this.audioDefault.Volume}");
        }

        private void audioDefault_Playing(object sender, EventArgs e)
        {
            // AlertBox.Show("Audio Playing");
        }

        private void audioDefault_Paused(object sender, EventArgs e)
        {
            // AlertBox.Show("Audio Paused", icon: MessageBoxIcon.Hand);
        }
    }
}
