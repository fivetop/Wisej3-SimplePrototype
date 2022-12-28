using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_SiteCard : Wisej.Web.UserControl
    {
        public event CompSiteCardVerify verifyClick;

		private DataSet1.EMServerNDeviceNameRow siteData;
        public Comp_SiteCard()
        {
            InitializeComponent();
        }

		public Comp_SiteCard(DataSet1.EMServerNDeviceNameRow siteData)
        {
			InitializeComponent();

			this.siteData = siteData;
			setupDBData();
		}

		public void setupDBData()
		{
			this.lb_siteName.Text = this.siteData.EMNAME;
			this.lb_siteNo.Text = Convert.ToString(this.siteData.EMServerId);
			this.lb_siteAddress.Text = this.siteData.em_address;
			this.lb_EMName.Text = this.siteData.DeviceName;
			
			if(this.siteData.state == "ON")
            {
				this.lb_EMStatus.BackColor = System.Drawing.Color.FromName("@bStatusGreen");
			}
            else
            {
				this.lb_EMStatus.BackColor = System.Drawing.Color.FromName("@bStatusRed");
			}
			

			
			this.pb_siteImage.ImageSource = this.siteData.em_images;
		}

		private void bt_siteDelete_Click(object sender, EventArgs e)
		{
			MessageBox.Show("LAW TEXT : 사이트삭제는 지원되지 않습니다.");

		}

		private void bt_siteVerfiy_Click(object sender, EventArgs e)
		{
			if (this.verifyClick != null)
			{
				verifyClick(this, new CompSiteCardVerifyClickedEventArgs(this.siteData.EMServerId));
			}
		}

		public delegate void CompSiteCardVerify(object sender, CompSiteCardVerifyClickedEventArgs e);

		/// <summary>
		/// Data for the OptionClickedEventHandler event handler.
		/// </summary>
		public class CompSiteCardVerifyClickedEventArgs : EventArgs
		{
			internal CompSiteCardVerifyClickedEventArgs(int site_index)
			{
				this.site_index = site_index;
			}

			public int site_index
			{
				get;
				private set;
			}
		}


    }
}
