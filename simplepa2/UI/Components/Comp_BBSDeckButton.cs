using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public class Comp_BBSDeckButton : Wisej.Web.Button
    {
        public Comp_BBSDeckButton()
        {
            InitializeComponent();
            
        }
        public Comp_BBSDeckButton(string text, int value)
        {
            InitializeComponent();
            this.Text = text;

            setupUIRandom(value);
        }

        public void setupUIRandom(int value)
        {
            Random ran = new Random();

            switch(value/3)
            { 
                case 0:
                setStatusGreen();
                    break; 
                case 1:
                setStatusRed();
                    break;
                 case 2:
                    setStatusYellow();
                        break;

            }

        }


        public void setStatusGreen()
        {
            this.BackColor = System.Drawing.Color.FromName("@button3BG");
            this.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
        }

        public void setStatusYellow()
        {
            this.BackColor = System.Drawing.Color.FromName("@bStatusYellolw");
            this.ForeColor = System.Drawing.Color.FromName("@bTextNormal");

        }

        public void setStatusRed()
        {
            this.BackColor = System.Drawing.Color.FromName("@bStatusRed");
            this.ForeColor = System.Drawing.Color.FromName("@bTextNormal");

        }


        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Comp_BBSDeckButton
            // 
            this.BackColor = System.Drawing.Color.FromName("@button3BG");
            this.Dock = Wisej.Web.DockStyle.Left;
            this.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.Name = "Comp_BBSDeckButton";
            this.Size = new System.Drawing.Size(59, 42);
            this.Text = "Ch1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
