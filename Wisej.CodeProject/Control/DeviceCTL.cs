
using Wisej.Web;
using System.Drawing;
using System;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject
{
	public partial class DeviceCTL : UserControl
    {
        public EventHandler UserControlClick;

        private AssetsRow _data1;
        public AssetsRow data1 
        {
            get 
            {
                return this._data1;
            }
            set
            {
                _data1 = value;
                label1.Text = _data1.DeviceName;
                label2.Text = _data1.ip;
                label3.Text = _data1.state;
                label4.Text = _data1.path;

                if (_data1.state == "On-Line")
                {
                    this.label1.ForeColor = Color.Black;
                    this.BackColor = Color.AliceBlue;
                }
                else
                {
                    this.label1.ForeColor = Color.Black;
                    this.BackColor = Color.White;
                    this.pictureBox1.ImageSource = null;
                }

            }
        } 


        public DeviceCTL()
        {
            InitializeComponent();
        }

    }
}