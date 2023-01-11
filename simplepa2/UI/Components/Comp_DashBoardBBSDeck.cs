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
        public Comp_DashBoardBBSDeck(DataRow[] dr, string EMNAME)
        {
            InitializeComponent();

            deckDataRow = dr;
            lb_EMNAME.Text = EMNAME;

            setupUI();
        }

        private void Comp_BBSDeckButton_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AlertBox.Show("사이트명 : " + this.lb_EMNAME.Text + "    채널번호 : " + (sender as Comp_BBSDeckButton).Text + 
                " 방 상태 : " + (sender as Comp_BBSDeckButton).bStatus + " 클릭되었습니다");

            gweb.mainFrame.setupBSroomWithOpen(this.lb_EMNAME.Text, (sender as Comp_BBSDeckButton).chno);
            
            // 01. Update  방 Status 

        }

        public void setupUI()
        {            
            foreach(DataRow row in deckDataRow)
            {                
                Comp_BBSDeckButton bt = new Comp_BBSDeckButton(Convert.ToInt16(row["chno"].ToString()), row["playing"].ToString());                
                bt.MouseDoubleClick += new Wisej.Web.MouseEventHandler(this.Comp_BBSDeckButton_MouseDoubleClick);
                bt.Click += new System.EventHandler(this.Comp_BBSDeckButton_Click);                

                this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
                this.pn_button.Controls.Add(bt);
                btList.Add(bt);
                this.pn_button.Controls.Add(spacer());
            }

        }
        private void Comp_BBSDeckButton_Click(object sender, EventArgs e)
        {
            Comp_BBSDeckButton objectButton = sender as Comp_BBSDeckButton;
            
            if(objectButton.changeClickStatusButton())
            { // 신규 클릭된것이라면
                selectChno = objectButton.chno;  // 선택 버튼 ID 업데이트 

                // // 같은 그룹내 Ch 아닌거 모두 해제
                foreach (Comp_BBSDeckButton dt in btList)
                {
                    if(dt.selectButton && dt.chno != selectChno)
                    {
                        dt.changeClickStatusButton();
                    }
                }                
                
            }
            else   // 기 선택된 것이 해제된 것이면 false 가 리턴됨
            {
                selectChno = 0;   // 초기화
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

        private void bt_enter_Click(object sender, EventArgs e)
        {
            if(selectChno != 0)
            {
                MessageBox.Show(selectChno + " 방으로 이동 합니다.");
            }
            
        }

        private void bt_bbsExit_Click(object sender, EventArgs e)
        {
            if (selectChno != 0)
            {
                MessageBox.Show(selectChno + " 방의 동작을 즉시 중지합니다.");
            }


        }
    }
}
