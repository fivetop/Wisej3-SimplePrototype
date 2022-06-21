using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.CodeProject.Setup
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Load(object sender, EventArgs e)
        {
            this.assetsTableAdapter.Fill(this.dataSet1.Assets);

            var t2 = this.dataSet1.Assets.OrderBy(p => p.seq).ToList();
            //listviewCTL2.Dock = DockStyle.Fill;
            //listviewCTL2.ListviewCTL_Load(t2);
            //listviewCTL2.UserControlClick += userControlClick2;

            for (Int32 i = 0; i < t2.Count; i++)
            {
                var lviResultat = new ListViewItem()
                {
                    Text = "TEXT",
                    ImageSource = null
                };

                var item = new UserControl1();
                item.Title = t2[i].path;
                item.Chk = t2[i].chk == 0 ? false : true;
                item.UserControlClick += userControlClick2;
                //item.Dock = DockStyle.Left;


                lviResultat.Control = item;
                listView1.Items.Add(lviResultat);
                //listView1.DataSource = DataList.child;
            }
            listView1.ItemSize = new System.Drawing.Size(300, 80);

        }

        private void userControlClick2(object sender, EventArgs e)
        {
            var s3 = (UserControl1)sender;

            if (s3.Chk)
                s3.Chk = false;
            else
                s3.Chk = true;
            //s3.data1.index                
        }
    }
}