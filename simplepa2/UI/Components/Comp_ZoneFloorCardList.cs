using simplepa2.UI.Popups;
using simplepa2.UI.Views;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_ZoneFloorCardList : Wisej.Web.UserControl
    {
        private Popup_BBCZoneForm pop_BBCZoneForm;

        private List<Comp_ZoneButton> zoneList;
        private bool bAddButton = false;

        private string strFloorName;
        private string strAddButton;

        public Comp_ZoneFloorCardList()
        {            
            InitializeComponent();
        }

        public Comp_ZoneFloorCardList(Zone_DataList dataList, bool isAddButton)
        {
            InitializeComponent();

            if (dataList == null)
                return;

            // 01. 데이터를 담고
           // this.zoneData = dataList.aStr_Zonelist;
            this.strFloorName = dataList.floorName;
            this.bAddButton = isAddButton;

            // 02. Zone 리스트를 만들고, Zone의 번호와 Zone명을 입력 > 상기는 예제로 이름을 두번 넣었음 
            zoneList = new List<Comp_ZoneButton>();

            foreach (var zoneItem in dataList.zoneListArray)
            {
                string zoneNo = Convert.ToString(zoneItem.AssetId);
                zoneList.Add(new Comp_ZoneButton(zoneNo, zoneItem.ZoneName));
            }

            // 03 .UI 구현 처리 
            Comp_ZoneFloorCardList_Load(zoneList);
        }

        private void Comp_ZoneFloorCardList_Load(List<Comp_ZoneButton> zoneButtonSet)
        {
            if (zoneButtonSet == null)
                return;
            
                // 02. 개별 컴포넌트 생성
            ch_floor.Text = strFloorName;

            foreach (Comp_ZoneButton zoneItem in zoneButtonSet)
            {
                
                this.flowLayoutPanel1.Controls.Add(zoneItem);
                
            }

            if(bAddButton)
            {
                this.strAddButton = "추가";
                Button addButton = new Button();
                addButton.Text = strAddButton;
                addButton.MouseClick += AddButton_MouseClick;
                this.flowLayoutPanel1.Controls.Add(addButton);
            }

        }

        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {
            // show the popup.
            if (this.pop_BBCZoneForm == null)
                this.pop_BBCZoneForm = new Popup_BBCZoneForm()
                {
                    Alignment = Placement.BottomRight,
                    Height = this.Parent.Parent.Height
                };

            if (this.pop_BBCZoneForm.Visible)
                this.pop_BBCZoneForm.Close();
            else
            {
                this.pop_BBCZoneForm.Height = this.Parent.Parent.Parent.Parent.Parent.Height;
                this.pop_BBCZoneForm.ShowPopup(this.Parent.Parent.Parent.Parent);
            }

        }

        private void ch_floor_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_floor.Checked)
            {
                foreach (Comp_ZoneButton zoneItem in zoneList)
                {
                    zoneItem.change_Click(true);
                }
            }
            else
            {
                foreach (Comp_ZoneButton zoneItem in zoneList)
                {
                    zoneItem.change_Click(false);
                }
            }
        }

        public void ch_floor_ChangeToChecked()   // 외부에서 Check를 변경해줄때 사용
        {
            this.ch_floor.Checked = true;
        }

        public void ch_floor_ChangeToUnChecked()   // 외부에서 Check를 변경해줄때 사용
        {
            this.ch_floor.Checked = false;
        }
    }
}
