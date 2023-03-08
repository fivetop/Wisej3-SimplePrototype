using System;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{
    public class Comp_ZoneButton : Wisej.Web.Button
    {
        private Boolean clicked { get; set; }
        private string strName { get; set; }
        private string strText { get; set; }

        private AssetsRow myAssetRow;

        public Comp_ZoneButton(string strName, string strText, AssetsRow ar)
        {
            this.strName = strName;
            this.strText = strText;
            this.myAssetRow = ar;

            InitializeComponent();
            setupButton(strText);            
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Comp_ZoneButton
            // 
            this.AppearanceKey = "button-cancel";
            this.Name = "Comp_ZoneButton";
            this.Click += new System.EventHandler(this.Comp_ZoneButton_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private void Comp_ZoneButton_Click(object sender, EventArgs e)
        {
            clicked = !clicked;

            if(clicked)
            {
                this.AppearanceKey = "button-ok";
            }
            else
            {
                this.AppearanceKey = "button-cancel";
                
            }
        }

        private void setupButton(string text)
        {
            this.Text = text;
        }

        public void change_Click(Boolean bChange)
        {
            this.clicked = bChange;

            if (clicked)
            {
                this.AppearanceKey = "button-ok";
            }
            else
            {
                this.AppearanceKey = "button-cancel";
                
               
            }
        }
        public AssetsRow getAssetRowIfSelected()
        {
            if (clicked)
                return myAssetRow;
            else
                return null;
        }
    }
}
