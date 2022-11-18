namespace simplepa2.UI.Components
{
    partial class Comp_SiteCard
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
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.line1 = new Wisej.Web.Line();
            this.label1 = new Wisej.Web.Label();
            this.buttonVerify = new Wisej.Web.Button();
            this.buttonDelete = new Wisej.Web.Button();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.textBox1 = new Wisej.Web.TextBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.textBox4 = new Wisej.Web.TextBox();
            this.panel1 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox1.ImageSource = "imgs\\dPanel1.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(140, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 148);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(20, 35);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(268, 10);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "동이름";
            // 
            // buttonVerify
            // 
            this.buttonVerify.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonVerify.Location = new System.Drawing.Point(194, 8);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(39, 27);
            this.buttonVerify.TabIndex = 3;
            this.buttonVerify.Text = "수정";
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerfiy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(239, 8);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(43, 27);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "삭제";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "동이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "상층";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "지층";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "계단";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "E.M 동작";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(62, 22);
            this.textBox4.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromName("@switchOn");
            this.panel1.Location = new System.Drawing.Point(90, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 29);
            this.panel1.TabIndex = 18;
            // 
            // Comp_SiteCard
            // 
            this.BackColor = System.Drawing.Color.FromName("@table-row-background-focused");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Comp_SiteCard";
            this.Size = new System.Drawing.Size(300, 224);
            this.Load += new System.EventHandler(this.Comp_SiteCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Line line1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button buttonVerify;
        private Wisej.Web.Button buttonDelete;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label label6;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.TextBox textBox3;
        private Wisej.Web.TextBox textBox4;
        private Wisej.Web.Panel panel1;
    }
}
