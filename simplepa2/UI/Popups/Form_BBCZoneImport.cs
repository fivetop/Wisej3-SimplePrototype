using DataClass;
using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace simplepa2.UI.Popups
{
    public partial class Form_BBCZoneImport : Wisej.Web.Form
    {

        string  strFileUploadPath = @"C:\SimplePA2" + "\\Uploaded_Files\\";
        Stream stream;
        String filename;


        public Form_BBCZoneImport()
        {
            InitializeComponent();
        }

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {
            stream = e.Files[0].InputStream;
            filename = e.Files[0].FileName;

            upload1.Text = "";
            if (filename == "" || filename == null)
                return;

            SaveStreamAsFile(strFileUploadPath, stream, filename);
            loadDataToGrid(strFileUploadPath + filename);
        }

        private void loadDataToGrid(string filePath)
        {
            string[] arString = System.IO.File.ReadAllLines(filePath, Encoding.GetEncoding(949));

            AlertBox.Show(" TODO : 그리드 입력 처리 후 수정 가능 + 컨펌 후 데이터 추가 처리");
            foreach (var strData in arString)
            {
                DataSet1.AssetsDataTable dt = new DataSet1.AssetsDataTable();
                
                

            }
        }

        private void bt_inputDecision_Click(object sender, EventArgs e)
        {
 
            
            DBInsert(strFileUploadPath + filename);            
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
    }
}
