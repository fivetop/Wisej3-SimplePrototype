﻿using System;
using Wisej.Web;


namespace Wisej.CodeProject
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(200,200);
        }

    }
}
