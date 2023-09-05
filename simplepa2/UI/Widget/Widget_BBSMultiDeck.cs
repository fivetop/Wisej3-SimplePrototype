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


        public Widget_BBSMultiDeck()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
            this.bsTreeWithStatusTableAdapter1.Fill(this.dataSet11.BsTreeWithStatus);

            deckUIList.Clear();
            this.pn_deckSpace.Controls.Clear();

            DataTable dt = dataSet11.BsTreeWithStatus;
                
            // get EM NAME 추출
            DataRow[] dr = dt.Select();

            var dic = new Dictionary<string, string>();

            string strTemp = null;
            
            foreach (DataRow dr2 in dr)
            {
                if(strTemp == null)
                {
                    strTemp = dr2["EMNAME"].ToString();
                    dic.Add(strTemp, dr2["state"].ToString());
                }

                if (!strTemp.Equals(dr2["EMNAME"].ToString()))
                {
                    strTemp = dr2["EMNAME"].ToString();
                    dic.Add(strTemp, dr2["state"].ToString());                    
                }
            }

            List<string> keys = new List<string>(dic.Keys);

            // EM 데이터 별로 DR 뽑아서 UI 만들어 주기
            foreach (string strENNAME in keys)
            {                
                DataRow[] drs = dt.Select("EMNAME = '" + strENNAME + "'", "chno ASC");                
                Comp_DashBoardBBSDeck tempDeck = new Comp_DashBoardBBSDeck(drs, strENNAME, dic[strENNAME]);
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

        // 채널 개별 디스플레이 처리 -> redraw 에서 채널 색상만 변경 처리 
        internal void reDraw(string eMNAME, int seqno, string v)
        {
            foreach (var t1 in deckUIList)
            {
                foreach (var t2 in t1.deckDataRow)
                { 
                    string str1 = (string)t2["EMNAME"];
                    int int1 = (int)t2["chno"];
                    if (str1 != eMNAME || int1 == seqno) continue;
                    t1.reDraw(eMNAME, seqno, v);
                    break;
                }
            }
        }


        public Panel newSpacerPanel()
        {
            Panel spacer = new Panel();
            spacer.Dock = Wisej.Web.DockStyle.Top;                        
            spacer.Size = new System.Drawing.Size(720, 12);
            spacer.BackColor = System.Drawing.Color.White;

            return spacer;
        }

        private void Widget_BBSMultiDeck_Load(object sender, EventArgs e)
        {
            reDraw();
        }

    }
}
