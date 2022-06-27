namespace pa_web.win
{
    partial class MSetupManager
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
            this.dataSet1 = new pa_web.DataSet1();
            this.simplepaTableAdapter = new pa_web.DataSet1TableAdapters.SimplepaTableAdapter();
            this.SimplepabindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.tableLayoutPanel2 = new Wisej.Web.TableLayoutPanel();
            this.textBox5 = new Wisej.Web.TextBox();
            this.textBox4 = new Wisej.Web.TextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimplepabindingSource1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simplepaTableAdapter
            // 
            this.simplepaTableAdapter.ClearBeforeFill = true;
            // 
            // SimplepabindingSource1
            // 
            this.SimplepabindingSource1.DataMember = "Simplepa";
            this.SimplepabindingSource1.DataSource = this.dataSet1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 36.36F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 63.64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 455);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.TabStop = true;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new Wisej.Web.Binding("Text", this.SimplepabindingSource1, "SpeakerIconSize", true));
            this.textBox5.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(420, 43);
            this.textBox5.Margin = new Wisej.Web.Padding(8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(98, 19);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(113, 43);
            this.textBox4.Margin = new Wisej.Web.Padding(8);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 19);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new Wisej.Web.Binding("Text", this.SimplepabindingSource1, "TileWidth", true));
            this.textBox3.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(658, 8);
            this.textBox3.Margin = new Wisej.Web.Padding(8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 19);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new Wisej.Web.Binding("Text", this.SimplepabindingSource1, "TileWidth", true));
            this.textBox2.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(420, 8);
            this.textBox2.Margin = new Wisej.Web.Padding(8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 19);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.SimplepabindingSource1, "UserName", true));
            this.textBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(113, 8);
            this.textBox1.Margin = new Wisej.Web.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 19);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Margin = new Wisej.Web.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "사용자명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 8);
            this.label3.Margin = new Wisej.Web.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "프리셋폭";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 8);
            this.label5.Margin = new Wisej.Web.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "그룹폭";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 43);
            this.label4.Margin = new Wisej.Web.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "스피커 Icon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 43);
            this.label6.Margin = new Wisej.Web.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "메인DSP";
            // 
            // MSetupManager
            // 
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MSetupManager";
            this.Size = new System.Drawing.Size(913, 607);
            this.Load += new System.EventHandler(this.MSetupManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimplepabindingSource1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private DataSet1TableAdapters.SimplepaTableAdapter simplepaTableAdapter;
        private Wisej.Web.BindingSource SimplepabindingSource1;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel2;
        private Wisej.Web.TextBox textBox5;
        private Wisej.Web.TextBox textBox4;
        private Wisej.Web.TextBox textBox3;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label6;
    }
}
