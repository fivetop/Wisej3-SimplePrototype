
using System;
using Wisej.Web;

namespace Wisejhtml
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

        private void htmlPanel1_ElementClick(object sender, HtmlPanelElementClickArgs e)
        {
			string a1 = e.Element.ToString();

			AlertBox.Show(a1);

			//if (a1 == "대기")
			{ 
				Page2 p2 = new Page2();
				p2.Show();
			}
        }
    }
}
