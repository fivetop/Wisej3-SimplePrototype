using DataClass;
using System;
using System.IO;
using System.Text;
using Wisej.Web;


// 자산 관리 
namespace simplepa2.UI.Views
{
    public partial class View_BBCAsset2 : Wisej.Web.UserControl
    {
        string strFileUploadPath;
        Stream stream;
        String filename;

        public View_BBCAsset2()
        {
            InitializeComponent();
        }

        private void BSAsset_Load(object sender, EventArgs e)
        {
            strFileUploadPath = @"C:\SimplePA2" + "\\Uploaded_Files\\";
            this.assetsTableAdapter.Fill(this.dataSet1.Assets);
        }

        internal void reDraw()
        {
            this.assetsTableAdapter.Fill(this.dataSet1.Assets);
        }

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {
            stream = e.Files[0].InputStream;
            filename = e.Files[0].FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            upload1.Text = "";
            if (filename == "" || filename == null)
                return;
            SaveStreamAsFile(strFileUploadPath, stream, filename);
            DBInsert(strFileUploadPath + filename);
            reDraw();
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
            EmSpeakerPositionList _emspl = new EmSpeakerPositionList();
            gweb.mainFrame.dBSqlite.DBInit();

            string[] d1 = System.IO.File.ReadAllLines(strFileUploadPath, Encoding.GetEncoding(949));

            _emspl.child.Clear();
            foreach (var d2 in d1)
            {
                EmSpeakerPosition em1 = new EmSpeakerPosition();
                em1.array = d2.Split(',');
                em1.file = em1.getfile();
                _emspl.child.Add(em1);
            }

            foreach (var t1 in _emspl.child)
            {
                gweb.mainFrame.dBSqlite.SaveAssets(t1);
                gweb.mainFrame.dBSqlite.EMServerSave(t1);
                gweb.mainFrame.dBSqlite.BSTreeSave(t1);
            }
            gweb.mainFrame.dBSqlite.AssetPresetSave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void DeleteRecord()
        {
            try
            {
                var row = this.dataGridView1.CurrentRow?.Index ?? -1;
                if (row > -1)
                {
                    if (MessageBox.Show("삭제하시겠습니까?",
                        icon: MessageBoxIcon.Question,buttons: MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        this.assetsBindingSource.RemoveCurrent();
                        var count = this.assetsTableAdapter.Update(this.dataSet1.Assets);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
            }
        }

    }
}
