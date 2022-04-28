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
    // 메인화면 처리 
    public partial class MyDesktop : Desktop
    {
		private void Main_Load62(object sender, EventArgs e)
		{
			this.assetsTableAdapter.Fill(this.dataSet1.Assets);
			var t1 = this.dataSet1.Assets.OrderBy(p => p.seq).ToList();

			listviewCTL2.Dock = DockStyle.Fill;
			listviewCTL2.ListviewCTL_Load(t1);
			listviewCTL2.UserControlClick += userControlClick2;
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