
using Wisej.Web;
using System.Drawing;
using System;

namespace Wisej.ListViewPanels
{
	public partial class UserControl1 : UserControl
    {
        public EventHandler UserControlClick;

        private data1 _data1;
        public data1 data1 
        {
            get 
            {
                return this._data1;
            }
            set
            {
                _data1 = value;
                this.Title = _data1.Title;
                this.Chk = _data1.Chk;
            }
        } 

        public bool Chk 
        {
            get 
            {
                return this.data1.Chk;
            } 
            set 
            {
                this.data1.Chk = value;
                if (this.data1.Chk)
                    this.BackColor = Color.AliceBlue;
                else
                    this.BackColor = Color.White;
            }
        }
        public string Title
        {
            get 
            {
                return this.data1.Title; 
            }
            set 
            {
                this.data1.Title = value;
                label1.Text = this.data1.Title; 
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
    }
}