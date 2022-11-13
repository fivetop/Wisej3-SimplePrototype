using simplepa2.UI.Popups;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCDevice : Wisej.Web.UserControl
    {
        private Popup_BBCDeviceForm pop_BBCDeviceForm;

        public View_BBCDevice()
        {
            InitializeComponent();
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.pop_BBCDeviceForm == null)
                this.pop_BBCDeviceForm = new Popup_BBCDeviceForm()
                {
                    Alignment = Placement.BottomRight
                };

            if (this.pop_BBCDeviceForm.Visible)
                this.pop_BBCDeviceForm.Close();
            else
                this.pop_BBCDeviceForm.ShowPopup(this);

        }
    }
}
