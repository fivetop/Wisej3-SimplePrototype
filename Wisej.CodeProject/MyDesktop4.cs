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
using System;

namespace Wisej.CodeProject
{
    // 프리셋 방송 
    public partial class MyDesktop : Desktop
    {
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