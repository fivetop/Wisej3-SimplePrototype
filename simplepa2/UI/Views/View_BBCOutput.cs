using simplepa2.UI.Popups;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCOutput : Wisej.Web.UserControl
    {
        private Popup_BBCOutputForm pop_BBCOutputForm;

        public View_BBCOutput()
        {
            InitializeComponent();
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            // show the gage popup.
            if (this.pop_BBCOutputForm == null)
                this.pop_BBCOutputForm = new Popup_BBCOutputForm()
                {
                    Alignment = Placement.BottomRight
                };

            if (this.pop_BBCOutputForm.Visible)
                this.pop_BBCOutputForm.Close();
            else
                this.pop_BBCOutputForm.ShowPopup(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 임시 기능 팝업 열기 
            // show the popup.
            if (this.pop_BBCOutputForm == null)
                this.pop_BBCOutputForm = new Popup_BBCOutputForm()
                {
                    Alignment = Placement.BottomRight,
                    Height = this.Parent.Height
                };

            if (this.pop_BBCOutputForm.Visible)
                this.pop_BBCOutputForm.Close();
            else
            {
                this.pop_BBCOutputForm.Height = this.Parent.Parent.Height;
                this.pop_BBCOutputForm.ShowPopup(this.Parent);
            }

        }
    }
}
