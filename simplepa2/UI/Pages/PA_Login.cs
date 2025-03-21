﻿using Microsoft.AspNet.SignalR;
using System;
using System.Linq;
using Wisej.Core;
using Wisej.Web;

namespace simplepa2.UI.Pages
{
    public partial class PA_Login : Wisej.Web.Page
    {
		string main = "";

        public PA_Login()
        {
            InitializeComponent();
            Application.LoadTheme("Material-3");
        }

        private void LoginPage_Accelerator(object sender, AcceleratorEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Login();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Login();
        }

		/*
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Dispose();
			Application.MainPage = new PA_MainFrame();
			Application.LoadTheme("LSMaterial-3"); //"Material-3" 
		}
		*/
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

			/*
            string aa = LocalStorageGet("userName");

            string l1 = Application.Session["login_id"];

			if (l1 != "")
			{ 
			}

            Application.Browser.LocalStorage.SetValue<string>("userName", "aaa");

            Application.Browser.LocalStorage.GetValue<string>("userName", (value) => {
                if (value != null)
                    AlertBox.Show($"Welcome back, {value}");
            });

            //Application.Browser.LocalStorage.ToJSON();

            Application.Cookies.Clear();
			Application.Cookies.Add("login","romee");
			*/
			Application.Session["isloggedon"] = "true";
			Application.Session["login_id"] = t1.FirstOrDefault().login_id;
			Application.Session["user_name"] = t1.FirstOrDefault().user_name;

			if (main != "")
			{
				var t2 = gweb.mgf.FirstOrDefault(p =>p.guidstring == main);
				if (t2 != null)
				{
					gweb.mgf.Remove(t2);	
					if(gweb.mgf.Count() > 0)
						t2.Close();
				}
			}

			Application.LoadTheme("LSMaterial-3"); //"Material-3" .
			Application.MainPage = new PA_MainFrame();
			this.Hide();
			this.Dispose();
		}

        private string LocalStorageGet(string v1)
        {
			string rlt = "";

            Application.Browser.LocalStorage.GetValue<string>("MainFrame", (value) => {
				if (value != null)
				{ 
					main = value.ToString();
                    //AlertBox.Show($"Welcome back, {value}");
				}
            });
			return rlt;
        }

        private void LocalStorageSet(string v1, string v2)
        {
            Application.Browser.LocalStorage.SetValue<string>(v1, v2);
        }

        private void LoginPage_Load(object sender, EventArgs e)
		{
			LocalStorageGet("userName");

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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			string loginid = tloginid.Text;
			if (loginid == "")
			{
				AlertBox.Show("ID 를 확인 바랍니다.");
				return;
			}
			var t1 = this.dataSet1.UserTrees.FirstOrDefault(p=>p.login_id == loginid);

			if (t1.email != "")
			{
				gweb.SendTestEmail(t1.email, t1.login_password, "", ""); // id 와 보내는 사람 동일 처리 
				AlertBox.Show("이메일로 패스워드를 전송 하였습니다.");
			}

		}
	}
}
