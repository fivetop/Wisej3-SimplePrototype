using simplepa2.UI.Components;
using simplepa2.UI.Popups;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCSite : Wisej.Web.UserControl
    {
        private Popup_BBCSiteForm pop_BBCSiteForm;

        private Random random = new Random();

        public View_BBCSite()
        {
            InitializeComponent();

            
        }

        private void comboBoxView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var flow = (FlowDirection)Enum.Parse(typeof(FlowDirection), (string)this.comboBoxView2.SelectedItem);
            //this.flowLayoutPanel1.FlowDirection = flow;

        }


        private void View_BBCSite_Load(object sender, EventArgs e)
        {
            addRandCardForTestSite();

        }

        public void addRandCardForTestSite()
        {
            var card1 = new Comp_SiteCard();
            var card2 = new Comp_SiteCard();
            var card3 = new Comp_SiteCard();
            var card4 = new Comp_SiteCard();
            var card5 = new Comp_SiteCard();
            var card6 = new Comp_SiteCard();
            var card7 = new Comp_SiteCard();

            card1.verifyClick += new Comp_SiteCard.CompSiteCardVerify(this.siteCardVerifyClick);
            card2.verifyClick += new Comp_SiteCard.CompSiteCardVerify(this.siteCardVerifyClick);
            card3.verifyClick += new Comp_SiteCard.CompSiteCardVerify(this.siteCardVerifyClick);
            card4.verifyClick += new Comp_SiteCard.CompSiteCardVerify(this.siteCardVerifyClick);
            card5.verifyClick += new Comp_SiteCard.CompSiteCardVerify(this.siteCardVerifyClick);
            card6.verifyClick += new Comp_SiteCard.CompSiteCardVerify(this.siteCardVerifyClick);
            card7.verifyClick += new Comp_SiteCard.CompSiteCardVerify(this.siteCardVerifyClick);            
            /*
            this.flowLayoutPanel1.Controls.Add(card1);
            this.flowLayoutPanel1.Controls.Add(card2);
            this.flowLayoutPanel1.Controls.Add(card3);
            this.flowLayoutPanel1.Controls.Add(card4);
            this.flowLayoutPanel1.Controls.Add(card5);
            this.flowLayoutPanel1.Controls.Add(card6);
            this.flowLayoutPanel1.Controls.Add(card7);
            */
        }

        private void siteCardVerifyClick(object sender, Comp_SiteCard.CompSiteCardVerifyClickedEventArgs args)
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
