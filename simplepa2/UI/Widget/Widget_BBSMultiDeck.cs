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


        //         private Binding 


        public Widget_BBSMultiDeck()
        {
            InitializeComponent();

        }

        public Widget_BBSMultiDeck(BindingSource bsSource)
        {
            InitializeComponent();

            bsTreeBindingSource = bsSource;
            if (bsTreeBindingSource == null)
            {
                MessageBox.Show("LAWTEXXT : BSTree 위젯의 데이터를 입력받지 못하였습니다. ");
            }

            initSetupUI();
        }
        
        public void setBSTreeData(DataSet1.BSTreeDataTable data)
        {
            bsTreeData = data;

        }
        public void initSetupUI()
        {
            DataTable dt = (bsTreeBindingSource.List as DataView).ToTable();
                        
            // get EM NAME 추출
            DataRow[] dr = dt.Select();
            List<string> tempList = new List<string>();
            string temp = null;
            foreach (DataRow dr2 in dr)
            {
                if(temp == null)
                {                    
                    temp = dr2["EMNAME"].ToString();
                    tempList.Add(temp);
                }

                if (!temp.Equals(dr2["EMNAME"].ToString()))
                {
                    temp = dr2["EMNAME"].ToString();
                    tempList.Add(temp);
                }                
            }

            // EM 데이터 별로 DR 뽑아서 UI 만들어 주기
            foreach(string strENNAME in tempList)
            {                
                DataRow[] drs = dt.Select("EMNAME = '" + strENNAME + "'", "chno DESC");                
                Comp_DashBoardBBSDeck tempDeck = new Comp_DashBoardBBSDeck(drs, strENNAME);
                tempDeck.Dock = Wisej.Web.DockStyle.Top;
                this.pn_deckSpace.Controls.Add(tempDeck);

                deckUIList.Add(tempDeck);  // UI Biding 객체저장
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
    }
}
