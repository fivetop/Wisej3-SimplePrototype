
using Wisej.Web;
using System.Drawing;
using System;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject
{
	public partial class UserControl1 : UserControl
    {
        public EventHandler UserControlClick;

        bool _chk;
        public bool Chk 
        {
            get 
            {   
                return _chk;
            } 
            set 
            {
                _chk = value;
                if (_chk == true)
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

        string _path;
        public string Title
        {
            get 
            {
                return _path; 
            }
            set 
            {
                _path = value;
                label1.Text = _path; 
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