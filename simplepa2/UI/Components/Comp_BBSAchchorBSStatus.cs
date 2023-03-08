using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{

    public partial class Comp_BBSAchchorBSStatus : Wisej.Web.UserControl
    {
        private bool b_bsOutput;
        private bool b_deviceStatus;
        private bool b_embStatus;

        public Comp_BBSAchchorBSStatus()
        {
            InitializeComponent();
        }

        public void setb_bsOutput(bool onNoff)
        {
            if(onNoff)
            {
                this.lb_bsOutput.BackColor = System.Drawing.Color.FromArgb(7, 216, 21);
                this.lb_bsOutput.Text = "방송";
            }
            else
            {
                this.lb_bsOutput.BackColor = System.Drawing.Color.FromArgb(255, 84, 84);
                this.lb_bsOutput.Text = "대기";
            }
        }

        public void setb_deviceStatus(bool deviceOnNoff)
        {
            if (deviceOnNoff)
            {
                this.lb_embStatus.BackColor = System.Drawing.Color.FromArgb(7, 216, 21);
                this.lb_embStatus.Text = "이상";
            }
            else
            {
                this.lb_embStatus.BackColor = System.Drawing.Color.FromArgb(255, 84, 84);
                this.lb_embStatus.Text = "정상";
            }
        }

        public void setb_embStatus(bool emOnNoff)
        {
            if (emOnNoff)
            {
                this.lb_embStatus.BackColor = System.Drawing.Color.FromArgb(7, 216, 21);
                this.lb_embStatus.Text = "이상";
            }
            else
            {
                this.lb_embStatus.BackColor = System.Drawing.Color.FromArgb(255, 84, 84);
                this.lb_embStatus.Text = "정상";
            }
        }


    }
}
