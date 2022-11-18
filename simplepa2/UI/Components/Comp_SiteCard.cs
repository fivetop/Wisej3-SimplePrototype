using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_SiteCard : Wisej.Web.UserControl
    {
        public event CompSiteCardVerify verifyClick;
        public Comp_SiteCard()
        {
            InitializeComponent();
        }

        private void Comp_SiteCard_Load(object sender, EventArgs e)
        {

        }

        private void buttonVerfiy_Click(object sender, EventArgs e)
        {
			if (this.verifyClick != null)
			{
				verifyClick(this, new CompSiteCardVerifyClickedEventArgs((Button)sender));
			}
		}

		public delegate void CompSiteCardVerify(object sender, CompSiteCardVerifyClickedEventArgs e);

		/// <summary>
		/// Data for the OptionClickedEventHandler event handler.
		/// </summary>
		public class CompSiteCardVerifyClickedEventArgs : EventArgs
		{
			internal CompSiteCardVerifyClickedEventArgs(Button button)
			{
				this.ViewName = button.UserData.ViewName;
			}

			public string ViewName
			{
				get;
				private set;
			}
		}
	}
}
