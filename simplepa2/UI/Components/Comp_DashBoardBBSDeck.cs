using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_DashBoardBBSDeck : Wisej.Web.UserControl
    {
        private DataRow[] deckDataRow;
        private List<Comp_BBSDeckButton> btList = new List<Comp_BBSDeckButton>();
        private int selectChno;

        public Comp_DashBoardBBSDeck()
        {
            InitializeComponent();
        }

        public Comp_DashBoardBBSDeck(DataRow[] dr, string EMNAME, string emState)
        {
            InitializeComponent();

            deckDataRow = dr;     
            // deckDataRow.
            lb_siteName.Text = EMNAME;

            setupEMStatus(emState);
            setupUI(emState);
        }

        private void Comp_BBSDeckButton_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            // 01. Update  방 Status 

        }

        public void setupEMStatus(string emState)
        {
            if (emState.Equals("ONLINE"))
            {
                this.lb_emStatus.AutoEllipsis = true;
                this.lb_emStatus.BackColor = System.Drawing.Color.FromName("@bStatusGreen");
                this.lb_emStatus.CssStyle = "border-radius:15px";
                this.lb_emStatus.Font = new System.Drawing.Font("default", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                this.lb_emStatus.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
                this.lb_emStatus.Location = new System.Drawing.Point(94, 17);
                this.lb_emStatus.Margin = new Wisej.Web.Padding(0);                
                this.lb_emStatus.Size = new System.Drawing.Size(30, 30);
                this.lb_emStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.lb_emStatus.Text = "ON";
            }
            else
            {
                this.lb_emStatus.AutoEllipsis = true;
                this.lb_emStatus.BackColor = System.Drawing.Color.FromArgb(255, 84, 84);
                this.lb_emStatus.CssStyle = "border-radius:15px";
                this.lb_emStatus.Font = new System.Drawing.Font("default", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                this.lb_emStatus.ForeColor = System.Drawing.Color.White;
                this.lb_emStatus.Location = new System.Drawing.Point(94, 17);
                this.lb_emStatus.Margin = new Wisej.Web.Padding(0);
                this.lb_emStatus.Size = new System.Drawing.Size(30, 30);                
                this.lb_emStatus.Text = "OFF";
                this.lb_emStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
        }



        public void setupUI(string emState)
        {
            flowLayoutPanel1.Controls.Clear();   // UI 구현시 입력시켜놓은 컨포넌트 클리어

            if(emState.Equals("ONLINE"))
            {
                foreach (DataRow row in deckDataRow)
                {                    
                    Comp_BBSDeckButton bt = new Comp_BBSDeckButton(Convert.ToInt16(row["chno"].ToString()), row["playing"].ToString(), row["user_name"].ToString());
                    flowLayoutPanel1.Controls.Add(bt);
                }
            }
            else
            {
                foreach (DataRow row in deckDataRow)
                {
                    Comp_BBSDeckButton bt = new Comp_BBSDeckButton(Convert.ToInt16(row["chno"].ToString()), "알수없음", "확인");
                    flowLayoutPanel1.Controls.Add(bt);
                }
            }

        }       

    public Panel spacer()
        {
            Panel spacer = new Panel();
            spacer.Dock = Wisej.Web.DockStyle.Left;
            spacer.Size = new System.Drawing.Size(5, 60);
            spacer.BackColor = System.Drawing.Color.Transparent;

            return spacer;
        }

    }
}
