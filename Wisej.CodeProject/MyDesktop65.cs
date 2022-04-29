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
    // 개별 앵커 방송
    public partial class MyDesktop : Desktop
    {
		int add = 0; // add =1. update =2

		private void uDeleteRecord()
		{
			// this method shows server-side modal.
			if (utextloginid.Text == "" || utextusername.Text == "" || umaskedTextBox1.Text == "")
			{
				AlertBox.Show("데이터를 확인 바랍니다.");
				return;
			}
			if (utextpassword.Text != utextpassword2.Text)
			{
				AlertBox.Show("Check Password!");
				return;
			}

			try
			{
				var row = this.udataGridView1.CurrentRow?.Index ?? -1;
				if (row > -1)
				{
					if (MessageBox.Show("삭제 하시겠습니까?", icon: MessageBoxIcon.Question,
						buttons: MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
					{
						this.ubindingSource1.RemoveCurrent();
						var count = this.userTreesTableAdapter.Update(this.dataSet1.UserTrees);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void uSaveData()
		{
			try
			{
				if (utextloginid.Text == "" || utextusername.Text == "" || umaskedTextBox1.Text == "")
				{
					AlertBox.Show("데이터를 확인 바랍니다.");
					return;
				}
				if (utextpassword.Text != utextpassword2.Text)
				{
					AlertBox.Show("Check Password!");
					return;
				}

				if (add == 1)
				{
					var t1 = this.dataSet1.UserTrees.Where(p => p.login_id == utextloginid.Text).FirstOrDefault();//.Select( .where . Select(); .ffin .GetDataBy(textloginid.Text);
					if (t1 != null)
						return;
				}
				this.ubindingSource1.EndEdit();
				var count = this.userTreesTableAdapter.Update(this.dataSet1.UserTrees);

				AlertBox.Show("Saved!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void uAddNewRecord()
		{
			try
			{
				this.ubindingSource1.AddNew();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void ubutton1_Click(object sender, EventArgs e)
		{
			uSaveData();
			add = 0;
		}

		private void ubutton2_Click(object sender, EventArgs e)
		{
			if (add == 1) return;
			add = 1;
			uAddNewRecord();
		}

		private void ubutton3_Click(object sender, EventArgs e)
		{
			add = 2;
			uDeleteRecord();
			add = 0;
		}
	}
}