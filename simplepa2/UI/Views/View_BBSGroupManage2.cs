using System;
using System.Linq;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBSGroupManage2 : Wisej.Web.UserControl
    {
        public View_BBSGroupManage2()
        {
            InitializeComponent();
        }

        private void AGroup_Load(object sender, EventArgs e)
        {
            reDraw();
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

        private void userControlClick2(object sender, EventArgs e)
        {
            var s3 = (UserControl1)sender;

            if (s3.Chk)
                s3.Chk = false;
            else
                s3.Chk = true;
            //s3.data1.index            
        }

        internal void reDraw()
        {
            this.assetsTableAdapter.Fill(this.dataSet1.Assets);

            // 자산 1
            var t1 = this.dataSet1.Assets.OrderBy(p => p.seq).ToList();
            listviewCTL1.Dock = DockStyle.Fill;
            listviewCTL1.ListviewCTL_Load2(t1);
            listviewCTL1.UserControlClick += userControlClick;

            // 자산 2
            var t2 = this.dataSet1.Assets.OrderBy(p => p.seq).ToList();
            listviewCTL2.Dock = DockStyle.Fill;
            listviewCTL2.ListviewCTL_Load(t2);
            listviewCTL2.UserControlClick += userControlClick2;
        }
    }
}
