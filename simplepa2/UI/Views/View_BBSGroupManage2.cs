using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Wisej.Web;
using static simplepa2.DataSet1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DialogResult = Wisej.Web.DialogResult;
using MessageBox = Wisej.Web.MessageBox;
using MessageBoxButtons = Wisej.Web.MessageBoxButtons;
using MessageBoxIcon = Wisej.Web.MessageBoxIcon;

namespace simplepa2.UI.Views
{
    public partial class View_BBSGroupManage2 : Wisej.Web.UserControl
    {        
        // data
        public List<AssetGroupListRow> assetGroupListRowList;
        public string selectedEMNAME;

        // UI
        public Comp_GroupListBasePanel comp_GroupListBasePanel;
        public Comp_GroupDetailPanel comp_GroupDetailPanel;

        public View_BBSGroupManage2()
        {
            InitializeComponent();
        }

        #region // init 
        private void View_BBSGroupManage_Load(object sender, EventArgs e)
        {
            init();
        }

        public void init()
        {
            this.emServerTableAdapter1.Fill(this.dataSet11.EMServer);
            this.assetGroupsTableAdapter1.Fill(this.dataSet11.AssetGroups);

            comp_Site1.dataSet = gweb.dBSqlite.EMServerWithWholeColLoad(1);
            comp_Site1.reDraw();
        }

        #endregion


        #region SETUP UI 파트

        public void reDraw()
        {
            itemClear();

            if (comp_Site1.selectedItem == null) return;
            this.selectedEMNAME = comp_Site1.selectedItem;  // 선택된 EM 저장            
            AssetGroupListDataTable dt = this.assetGroupsListTableAdapter1.GetData(selectedEMNAME);
            if (dt == null) return;
            setupGroupListUI(dt);
        }



        // 화면 클리어 
        private void itemClear()
        {
            comp_UGroup1.Filter = "";
            comp_UGroup1.GroupFilter = "";
            comp_UGroup1.clear();
            comp_UGroup1.GroupUse = false;
            tb_groupName.Text = "";

            SelId = 0;
            oldId = 0;
        }

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
            reDraw();
        }


        public List<Group_DataPack> preProcessingDataFormatForGroupList(AssetGroupListDataTable groupDt)
        {
            List<Group_DataPack> groupList_Temp = new List<Group_DataPack>();

            for (int i = 0; i < groupDt.Count; i++)  // data Pack to List 
            {
                Group_DataPack gDt = new Group_DataPack();

                if (!int.TryParse(groupDt.Rows[i]["regionCount"].ToString(), out gDt.intRegionCount))
                {
                    gDt.intRegionCount = 0;
                }

                gDt.strGroupName = groupDt.Rows[i]["groupName"].ToString(); ;
                gDt.intGroupIndex = int.Parse(groupDt.Rows[i]["groupNo"].ToString());

                groupList_Temp.Add(gDt);
            }
            return groupList_Temp;
        }

        public List<Group_DataPack> group_data = new List<Group_DataPack>();  // GroupList       

        public List<Comp_GroupNameCard2> group_UI_Cardlist = new List<Comp_GroupNameCard2>();  // Group UI List

        public void setupGroupListUI(AssetGroupListDataTable groupDt)
        {
            group_data = preProcessingDataFormatForGroupList(groupDt);
            if (group_data.Count == 0) return;
            pn_GroupList.Controls.Clear();   // UI stack clear 
            group_UI_Cardlist.Clear();  // UI pointer list clear

            foreach (Group_DataPack data in group_data)
            {
                Comp_GroupNameCard2 card = new Comp_GroupNameCard2(data);
                card.ClickedEventHandler += Card_ClickedEventHandler;
                group_UI_Cardlist.Add(card);
                pn_GroupList.Controls.Add(card);
            }
        }

        int SelId = 0;
        int oldId = 0;

        private void Card_ClickedEventHandler(object sender, EventArgs e)
        {
            SelId = (int)sender;
            if (SelId == 0) return;
            if (SelId == oldId) return;
            oldId = SelId;

            // 선택된 카드외에는 리셋해주고 
            foreach (Comp_GroupNameCard2 ui in pn_GroupList.Controls)
            {
                ui.setCardStatus(false);
            }
            dispDetail();
        }
        // 카드 선택을 하면 프리셋 차일드를 우측에 보여준다.
        private void dispDetail()
        {
            add = false;
            var r1 = group_data.FirstOrDefault(p => p.intGroupIndex == SelId);
            tb_groupName.Text = r1.strGroupName;

            comp_UGroup1.Filter = this.selectedEMNAME;
            comp_UGroup1.GroupFilter = r1.strGroupName;

            comp_UGroup1.clear();
            comp_UGroup1.SetSelAssets(AssetGroupGetAssets(r1.strGroupName));
            comp_UGroup1.reDraw();
        }

        private List<AssetsRow> AssetGroupGetAssets(string strGroupName)
        {
            List<AssetsRow> list = new List<AssetsRow>();
            var rt1 = gweb.dBSqlite.Ds1.AssetGroups.Where(p => p.Name == strGroupName);

            foreach (var r in rt1)
            {
                var m1 = gweb.dBSqlite.Ds1.Assets.FirstOrDefault(p => p.AssetId == r.AssetId);
                if (m1 == null) continue;
                list.Add(m1);
            }
            return list;
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

        #region // add delete update

        bool add = false;

        private void bt_GroupAdd_Click(object sender, EventArgs e)
        {
            comp_UGroup1.clear();

            DateTime dt = DateTime.Now;
            comp_UGroup1.Filter = comp_Site1.selectedItem;
            comp_UGroup1.reDraw();
            tb_groupName.Text = comp_Site1.selectedItem + "그룹_" + dt.Minute.ToString("00") + dt.Second.ToString("00");
            //puser_name.Text = gweb.mainFrame.user_name;
            add = true;
        }

        private void bt_store_Click(object sender, EventArgs e)
        {
            if (add)
                SaveGroup();
            else
                UpdateGroup();
            reDraw();
            gweb.dBSqlite.DBInit();
            add = false;
        }

        private void UpdateGroup()
        {
            var t1 = comp_UGroup1.SelAssets();
            if (t1 == null)
            {
                return;
            }

            try
            {
                string groupName = tb_groupName.Text;
                string EMNAME = selectedEMNAME;

                this.assetGroupsTableAdapter1.DeleteAssetGroupsByAssetGroupName(groupName);

                foreach (AssetsRow iRow in t1)
                {
                    this.assetGroupsTableAdapter1.insertAssetGroupsRow(groupName, iRow.AssetId, EMNAME);
                }
            }
            catch (Exception e1)
            {
                AlertBox.Show(e1.Message);
                return;
            }
        }

        private void SaveGroup()
        {
            var t1 = comp_UGroup1.SelAssets();
            if (t1 == null)
            {
                return;
            }

            try
            {
                string groupName = tb_groupName.Text;
                string EMNAME = selectedEMNAME;

                foreach (AssetsRow iRow in t1)
                {
                    this.assetGroupsTableAdapter1.insertAssetGroupsRow(groupName, iRow.AssetId, EMNAME);
                }
            }
            catch (Exception e1)
            {
                AlertBox.Show(e1.Message);
                return;
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (tb_groupName.Text == "") return;

            try
            {
                if (MessageBox.Show(tb_groupName.Text + " 데이터를 삭제하시겠습니까?",
                    icon: MessageBoxIcon.Warning, buttons: MessageBoxButtons.YesNo) == DialogResult.No) return;
                this.assetGroupsTableAdapter1.DeleteAssetGroupsByAssetGroupName(tb_groupName.Text);
                reDraw();
                gweb.dBSqlite.DBInit();
            }
            catch (Exception ex)
            {
            }

        }
        #endregion

        /*

        private void bt_store_Click(object sender, EventArgs e)
        {
            //01. Validating 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!zone_Select_Validating())  // Assetlist 호출 포함 
                {
                    // 선택된 Assetlist 없으면 
                    return;
                }
            }
            else
            {
                AlertBox.Show("모든 필수 입력 항목을 입력하십시오");
                return;
            }

            try
            {
                string groupName = tb_groupName.Text;
                string EMNAME = this.thisEMNAME;

                if (!isFomForNew)
                {
                    this.assetGroupsTableAdapter1.DeleteAssetGroupsByAssetGroupName(thisGroupName);
                    //this.assetGroupsTableAdapter1.dele
                }

                foreach (AssetsRow iRow in this.arForSaveList)
                {
                    this.assetGroupsTableAdapter1.insertAssetGroupsRow(groupName, iRow.AssetId, EMNAME);
                }
            }
            catch (Exception e1)
            {
                AlertBox.Show(e1.Message);
                return;
            }

            gweb.mainFrame.reDraw();

            // 04. UI 초기화 
        }

        private void tb_groupName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_groupName.Text))
            {
                errorProvider1.SetError(tb_groupName, "그룹명 입력은 필수 입니다.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tb_groupName, "");
            }
        }

        private bool zone_Select_Validating()
        {
            List<AssetsRow> arForSaveList = this.czp.getAllSelectedAssetRow();

            if (arForSaveList.Count == 0)
            {
                errorProvider1.SetError(lb_zone, "최소 한개 이상의 Zone 선택은 필수 입니다.");
                return false;
            }
            else
            {
                errorProvider1.SetError(lb_zone, "");
                this.arForSaveList = arForSaveList;
            }

            return true;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택된 그룹을 삭제하시겠습니까?", "경고",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.assetGroupsTableAdapter1.DeleteAssetGroupsByAssetGroupName(this.thisGroupName);
                gweb.mainFrame.reDraw();
                this.Dispose();
            }
        }
        */
    }
}
