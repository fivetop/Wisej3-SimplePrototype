
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.ListViewPanels
{
	public partial class Page1 : Page
	{
		Data1List DataList { get; set; } = new Data1List();

		public Page1()
		{
			InitializeComponent();			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddItems();
		}

		private void AddItems()
		{

			var nbResultats = 42;

			for (Int32 i = 0; i < nbResultats; i++)
			{
				var item = new data1();
				item.index = i;
				item.Title = "Item " + i;
				item.Chk = true;
				DataList.child.Add(item);
			}


			for (Int32 i = 0; i < nbResultats; i++)
			{
				var lviResultat = new ListViewItem()
				{
					Text = "TEXT",
					ImageSource = null
				};

				var item = new UserControl1();
				item.data1 = DataList.child[i];
				item.UserControlClick += userControlClick;
				//item.Dock = DockStyle.Left;

				lviResultat.Control = item;
				listView1.Items.Add(lviResultat);
				//listView1.DataSource = DataList.child;
			}
		}

        private void userControlClick(object sender, EventArgs e)
        {
			var s3 = (UserControl1)sender;

			if (s3.Chk)
				s3.Chk = false;
			else
				s3.Chk = true;
			//s3.data1.index
		}

		private void listView1_ClientSizeChanged(object sender, EventArgs e)
        {
			//this.listView1.ItemSize = new System.Drawing.Size(this.listView1.ItemSize.Width , this.listView1.ItemSize.Height);
			//this.listView1.ItemSize = new System.Drawing.Size(this.listView1.Size.Width - 20, this.listView1.ItemSize.Height);
		}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
			/*
			var s1 = (ListView)sender;
			var s2 = s1.SelectedItems;
			var s3 = (UserControl1)s1.SelectedItems[0].Control;

			if (s3 == null) return;

			if(s3.Chk)
				s3.Chk = false;
			else
				s3.Chk = true;
			*/

		}

        private void Page1_Load(object sender, EventArgs e)
        {
			BindingList<ProductModel> dataSource = new BindingList<ProductModel>();
			dataSource.Add(new ProductModel() { ProductTitle = "Gift Card", InStock = true, Price = 20.00m, Image = @"Images\giftcard20.png", ProductDetail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s" });
			dataSource.Add(new ProductModel() { ProductTitle = "Notebook", InStock = true, Price = 1299.99m, Image = @"Images\laptop.jpg", ProductDetail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s" });
			dataSource.Add(new ProductModel() { ProductTitle = "Desktop monitor", InStock = false, Price = 250.00m, Image = @"Images\monitor.png", ProductDetail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s" });
			dataSource.Add(new ProductModel() { ProductTitle = "Headphones", InStock = true, Price = 27.49m, Image = @"Images\headphones.jpg", ProductDetail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s" });
			dataSource.Add(new ProductModel() { ProductTitle = "Harddisk", InStock = true, Price = 85.00m, Image = @"Images\hdd.png", ProductDetail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s" });
			dataSource.Add(new ProductModel() { ProductTitle = "Phone", InStock = false, Price = 320.00m, Image = @"Images\phone.png", ProductDetail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s" });
			dataSource.Add(new ProductModel() { ProductTitle = "Router", InStock = true, Price = 24.00m, Image = @"Images\router.png", ProductDetail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s" });
			dataRepeater1.DataSource = dataSource;
		}

        private void button2_Click(object sender, EventArgs e)
        {
			var nCurr = dataRepeater1.CurrentItemIndex;
		}
    }
}
