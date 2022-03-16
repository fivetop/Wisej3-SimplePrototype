namespace Wisej.CodeProject
{
    partial class MSet
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
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.textBox5 = new Wisej.Web.TextBox();
            this.bindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.textBox4 = new Wisej.Web.TextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.simplepaTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.SimplepaTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 36.36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 63.64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            this.tableLayoutPanel1.PanelCollapsed += new System.EventHandler(this.tableLayoutPanel1_PanelCollapsed);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "SpeakerIconSize", true));
            this.textBox5.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(420, 43);
            this.textBox5.Margin = new Wisej.Web.Padding(8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(98, 19);
            this.textBox5.TabIndex = 9;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Simplepa";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.textBox3.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "TileWidth", true));
            this.textBox3.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(658, 8);
            this.textBox3.Margin = new Wisej.Web.Padding(8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 19);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "TileWidth", true));
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
            this.textBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.bindingSource1, "UserName", true));
            this.textBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(113, 8);
            this.textBox1.Margin = new Wisej.Web.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 19);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new Wisej.Web.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "사용자명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 8);
            this.label2.Margin = new Wisej.Web.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "프리셋폭";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 8);
            this.label5.Margin = new Wisej.Web.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "그룹폭";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 43);
            this.label4.Margin = new Wisej.Web.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "스피커 Icon";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Margin = new Wisej.Web.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "메인DSP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // simplepaTableAdapter
            // 
            this.simplepaTableAdapter.ClearBeforeFill = true;
            // 
            // MSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MSet";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "환경설정";
            this.Load += new System.EventHandler(this.MSet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.TableLayoutPanel tableLayoutPanel1;
        private Web.Label label1;
        private Web.Label label5;
        private Web.Label label4;
        private Web.Label label3;
        private Web.Label label2;
        private DataSet1 dataSet1;
        private Web.BindingSource bindingSource1;
        private DataSet1TableAdapters.SimplepaTableAdapter simplepaTableAdapter;
        private Web.TextBox textBox1;
        private Web.TextBox textBox5;
        private Web.TextBox textBox4;
        private Web.TextBox textBox3;
        private Web.TextBox textBox2;
    }
}