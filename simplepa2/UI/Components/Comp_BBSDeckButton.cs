using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public class Comp_BBSDeckButton : Wisej.Web.Button
    {
        public string bStatus;
        public int chno;
        private Label lb_User;
        public bool selectButton = false;

        // 대기, -> 대기
        // 방송종료, 방송중지 -> 대기
        // 방송시작, 방송중, -> 방송 주황
        


        public Comp_BBSDeckButton()
        {
            InitializeComponent();

        }
        public Comp_BBSDeckButton(int chno, string bstatus, string userName)
        {
            InitializeComponent();

            this.chno = chno;
            this.bStatus = bstatus;
            this.Text = "Ch" + chno;

            setupUIRandom(bstatus);

            setupUserText(userName);
        }

        public void setupUserText(string userName)
        {
            string labelString = userName;

            if(labelString == null || labelString.Equals(""))
            {
                labelString = "준비";
            }
            else if (labelString != null)
            {
                if(isContainHangul(labelString))
                {
                    if (labelString.Length > 3)
                    {
                        labelString = labelString.Substring(0, 3);
                        labelString = labelString + "..";
                    }
                }
                else
                {
                    if (labelString.Length > 5)
                    {
                        labelString = labelString.Substring(0, 5);
                        labelString = labelString + "..";
                    }
                }

            }
            this.lb_User.Text = labelString;

        }

        public bool isContainHangul(string s)
        {
            char[] charArr = s.ToCharArray();
            foreach(char c in charArr)
            {
                if(char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                {
                    return true;
                }
            }
            return false; 
        }
        

        public void setupUIRandom(string bstatus)
        {
            Random ran = new Random();

            if (bstatus.Equals("대기") || bstatus.Equals("방송종료") || bstatus.Equals("방송중지"))
            {
                setStatusGreen();
            }
            else if (bstatus.Equals("방송시작") || bstatus.Equals("방송중"))
            {
                setStatusYellow();             
            }
            else
            {
                setStatusRed();
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
                //this.label3.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            }
            else
            {
                //this.label3.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.lb_User = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.lb_User.Dock = Wisej.Web.DockStyle.Bottom;
            this.lb_User.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_User.Location = new System.Drawing.Point(2, 24);
            this.lb_User.Name = "label1";
            this.lb_User.Size = new System.Drawing.Size(61, 24);
            this.lb_User.TabIndex = 0;
            this.lb_User.Text = "사용자";
            this.lb_User.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Comp_BBSDeckButton
            // 
            this.BackColor = System.Drawing.Color.FromName("@button3BG");
            this.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Controls.Add(this.lb_User);
            this.CssStyle = "    width: 50px;\r\n    height: 50px;\r\n    border-radius: 15px;\r\n    border: 1px so" +
    "lid /*#E0E3EB*/#dde4f3;";
            this.Font = new System.Drawing.Font("@topLabel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.Margin = new Wisej.Web.Padding(2);
            this.Name = "Comp_BBSDeckButton";
            this.Padding = new Wisej.Web.Padding(2);
            this.Size = new System.Drawing.Size(65, 50);
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
