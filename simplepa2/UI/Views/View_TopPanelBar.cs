using simplepa2.UI.Pages;
using System;
using Wisej.Web;
using PA_MainFrame = simplepa2.UI.Pages.PA_MainFrame;

namespace simplepa2.UI.Views
{
    public partial class View_TopPanelBar : Wisej.Web.UserControl
    {
        private System.Threading.Timer timer;

        public View_TopPanelBar()
        {
            InitializeComponent();
        }

        private void View_TopPanelBar_Load(object sender, EventArgs e)
        {
            this.timer = Application.StartTimer(1, 1000, () => {
                var now = DateTime.Now;
                this.label_date.Text = now.ToString("yyyy:MM:dd");
                this.label_time.Text = now.ToString("hh:mm:ss");
                Application.Update(this);
            });

        }

        public void User(string user)
        {
            this.label1.Text = user;
            Application.Update(this);
        }

        private void View_TopPanelBar_Disposed(object sender, EventArgs e)
        {
            this.timer.Dispose();
        }

        // log out 처리 
        private void button_LogOut_Click(object sender, EventArgs e)
        {
            PA_MainFrame pA_MainFrame = (PA_MainFrame)Application.MainPage;

            pA_MainFrame.Logout();

        }
    }
}
