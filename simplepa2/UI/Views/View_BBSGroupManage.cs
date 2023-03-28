using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_BBSGroupManage : Wisej.Web.UserControl
    {        
        // data
        public List<AssetGroupListRow> assetGroupListRowList;

        public string selectedEMNAME;

        // UI
        public Comp_GroupListBasePanel comp_GroupListBasePanel;

        public Comp_GroupDetailPanel comp_GroupDetailPanel;

        



        public View_BBSGroupManage()
        {
            InitializeComponent();
        }


        #region SETUP UI 파트

        public void reDraw()
        {            
            // 01. Combo Setup
            this.emServerTableAdapter1.Fill(this.dataSet11.EMServer);            
            this.cb_SiteName.DataSource = this.dataSet11.EMServer;
            this.assetGroupsTableAdapter1.Fill(this.dataSet11.AssetGroups);

            // 02. Group List Call and Setup // l로그인 유저는 추가 변경 필요 
            //group_data = getGroupListFromDBBySiteName(cb_SiteName.Text);
            //assetGroupsTableAdapter1.GetGroupListByEmname(

            
            //setupGroupListUI(group_data);
        }


        private void View_BBSGroupManage_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        private void cb_SiteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AlertBox.Show(cb_SiteName.SelectedItem as  " 선택되었습니다");
            //selectedSiteName = (((sender as ComboBox).SelectedItem as DataRowView).Row as DataSet1.EMServerRow).EMNAME;
            try
            {
                if (cb_SiteName.SelectedItem == null)
                    return;

                string emName = ((cb_SiteName.SelectedItem as DataRowView).Row as DataSet1.EMServerRow).EMNAME;

                this.selectedEMNAME = emName;  // 선택된 EM 저장            

                AssetGroupListDataTable dt = this.assetGroupsListTableAdapter1.GetData(emName);

                setupUIGroupList(dt);
            } 
            catch(Exception e1)
            {
                return;
            }

        }

        private void setupUIGroupList(AssetGroupListDataTable dt)
        {
            if (dt == null)
                return;

            if(comp_GroupListBasePanel == null)
            {
                comp_GroupListBasePanel = new Comp_GroupListBasePanel();
                comp_GroupListBasePanel.GroupCardClicked += Comp_GroupList_Selected;
                pn_GroupList.Controls.Add(comp_GroupListBasePanel);
            }

            comp_GroupListBasePanel.setupGroupListUI(dt);                
        }

        private void Comp_GroupList_Selected(object sender, CompBBSGroupListClickedEventArgs e)
        {   
            if(comp_GroupDetailPanel == null || comp_GroupDetailPanel.IsDisposed)
            {
                comp_GroupDetailPanel = new Comp_GroupDetailPanel(this.dataSet11.AssetGroups);
                pn_GroupDetails.Controls.Add(comp_GroupDetailPanel);
            }

            comp_GroupDetailPanel.isFomForNew = false;
            comp_GroupDetailPanel.setGroupUIWithGroupName(e.groupName, this.selectedEMNAME);
        }
        #endregion

        private void bt_GroupAdd_Click(object sender, EventArgs e)
        {
            if (comp_GroupDetailPanel == null || comp_GroupDetailPanel.IsDisposed)
            {
                comp_GroupDetailPanel = new Comp_GroupDetailPanel(this.dataSet11.AssetGroups);                
                pn_GroupDetails.Controls.Add(comp_GroupDetailPanel);
            }

            comp_GroupDetailPanel.isFomForNew = true;
            comp_GroupDetailPanel.setGroupUIWithGroupName("", this.selectedEMNAME);

        }
    }


}
