using System;
using System.Collections.Generic;
using Wisej.Web;

namespace simplepa2.UI.Popups
{
    public partial class Popup_BBCSiteForm : Wisej.Web.UserPopup
    {
        public Popup_BBCSiteForm()
        {
            InitializeComponent();

            addExampleData();
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
          

        }

        public void addExampleData()
        {
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

        }

        public class sampleData
        {
            public string floorName { get; set; }
            public string floorIdenfier { get; set; }
            public string floorValue { get; set; }
        }
    }
}
