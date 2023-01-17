using simplepa2.UI.Components;
using simplepa2.UI.Popups;
using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCZone : Wisej.Web.UserControl
    {
        private Popup_BBCZoneForm pop_BBCZoneForm;
        private Form_BBCZoneImport form_BBCZoneImport;

        private List<Comp_ZoneBuildingPanels> buildPanelDataList;


        private string comboWholeText = "전체";
        private string strSelectRelease = "선택해제";
        private string strSelectAll = "모두선택";
        private bool bZoneSelectAll = false; 

        private bool NOT_USE_BUILDING_CHECK_BOX = false;


        public View_BBCZone()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
            // DB Call
            dbInit();

            // Combo Setup, 이후 데이터는 콤보 셋업에 따라 동작함 
            comboUISetup();


        }

        public void dbInit()
        {
            try
            {
                this.assetsTableAdapter1.Fill(this.dataSet11.Assets);
                this.emServerWithWholeColTableAdapter1.Fill(this.dataSet11.EMServerWithWholeCol);
                this.assetsSitenBuildingTableAdapter1.Fill(this.dataSet11.AssetsSitenBuilding);
            }
            catch(Exception e)
            {
                MessageBox.Show("LAW TEXT : Asset 데이터를 가져오는 중 예외발생 -"+e.Message);
            }                       
        }

        public void comboUISetup()
        {
            // cb_SiteName
            comp_Site1.dataSet = gweb.mainFrame.dBSqlite.EMServerWithWholeColLoad();
            comp_Site1.reDraw();
            
        }

        /* 로딩 버튼을 누른경우 */
        private void bt_SelectLoading_Click(object sender, EventArgs e)
        {
            dbInit();

            comboUISetup();
        }

        private List<Comp_ZoneBuildingPanels> buildingDataUISetup(string selectedItem, bool isCheckBoxSetup)
        {
            List<Comp_ZoneBuildingPanels> dataList = new List<Comp_ZoneBuildingPanels>();

            // 빌딩 데이터 가져오기
            DataRow[] buildList;
            
            if(selectedItem.Equals("전체"))
            {
                buildList = this.dataSet11.AssetsSitenBuilding.Select();
            }
            else
            {
                buildList = this.dataSet11.AssetsSitenBuilding.Select("emServer = '" + selectedItem + "'");
            }
            
            
            // 기존 패널 클리어
            this.pn_Contents.Controls.Clear();

            // 각 빌딩 데이터 셋을 Building UI에 넣고 Panel에 생성 
            foreach (DataRow dr in buildList)
            {
                string buildName = (dr as DataSet1.AssetsSitenBuildingRow).building;
                Comp_ZoneBuildingPanels uiCZB = new Comp_ZoneBuildingPanels(buildName, this.dataSet11.Assets.Select("building = '" + buildName + "'"), NOT_USE_BUILDING_CHECK_BOX);

                dataList.Add(uiCZB);                

                this.pn_Contents.Controls.Add(uiCZB);
                this.pn_Contents.Controls.Add(new Comp_GroupNameSpacer());

            }

            return dataList;
        }        

        private void popTestButton_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.pop_BBCZoneForm == null)
                this.pop_BBCZoneForm = new Popup_BBCZoneForm()
                {
                    Alignment = Placement.BottomRight
                };

            if (this.pop_BBCZoneForm.Visible)
                this.pop_BBCZoneForm.Close();
            else
                this.pop_BBCZoneForm.ShowPopup(this);

        }


        private void bt_WholeSelect_Click(object sender, EventArgs e)
        {
            bZoneSelectAll = !bZoneSelectAll;
            /*
            if(bZoneSelectAll == true)
            {
                foreach (Comp_ZoneFloorCardList zoneCard in cardList)
                {
                    zoneCard.ch_floor_ChangeToChecked();
                    this.bt_WholeSelect.Text = strSelectRelease;
                }
            }
            else
            {
                foreach (Comp_ZoneFloorCardList zoneCard in cardList)
                {
                    zoneCard.ch_floor_ChangeToUnChecked();
                    this.bt_WholeSelect.Text = strSelectAll;
                }
            }
            */
        }

        private void bt_StoreData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO : Zone 추가 삭제된 내용을 Database에 저장하고 시스템에 반영합니다.");
        }

        

        private void bt_ImportCSV_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.form_BBCZoneImport == null)
            {
                this.form_BBCZoneImport = new Form_BBCZoneImport();                
                this.form_BBCZoneImport.Closed += new System.EventHandler(this.Form_BBCZoneImport_Disposed);
                //this.form_BBCZoneImport.Disposed += new Form
                this.form_BBCZoneImport.ShowDialog();
            }
            else
            {
                this.form_BBCZoneImport.ShowDialog();
            }      

        }

        private void Form_BBCZoneImport_Disposed(object sender, EventArgs e)
        {
            gweb.mainFrame.reDraw();
        }

        private void bt_dataDelete_Click(object sender, EventArgs e)
        {
            DeleteAllZoneRecord();
        }


        private void View_BBCZone_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedItem = null;

            if (sender == null)
                return;

            try
            {
                selectedItem = sender.ToString();
            }
            catch (Exception e2)
            {
                AlertBox.Show("LAW TEXT : 예외 " + this.ToString() +  e2.ToString());
                selectedItem = null;
                return;
            }

            this.assetsSitenBuildingTableAdapter1.Fill(this.dataSet11.AssetsSitenBuilding);
            this.buildPanelDataList = buildingDataUISetup(selectedItem, NOT_USE_BUILDING_CHECK_BOX);

        }

        private void DeleteAllZoneRecord()
        {
            try
            {                
                   if (MessageBox.Show("모든 선번 및 관련 데이터를 모두 삭제하시겠습니까?",
                        icon: MessageBoxIcon.Warning, buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                    assetPresetGroupsTableAdapter1.DeleteAllQuery();
                    assetGroupsTableAdapter1.DeleteAllQuery();
                    assetsTableAdapter1.DeleteAllQuery();
                    bsTreeTableAdapter1.DeleteAllQuery();
                    emServerTableAdapter1.DeleteAllQuery();
                    
                }                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
            }

            // DB Call, Application 전체 Drawing 필요
            gweb.mainFrame.reDraw();
        }
    }
}
