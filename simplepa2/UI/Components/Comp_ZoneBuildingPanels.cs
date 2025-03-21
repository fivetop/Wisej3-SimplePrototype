﻿using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{    
    public partial class Comp_ZoneBuildingPanels : Wisej.Web.UserControl
    {
        public string siteName = "";
        public string buildingName = "";
        // original  data
        private DataRow[] buildList;

        private object dockObject;

        // 1차 가공 데이터
        private List<Zone_DataList> zoneFloorDataList = new List<Zone_DataList>();

        // UI 접근 및 컨트롤 포인터
        private List<Comp_ZoneFloorCardList> zoneFloorCardUIList = new List<Comp_ZoneFloorCardList>();

        private bool ZONE_LIST_ADD_BUTTON_SETUP = true;        


        public Comp_ZoneBuildingPanels()
        {
            InitializeComponent();
        }

        public Comp_ZoneBuildingPanels(object popupDockObject, string buildingName, DataRow[] buildList, bool isCheckUse, bool isZoneAddButton)
        {
            InitializeComponent();

            this.dockObject = popupDockObject;  // 팝업용 포인터

            this.buildList = buildList;

            this.ZONE_LIST_ADD_BUTTON_SETUP = isZoneAddButton;

            // inital UI 

            lb_buildingName.Text = buildingName;            

            /* Label 과 체크박스 위치 */
            var hSize = this.Height / 2;
            this.lb_buildingName.Location = new System.Drawing.Point(-1, hSize - 25);
            this.ch_building.Location = new System.Drawing.Point(11, hSize);
            ch_building.Visible = isCheckUse;

            this.zoneFloorDataList = prepareFloorZoneData(buildList);            

            setupUICardData(zoneFloorDataList, isCheckUse);
            
        }

        public Comp_ZoneBuildingPanels(object popupDockObject, string siteName, string buildingName, DataRow[] buildList, bool isCheckUse, bool isZoneAddButton)
        {
            InitializeComponent();

            this.siteName = siteName;
            this.buildingName = buildingName;
            this.dockObject = popupDockObject;  // 팝업용 포인터

            this.buildList = buildList;

            this.ZONE_LIST_ADD_BUTTON_SETUP = isZoneAddButton;

            // inital UI 

            lb_buildingName.Text = buildingName;

            /* Label 과 체크박스 위치 */
            var hSize = this.Height / 2;
            this.lb_buildingName.Location = new System.Drawing.Point(-1, hSize - 25);
            this.ch_building.Location = new System.Drawing.Point(11, hSize);
            ch_building.Visible = isCheckUse;

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

                if (drType.emServer != siteName && siteName != "전체") continue;
                // 첫번째 경우 플로어 정보 일단 저장
                string dataFloorName = drType.floorname;

                Zone_DataList zDresult = zoneList.Find(x => x.floorName == dataFloorName && x.path == drType.path);

                if(zDresult == null)
                {
                    Zone_DataList zdData = new Zone_DataList();
                    zdData.path = drType.path;
                    zdData.floorName = dataFloorName;
                    zdData.zoneListArray.Add(drType);
                    zoneList.Add(zdData);
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
                Comp_ZoneFloorCardList com_zfc = new Comp_ZoneFloorCardList(this.dockObject, zoneFloorData, ZONE_LIST_ADD_BUTTON_SETUP, isCheckBoxUse);
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

        private void ch_building_CheckedChanged(object sender, EventArgs e)
        {
            var buildChecked = (sender as CheckBox).Checked;

            foreach (Comp_ZoneFloorCardList zoneFC in zoneFloorCardUIList)
            {
                if (buildChecked)
                {
                    zoneFC.ch_floor_ChangeToChecked();
                }
                else
                {
                    zoneFC.ch_floor_ChangeToUnChecked();
                }
            }

        }

        public List<AssetsRow> getAllSelectedAssetsRowInBuilding()
        {
            List<AssetsRow> packBuildingAssetRow = new List<AssetsRow>();

            foreach (Comp_ZoneFloorCardList zoneFC in zoneFloorCardUIList)
            {
                List<AssetsRow> tempList = zoneFC.getSelectedAssetRowInFloor();

                if(tempList.Count > 0)
                {
                    packBuildingAssetRow.AddRange(tempList);
                }
            }
            return packBuildingAssetRow;
        }

        public void setAssetsRowSelectedByID(List<int> assetID)
        {
            foreach (Comp_ZoneFloorCardList zoneFC in zoneFloorCardUIList)
            {
                zoneFC.setAssetRowSelectedByAssetId(assetID);
            }

            return;

        }

    }

    }

    public class Zone_DataList
    {
        public string path;
        public string floorName;
        public List<simplepa2.DataSet1.AssetsRow> zoneListArray = new List<simplepa2.DataSet1.AssetsRow>();
    }

