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

        private List<Zone_DataList> zone_list;
        private Object[] site_list;
        private List<Comp_ZoneFloorCardList> cardList;

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
            zone_list = new List<Zone_DataList>();
        }

        public void dbInit()
        {
            try
            {
                this.assetsTableAdapter1.Fill(this.dataSet11.Assets);
                this.emServerTableAdapter1.Fill(this.dataSet11.EMServer);
            }
            catch(Exception e)
            {
                MessageBox.Show("LAW TEXT : Asset 데이터를 가져오는 중 예외발생 -"+e.Message);
            }           
            
        }

        public void comboUISetup()
        {
            cb_SiteName.DataSource = this.dataSet11.EMServer;
            this.cb_SiteName.SelectedIndex = 0;
        }

        private void bt_SelectLoading_Click(object sender, EventArgs e)
        {
            // 선택된 사이트명 확인 (EM명)
            string selectedItem = (((this.cb_SiteName.SelectedItem as DataRowView).Row) as DataSet1.EMServerRow).EMNAME;

            // E.M 명으로 데이터 정렬 
            DataRow[] dataZoneArray = this.dataSet11.Assets.Select("emServer = '" + selectedItem + "'");
            
            setupZoneCardUI(dataZoneArray);

            /*
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
            */


        }

        private void setupZoneCardUI(DataRow[] dataSiteArray)
        {
            if(cardList == null)
            {
                cardList = new List<Comp_ZoneFloorCardList>();
            }
            else
            {
                cardList.Clear();
            }

            foreach(DataRow drR in dataSiteArray)
            {
                // Comp_ZoneFloorCardList czf = new Comp_ZoneFloorCardList(drR, true);
                //cardList.Add(czf);
                //this.pn_Contents.Controls.Add(czf);
            }
            



            // TODO : Interface Setup and making CardList 
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
        public DataRow[] dataSiteArray;


    }   
}
