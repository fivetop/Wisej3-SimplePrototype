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
            this.panel_filePlayerLocation.Height = 360;
        }

        private void View_BBSMusicManage_Load(object sender, EventArgs e)
        {
            reDraw();
        }
    }
}
