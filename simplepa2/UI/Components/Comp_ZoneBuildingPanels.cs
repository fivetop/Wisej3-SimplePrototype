using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;

namespace simplepa2.UI.Components
{    
    public partial class Comp_ZoneBuildingPanels : Wisej.Web.UserControl
    {
        // original  data
        private DataRow[] buildList;

        // 1차 가공 데이터
        private List<Zone_DataList> zoneFloorDataList = new List<Zone_DataList>();

        // UI 접근 및 컨트롤 포인터
        private List<Comp_ZoneFloorCardList> zoneFloorCardUIList = new List<Comp_ZoneFloorCardList>();

        private bool ZONE_LIST_WITH_ADD_BUTTON = true;
        private bool ZONE_LIST_WITHOUT_ADD_BUTTON = false;
        private bool ZONE_CHECK_BOX_VISIBLE = false;        


        public Comp_ZoneBuildingPanels()
        {
            InitializeComponent();
        }

        public Comp_ZoneBuildingPanels(string buildingName, DataRow[] buildList, bool isCheckUse)
        {
            InitializeComponent();

            this.buildList = buildList;

            lb_buildingName.Text = buildingName;

            ch_floor.Visible = isCheckUse;

            this.zoneFloorDataList = prepareFloorZoneData(buildList);            

            setupUICardData(zoneFloorDataList, isCheckUse);
            
        }

        public List<Zone_DataList> prepareFloorZoneData(DataRow[] assetsSpecificBuildingList)
        {
            List<Zone_DataList> zoneList = new List<Zone_DataList>();

            if (assetsSpecificBuildingList == null)
                return null;

            foreach (DataRow dr in assetsSpecificBuildingList)
            {
                // 형변환 
                DataSet1.AssetsRow drType = (dr as DataSet1.AssetsRow);

                // 첫번째 경우 플로어 정보 일단 저장
                string dataFloorName = drType.floorname;

                Zone_DataList zDresult = zoneList.Find(x => x.floorName == dataFloorName);

                if(zDresult == null)
                {
                    Zone_DataList zdData = new Zone_DataList();
                    zdData.floorName = dataFloorName;
                    zdData.zoneListArray.Add(drType);
                    zoneList.Add(zdData);
                }
                else
                {
                    zDresult.zoneListArray.Add(drType);
                }
            }

            return zoneList;
        }

        public void setupUICardData(List<Zone_DataList> zoneFloorDataList, bool isCheckBoxUse)
        {
            this.Height = 0;
            pn_FloorZone.Controls.Clear();

            int index = 0;
            foreach(Zone_DataList zoneFloorData in zoneFloorDataList)
            {
                Comp_ZoneFloorCardList com_zfc = new Comp_ZoneFloorCardList(zoneFloorData, ZONE_LIST_WITHOUT_ADD_BUTTON, isCheckBoxUse);
                // 필요시 이벤트 추가 등록 후 
                index++;

                // UI 접근자 저장
                zoneFloorCardUIList.Add(com_zfc);

                // UI 추가 
                pn_FloorZone.Controls.Add(com_zfc);

                this.Height += com_zfc.Height;
                //this.Height += com_zfc.Height + 20;  //20 spacer height
            }
        }
    }

    }

    public class Zone_DataList
    {        
        public string floorName;
        public List<simplepa2.DataSet1.AssetsRow> zoneListArray = new List<simplepa2.DataSet1.AssetsRow>();
    }

