using simplepa2.UI.Views;
using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_PresetNameCard2 : Wisej.Web.UserControl
    {
        public bool selectMode = false;
        public DataSet1.PresetRow singleData;
        public event EventHandler ClickedEventHandler;

        // 화면에 표기할 내용 로비외 23곳/음원3개 
        public string EMName { get; set; }
        public string ZoneName { get; set; }
        public int ZoneCount { get; set; }
        public string MusicName { get; set; }
        public int MusicCount { get; set; }

        public Comp_PresetNameCard2(DataSet1.PresetRow dSet)
        {
            InitializeComponent();
            this.singleData = dSet;
            this.lb_MainText.Text = dSet.Name;
        }

        public void setCardStatus(bool sel)
        {
            if (sel)
            {
                selectMode = true;
                ClickedEventHandler?.Invoke(this.singleData.PresetId, null);
                this.pn_CardOutline.BackColor = System.Drawing.Color.FromArgb(52, 129, 255);   // 파란
                this.pn_CardOutline.ForeColor = System.Drawing.Color.White; // 흰색
                this.lb_MainText.ForeColor = System.Drawing.Color.White;  // 메인 흰색                
                this.lb_SubText.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
                this.lb_SubText.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {                
                this.pn_CardOutline.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
                this.pn_CardOutline.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
                this.lb_MainText.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);                
                this.lb_SubText.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
                selectMode = false;
            }
        }

        public void setCardText()
        {
            this.lb_SubText.Text = EMName + " " + ZoneName + " 포함 " + ZoneCount + "곳 / 음원" +MusicCount.ToString() + "개";
        }

        public void cardStatusChange()
        {
            this.selectMode = !selectMode;
            setCardStatus(this.selectMode);
        }
        private void lb_MainText_Click(object sender, EventArgs e)
        {
            cardStatusChange();
        }

        private void lb_SubText_Click(object sender, EventArgs e)
        {
            cardStatusChange();
        }

        private void pn_CardOutline_Click(object sender, EventArgs e)
        {
            cardStatusChange();
        }
    }

}
