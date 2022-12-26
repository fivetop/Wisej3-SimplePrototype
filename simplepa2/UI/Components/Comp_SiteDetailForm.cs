using simplepa2.UI.Popups;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_SiteDetailForm : Wisej.Web.UserControl
    {
        /*===========  데이터 바인딩 프로퍼티 ===========  */
        // 선택된 사이트 한개의 일반 정보 
        private DataSet1.spa_siteRow currentSiteDataSet;

        // 사이트에서 관리하는 E.M의 장비를 매칭하는 Device List 
        private DataRow[] deviceDataDR;

        // 사이트의 모든 빌딩 정보 
        private DataSet1.spa_bd_structDataTable dsBuildingListDataTable;

        // 사이트의 빌딩 층정보 상세 테이블 
        private DataSet1.siteDataDetailDataTable dsAllBuildingFloorDetailDataTable;

        /*===========  UI  바인딩 프로퍼티 ===========  */
        // 빌딩의 플로어 편집 팝업
        private Popup_BBCSiteForm popup_BBCSiteForm;

        /*===========  파일업로드 관련 프로퍼티 ===========  */
        private string strFileUploadPath =@"C:\SimplePA2" + "\\Uploaded_Files\\";
        private Stream fileStream;
        private String uploadFilename;
        private HttpPostedFile httpFileCol; 
    

        private void pic_upload_Uploaded(object sender, UploadedEventArgs e)
        {
            if (e.Files.Count == 0)
                return;

            httpFileCol = e.Files[0];
            LoadImage(e.Files[0]);
        }

        public Comp_SiteDetailForm(int site_index, DataRow siteDataSet, 
            DataSet1.spa_bd_structDataTable buildingsList, DataSet1.siteDataDetailDataTable floorDataList,
            DataRow[] deviceDataTable)
        {
            InitializeComponent();
            
            this.currentSiteDataSet = siteDataSet as DataSet1.spa_siteRow;
            this.dsBuildingListDataTable = buildingsList;
            this.dsAllBuildingFloorDetailDataTable = floorDataList;
            this.deviceDataDR = deviceDataTable;

            initUI(site_index);
        }

        public void initUI(int site_index)
        {
            // 사이트 일반정보 로드
            tb_siteAddr.Text = currentSiteDataSet.site_address;
            tb_siteName.Text = currentSiteDataSet.site_name;
            tb_siteDescrip.Text = currentSiteDataSet.site_description;
            tb_siteContact.Text = currentSiteDataSet.site_contact;
            cb_emServer.DataSource = deviceDataDR;                  
            
            
            // Combo 위치를 저장된 데이터로 돌려주기 
            foreach (DataSet1.DeviceRow singleDevice in deviceDataDR)
            {
                if (singleDevice.DeviceId == currentSiteDataSet.em_device_id)
                {
                    cb_emServer.SelectedItem = singleDevice;
                }
            }

            // 사이트의 이미지 설정 + 업로드된 이미지의 위치와 이미지명 
            if (currentSiteDataSet.site_images == null)
            {
                this.pb_sitePreImage.ImageSource = "Images\\site_image_none.png";
            }
            else
            {
                this.pb_sitePreImage.ImageSource = currentSiteDataSet.site_images;
            }

            // 사이트의 빌딩 정보 로드해서 아래의 표에 넣어주기
            //   DataRow[] dataRowArray = this.dataSet11.spa_site.Select("site_index = '" + site_index + "'");
            DataRow[] siteBuidlingRowArray = this.dsBuildingListDataTable.Select("refer_site_id= '" + site_index + "'");
            this.dg_buildingStruct.DataSource = siteBuidlingRowArray;

        }

        public void setImages(string imagePath)
        {

        }
        private void bt_deletePic_Click(object sender, EventArgs e)
        {
            this.pb_sitePreImage.ImageSource = "Images\\site_image_none.png";
            this.currentSiteDataSet.site_images = "";
        }

        public void initUIBySiteData(int site_index, DataRow siteDataSet)
        {
            this.currentSiteDataSet = siteDataSet as DataSet1.spa_siteRow;
            initUI(site_index);
        }

        private void bt_newBuilding_Click(object sender, EventArgs e)
        {
            // 빌딩 팝업 열고
            openBBCSiteFromPopup();

            // 폼 클린 해줌
            this.popup_BBCSiteForm.setupUItoNewForm();
        }

        private void bt_selectBuildDelete_Click(object sender, EventArgs e)
        {
            var dgv = this.dg_buildingStruct;

            var selectedIndexCount = dgv.SelectedRows.Count;

            // 그리드에서 한개를 눌렀을 경우 해당 데이터의 팝업을 열어줌 
            if(selectedIndexCount == 1)
            {                
                var r1 = dgv.Rows[0];
                openSiteFloorPopupWithDataGridIndex(r1.DataBoundItem as DataSet1.spa_bd_structRow);
            }            
        }

        /*  빌딩 정보 그리드에서 마우스 클릭이 들어올 경우 */
        private void dg_buildingStruct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            // 01. Grid 데이터를 찾고
            var dgv = (DataGridView)sender;
            var r1 = dgv.Rows[e.RowIndex];
            openSiteFloorPopupWithDataGridIndex(r1.DataBoundItem as DataSet1.spa_bd_structRow);


        }

        private void openSiteFloorPopupWithDataGridIndex(DataSet1.spa_bd_structRow boundingData)
        {
            DataSet1.spa_bd_structRow structRow = boundingData;

            // 02. 층 데이터를 편집
            DataRow[] drBuildingFloorData = this.dsAllBuildingFloorDetailDataTable.Select("refer_bd_id= '" + structRow.bd_id + "'");

            // 03. 팝업 열고
            openBBCSiteFromPopup();

            // 04. Popup 객체에 사전 셋업 
            popup_BBCSiteForm.setupUIwithData(structRow, drBuildingFloorData);

        }

        /* 빌딩 상세 내역 + Floor 데이터를 편집하는 팝업 열기*/
        public void openBBCSiteFromPopup()
        {
            // show the popup.
            if (this.popup_BBCSiteForm == null)
                this.popup_BBCSiteForm = new Popup_BBCSiteForm()
                {
                    Alignment = Placement.BottomRight,
                    Height = this.Parent.Parent.Height
                };

            if (this.popup_BBCSiteForm.Visible)
                this.popup_BBCSiteForm.Close();
            else
            {                
                this.popup_BBCSiteForm.Height = this.Parent.Parent.Parent.Parent.Parent.Height;
                this.popup_BBCSiteForm.ShowPopup(this.Parent.Parent.Parent.Parent);
            }

        }

        private void bt_store_Click(object sender, EventArgs e)
        {
            //this.currentSiteDataSet
        }

        public void setupNewSiteGeneration()
        {
            MessageBox.Show("신규 생성을 위한 폼 초기화");
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

        private void LoadImage(HttpPostedFile file)
        {
            //is.labelChoose.Hide();
            this.pic_upload.Value = file.FileName;
            this.pb_sitePreImage.Image = new Bitmap(Image.FromStream(file.InputStream));
        }

    }
}
