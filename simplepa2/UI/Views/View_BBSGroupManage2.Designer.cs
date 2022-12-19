namespace simplepa2.UI.Views
{
    partial class View_BBSGroupManage2
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
            this.splitContainer7 = new Wisej.Web.SplitContainer();
            this.listviewCTL1 = new simplepa2.Control.ListviewCTL();
            this.listviewCTL2 = new simplepa2.Control.ListviewCTL();
            this.dataSet1 = new simplepa2.DataSet1();
            this.assetsTableAdapter = new simplepa2.DataSet1TableAdapters.AssetsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.listviewCTL1);
            this.splitContainer7.Panel1.TabStop = true;
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.listviewCTL2);
            this.splitContainer7.Panel2.TabStop = true;
            this.splitContainer7.Size = new System.Drawing.Size(900, 600);
            this.splitContainer7.SplitterDistance = 297;
            this.splitContainer7.TabIndex = 2;
            // 
            // listviewCTL1
            // 
            this.listviewCTL1.Location = new System.Drawing.Point(20, 25);
            this.listviewCTL1.Name = "listviewCTL1";
            this.listviewCTL1.Size = new System.Drawing.Size(272, 197);
            this.listviewCTL1.TabIndex = 0;
            // 
            // listviewCTL2
            // 
            this.listviewCTL2.Location = new System.Drawing.Point(21, 25);
            this.listviewCTL2.Name = "listviewCTL2";
            this.listviewCTL2.Size = new System.Drawing.Size(381, 197);
            this.listviewCTL2.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // AGroup
            // 
            this.Controls.Add(this.splitContainer7);
            this.Name = "AGroup";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.AGroup_Load);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.SplitContainer splitContainer7;
        private Control.ListviewCTL listviewCTL1;
        private Control.ListviewCTL listviewCTL2;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
    }
}
