namespace Wisej.CodeProject.win
{
    partial class MMusicManager
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
            this.mbindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.musicsTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.MusicsTableAdapter();
            this.ptop = new Wisej.Web.Panel();
            this.tableLayoutPanel5 = new Wisej.Web.TableLayoutPanel();
            this.label12 = new Wisej.Web.Label();
            this.mtextBox1 = new Wisej.Web.TextBox();
            this.label11 = new Wisej.Web.Label();
            this.mtextBox2 = new Wisej.Web.TextBox();
            this.mbutton2 = new Wisej.Web.Button();
            this.mupload1 = new Wisej.Web.Upload();
            this.mbutton3 = new Wisej.Web.Button();
            this.mbutton1 = new Wisej.Web.Button();
            this.mdataGridView1 = new Wisej.Web.DataGridView();
            this.colMusicid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel1 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.ptop.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbindingSource1
            // 
            this.mbindingSource1.DataMember = "Musics";
            this.mbindingSource1.DataSource = this.dataSet1;
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
            // ptop
            // 
            this.ptop.Controls.Add(this.tableLayoutPanel5);
            this.ptop.Controls.Add(this.mbutton2);
            this.ptop.Controls.Add(this.mupload1);
            this.ptop.Controls.Add(this.mbutton3);
            this.ptop.Controls.Add(this.mbutton1);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(0, 0);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(905, 70);
            this.ptop.TabIndex = 1;
            this.ptop.TabStop = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 28.88F));
            this.tableLayoutPanel5.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 71.12F));
            this.tableLayoutPanel5.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 104F));
            this.tableLayoutPanel5.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 178F));
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.mtextBox1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.mtextBox2, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(17, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.75F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(506, 44);
            this.tableLayoutPanel5.TabIndex = 8;
            this.tableLayoutPanel5.TabStop = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 8);
            this.label12.Margin = new Wisej.Web.Padding(8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "파일명";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtextBox1
            // 
            this.mtextBox1.AutoSize = false;
            this.mtextBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.mbindingSource1, "FileName", true));
            this.mtextBox1.Location = new System.Drawing.Point(72, 8);
            this.mtextBox1.Margin = new Wisej.Web.Padding(8);
            this.mtextBox1.Name = "mtextBox1";
            this.mtextBox1.Size = new System.Drawing.Size(143, 18);
            this.mtextBox1.TabIndex = 1;
            this.mtextBox1.Watermark = "Enter a name";
            // 
            // label11
            // 
            this.label11.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 8);
            this.label11.Margin = new Wisej.Web.Padding(8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "내용";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtextBox2
            // 
            this.mtextBox2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.mtextBox2.AutoSize = false;
            this.mtextBox2.DataBindings.Add(new Wisej.Web.Binding("Text", this.mbindingSource1, "FileContent", true));
            this.mtextBox2.Location = new System.Drawing.Point(335, 8);
            this.mtextBox2.Margin = new Wisej.Web.Padding(8);
            this.mtextBox2.Name = "mtextBox2";
            this.mtextBox2.Size = new System.Drawing.Size(163, 17);
            this.mtextBox2.TabIndex = 7;
            // 
            // mbutton2
            // 
            this.mbutton2.Location = new System.Drawing.Point(644, 16);
            this.mbutton2.Name = "mbutton2";
            this.mbutton2.Size = new System.Drawing.Size(100, 27);
            this.mbutton2.TabIndex = 12;
            this.mbutton2.Text = "등록";
            this.mbutton2.Click += new System.EventHandler(this.mbutton2_Click);
            // 
            // mupload1
            // 
            this.mupload1.ButtonPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.mupload1.Location = new System.Drawing.Point(543, 49);
            this.mupload1.Name = "mupload1";
            this.mupload1.Size = new System.Drawing.Size(98, 27);
            this.mupload1.TabIndex = 10;
            this.mupload1.Text = "파일";
            this.mupload1.Visible = false;
            // 
            // mbutton3
            // 
            this.mbutton3.Location = new System.Drawing.Point(750, 16);
            this.mbutton3.Name = "mbutton3";
            this.mbutton3.Size = new System.Drawing.Size(100, 27);
            this.mbutton3.TabIndex = 13;
            this.mbutton3.Text = "삭제";
            this.mbutton3.Click += new System.EventHandler(this.mbutton3_Click);
            // 
            // mbutton1
            // 
            this.mbutton1.Location = new System.Drawing.Point(541, 16);
            this.mbutton1.Name = "mbutton1";
            this.mbutton1.Size = new System.Drawing.Size(100, 27);
            this.mbutton1.TabIndex = 11;
            this.mbutton1.Text = "저장";
            this.mbutton1.Click += new System.EventHandler(this.mbutton1_Click);
            // 
            // mdataGridView1
            // 
            this.mdataGridView1.AutoGenerateColumns = false;
            this.mdataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colMusicid,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mdataGridView1.DataSource = this.mbindingSource1;
            this.mdataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.mdataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.mdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.mdataGridView1.Name = "mdataGridView1";
            this.mdataGridView1.RowHeadersWidth = 16;
            this.mdataGridView1.Size = new System.Drawing.Size(905, 547);
            this.mdataGridView1.TabIndex = 9;
            // 
            // colMusicid
            // 
            this.colMusicid.DataPropertyName = "MusicId";
            this.colMusicid.HeaderText = "No";
            this.colMusicid.Name = "colMusicid";
            this.colMusicid.ReadOnly = true;
            this.colMusicid.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn2.HeaderText = "파일명";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FileContent";
            this.dataGridViewTextBoxColumn3.HeaderText = "내용";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mdataGridView1);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 547);
            this.panel1.TabIndex = 2;
            // 
            // MMusicManager
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptop);
            this.Name = "MMusicManager";
            this.Size = new System.Drawing.Size(905, 617);
            this.Load += new System.EventHandler(this.MMusicManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ptop.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.BindingSource mbindingSource1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.MusicsTableAdapter musicsTableAdapter;
        private Web.Panel ptop;
        private Web.DataGridView mdataGridView1;
        private Web.DataGridViewTextBoxColumn colMusicid;
        private Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Web.TableLayoutPanel tableLayoutPanel5;
        private Web.Label label11;
        private Web.Label label12;
        private Web.TextBox mtextBox1;
        private Web.TextBox mtextBox2;
        private Web.Button mbutton2;
        private Web.Upload mupload1;
        private Web.Button mbutton3;
        private Web.Button mbutton1;
        private Web.Panel panel1;
    }
}
