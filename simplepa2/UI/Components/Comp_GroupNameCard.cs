using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_GroupNameCard : Wisej.Web.UserControl
    {
        public bool cardClicked = false;
        public int intCardNo;
        public int intRegionNo;
        public string strGroupName;

        public event GroupClickedEventHandler groupClick;

        public Comp_GroupNameCard(string cardName, int cardNo, int regionCount, bool bClicked)
        {
            InitializeComponent();

            this.intCardNo = cardNo;
            this.lb_cardNo.Text = cardNo.ToString() + ".";

            this.intRegionNo = regionCount;
            this.lb_regionNo.Text = regionCount.ToString() + "개 존";
                 
            this.strGroupName = cardName;
            this.label_GroupName.Text = cardName;

            this.cardClicked = bClicked;


            // normal color 
            // // this.panel8.BackColor = System.Drawing.Color.FromArgb(33, 149, 242);
            // this.label1.ForeColor = System.Drawing.Color.White;
            // this.label50.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);

            // operation color
            // this.panel8.BackColor = System.Drawing.Color.FromArgb(52, 129, 255);
            // 52, 129, 255


        }

        private void panelCardBack_Click(object sender, EventArgs e)
        {
            cardClicked = !cardClicked;

            // 카드가 클릭된 것이면 이벤트 발생
            if (cardClicked) { groupClick(this, new GroupClickedEventArgs(this.strGroupName));  }

            // 상태 변경 
            setCardStatus(cardClicked);            
        }

        public void setCardStatus(bool cardStatus)
        {
                if (cardStatus)
                {
                    this.panelCardBack.BackColor = System.Drawing.Color.FromArgb(52, 129, 255);
                    this.panelCardBack.ForeColor = System.Drawing.Color.White;                    
                }
                else
                {
                    this.panelCardBack.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
                    this.panelCardBack.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
                }
        }

        public delegate void GroupClickedEventHandler(object sender, GroupClickedEventArgs e);

        private void label_GroupName_Click(object sender, EventArgs e)
        {
            panelCardBack_Click(this, null);
        }
    }

    public class GroupClickedEventArgs : EventArgs
    {
        internal GroupClickedEventArgs(string groupName)
        {
            this.groupName = groupName;
        }

        public string groupName
        {
            get;
            private set;
        }
    }
}
