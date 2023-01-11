using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public class Comp_BBSDeckButton : Wisej.Web.Button
    {
        public string bStatus;
        public Label label3;
        public int chno;
        public bool selectButton = false;

        public Comp_BBSDeckButton()
        {
            InitializeComponent();

        }
        public Comp_BBSDeckButton(int chno, string bstatus)
        {
            InitializeComponent();

            this.chno = chno;
            this.bStatus = bstatus;

            this.Text = "Ch" + chno;

            setupUIRandom(bstatus);
        }

        public void setupUIRandom(string bstatus)
        {
            Random ran = new Random();

            if (bstatus.Equals("대기"))
            {
                setStatusGreen();
            }
            else if (bstatus.Equals("방송시작"))
            {
                setStatusRed();
            }
            else
            {
                setStatusYellow();
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

        public bool changeClickStatusButton()
        {
            selectButton = !selectButton;

            if (selectButton)
            {
                this.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.label3.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            }
            else
            {
                this.label3.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            }

            return selectButton;
        }


        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(-2, 20);
            this.label3.Name = "label3";
            this.label3.Padding = new Wisej.Web.Padding(3);
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 95;
            this.label3.Text = "사용자명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Comp_BBSDeckButton
            // 
            this.BackColor = System.Drawing.Color.FromName("@button3BG");
            this.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Controls.Add(this.label3);
            this.Dock = Wisej.Web.DockStyle.Left;
            this.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.Margin = new Wisej.Web.Padding(2);
            this.Name = "Comp_BBSDeckButton";
            this.Padding = new Wisej.Web.Padding(3);
            this.Size = new System.Drawing.Size(70, 50);
            this.Text = "Ch1";
            this.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResumeLayout(false);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
        #endregion

}
