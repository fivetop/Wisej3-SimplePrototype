﻿using System;
using Wisej.Web;

namespace simplepa2.win
{
    public partial class MSetupManager : Wisej.Web.UserControl
    {
        public MSetupManager()
        {
            InitializeComponent();
        }

        private void MSetupManager_Load(object sender, EventArgs e)
        {
            this.simplepaTableAdapter.Fill(this.dataSet1.Simplepa);

        }
    }
}
