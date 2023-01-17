using simplepa2.UI.Components;
using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBSMusicManage : Wisej.Web.UserControl
    {
        public View_BBSMusicManage()
        {
            InitializeComponent();
        }

        public void reDraw()
        {

            this.panel_filePlayerLocation.Controls.Clear();
            this.panel_filePlayerLocation.Controls.Add(new Comp_FilePlayer());
            this.panel_filePlayerLocation.Height = 450;
        }

        private void View_BBSMusicManage_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        private void bt_musicSize_Click(object sender, EventArgs e)
        {
            if(this.panel_filePlayerLocation.Height == 450)
            {
                this.panel_filePlayerLocation.Height = 700;
                this.bt_musicSize.Text = "축소";
            }
            else
            {
                this.panel_filePlayerLocation.Height = 450;
                this.bt_musicSize.Text = "확대";
            }
            
        }
    }
}
