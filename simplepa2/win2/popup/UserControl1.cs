using System;
using Wisej.Web;
using System.Threading;
using System.Drawing;

namespace simplepa2.win2.popup
{
    public partial class UserControl1 : Wisej.Web.UserPopup
    {
        public UserControl1()
        {
            InitializeComponent();
        }		

		public event EventHandler ExampleCreated;

		private void btnBackgroundTasks_Click(object sender, EventArgs e)
		{
			var example = new Examples.BackgroundTasks();
			this.ExampleCreated?.Invoke(example, EventArgs.Empty);
			example.Show();
		}

		private void btnIntegration_Click(object sender, EventArgs e)
		{
	
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.StartTask(() =>
			{
				for (int i = 0; i < 4; i++)
				{
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Information, alignment: ContentAlignment.BottomCenter);
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Error, alignment: ContentAlignment.BottomLeft);
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Hand, alignment: ContentAlignment.BottomRight);
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Stop, alignment: ContentAlignment.MiddleCenter);
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Question, alignment: ContentAlignment.MiddleLeft);
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Stop, alignment: ContentAlignment.MiddleRight);
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Warning, alignment: ContentAlignment.TopCenter);
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Question, alignment: ContentAlignment.TopLeft);
					AlertBox.Show("Hello, <b>World!</b>", icon: MessageBoxIcon.Information, alignment: ContentAlignment.TopRight);
					Application.Update(this);

					Thread.Sleep(500);
				}
			});
		}

        private void UserControl1_VisibleChanged(object sender, EventArgs e)
        {
			if(this.Visible)
            {
				SStartupdateingForm();
            }
        }

		private void SStartupdateingForm()
        {
			Application.StartTask(() =>
			{
				while (this.Visible && !Application.IsTerminated)
				{
					Application.Update(this);

					Thread.Sleep(1000);
				}

			});

		}

	}
}
