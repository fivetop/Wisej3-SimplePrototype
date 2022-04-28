using System;
using Wisej.Web;
using System.Threading;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using DataClass;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject
{
	public partial class Main4 : Form
	{
		MyDesktop myDesktop { get; set; }

		public Main4()
		{
			var t1 = new Wisej.Web.MenuItem();
			InitializeComponent();

			this.button1.Enabled = true;
			this.button2.Enabled = false;

			this.WindowState = FormWindowState.Maximized;
			myDesktop  = (MyDesktop)Application.Desktop;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);
			var t1 = this.dataSet1.Assets.OrderBy(p => p.seq).ToList();

			listviewCTL1.Dock = DockStyle.Fill;
			listviewCTL1.ListviewCTL_Load2(t1);
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


		#region // 버튼 처리 
		private void button1_Click(object sender, EventArgs e)
        {
        }

		private void button2_Click(object sender, EventArgs e)
		{
		}
		#endregion



    }
}
