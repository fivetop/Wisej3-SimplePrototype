using simplepa2.UI.Popups;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCSite : Wisej.Web.UserControl
    {
        private Popup_BBCSiteForm pop_BBCSiteForm;

        public View_BBCSite()
        {
            InitializeComponent();
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.pop_BBCSiteForm == null)
                this.pop_BBCSiteForm = new Popup_BBCSiteForm()
                {
                    Alignment = Placement.BottomRight
                };

            if (this.pop_BBCSiteForm.Visible)
                this.pop_BBCSiteForm.Close();
            else
                this.pop_BBCSiteForm.ShowPopup(this);

        }
    }
}
