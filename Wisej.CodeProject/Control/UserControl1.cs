
using Wisej.Web;
using System.Drawing;
using System;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject
{
	public partial class UserControl1 : UserControl
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
                this.Title = _data1.path;
                this.Chk = _data1.chk == 0 ? false:true;
            }
        } 

        public bool Chk 
        {
            get 
            {
                return this.data1.chk == 0 ? false : true;
            } 
            set 
            {
                this.data1.chk = value == false ? 0 : 1;
                if (this.data1.chk == 1)
                {
                    this.label1.ForeColor = Color.Black;
                    this.BackColor = Color.OrangeRed;
                }
                else
                {
                    this.label1.ForeColor = Color.Black;
                    this.BackColor = Color.White;
                }
            }
        }
        public string Title
        {
            get 
            {
                return this.data1.path; 
            }
            set 
            {
                this.data1.path = value;
                label1.Text = this.data1.path; 
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UserControlClick?.Invoke(this, e);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            UserControlClick?.Invoke(this, e);
        }
    }
}