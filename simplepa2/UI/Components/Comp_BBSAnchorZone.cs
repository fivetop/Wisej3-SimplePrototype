using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{
    public partial class Comp_BBSAnchorZone : Wisej.Web.UserControl
    {
        private Comp_ZoneBasePanel comp_ZoneBasePanel;


        public Comp_BBSAnchorZone()
        {
            InitializeComponent();
        }        

        public void reDraw()
        {
            dbInit();

            comboUISetup();

            zoneUISetup();
        }

        public void dbInit()
        {
            try
            {
                this.emServerTableAdapter1.Fill(this.dataSet11.EMServer);
            }
            catch (Exception e)
            {
                MessageBox.Show("LAW TEXT : EMSERVER 데이터를 가져오는 중 예외발생 " + e.Message);
            }
        }

        public void comboUISetup()
        {
            // cb_SiteName
            comp_Site1.DataSource = this.dataSet11.EMServer;
            // cb_ group List  
            // cb_groupList.DataSource = this.dataSet11

        }

        public void zoneUISetup()
        {
            if (comp_ZoneBasePanel == null)
            {
                comp_ZoneBasePanel = new Comp_ZoneBasePanel();
            }
            this.pn_Contents.Controls.Add(comp_ZoneBasePanel);

            comp_Site1_SelectedIndexChanged(this.comp_Site1, null);
        }

        private void comp_Site1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSiteName= null;

            if (sender == null)
                return;

            try
            {                
                selectedSiteName = (((sender as ComboBox).SelectedItem as DataRowView).Row as DataSet1.EMServerRow).EMNAME;             

            }
            catch (Exception e2)
            {
                AlertBox.Show("LAW TEXT : 예외 " + this.ToString() + e2.ToString());
                selectedSiteName = null;
                return;
            }

            if(comp_ZoneBasePanel != null)
                comp_ZoneBasePanel.buildingDataUISetup(selectedSiteName, true, false);   // check box setup : true, add button setup : false
           
        }

        private void bt_WholeSelect_Click(object sender, EventArgs e)
        {
            List<AssetsRow> allSelectedAssetsRowList = comp_ZoneBasePanel.getAllSelectedAssetRow();

            String selectedAssetName = "SELECTED ASSETSROW LIST >> ";
            int count = 1;
            foreach (AssetsRow assetRow in allSelectedAssetsRowList)
            {
                selectedAssetName += "Count : " + count + ", " + assetRow.ZoneName + "/ ";
                count++;
            }
            MessageBox.Show(selectedAssetName);
        }

        public List<AssetsRow> getSelectedAssetList()
        {
            return comp_ZoneBasePanel.getAllSelectedAssetRow();
        }

        private void Comp_BBSAnchorZone_Load(object sender, EventArgs e)
        {
            reDraw();
        }
    }
}
