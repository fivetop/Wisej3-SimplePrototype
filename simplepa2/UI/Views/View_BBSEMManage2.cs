﻿using DataClass;
using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBSEMManage2 : Wisej.Web.UserControl
    {

        public View_BBSEMManage2()
        {
            InitializeComponent();
        }

        private void BSAsset_Load(object sender, EventArgs e)
        {
            this.eMServerTableAdapter.Fill(this.dataSet1.EMServer);
        }

        internal void reDraw()
        {
            this.eMServerTableAdapter.Fill(this.dataSet1.EMServer);
        }

        // EM 상태 요청 처리 
        private void button2_Click(object sender, EventArgs e)
        {
            reDraw();
        }


    }
}