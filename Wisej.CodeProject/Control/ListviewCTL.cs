using System;
using System.Collections.Generic;
using Wisej.Web;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject.Control
{
    public partial class ListviewCTL : Wisej.Web.UserControl
    {
		public EventHandler UserControlClick;
		public ListviewCTL()
        {
            InitializeComponent();
        }

        public void ListviewCTL_Load(List<AssetsRow> list)
        {
			for (Int32 i = 0; i < list.Count; i++)
			{
				var lviResultat = new ListViewItem()
				{
					Text = "TEXT",
					ImageSource = null
				};

				var item = new UserControl1();
				item.data1 = list[i];
				item.UserControlClick += userControlClick;
				//item.Dock = DockStyle.Left;

				
				lviResultat.Control = item;
				listView1.Items.Add(lviResultat);
				//listView1.DataSource = DataList.child;
			}
			listView1.ItemSize = new System.Drawing.Size(300, 80);
		}

		public void ListviewCTL_Load2(List<AssetsRow> list)
		{
			for (Int32 i = 0; i < list.Count; i++)
			{
				var lviResultat = new ListViewItem()
				{
					Text = "TEXT",
					ImageSource = null
				};

				var item = new DeviceCTL();
				item.data1 = list[i];
				item.UserControlClick += userControlClick;
				//item.Dock = DockStyle.Left;

				lviResultat.Control = item;
				listView1.Items.Add(lviResultat);
				//listView1.DataSource = DataList.child;
			}
			listView1.ItemSize = new System.Drawing.Size(300, 130);
		}
		private void userControlClick(object sender, EventArgs e)
        {
			UserControlClick?.Invoke(sender, e);
		}
    }
}
