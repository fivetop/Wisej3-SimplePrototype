using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Wisej.Web;
using simplepa2.Controller;

namespace simplepa2
{
    public partial class Comp_UFloor : Wisej.Web.UserControl
    {
        bool _Floor { get; set; } = false;

        IEnumerable <Comp_UZone> _child= null;

        public Comp_UFloor()
        {
            InitializeComponent();
        }
        private void f1_SizeChanged(object sender, EventArgs e)
        {
            this.Height = f1.Height + 10;
            panel1.Height = f1.Height;
            shape1.Height = f1.Height;
            //shape1.Width = this.Width - 20;
            //shape1.Location = new System.Drawing.Point(5, 5);
        }

        string _지역명;

        public string 지역명 
        {
            get 
            {
                return _지역명;
            }
            set 
            { 
                _지역명 = value;
                Floor.Text = _지역명;
            } 
        }

        Assets _assetRow;

        public Assets assetRow
        {
            get { return _assetRow; }
            set 
            { 
                _assetRow = value;
                Comp_UZone b1 = new Comp_UZone();
                b1.assetRow = _assetRow;
                b1.Width = 140;
                b1.Height = 50;
                this.f1.Controls.Add(b1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _Floor = !_Floor;
            if (_Floor)
            {
                this.Floor.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                Floor.ForeColor = System.Drawing.Color.Blue;

                var t2 = f1.Controls.ToList(); // .ToList();
                foreach (Comp_UZone t1 in t2)
                    t1.Zone_Click(1);
            }
            else
            {
                this.Floor.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                Floor.ForeColor = System.Drawing.Color.Gray;
                var t2 = f1.Controls.ToList(); // .ToList();
                foreach (Comp_UZone t1 in t2)
                    t1.Zone_Click(0);
            }
        }

        private void UFloor_Load(object sender, EventArgs e)
        {
        }
    }
}
