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


        public Widget_BBSMultiDeck(BindingSource bsSource)
        {
            InitializeComponent();

            bsTreeBindingSource = bsSource;
            bsTreeBindingSource.RefreshValueOnChange = true;

            if (bsTreeBindingSource == null)
            {
                MessageBox.Show("LAWTEXXT : BSTree 위젯의 데이터를 입력받지 못하였습니다. ");
            }

            initSetupUI();
            // startTimer();
        }
        public void setBindingSource(BindingSource bsSource)
        {
            this.bsTreeBindingSource = bsSource;
        }


        /*
        public void startTimer()
        {           
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("updateD");
            
            initSetupUI();
        } */

        public void setBSTreeData(DataSet1.BSTreeDataTable data)
        {
            bsTreeData = data;

        }
        public void initSetupUI()
        {
            DataTable dt = (bsTreeBindingSource.List as DataView).ToTable();
                        
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

            deckUIList.Clear();
            this.pn_deckSpace.Controls.Clear();

            // EM 데이터 별로 DR 뽑아서 UI 만들어 주기
            foreach (string strENNAME in listStr)
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
