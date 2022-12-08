using simplepa2.UI.Views;
using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public partial class Comp_PresetNameCard : Wisej.Web.UserControl
    {
        private Preset_DataList dataSet;
        public bool selectMode = false;
        public int intCardNo;
        private string divider = " / ";

        public event PresetClickedEventHandler presetClick;            
        public delegate void PresetClickedEventHandler(object sender, PresetClickedEventArgs e);


        public Comp_PresetNameCard()
        {
            InitializeComponent();
        }

        public Comp_PresetNameCard(Preset_DataList dSet)
        {
            InitializeComponent();
            dataSet = dSet;

            if(dataSet != null)
            {
                this.intCardNo = dSet.intPresetID;
            }
            setCardUserInterface(dSet);
        }

        public void setCardUserInterface(Preset_DataList dSet)
        {
            this.lb_MainText.Text = dSet.strPresetName;
            this.lb_SubText.Text = dSet.strPresetSite + divider + dSet.strSelectAreaCount;
            this.pn_Image.BackgroundImageSource = dSet.strPresetImageName;
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

                presetClick(this, new PresetClickedEventArgs(this.dataSet.intPresetID));

            }
            else
            {                
                this.pn_CardOutline.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
                this.pn_CardOutline.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);

                this.lb_MainText.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);                

                this.lb_SubText.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            }
        }

        private void lb_MainText_Click(object sender, EventArgs e)
        {
            cardStatusChange();
        }

        public void cardStatusChange()
        {
            this.selectMode = !selectMode;

            setCardStatus(this.selectMode);
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

    public class PresetClickedEventArgs : EventArgs
    {
        internal PresetClickedEventArgs(int presetID)
        {
            this.presetID = presetID;
        }

        public int presetID
        {
            get;
            private set;
        }
    }

}
