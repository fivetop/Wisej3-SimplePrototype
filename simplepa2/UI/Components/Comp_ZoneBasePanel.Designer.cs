namespace simplepa2.UI.Components
{
    partial class Comp_ZoneBasePanel
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
            this.dataSet11 = new simplepa2.DataSet1();
            this.assetsSitenBuildingTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetsSitenBuildingTableAdapter();
            this.assetsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            this.pn_ZoneArea = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsSitenBuildingTableAdapter1
            // 
            this.assetsSitenBuildingTableAdapter1.ClearBeforeFill = true;
            // 
            // assetsTableAdapter1
            // 
            this.assetsTableAdapter1.ClearBeforeFill = true;
            // 
            // pn_ZoneArea
            // 
            this.pn_ZoneArea.AutoScroll = true;
            this.pn_ZoneArea.BackColor = System.Drawing.Color.FromName("@window");
            this.pn_ZoneArea.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_ZoneArea.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.pn_ZoneArea.Location = new System.Drawing.Point(0, 0);
            this.pn_ZoneArea.Name = "pn_ZoneArea";
            this.pn_ZoneArea.Size = new System.Drawing.Size(800, 600);
            this.pn_ZoneArea.TabIndex = 53;
            this.pn_ZoneArea.Text = "listPanel";
            // 
            // Comp_ZoneBasePanel
            // 
            this.Controls.Add(this.pn_ZoneArea);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "Comp_ZoneBasePanel";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.AssetsSitenBuildingTableAdapter assetsSitenBuildingTableAdapter1;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter1;
        private Wisej.Web.Panel pn_ZoneArea;
    }
}
