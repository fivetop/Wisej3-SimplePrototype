using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;

namespace simplepa2.UI.Popups
{
    public partial class Popup_BBCSiteForm : Wisej.Web.UserPopup
    {
        private DataRow[] drFloor;
        private DataSet1.spa_bd_structRow structRow;
        public Popup_BBCSiteForm()
        {
            InitializeComponent();

            addExampleData();
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
          

        }

        public void setupUIwithData(DataSet1.spa_bd_structRow structRow, DataRow[] drFloor)
        {
            this.structRow = structRow;
            this.drFloor = drFloor;

            tb_bdName.Text = structRow.bd_name;
            tb_bdFireID.Text = structRow.bd_fire_id.ToString();
            tb_bdDescription.Text = structRow.bd_description;
            tb_bdFloorNo.Text = structRow.num_of_stairs.ToString();

            dg_floorList.DataSource = drFloor;            
        }

        public void setupUItoNewForm()
        {
            tb_bdName.Text = "";
            tb_bdFireID.Text = "";
            tb_bdDescription.Text = "";
            tb_bdFloorNo.Text = "";

            dg_floorList.DataSource = null;
            
        }

        public void addExampleData()
        {
            /*
            string floorName = "층";
            string floorIdentifier = "F";

            this.listView1.BeginUpdate();
            this.listView1.Items.Clear();


            var myData = new List<sampleData>();
            ListViewItem item1; 

            for (int i = 0; i < 15; i++)
            {
                item1 = new ListViewItem(i + floorName);

                item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, i + floorIdentifier));
                item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, "0" + i));
                this.listView1.Items.Add(item1);

            }
            this.listView1.EndUpdate();
            */
        }

        public class sampleData
        {
            public string floorName { get; set; }
            public string floorIdenfier { get; set; }
            public string floorValue { get; set; }
        }
    }
}
