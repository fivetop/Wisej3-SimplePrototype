using simplepa2.UI.Popups;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_SystemAccount : Wisej.Web.UserControl
    {
        private Popup_SystemAddUser pop_systemAddUser;

        public View_SystemAccount()
        {
            InitializeComponent();
        }

        private void bt_AddNewUser_Click(object sender, EventArgs e)
        {
            // show the popup.
            if (this.pop_systemAddUser == null)
                this.pop_systemAddUser = new Popup_SystemAddUser()
                {
                    Alignment = Placement.BottomRight,                    
                };

            if (this.pop_systemAddUser.Visible)
                this.pop_systemAddUser.Close();
            else
            {
                this.pop_systemAddUser.Height = this.Parent.Parent.Parent.Height;
                this.pop_systemAddUser.ShowPopup(this.Parent);
            }
        }
    }
}
