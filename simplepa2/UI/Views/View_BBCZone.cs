using simplepa2.UI.Popups;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCZone : Wisej.Web.UserControl
    {
        private Popup_BBCZoneForm pop_BBCZoneForm;

        public View_BBCZone()
        {
            InitializeComponent();
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.pop_BBCZoneForm == null)
                this.pop_BBCZoneForm = new Popup_BBCZoneForm()
                {
                    Alignment = Placement.BottomRight
                };

            if (this.pop_BBCZoneForm.Visible)
                this.pop_BBCZoneForm.Close();
            else
                this.pop_BBCZoneForm.ShowPopup(this);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
