using System;
using Wisej.Web;

namespace simplepa2.UI.Components
{
    public class Comp_SiteListComboBox : Wisej.Web.ComboBox
    {
        DataSet1 DataSet1 { get; set; }

        public Comp_SiteListComboBox(DataSet1.EMServerWithWholeColDataTable dt)
        {
            InitializeComponent();

            this.DataSource = dt;
            this.SelectedIndex = 0;
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
            // Comp_SiteListComboBox
            // 
            this.DisplayMember = "EMNAME";
            this.Font = new System.Drawing.Font("@menu", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Comp_SiteListComboBox";
            this.Text = "Comp_SiteListComboBox";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
