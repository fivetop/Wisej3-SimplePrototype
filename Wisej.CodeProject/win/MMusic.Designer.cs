namespace Wisej.CodeProject
{
    partial class MMusic
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
            this.colFilecontent = new Wisej.Web.DataGridViewTextBoxColumn();
            this.statusBar1 = new Wisej.Web.StatusBar();
            this.bindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.textBox2 = new Wisej.Web.TextBox();
            this.musicsTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.MusicsTableAdapter();
            this.dataSet1BindingSource = new Wisej.Web.BindingSource(this.components);
            this.musicsBindingSource = new Wisej.Web.BindingSource(this.components);
            this.button3 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.upload1 = new Wisej.Web.Upload();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = Wisej.Web.AnchorStyles.Right;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colMusicid,
            this.colFilename,
            this.colFilecontent});
            this.dataGridView1.Controls.Add(this.statusBar1);
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 16;
            this.dataGridView1.Size = new System.Drawing.Size(452, 306);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.colFilename.DataPropertyName = "FileName";
            this.colFilename.HeaderText = "파일명";
            this.colFilename.Name = "colFilename";
            this.colFilename.Width = 150;
            // 
            // colFilecontent
            // 
            this.colFilecontent.DataPropertyName = "FileContent";
            this.colFilecontent.HeaderText = "내용";
            this.colFilecontent.Name = "colFilecontent";
            this.colFilecontent.Width = 150;
            // 
            // statusBar1
            // 
            this.statusBar1.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.statusBar1.Location = new System.Drawing.Point(0, 282);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = false;
            this.statusBar1.Size = new System.Drawing.Size(450, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
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
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "FileName", true));
            this.textBox1.Location = new System.Drawing.Point(140, 8);
            this.textBox1.Margin = new Wisej.Web.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 18);
            this.textBox1.TabIndex = 1;
            this.textBox1.Watermark = "Enter a name";
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Margin = new Wisej.Web.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "내용";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new Wisej.Web.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "파일명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 28.88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 71.12F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.75F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 49.25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.textBox2.AutoSize = false;
            this.textBox2.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "FileContent", true));
            this.textBox2.Location = new System.Drawing.Point(140, 42);
            this.textBox2.Margin = new Wisej.Web.Padding(8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 17);
            this.textBox2.TabIndex = 7;
            // 
            // musicsTableAdapter
            // 
            this.musicsTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // musicsBindingSource
            // 
            this.musicsBindingSource.DataMember = "Musics";
            this.musicsBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "삭제";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "등록";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "저장";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upload1
            // 
            this.upload1.ButtonPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.upload1.Location = new System.Drawing.Point(23, 76);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(98, 27);
            this.upload1.TabIndex = 1;
            this.upload1.Text = "파일";
            this.upload1.Visible = false;
            this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
            // 
            // MMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.upload1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MMusic";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "음원관리";
            this.Load += new System.EventHandler(this.DataBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.TextBox textBox1;
        private Web.Label label1;
        private Web.Label label3;
        private Web.TableLayoutPanel tableLayoutPanel1;
        private Web.StatusBar statusBar1;
        private DataSet1 dataSet1;
        private Web.TextBox textBox2;
        private Web.BindingSource bindingSource1;
        private DataSet1TableAdapters.MusicsTableAdapter musicsTableAdapter;
        private Web.DataGridViewTextBoxColumn colMusicid;
        private Web.DataGridViewTextBoxColumn colFilename;
        private Web.DataGridViewTextBoxColumn colFilecontent;
        private Web.BindingSource dataSet1BindingSource;
        private Web.BindingSource musicsBindingSource;
        private Web.Button button3;
        private Web.Button button2;
        private Web.Button button1;
        private Web.Upload upload1;
    }
}