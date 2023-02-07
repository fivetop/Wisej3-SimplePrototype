using simplepa2.UI.Views;
using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_PresetNameCard2 : Wisej.Web.UserControl
    {
        public bool selectMode = false;
        public DataSet1.PresetRow preset_singleData;
        public event EventHandler PresetClickedEventHandler;            

        public Comp_PresetNameCard2(DataSet1.PresetRow dSet)
        {
            InitializeComponent();
            this.preset_singleData = dSet;
            this.lb_MainText.Text = dSet.Name;
            //this.lb_SubText.Text = dSet.strPresetSite + "/" + dSet.strSelectAreaCount;
            //this.pn_Image.BackgroundImageSource = dSet.strPresetImageName;
        }

        public void setCardStatus(bool selectMode)
        {
            if (selectMode)
            {
                this.pn_CardOutline.BackColor = System.Drawing.Color.FromArgb(52, 129, 255);   // 파란
                this.pn_CardOutline.ForeColor = System.Drawing.Color.White; // 흰색

                this.lb_MainText.ForeColor = System.Drawing.Color.White;  // 메인 흰색                

                this.lb_SubText.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
                this.lb_SubText.BackColor = System.Drawing.Color.Transparent;

                //presetClick(this, new PresetClickedEventArgs(this.dataSet.intPresetID));
                PresetClickedEventHandler?.Invoke(this, null);

            }
            else
            {                
                this.pn_CardOutline.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
                this.pn_CardOutline.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
                this.lb_MainText.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);                
                this.lb_SubText.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            }
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
