using simplepa2.UI.Popups;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_SystemAccount : Wisej.Web.UserControl
    {
        private Popup_SystemAddUser popup_SystemAddUser;
        public View_SystemAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show the popup.
            if (this.popup_SystemAddUser == null)
                this.popup_SystemAddUser = new Popup_SystemAddUser()
                {
                    Alignment = Placement.BottomRight,
                    Height = this.Parent.Height
                };

            if (this.popup_SystemAddUser.Visible)
                this.popup_SystemAddUser.Close();
            else
            {
                this.popup_SystemAddUser.Height = this.Parent.Parent.Height;
                this.popup_SystemAddUser.ShowPopup(this.Parent);
            }

        }
    }
}
