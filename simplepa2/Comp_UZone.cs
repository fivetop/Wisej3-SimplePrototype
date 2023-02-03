using Microsoft.Ajax.Utilities;
using System;
using System.Windows;
using Wisej.Web;
using simplepa2.Controller;

namespace simplepa2
{
    public partial class Comp_UZone : Wisej.Web.UserControl
    {
        public Comp_UZone()
        {
            InitializeComponent();
        }

        Assets _assetRow;

        public Assets assetRow
        {
            get { return _assetRow; }
            set
            {
                _assetRow = value;
                Zone.Text = _assetRow.ZoneName;
            }
        }

        private void Zone_Click(object sender, EventArgs e)
        {
            if(_assetRow.chk == 1)
                _assetRow.chk = 0;
            else
                _assetRow.chk = 1;
            Zone_Click(_assetRow.chk);
        }

        public void Zone_Click(int? chk)
        {
            if (chk == 1)
            {
                _assetRow.chk = 1;
                panel1.BackColor = System.Drawing.Color.Blue;
                this.Zone.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                Zone.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                _assetRow.chk = 0;
                panel1.BackColor = System.Drawing.Color.Transparent;
                this.Zone.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                Zone.ForeColor = System.Drawing.Color.Gray;
            }

        }

    }
}
