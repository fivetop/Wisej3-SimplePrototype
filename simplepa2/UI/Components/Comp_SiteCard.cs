using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_SiteCard : Wisej.Web.UserControl
    {
        public event CompSiteCardVerify verifyClick;

		private DataSet1.spa_siteRow siteData;
        public Comp_SiteCard()
        {
            InitializeComponent();
        }

		public Comp_SiteCard(DataSet1.spa_siteRow siteData)
        {
			InitializeComponent();

			this.siteData = siteData;
			setupDBData();
		}

		public void setupDBData()
        {
			this.lb_siteName.Text = this.siteData.site_name;
			this.lb_dong.Text = Convert.ToString(this.siteData.num_of_bd);
			this.lb_address.Text = this.siteData.site_address;
			this.lb_description.Text = this.siteData.site_description;
			this.lb_BServer.Text = Convert.ToString(this.siteData.em_device_id);
			this.pb_siteImage.ImageSource = this.siteData.site_images;
		}

		private void bt_siteDelete_Click(object sender, EventArgs e)
		{
			MessageBox.Show("추가 작업 : 해당 사이트 데이터를 삭제 합니다.");

		}

		private void bt_siteVerfiy_Click(object sender, EventArgs e)
		{
			if (this.verifyClick != null)
			{
				verifyClick(this, new CompSiteCardVerifyClickedEventArgs(this.siteData.site_index));
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
