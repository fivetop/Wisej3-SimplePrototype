using Microsoft.Ajax.Utilities;
using System;
using System.Windows;
using Wisej.Web;

namespace simplepa2
{
    public partial class Comp_UZone : Wisej.Web.UserControl
    {
        public bool Checked { get; set; } = false;

        public Comp_UZone()
        {
            InitializeComponent();
        }

        public void SetZone(string zone)
        { 
            Zone.Text = zone;
        }

        private void Zone_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            Zone_Click(Checked);
        }

        public void Zone_Click(bool chk)
        {
            if (chk)
            {
                panel1.BackColor = System.Drawing.Color.Blue;
                this.Zone.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                Zone.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                panel1.BackColor = System.Drawing.Color.Transparent;
                this.Zone.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                Zone.ForeColor = System.Drawing.Color.Gray;
            }

        }
    }
}
