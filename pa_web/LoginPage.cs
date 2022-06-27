using System;
using System.Linq;
using Wisej.Web;


namespace pa_web
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
			string loginid = tloginid.Text;
			string loginpw = tloginpw.Text;

			if (loginid == "" || loginpw == "")
			{
				AlertBox.Show("ID 혹은 Password 를 확인 바랍니다.");
				return;
			}
			var t1 = this.userTreesTableAdapter.GetDataBy(loginid, loginpw);

			if (t1.Count == 0)
			{
				AlertBox.Show("ID 혹은 Password 를 확인 바랍니다.");
				return;
			}

			Application.Session["isloggedon"] = "true";
			Application.Session["user"] = t1.FirstOrDefault().login_id;
			Application.Session["user_name"] = t1.FirstOrDefault().user_name;
			Application.Desktop = new MyDesktop();
			this.Hide();
			this.Dispose();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AlertBox.Show("이메일로 패스워드를 전송 하였습니다.");
		}

        private void LoginPage_Load(object sender, EventArgs e)
        {
			Application.Session["isloggedon"] = "false";

			this.userTreesTableAdapter.Fill(this.dataSet1.UserTrees);

			if (this.dataSet1.UserTrees.Count < 1)
			{
				var m1 = this.dataSet1.UserTrees.NewUserTreesRow();
				m1.login_id = "Admin";
				m1.login_password = "Admin";
				m1.login_password2 = "Admin";
				m1.mobile = "01012341234";
				m1.user_name = "관리자";
				m1.user_group = "Admin";
				m1.email = "Admin@user.com";
				this.dataSet1.UserTrees.Rows.Add(m1);
				this.userTreesTableAdapter.Update(this.dataSet1.UserTrees);
				this.dataSet1.AcceptChanges();
			}
		}
	}
}
