using System;
using System.Drawing;
using Wisej.Web;

namespace simplepa2
{
    public partial class bslamp : Wisej.Web.UserControl
    {
        public bslamp()
        {
            InitializeComponent();
        }

        public void LabelOn(int cnt, bool b = false)
        {
            switch (cnt)
            {
                case 1:
                    if (b) label1.ForeColor = Color.OrangeRed;
                    else label1.ForeColor = Color.Black;
                    break;
                case 2:
                    if (b) label2.ForeColor = Color.White;
                    else label2.ForeColor = Color.Black;
                    break;
                case 3:
                    if (b) label3.ForeColor = Color.White;
                    else label3.ForeColor = Color.Black;
                    break;
                case 4:
                    if (b) label4.ForeColor = Color.White;
                    else label4.ForeColor = Color.Black;
                    break;
                case 5:
                    if (b) label5.ForeColor = Color.White;
                    else label5.ForeColor = Color.Black;
                    break;
                case 6:
                    if (b) label6.ForeColor = Color.White;
                    else label6.ForeColor = Color.Black;
                    break;
                case 7:
                    if (b) label7.ForeColor = Color.White;
                    else label7.ForeColor = Color.Black;
                    break;
                case 8:
                    if (b) label8.ForeColor = Color.White;
                    else label8.ForeColor = Color.Black;
                    break;
                case 9:
                    if (b) label9.ForeColor = Color.Cyan;
                    else label9.ForeColor = Color.Black;
                    break;
            }

        }
    }
}
