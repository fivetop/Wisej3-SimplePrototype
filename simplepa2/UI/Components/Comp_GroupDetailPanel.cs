using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{
    public partial class Comp_GroupDetailPanel : Wisej.Web.UserControl
    {
        public AssetGroupsDataTable dt = null;
        public string thisEMNAME;
        public string thisGroupName;
        public Comp_ZoneBasePanel czp;
        List<AssetsRow> arForSaveList;

        public bool isFomForNew = false;


        public Comp_GroupDetailPanel()
        {
            InitializeComponent();
        }

        public Comp_GroupDetailPanel(AssetGroupsDataTable dt)
        {
            InitializeComponent();
            this.dt = dt;            
        }

        public void setGroupUIWithGroupName(string groupName, string EMNAME)
        {
            //AlertBox.Show(groupName + " 이 클릭되었습니다);");
            this.thisEMNAME = EMNAME;
            this.thisGroupName = groupName;

            tb_groupName.Text = groupName;
            setComboEMNAME(EMNAME);
            this.cb_emname.Enabled = false;

            
            this.pn_zone.Controls.Clear(); // 삭제 후             

            czp = new Comp_ZoneBasePanel();
            this.pn_zone.Controls.Add(czp); // 재 생성 
            czp.buildingDataUISetup(EMNAME, true,  false);

            List<int> assetIdList = getAssetIDListByGroupName(groupName);
            // 선택된 그룹으로 그룹 선택 setup 
            czp.setAssetSelectedByAssetID(assetIdList);
        }

        public void setGroupUIForNew(string EMNAME)
        {         
            this.thisEMNAME = EMNAME;
            tb_groupName.Text = "신규 그룹 생성";

            setComboEMNAME(EMNAME);
            this.cb_emname.Enabled = false;

            Comp_ZoneBasePanel czp = new Comp_ZoneBasePanel();
            this.pn_zone.Controls.Clear(); // 삭제 후 
            this.pn_zone.Controls.Add(czp); // 재 생성 
            czp.buildingDataUISetup(EMNAME, true, false);
            
        }

        public List<int> getAssetIDListByGroupName(string groupName)
        {
            DataRow[] assetIDList = dt.Select("Name = '" + groupName + "'");
            List<int> assetIdList = new List<int>();
            foreach (AssetGroupsRow assetID in assetIDList)
            {
                assetIdList.Add(assetID.AssetId);
            }
            return assetIdList;

        }

        public void setComboEMNAME(string EMNAME)
        {
            this.cb_emname.Text = EMNAME;
        }


        private void Comp_GroupDetailPanel_Load(object sender, EventArgs e)
        {
            this.emServerTableAdapter1.Fill(this.dataSet11.EMServer);
            this.cb_emname.DataSource = this.dataSet11.EMServer;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            setGroupUIWithGroupName(this.thisGroupName, this.thisEMNAME);
        }

        private void bt_store_Click(object sender, EventArgs e)
        {
            //01. Validating 
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
               if(!zone_Select_Validating())  // Assetlist 호출 포함 
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
            catch(Exception e1)
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

            if(arForSaveList.Count == 0)
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
            if(MessageBox.Show("선택된 그룹을 삭제하시겠습니까?", "경고", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.assetGroupsTableAdapter1.DeleteAssetGroupsByAssetGroupName(this.thisGroupName);
                gweb.mainFrame.reDraw();
                this.Dispose();
            }
        }
    }
}
