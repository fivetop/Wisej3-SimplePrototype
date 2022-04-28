using Wisej.Web;
using System.Threading;
using Wisej.CodeProject.Examples;
using Wisej.CodeProject.Setup;
using Wisej.ChatServer;
using Wisej.CodeProject.SignalR;
using System.Collections.Generic;
using static Wisej.CodeProject.DataSet1;
using System.Linq;
using Microsoft.Ajax.Utilities;
using DataClass;
using System.Drawing;
using Wisej.CodeProject.win;
using System;

namespace Wisej.CodeProject
{
    // 프리셋 방송 
    public partial class MyDesktop : Desktop
    {

		private void Main_Load42(object sender, EventArgs e)
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
	}
}