using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public class Comp_ZoneButton : Wisej.Web.Button
    {
        private Boolean clicked { get; set; }
        private string strName { get; set; }
        private string strText { get; set; }
        public Comp_ZoneButton(string strName, string strText)
        {
            this.strName = strName;
            this.strText = strText;

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
    }
}
