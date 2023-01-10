namespace simplepa2.UI.Views
{
    partial class View_BBSEMChannel2
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.panel2 = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colBstreeid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEMNAME = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colChno = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPlaying = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colWtime = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.bSTreeBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.ptop = new Wisej.Web.Panel();
            this.button2 = new Wisej.Web.Button();
            this.bSTreeTableAdapter = new simplepa2.DataSet1TableAdapters.BSTreeTableAdapter();
            this.bsTreeCTableAdapter = new simplepa2.DataSet1TableAdapters.BSTreeCTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSTreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.ptop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 72);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(862, 524);
            this.panel2.TabIndex = 7;
            this.panel2.TabStop = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colBstreeid,
            this.colEMNAME,
            this.colChno,
            this.colPlaying,
            this.colWtime});
            this.dataGridView1.DataSource = this.bSTreeBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(822, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // colBstreeid
            // 
            this.colBstreeid.DataPropertyName = "BSTreeId";
            this.colBstreeid.HeaderText = "번호";
            this.colBstreeid.Name = "colBstreeid";
            this.colBstreeid.ReadOnly = true;
            this.colBstreeid.Width = 60;
            // 
            // colEMNAME
            // 
            this.colEMNAME.DataPropertyName = "EMNAME";
            this.colEMNAME.HeaderText = "EM서버";
            this.colEMNAME.Name = "colEMNAME";
            this.colEMNAME.Width = 140;
            // 
            // colChno
            // 
            this.colChno.DataPropertyName = "chno";
            this.colChno.HeaderText = "채널";
            this.colChno.Name = "colChno";
            this.colChno.Width = 80;
            // 
            // colPlaying
            // 
            this.colPlaying.DataPropertyName = "playing";
            this.colPlaying.HeaderText = "방송상태";
            this.colPlaying.Name = "colPlaying";
            this.colPlaying.Width = 120;
            // 
            // colWtime
            // 
            this.colWtime.DataPropertyName = "wtime";
            dataGridViewCellStyle1.Format = "G";
            this.colWtime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colWtime.HeaderText = "시작시간";
            this.colWtime.Name = "colWtime";
            this.colWtime.Width = 200;
            // 
            // bSTreeBindingSource
            // 
            this.bSTreeBindingSource.DataMember = "BSTree";
            this.bSTreeBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ptop
            // 
            this.ptop.BackColor = System.Drawing.Color.White;
            this.ptop.Controls.Add(this.button2);
            this.ptop.Dock = Wisej.Web.DockStyle.Top;
            this.ptop.Location = new System.Drawing.Point(20, 20);
            this.ptop.Name = "ptop";
            this.ptop.Size = new System.Drawing.Size(862, 52);
            this.ptop.TabIndex = 7;
            this.ptop.TabStop = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "방송초기화";
            this.button2.ToolTipText = "해당 채널의 방송을 강제로 초기화 상태로 만드는 기능 입니다.";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bSTreeTableAdapter
            // 
            this.bSTreeTableAdapter.ClearBeforeFill = true;
            // 
            // bsTreeCTableAdapter
            // 
            this.bsTreeCTableAdapter.ClearBeforeFill = true;
            // 
            // View_BBSEMChannel2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptop);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSEMChannel2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(902, 616);
            this.Load += new System.EventHandler(this.BSAsset_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSTreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ptop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn colBstreeid;
        private Wisej.Web.DataGridViewTextBoxColumn colEMNAME;
        private Wisej.Web.DataGridViewTextBoxColumn colChno;
        private Wisej.Web.DataGridViewTextBoxColumn colPlaying;
        private Wisej.Web.DataGridViewDateTimePickerColumn colWtime;
        private Wisej.Web.BindingSource bSTreeBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.BSTreeTableAdapter bSTreeTableAdapter;
        private Wisej.Web.Panel ptop;
        private Wisej.Web.Button button2;
        private DataSet1TableAdapters.BSTreeCTableAdapter bsTreeCTableAdapter;
    }
}
