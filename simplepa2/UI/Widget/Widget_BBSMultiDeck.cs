using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;

namespace simplepa2.UI.Widget
{
    public partial class Widget_BBSMultiDeck : Wisej.Web.UserControl
    {
        private List<Comp_DashBoardBBSDeck> uiList = new List<Comp_DashBoardBBSDeck>();

        private DataSet1.BSTreeDataTable bsTreeData;

        private Wisej.Web.BindingSource bsTreeBindingSource;

        private List<Comp_DashBoardBBSDeck> deckUIList = new List<Comp_DashBoardBBSDeck>();

        private Timer timer = new Timer();
        //         private Binding 


        public Widget_BBSMultiDeck()
        {
            InitializeComponent();

            dataBindRefersh();

            reDraw();

            startTimer();
        }

        public void dataBindRefersh()
        {
            this.bsTreeTableAdapter1.Fill(this.dataSet11.BSTree);
        }        
        public void startTimer()
        {           
            timer.Interval = gweb.dashBoardRefreshInterval;
            timer.Tick += Timer_Tick;
            timer.Start();            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dataBindRefersh();
            reDraw();
        } 

        public void reDraw()
        {
            deckUIList.Clear();
            this.pn_deckSpace.Controls.Clear();

            DataTable dt = dataSet11.BSTree;
                
            // get EM NAME 추출
            DataRow[] dr = dt.Select();
            List<string> listStr = new List<string>();
            string strTemp = null;
            foreach (DataRow dr2 in dr)
            {
                if(strTemp == null)
                {
                    strTemp = dr2["EMNAME"].ToString();
                    listStr.Add(strTemp);
                }

                if (!strTemp.Equals(dr2["EMNAME"].ToString()))
                {
                    strTemp = dr2["EMNAME"].ToString();
                    listStr.Add(strTemp);
                }                
            }

            // EM 데이터 별로 DR 뽑아서 UI 만들어 주기
            foreach (string strENNAME in listStr)
            {                
                DataRow[] drs = dt.Select("EMNAME = '" + strENNAME + "'", "chno DESC");                
                Comp_DashBoardBBSDeck tempDeck = new Comp_DashBoardBBSDeck(drs, strENNAME);
                tempDeck.Dock = Wisej.Web.DockStyle.Top;
                this.pn_deckSpace.Controls.Add(tempDeck);

                deckUIList.Add(tempDeck);  // UI Biding 객체저장
            }                    
            

            /* For testing UI 
             * 

            Comp_DashBoardBBSDeck cd1 = new Comp_DashBoardBBSDeck();
            Comp_DashBoardBBSDeck cd2 = new Comp_DashBoardBBSDeck();
            Comp_DashBoardBBSDeck cd3 = new Comp_DashBoardBBSDeck();
            Comp_DashBoardBBSDeck cd4 = new Comp_DashBoardBBSDeck();
            Comp_DashBoardBBSDeck cd5 = new Comp_DashBoardBBSDeck();

            pn_deckSpace.Controls.Add(cd1);
            pn_deckSpace.Controls.Add(cd2);
            pn_deckSpace.Controls.Add(cd3);
            pn_deckSpace.Controls.Add(cd4);

            pn_deckSpace.Controls.Add(cd5);
            */
        }

        public Panel newSpacerPanel()
        {
            Panel spacer = new Panel();
            spacer.Dock = Wisej.Web.DockStyle.Top;                        
            spacer.Size = new System.Drawing.Size(720, 12);
            spacer.BackColor = System.Drawing.Color.White;

            return spacer;
        }
    }
}
