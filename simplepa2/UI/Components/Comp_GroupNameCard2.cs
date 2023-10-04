using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_GroupNameCard2 : Wisej.Web.UserControl
    {
        public bool cardClicked = false;
        public int intCardNo;
        public string strGroupName;
        public event EventHandler ClickedEventHandler;
        Group_DataPack data;

        public Comp_GroupNameCard2(Group_DataPack data)
        {
            InitializeComponent();
            this.data = data;
            this.intCardNo = data.intGroupIndex;
            this.lb_cardNo.Text = intCardNo.ToString() + ".";
            this.lb_regionNo.Text = data.intRegionCount.ToString() + "개 존";
            this.strGroupName = data.strGroupName;
            this.label_GroupName.Text = data.strGroupName;
        }

        private void panelCardBack_Click(object sender, EventArgs e)
        {
            cardClicked = !cardClicked;
            setCardStatus(cardClicked);
        }

        public void setCardStatus(bool cardStatus)
        {
            if (cardStatus)
            {
                cardClicked = true;
                ClickedEventHandler?.Invoke(this.intCardNo, null);
                this.panelCardBack.BackColor = System.Drawing.Color.FromArgb(52, 129, 255);
                this.panelCardBack.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                this.panelCardBack.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
                this.panelCardBack.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
                cardClicked = false;
            }
        }

        private void label_GroupName_Click(object sender, EventArgs e)
        {
            panelCardBack_Click(this, null);
        }

    }
}
