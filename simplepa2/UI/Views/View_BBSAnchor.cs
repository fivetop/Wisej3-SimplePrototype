﻿using System;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBSAnchor : Wisej.Web.UserControl
    {
        public View_BBSAnchor()
        {
            InitializeComponent();
        }

        private void popTestButton_Click(object sender, EventArgs e)
        {
            label2.Text = "chcnge";
        }
    }
}