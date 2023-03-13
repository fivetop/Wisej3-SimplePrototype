using DataClass;
using simplepa2.UI.Views;
using System;
using System.IO;
using System.Text;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Popups
{
    public partial class Form_BBCZoneImport : Wisej.Web.Form
    {

        string  strFileUploadPath = Application.StartupPath +@"\Uploaded_Files\";
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
                AssetsRow ar = assetsTextParcer(strData);

                if(ar != null)
                {
                    this.dataSet11.Assets.AddAssetsRow(ar);
                }                
            }

            dg_assetTextData.DataSource = this.dataSet11.Assets;
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

        // 선번장을 읽은후 기본 테이블 만들기 
        // assets, emserver, bstree, assetgroup, assetpreset
        private void DBInsert(string strFileUploadPath)
        {
            EmSpeakerPositionList _emspl = new EmSpeakerPositionList();
            gweb.dBSqlite.DBInit();

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
                gweb.dBSqlite.SaveAssets(t1);
                gweb.dBSqlite.EMServerSave(t1);
                gweb.dBSqlite.BSTreeSave(t1);
            }
            gweb.dBSqlite.AssetGroupsSave();
            gweb.dBSqlite.AssetPresetSave();

            this.Close();

        }

        public AssetsRow assetsTextParcer(String text)
        {
            AssetsRow m2 = this.dataSet11.Assets.NewAssetsRow();

            string[] aa = text.Split(',');

            if (aa.Length < 12)
                return null;
            try
            {
                m2.seq = int.Parse(aa[0]);
                m2.emServer = aa[1];
                m2.building = aa[2];
                m2.floorname = aa[3];
                m2.GroupName = aa[2] + aa[3];
                m2.ZoneName = aa[4];
                m2.SpeakerName = aa[5];
                m2.DeviceName = aa[6];
                m2.path = aa[1] + " " + aa[2] + " " + aa[3] + " " + aa[4] + " " + aa[5];
                m2.ch = int.Parse(aa[7]);
                m2.zpc = aa[8];
                m2.zpci = int.Parse(aa[9]=="" ? "0": aa[9]);
                m2.zpco = int.Parse(aa[10] == "" ? "0" : aa[10]);              // max 13
                m2.floor = int.Parse(aa[11]) * 100 + int.Parse(aa[12]) * 10 + int.Parse(aa[13]);
                if (m2.ch == 0)
                    m2.ch = 1;
                m2.chk = 0;

                m2.ip = "";
                m2.state = "";
                m2.state_old = "";
                m2.DeviceId = 0;
            } catch (Exception e1)
            {
                m2 = null;
            }
            return m2;
        }


    }
}
