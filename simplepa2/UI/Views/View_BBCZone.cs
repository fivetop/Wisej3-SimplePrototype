using simplepa2.UI.Components;
using simplepa2.UI.Popups;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCZone : Wisej.Web.UserControl
    {
        private Popup_BBCZoneForm pop_BBCZoneForm;
        private Form_BBCZoneImport form_BBCZoneImport;

        private List<Zone_DataList> zone_list;
        private Object[] site_list;
        private List<Comp_ZoneFloorCardList> cardList;

        private string strSelectRelease = "선택해제";
        private string strSelectAll = "모두선택";
        private bool bZoneSelectAll = false; 


        public View_BBCZone()
        {
            InitializeComponent();
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


        private void View_BBCZone_Load(object sender, EventArgs e)
        {          
            if(zone_list == null)
            {
                // DB 콜 필요, 아래는 예제 데이터   사이트는 계정별 관리하는 건물만 표시할 것 
                site_list = new Object[] { "오크동", "대명리조트본관", "오션월드", "스키센터", "호텔동" };

                cardList = new List<Comp_ZoneFloorCardList>();
            }

            setupSiteList(site_list);
        }

        private void setupSiteList(Object[] site_list)
        {
            this.cb_SiteName.Items.AddRange(site_list);
            this.cb_SiteName.SelectedIndex = 0;

        }

        private void setupZoneInterface(List<Zone_DataList> zlist)
        {
            foreach(Zone_DataList z in zlist)
            {
                Comp_ZoneFloorCardList czf = new Comp_ZoneFloorCardList(z, true);
                cardList.Add(czf);
                this.pn_Contents.Controls.Add(czf);
            }
            
            // TODO : Interface Setup and making CardList 

        }

             
            
        
        private List<Zone_DataList> exampleZoneList()
        {
            List<Zone_DataList> zlist = new List<Zone_DataList>();

            Zone_DataList zoneList1 = new Zone_DataList();
            zoneList1.floorName = "1층";
            zoneList1.aStr_Zonelist = new string[]  {"1층-S1","1층-S2","1층-S2","1층-S3","1층-S4","1층-S5","1층-S6","1층-S7","1층-S8","1층-S9","1층-S10","1층-S11","1층-S12","1층-S13","1층-S14","1층-S15","1층-S16","1층-S17","1층-S18","1층-S19"};
            zlist.Add(zoneList1);

            Zone_DataList zoneList2 = new Zone_DataList();
            zoneList2.floorName = "2층";
            zoneList2.aStr_Zonelist = new string[] { "2층-S1","2층-S2","2층-S2","2층-S3","2층-S4","2층-S5","2층-S6","2층-S7","2층-S8","2층-S9","2층-S10","2층-S11","2층-S12","2층-S13","2층-S14","2층-S15","2층-S16","2층-S17","2층-S18","2층-S19"};
            zlist.Add(zoneList2);

            Zone_DataList zoneList3 = new Zone_DataList();
            zoneList3.floorName = "3층";
            zoneList3.aStr_Zonelist = new string[] { "3층-S1","3층-S2","3층-S2","3층-S3","3층-S4","3층-S5","3층-S6","3층-S7","3층-S8","3층-S9","3층-S10","3층-S11","3층-S12","3층-S13","3층-S14","3층-S15","3층-S16","3층-S17","3층-S18","3층-S19"};
            zlist.Add(zoneList3);

            Zone_DataList zoneList4 = new Zone_DataList();
            zoneList4.floorName = "4층";
            zoneList4.aStr_Zonelist = new string[] { "4층-S1","4층-S2","4층-S2","4층-S3","4층-S4","4층-S5","4층-S6","4층-S7","4층-S8","4층-S9","4층-S10","4층-S11","4층-S12","4층-S13","4층-S14","4층-S15","4층-S16","4층-S17","4층-S18","4층-S19"};
            zlist.Add(zoneList4);

            Zone_DataList zoneList5 = new Zone_DataList();
            zoneList5.floorName = "5층";
            zoneList5.aStr_Zonelist = new string[] { "5층-S1","5층-S2","5층-S2","5층-S3","5층-S4","5층-S5","5층-S6","5층-S7","5층-S8","5층-S9","5층-S10","5층-S11","5층-S12","5층-S13","5층-S14","5층-S15","5층-S16","5층-S17","5층-S18","5층-S19"};
            zlist.Add(zoneList5);

            Zone_DataList zoneList6 = new Zone_DataList();
            zoneList6.floorName = "6층";
            zoneList6.aStr_Zonelist = new string[] { "6층-S1","6층-S2","6층-S2","6층-S3","6층-S4","6층-S5","6층-S6","6층-S7","6층-S8","6층-S9","6층-S10","6층-S11","6층-S12","6층-S13","6층-S14","6층-S15","6층-S16","6층-S17","6층-S18","6층-S19"};
            zlist.Add(zoneList6);

            Zone_DataList zoneList7 = new Zone_DataList();
            zoneList7.floorName = "7층";
            zoneList7.aStr_Zonelist = new string[] { "7층-S1","7층-S2","7층-S2","7층-S3","7층-S4","7층-S5","7층-S6","7층-S7","7층-S8","7층-S9","7층-S10","7층-S11","7층-S12","7층-S13","7층-S14","7층-S15","7층-S16","7층-S17","7층-S18","7층-S19"};
            zlist.Add(zoneList7);

            Zone_DataList zoneList8 = new Zone_DataList();
            zoneList8.floorName = "8층";
            zoneList8.aStr_Zonelist = new string[] { "8층-S1","8층-S2","8층-S2","8층-S3","8층-S4","8층-S5","8층-S6","8층-S7","8층-S8","8층-S9","8층-S10","8층-S11","8층-S12","8층-S13","8층-S14","8층-S15","8층-S16","8층-S17","8층-S18","8층-S19"};
            zlist.Add(zoneList8);

            Zone_DataList zoneList9 = new Zone_DataList();
            zoneList9.floorName = "9층";
            zoneList9.aStr_Zonelist = new string[] { "9층-S1","9층-S2","9층-S2","9층-S3","9층-S4","9층-S5","9층-S6","9층-S7","9층-S8","9층-S9","9층-S10","9층-S11","9층-S12","9층-S13","9층-S14","9층-S15","9층-S16","9층-S17","9층-S18","9층-S19"};
            zlist.Add(zoneList9);

            Zone_DataList zoneList10 = new Zone_DataList();
            zoneList10.floorName = "10층";
            zoneList10.aStr_Zonelist = new string[] { "10층-S1","10층-S2","10층-S2","10층-S3","10층-S4","10층-S5","10층-S6","10층-S7","10층-S8","10층-S9","10층-S10","10층-S11","10층-S12"};
            zlist.Add(zoneList10);

            Zone_DataList zoneList11 = new Zone_DataList();
            zoneList11.floorName = "11층";
            zoneList11.aStr_Zonelist = new string[] { "11층-S1","11층-S2","11층-S2","11층-S3","11층-S4","11층-S5","11층-S6","11층-S7","11층-S8","11층-S9","11층-S10","11층-S11","11층-S12"};
            zlist.Add(zoneList11);

            Zone_DataList zoneList12 = new Zone_DataList();
            zoneList12.floorName = "12층";
            zoneList12.aStr_Zonelist = new string[] { "12층-S1","12층-S2","12층-S2","12층-S3","12층-S4","12층-S5","12층-S6","12층-S7","12층-S8","12층-S9","12층-S10","12층-S11"};
            zlist.Add(zoneList12);

            return zlist;
        }

        private void bt_SelectLoading_Click(object sender, EventArgs e)
        {
            if (this.cb_SiteName.SelectedItem.Equals("오크동"))
            {
                zone_list = exampleZoneList();
                // Zone 내역을 UI에 셋업  
                setupZoneInterface(zone_list);
            }
            else
            {
                MessageBox.Show("데이터가 없습니다., DB 연결 구현 필요");
            }


        }

        private void bt_WholeSelect_Click(object sender, EventArgs e)
        {
            bZoneSelectAll = !bZoneSelectAll;

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
        }

        private void bt_StoreData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO : Zone 추가 삭제된 내용을 Database에 저장하고 시스템에 반영합니다.");
        }

        private void bt_ExportCSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO : 현재의 Zone 리스트를 CSV 파일로 추출해 줍니다. ");
        }

        private void bt_ImportCSV_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.form_BBCZoneImport == null)
            {
                this.form_BBCZoneImport = new Form_BBCZoneImport();
                this.form_BBCZoneImport.ShowDialog();
            }
            else
            {
                this.form_BBCZoneImport.ShowDialog();
            }      

        }
    }


    public class Zone_DataList
    {
        public string floorName;
        public string[] aStr_Zonelist;
        
    }   
}
