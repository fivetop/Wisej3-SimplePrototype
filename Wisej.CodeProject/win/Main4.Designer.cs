namespace Wisej.CodeProject
{
	partial class Main4
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new Wisej.Web.Panel();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.assetsBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.assetsTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.AssetsTableAdapter();
            this.contextMenu1 = new Wisej.Web.ContextMenu();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuItem2 = new Wisej.Web.MenuItem();
            this.panel3 = new Wisej.Web.Panel();
            this.listviewCTL1 = new Wisej.CodeProject.Control.ListviewCTL();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.Size = new System.Drawing.Size(838, 80);
            this.panel1.TabIndex = 8;
            this.panel1.TabStop = true;
            // 
            // button2
            // 
            this.button2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/stop-button.svg";
            this.button2.Location = new System.Drawing.Point(182, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-arrow.svg";
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.dataSet1;
            this.assetsBindingSource.Sort = "seq";
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
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            this.contextMenu1.Name = "contextMenu1";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "menuItem1";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Text = "menuItem2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel3.Controls.Add(this.listviewCTL1);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(4);
            this.panel3.ShowCloseButton = false;
            this.panel3.Size = new System.Drawing.Size(838, 426);
            this.panel3.TabIndex = 7;
            this.panel3.TabStop = true;
            // 
            // listviewCTL1
            // 
            this.listviewCTL1.Location = new System.Drawing.Point(26, 32);
            this.listviewCTL1.Name = "listviewCTL1";
            this.listviewCTL1.Size = new System.Drawing.Size(278, 193);
            this.listviewCTL1.TabIndex = 1;
            // 
            // Main4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 506);
            this.CloseBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Main4";
            this.Text = "자산관리";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
        private Web.Panel panel1;
        private Web.Button button2;
        private Web.Button button1;
        private Web.BindingSource assetsBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AssetsTableAdapter assetsTableAdapter;
        private Web.ContextMenu contextMenu1;
        private Web.MenuItem menuItem1;
        private Web.MenuItem menuItem2;
        private Web.Panel panel3;
        private Control.ListviewCTL listviewCTL1;
    }
}