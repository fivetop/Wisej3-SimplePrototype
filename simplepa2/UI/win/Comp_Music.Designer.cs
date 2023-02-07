namespace simplepa2.UI.win
{
    partial class Comp_Music
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
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.파일명 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colMusicid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFilename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel5 = new Wisej.Web.Panel();
            this.button3 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.파일명});
            this.dataGridView2.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView2.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(349, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 14;
            this.dataGridView2.Size = new System.Drawing.Size(290, 235);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // 파일명
            // 
            this.파일명.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.파일명.DataPropertyName = "FileName";
            this.파일명.HeaderText = "파일명";
            this.파일명.Name = "파일명";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colMusicid,
            this.colFilename});
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 14;
            this.dataGridView1.Size = new System.Drawing.Size(290, 235);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDoubleClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // colMusicid
            // 
            this.colMusicid.DataPropertyName = "MusicId";
            this.colMusicid.HeaderText = "No";
            this.colMusicid.Name = "colMusicid";
            this.colMusicid.ReadOnly = true;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = Wisej.Web.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(299, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(44, 235);
            this.panel5.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button3.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.button3.BackgroundImageSource = "Images/music-crrl-1.png";
            this.button3.Location = new System.Drawing.Point(3, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 33);
            this.button3.TabIndex = 3;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button2.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.button2.BackgroundImageSource = "Images/music-crrl-2.png";
            this.button2.Location = new System.Drawing.Point(3, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 33);
            this.button2.TabIndex = 2;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 241);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Comp_Music
            // 
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Comp_Music";
            this.Size = new System.Drawing.Size(642, 241);
            this.Load += new System.EventHandler(this.Comp_Music_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.DataGridViewTextBoxColumn 파일명;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colMusicid;
        private Wisej.Web.DataGridViewTextBoxColumn colFilename;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Button button3;
        private Wisej.Web.Button button2;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
    }
}
