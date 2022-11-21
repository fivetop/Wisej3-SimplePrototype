namespace simplepa2.UI.Views
{
    partial class View_BBCAmpFailover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_BBCAmpFailover));
            this.popTestButton = new Wisej.Web.Button();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // popTestButton
            // 
            this.popTestButton.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.popTestButton.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.popTestButton.CssStyle = resources.GetString("popTestButton.CssStyle");
            this.popTestButton.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.popTestButton.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.popTestButton.Location = new System.Drawing.Point(1280, 20);
            this.popTestButton.Margin = new Wisej.Web.Padding(0);
            this.popTestButton.Name = "popTestButton";
            this.popTestButton.Size = new System.Drawing.Size(100, 32);
            this.popTestButton.TabIndex = 5;
            this.popTestButton.Text = "적용";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.CssStyle = resources.GetString("textBox1.CssStyle");
            this.textBox1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Location = new System.Drawing.Point(120, 20);
            this.textBox1.Margin = new Wisej.Web.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 32);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(41, 834);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "방송설정-앰프Failover";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox1.AutoSize = false;
            this.comboBox1.CssStyle = resources.GetString("comboBox1.CssStyle");
            this.comboBox1.Location = new System.Drawing.Point(1070, 20);
            this.comboBox1.Margin = new Wisej.Web.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 32);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBox2.AutoSize = false;
            this.comboBox2.CssStyle = resources.GetString("comboBox2.CssStyle");
            this.comboBox2.Location = new System.Drawing.Point(860, 20);
            this.comboBox2.Margin = new Wisej.Web.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 32);
            this.comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(780, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "백업엠프";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "컨트롤러";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 24.63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 75.37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 25.95F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 74.05F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1360, 93);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // View_BBCAmpFailover
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.popTestButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBCAmpFailover";
            this.Size = new System.Drawing.Size(1400, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button popTestButton;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.ComboBox comboBox1;
        private Wisej.Web.ComboBox comboBox2;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
    }
}
