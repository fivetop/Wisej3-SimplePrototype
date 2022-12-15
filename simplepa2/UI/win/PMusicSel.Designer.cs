namespace simplepa2
{
    partial class PMusicSel
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
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colMusicid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFilename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.bindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.musicsTableAdapter = new simplepa2.DataSet1TableAdapters.MusicsTableAdapter();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.파일명 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.pMusicSelBindingSource = new Wisej.Web.BindingSource(this.components);
            this.panel1 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMusicSelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colMusicid,
            this.colFilename});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(8, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 14;
            this.dataGridView1.Size = new System.Drawing.Size(290, 222);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // colMusicid
            // 
            this.colMusicid.DataPropertyName = "MusicId";
            this.colMusicid.HeaderText = "No";
            this.colMusicid.Name = "colMusicid";
            this.colMusicid.Width = 60;
            // 
            // colFilename
            // 
            this.colFilename.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.colFilename.DataPropertyName = "FileName";
            this.colFilename.HeaderText = "파일명";
            this.colFilename.Name = "colFilename";
            this.colFilename.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Musics";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musicsTableAdapter
            // 
            this.musicsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = Wisej.Web.AnchorStyles.None;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.파일명});
            this.dataGridView2.DataSource = this.pMusicSelBindingSource;
            this.dataGridView2.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(316, 75);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 14;
            this.dataGridView2.Size = new System.Drawing.Size(290, 222);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // 파일명
            // 
            this.파일명.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.파일명.DataPropertyName = "FileName";
            this.파일명.HeaderText = "파일명";
            this.파일명.Name = "파일명";
            // 
            // pMusicSelBindingSource
            // 
            this.pMusicSelBindingSource.DataMember = "bind";
            this.pMusicSelBindingSource.DataSource = typeof(simplepa2.PMusicSel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 57);
            this.panel1.TabIndex = 9;
            this.panel1.TabStop = true;
            // 
            // button1
            // 
            this.button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-arrow.svg";
            this.button1.Location = new System.Drawing.Point(505, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "선택";
            this.button1.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PMusicSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PMusicSel";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "음원파일선택";
            this.Load += new System.EventHandler(this.DataBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMusicSelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource bindingSource1;
        private DataSet1TableAdapters.MusicsTableAdapter musicsTableAdapter;
        private Wisej.Web.DataGridViewTextBoxColumn colMusicid;
        private Wisej.Web.DataGridViewTextBoxColumn colFilename;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.BindingSource pMusicSelBindingSource;
        private Wisej.Web.DataGridViewTextBoxColumn 파일명;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button button1;
    }
}