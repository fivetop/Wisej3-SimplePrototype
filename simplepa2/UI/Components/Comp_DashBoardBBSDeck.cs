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

        public Comp_DashBoardBBSDeck(DataRow[] dr, string EMNAME)
        {
            InitializeComponent();

            deckDataRow = dr;            

            setupUI();
        }

        private void Comp_BBSDeckButton_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            // 01. Update  방 Status 

        }

        public void setupUI()
        {
            flowLayoutPanel1.Controls.Clear();   // UI 구현시 입력시켜놓은 컨포넌트 클리어

            foreach (DataRow row in deckDataRow)
            {                
                Comp_BBSDeckButton bt = new Comp_BBSDeckButton(Convert.ToInt16(row["chno"].ToString()), row["playing"].ToString(),"아무개개");
                flowLayoutPanel1.Controls.Add(bt);
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
