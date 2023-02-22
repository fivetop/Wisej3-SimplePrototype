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
        private Comp_ZoneBasePanel comp_ZoneBasePanel;

        private List<Comp_ZoneBuildingPanels> buildingPanelPointerList;


        private string comboWholeText = "전체";
        private string strSelectRelease = "선택해제";
        private string strSelectAll = "모두선택";
        private bool bZoneSelectAll = false;

        private bool ZONE_CHECK_BOX_VISIBLE = true;
        private bool ZONE_CHECK_BOX_UNVISIBLE = false;

        private bool ZONE_LIST_WITH_ADD_BUTTON = true;
        private bool ZONE_LIST_WITH_NO_ADD_BUTTON = false;

        public View_BBCZone()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
            // DB Call for Combo only 
            dbInit();

            // Combo Setup, 이후 데이터는 콤보 셋업에 따라 동작함 
            comboUISetup();

            // Zone Base 로드 
            zoneUISetup();

        }

        public void dbInit()
        {
            try
            {                
                this.emServerWithWholeColTableAdapter1.Fill(this.dataSet11.EMServerWithWholeCol);             
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

        public void zoneUISetup()
        {
            if(comp_ZoneBasePanel == null)
            {
                comp_ZoneBasePanel = new Comp_ZoneBasePanel();
            }
            this.pn_Contents.Controls.Add(comp_ZoneBasePanel);
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

        /* 로딩 버튼을 누른경우 */
        private void bt_SelectLoading_Click(object sender, EventArgs e)
        {
            dbInit();

            comboUISetup();
        }

        private void buildingDataUISetup(string selectedItem, bool isCheckBoxSetup, bool isAddButtonSetup)
        {
            if(comp_ZoneBasePanel == null)
            {
                comp_ZoneBasePanel = new Comp_ZoneBasePanel();
            }

           comp_ZoneBasePanel.buildingDataUISetup(selectedItem, isCheckBoxSetup, isAddButtonSetup);               
            
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
            
            buildingDataUISetup(selectedItem, ZONE_CHECK_BOX_UNVISIBLE, ZONE_LIST_WITH_NO_ADD_BUTTON);

        }


    }
}
