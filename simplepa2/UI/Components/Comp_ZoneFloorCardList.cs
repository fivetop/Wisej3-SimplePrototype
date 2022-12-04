using simplepa2.UI.Popups;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_ZoneFloorCardList : Wisej.Web.UserControl
    {
        private Popup_BBCZoneForm pop_BBCZoneForm;
        private List<Comp_ZoneButton> zoneList; 

        private string strFloorName;
        private string strAddButton;


        public Comp_ZoneFloorCardList()
        {
            
            InitializeComponent();
        }

        public Comp_ZoneFloorCardList(List<Comp_ZoneButton> zoneList, string floorName)
        {
            InitializeComponent();

            if (zoneList != null)
            {
                this.zoneList = zoneList;
                this.strFloorName = floorName;
            }

        }

        private void Comp_ZoneFloorCardList_Load(object sender, EventArgs e)
        {
            if (zoneList == null)
                Dispose();
            
             // 02. 개별 컴포넌트 생성
            floorCheck.Text = strFloorName;

            foreach (Comp_ZoneButton zoneItem in zoneList)
            {
                this.flowLayoutPanel1.Controls.Add(zoneItem);
            }
            this.strAddButton = "추가";
            Button addButton = new Button();
            addButton.Text = strAddButton;
            addButton.MouseClick += AddButton_MouseClick;
            this.flowLayoutPanel1.Controls.Add(addButton);
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
                this.pop_BBCZoneForm.Height = this.Parent.Parent.Parent.Parent.Height;
                this.pop_BBCZoneForm.ShowPopup(this.Parent.Parent.Parent);
            }

        }

        private void floorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(floorCheck.Checked)
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
    }
}
