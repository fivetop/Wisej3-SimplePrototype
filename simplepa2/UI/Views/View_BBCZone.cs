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


        public View_BBCZone()
        {
            InitializeComponent();

            // DB Call
            dbInit();

            // Combo Setup
            comboUISetup();

            // List Setup 
            // zone_list = new List<Zone_DataList>();
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
            cb_SiteName.DataSource = this.dataSet11.EMServerWithWholeCol;            
            this.cb_SiteName.SelectedIndex = 0;
        }

        /* 로딩 버튼을 누른경우 */
        private void bt_SelectLoading_Click(object sender, EventArgs e)
        {
            dbInit();

            comboUISetup();
        }
        /*  콤보 돌린 경우 */
        private void cb_SiteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem;

            if (dataSet11.EMServerWithWholeCol.Count == 0)
                return;

            try {
                selectedItem =(((this.cb_SiteName.SelectedItem as DataRowView).Row) as DataSet1.EMServerWithWholeColRow).EMNAME;
            } catch (Exception e2)
            {
                selectedItem = null;
                return;
            }

            this.assetsSitenBuildingTableAdapter1.Fill(this.dataSet11.AssetsSitenBuilding);
            this.buildPanelDataList = buildingDataUISetup(selectedItem);
        }

        private List<Comp_ZoneBuildingPanels> buildingDataUISetup(string selectedItem)
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
                Comp_ZoneBuildingPanels uiCZB = new Comp_ZoneBuildingPanels(buildName, this.dataSet11.Assets.Select("building = '" + buildName + "'"));

                dataList.Add(uiCZB);

                this.pn_Contents.Controls.Add(uiCZB);
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
                this.form_BBCZoneImport.Disposed += new System.EventHandler(this.formDisposed);
                this.form_BBCZoneImport.FormClosed += Form_BBCZoneImport_FormClosed;
                this.form_BBCZoneImport.ShowDialog();
            }
            else
            {
                this.form_BBCZoneImport.ShowDialog();
            }      

        }

        private void Form_BBCZoneImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbInit();
            comboUISetup();
        }

        private void formDisposed(object sender, EventArgs e)
        {
            dbInit();
            comboUISetup();
        }

        private void bt_dataDelete_Click(object sender, EventArgs e)
        {
            DeleteAllZoneRecord();
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

            // DB Call
            dbInit();
 
        }

    }
}
