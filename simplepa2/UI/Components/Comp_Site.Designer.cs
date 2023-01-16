namespace simplepa2.UI.Components
{
    partial class Comp_Site
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_BuildingName = new Wisej.Web.Label();
            this.cb_SiteName = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // lb_BuildingName
            // 
            this.lb_BuildingName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_BuildingName.Location = new System.Drawing.Point(0, 0);
            this.lb_BuildingName.Name = "lb_BuildingName";
            this.lb_BuildingName.Size = new System.Drawing.Size(68, 32);
            this.lb_BuildingName.TabIndex = 94;
            this.lb_BuildingName.Text = "사이트명";
            this.lb_BuildingName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_SiteName
            // 
            this.cb_SiteName.AutoSize = false;
            this.cb_SiteName.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cb_SiteName.Items.AddRange(new object[] {
            "전체"});
            this.cb_SiteName.Location = new System.Drawing.Point(70, 1);
            this.cb_SiteName.Margin = new Wisej.Web.Padding(0);
            this.cb_SiteName.Name = "cb_SiteName";
            this.cb_SiteName.Size = new System.Drawing.Size(200, 32);
            this.cb_SiteName.TabIndex = 93;
            this.cb_SiteName.SelectedValueChanged += new System.EventHandler(this.cb_SiteName_SelectedValueChanged);
            // 
            // Comp_Site
            // 
            this.Controls.Add(this.lb_BuildingName);
            this.Controls.Add(this.cb_SiteName);
            this.Name = "Comp_Site";
            this.Size = new System.Drawing.Size(270, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Label lb_BuildingName;
        private Wisej.Web.ComboBox cb_SiteName;
    }
}
