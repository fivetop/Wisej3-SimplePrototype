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
        private DataSet1.EMServerNDeviceNameRow currentSiteDataSet;

        // 사이트에서 관리하는 E.M의 장비를 매칭하는 Device List 
        private DataRow[] deviceDataDR;

        // 사이트의 모든 빌딩 정보 
        private DataSet1.spa_bd_structDataTable dsBuildingListDataTable;

        // 사이트의 빌딩 층정보 상세 테이블 
        //private DataSet1.siteDataDetailDataTable dsAllBuildingFloorDetailDataTable;

        /*===========  UI  바인딩 프로퍼티 ===========  */
        // 빌딩의 플로어 편집 팝업
        private Popup_BBCSiteForm popup_BBCSiteForm;

        /*===========  파일업로드 관련 프로퍼티 ===========  */        
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

        public Comp_SiteDetailForm(DataRow siteDataSet)
        {
            InitializeComponent();

            this.currentSiteDataSet = siteDataSet as DataSet1.EMServerNDeviceNameRow;

            initUI();
        }

        public void initUI()
        {
            // 사이트 일반정보 로드
            tb_siteAddr.Text = currentSiteDataSet.em_address;
            tb_emName.Text = currentSiteDataSet.DeviceName;
            tb_siteDescrip.Text = currentSiteDataSet.em_description;
            tb_siteName.Text = currentSiteDataSet.EMNAME;

            // 사이트의 이미지 설정 + 업로드된 이미지의 위치와 이미지명 
            if (currentSiteDataSet.em_images == null)
            {
                this.pb_sitePreImage.ImageSource = "Images\\site_image_none.png";
            }
            else
            {
                this.pb_sitePreImage.ImageSource = currentSiteDataSet.em_images;
            }
        }

        public void setImages(string imagePath)
        {

        }
        private void bt_deletePic_Click(object sender, EventArgs e)
        {
            this.pb_sitePreImage.ImageSource = "Images\\site_image_none.png";
            this.currentSiteDataSet.em_images = "";
        }

        public void initUIBySiteData(DataRow siteDataSet)
        {
            this.currentSiteDataSet = siteDataSet as DataSet1.EMServerNDeviceNameRow;
            initUI();
        }

        private void bt_newBuilding_Click(object sender, EventArgs e)
        {
            // 빌딩 팝업 열고
            openBBCSiteFromPopup();

            // 폼 클린 해줌
            this.popup_BBCSiteForm.setupUItoNewForm();
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
            //DataRow[] drBuildingFloorData = this.dsAllBuildingFloorDetailDataTable.Select("refer_bd_id= '" + structRow.bd_id + "'");

            // 03. 팝업 열고
            openBBCSiteFromPopup();

            // 04. Popup 객체에 사전 셋업 
            //popup_BBCSiteForm.setupUIwithData(structRow, drBuildingFloorData);

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
