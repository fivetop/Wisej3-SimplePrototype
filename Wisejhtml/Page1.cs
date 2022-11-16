
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

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void shape2_Click(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox12_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox20_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel12_PanelCollapsed(object sender, EventArgs e)
		{

		}

		private void textBox21_TextChanged(object sender, EventArgs e)
		{

		}

		private void shape4_Click(object sender, EventArgs e)
		{

		}

		private void panel2_PanelCollapsed(object sender, EventArgs e)
		{

		}
	}
}
