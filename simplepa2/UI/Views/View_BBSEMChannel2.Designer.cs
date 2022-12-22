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
            this.dataSet1 = new simplepa2.DataSet1();
            this.bSTreeBindingSource = new Wisej.Web.BindingSource(this.components);
            this.bSTreeTableAdapter = new simplepa2.DataSet1TableAdapters.BSTreeTableAdapter();
            this.colBstreeid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colWtime = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.colChno = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEMNAME = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPlaying = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSTreeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(20);
            this.panel2.Size = new System.Drawing.Size(862, 576);
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
            this.dataGridView1.Size = new System.Drawing.Size(822, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bSTreeBindingSource
            // 
            this.bSTreeBindingSource.DataMember = "BSTree";
            this.bSTreeBindingSource.DataSource = this.dataSet1;
            // 
            // bSTreeTableAdapter
            // 
            this.bSTreeTableAdapter.ClearBeforeFill = true;
            // 
            // colBstreeid
            // 
            this.colBstreeid.DataPropertyName = "BSTreeId";
            this.colBstreeid.HeaderText = "번호";
            this.colBstreeid.Name = "colBstreeid";
            this.colBstreeid.ReadOnly = true;
            // 
            // colWtime
            // 
            this.colWtime.DataPropertyName = "wtime";
            dataGridViewCellStyle1.Format = "G";
            this.colWtime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colWtime.HeaderText = "시작시간";
            this.colWtime.Name = "colWtime";
            // 
            // colChno
            // 
            this.colChno.DataPropertyName = "chno";
            this.colChno.HeaderText = "채널";
            this.colChno.Name = "colChno";
            // 
            // colEMNAME
            // 
            this.colEMNAME.DataPropertyName = "EMNAME";
            this.colEMNAME.HeaderText = "EM서버";
            this.colEMNAME.Name = "colEMNAME";
            // 
            // colPlaying
            // 
            this.colPlaying.DataPropertyName = "playing";
            this.colPlaying.HeaderText = "방송상태";
            this.colPlaying.Name = "colPlaying";
            // 
            // View_BBSEMChannel2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.Controls.Add(this.panel2);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSEMChannel2";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(902, 616);
            this.Load += new System.EventHandler(this.BSAsset_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSTreeBindingSource)).EndInit();
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
    }
}
