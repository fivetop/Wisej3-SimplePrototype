using System;
using Wisej.Web;


namespace Wisej.CodeProject
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

		private void LoginPage_Accelerator(object sender, AcceleratorEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Login();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void Login()
		{
			Application.Desktop = new MyDesktop();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AlertBox.Show("We have sent your password.");
		}

    }
}
