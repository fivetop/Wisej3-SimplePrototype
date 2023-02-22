using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_ZoneBasePanel : Wisej.Web.UserControl
    {
        private List<Comp_ZoneBuildingPanels> buildPanelDataList;
        

        public Comp_ZoneBasePanel()
        {
            InitializeComponent();            
        }     

        public void buildingDataUISetup(string selectedItem, bool isCheckBoxSetup, bool isZoneAddButton)
        {

            this.assetsTableAdapter1.Fill(this.dataSet11.Assets);
            this.assetsSitenBuildingTableAdapter1.Fill(this.dataSet11.AssetsSitenBuilding);

            this.pn_ZoneArea.Controls.Clear();

            List<Comp_ZoneBuildingPanels> dataList = new List<Comp_ZoneBuildingPanels>();

            // 빌딩 데이터 가져오기
            DataRow[] buildList;

            if (selectedItem.Equals("전체"))
            {
                buildList = this.dataSet11.AssetsSitenBuilding.Select();
            }
            else
            {
                buildList = this.dataSet11.AssetsSitenBuilding.Select("emServer = '" + selectedItem + "'");
            }


            // 기존 패널 클리어
           // this.pn_Contents.Controls.Clear();

            // 각 빌딩 데이터 셋을 Building UI에 넣고 Panel에 생성 
            foreach (DataRow dr in buildList)
            {
                string buildName = (dr as DataSet1.AssetsSitenBuildingRow).building;
                Comp_ZoneBuildingPanels uiCZBP = new Comp_ZoneBuildingPanels(this, buildName, this.dataSet11.Assets.Select("building = '" + buildName + "'"), isCheckBoxSetup, isZoneAddButton);

                dataList.Add(uiCZBP);

                this.pn_ZoneArea.Controls.Add(uiCZBP);
                this.pn_ZoneArea.Controls.Add(new Comp_GroupNameSpacer());

            }

            this.buildPanelDataList = dataList;                  
        }

        
    }
}
