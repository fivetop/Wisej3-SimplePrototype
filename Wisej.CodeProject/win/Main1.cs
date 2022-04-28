using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject.win
{
    public partial class Main1 : Form
    {
		public List<AssetsRow> SelAsset { get; set; } = new List<AssetsRow>();

		public Main1()
        {
            InitializeComponent();
        }

		private void Main1_Load(object sender, EventArgs e)
		{
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);
			var t1 = this.dataSet1.Assets.OrderBy(p=>p.seq).ToList();

			listviewCTL1.Dock = DockStyle.Fill;
			listviewCTL1.ListviewCTL_Load(t1);
			listviewCTL1.UserControlClick += userControlClick;
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

    }
}
