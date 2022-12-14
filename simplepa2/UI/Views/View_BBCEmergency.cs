using System;
using Wisej.Web;
using simplepa2.UI.Popups;

namespace simplepa2.UI.Views
{
    public partial class View_BBCEmergency : Wisej.Web.UserControl
    {
        private Popup_BBCEmergencyBBSCustom pop_BBCEmergencyForm;

        public View_BBCEmergency()
        {
            InitializeComponent();
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.pop_BBCEmergencyForm == null)
                this.pop_BBCEmergencyForm = new Popup_BBCEmergencyBBSCustom()
                {
                    Alignment = Placement.BottomRight
                };

            if (this.pop_BBCEmergencyForm.Visible)
                this.pop_BBCEmergencyForm.Close();
            else
                this.pop_BBCEmergencyForm.ShowPopup(this);
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 팝업용 임시 펑션 구현시 삭제바람
            // show the popup.
            if (this.pop_BBCEmergencyForm == null)
                this.pop_BBCEmergencyForm = new Popup_BBCEmergencyBBSCustom()
                {
                    Alignment = Placement.BottomRight,
                    Height = this.Parent.Height
                };

            if (this.pop_BBCEmergencyForm.Visible)
                this.pop_BBCEmergencyForm.Close();
            else
            {
                this.pop_BBCEmergencyForm.Height = this.Parent.Parent.Height;
                this.pop_BBCEmergencyForm.ShowPopup(this.Parent);
            }
        }
    }
}
