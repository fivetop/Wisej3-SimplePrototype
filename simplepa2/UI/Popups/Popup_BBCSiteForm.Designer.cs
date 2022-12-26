namespace simplepa2.UI.Popups
{
    partial class Popup_BBCSiteForm
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle7 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle8 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle9 = new Wisej.Web.DataGridViewCellStyle();
            this.panel22 = new Wisej.Web.Panel();
            this.dg_floorList = new Wisej.Web.DataGridView();
            this.floor_name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.floor_no = new Wisej.Web.DataGridViewTextBoxColumn();
            this.floor_fire_no = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel4 = new Wisej.Web.Panel();
            this.panel6 = new Wisej.Web.Panel();
            this.button2 = new Wisej.Web.Button();
            this.panel7 = new Wisej.Web.Panel();
            this.textBox4 = new Wisej.Web.TextBox();
            this.label3 = new Wisej.Web.Label();
            this.textBox3 = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.line2 = new Wisej.Web.Line();
            this.panel34 = new Wisej.Web.Panel();
            this.label23 = new Wisej.Web.Label();
            this.label22 = new Wisej.Web.Label();
            this.panel5 = new Wisej.Web.Panel();
            this.panel89 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.tb_bdDescription = new Wisej.Web.TextBox();
            this.label5 = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            this.tb_bdFloorNo = new Wisej.Web.TextBox();
            this.label4 = new Wisej.Web.Label();
            this.panel3 = new Wisej.Web.Panel();
            this.tb_bdFireID = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.panel35 = new Wisej.Web.Panel();
            this.tb_bdName = new Wisej.Web.TextBox();
            this.label24 = new Wisej.Web.Label();
            this.line5 = new Wisej.Web.Line();
            this.button53 = new Wisej.Web.Button();
            this.label66 = new Wisej.Web.Label();
            this.panel136 = new Wisej.Web.Panel();
            this.animation1 = new Wisej.Web.Animation(this.components);
            this.animation2 = new Wisej.Web.Animation(this.components);
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_floorList)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel89.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel136.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel22
            // 
            this.panel22.AutoScroll = true;
            this.panel22.Controls.Add(this.dg_floorList);
            this.panel22.Controls.Add(this.panel4);
            this.panel22.Controls.Add(this.panel5);
            this.panel22.Controls.Add(this.panel89);
            this.panel22.Dock = Wisej.Web.DockStyle.Fill;
            this.panel22.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel22.Location = new System.Drawing.Point(20, 72);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(402, 887);
            this.panel22.TabIndex = 56;
            this.panel22.Text = "listPanel";
            // 
            // dg_floorList
            // 
            this.dg_floorList.AutoGenerateColumns = false;
            this.dg_floorList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.floor_no,
            this.floor_name,
            this.floor_fire_no});
            this.dg_floorList.Dock = Wisej.Web.DockStyle.Fill;
            this.dg_floorList.Location = new System.Drawing.Point(0, 393);
            this.dg_floorList.Name = "dg_floorList";
            this.dg_floorList.RowHeadersVisible = false;
            this.dg_floorList.Size = new System.Drawing.Size(402, 494);
            this.dg_floorList.TabIndex = 166;
            // 
            // floor_name
            // 
            this.floor_name.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.floor_name.DataPropertyName = "floor_name";
            dataGridViewCellStyle7.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.floor_name.DefaultCellStyle = dataGridViewCellStyle7;
            this.floor_name.HeaderText = "층이름";
            this.floor_name.Name = "floor_name";
            this.floor_name.Width = 150;
            // 
            // floor_no
            // 
            this.floor_no.DataPropertyName = "floor_no";
            dataGridViewCellStyle8.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.floor_no.DefaultCellStyle = dataGridViewCellStyle8;
            this.floor_no.HeaderText = "층번호";
            this.floor_no.Name = "floor_no";
            this.floor_no.Width = 70;
            // 
            // floor_fire_no
            // 
            this.floor_fire_no.DataPropertyName = "floor_fire_no";
            dataGridViewCellStyle9.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.floor_fire_no.DefaultCellStyle = dataGridViewCellStyle9;
            this.floor_fire_no.HeaderText = "화재수신번호";
            this.floor_fire_no.Name = "floor_fire_no";
            this.floor_fire_no.Width = 150;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.line2);
            this.panel4.Controls.Add(this.panel34);
            this.panel4.Dock = Wisej.Web.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 259);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new Wisej.Web.Padding(20);
            this.panel4.Size = new System.Drawing.Size(402, 134);
            this.panel4.TabIndex = 165;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = Wisej.Web.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(20, 58);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel6.Size = new System.Drawing.Size(362, 56);
            this.panel6.TabIndex = 164;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.button2.Dock = Wisej.Web.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button2.Location = new System.Drawing.Point(272, 20);
            this.button2.Margin = new Wisej.Web.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 162;
            this.button2.Text = "신규 생성";
            // 
            // panel7
            // 
            this.panel7.Dock = Wisej.Web.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(253, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(19, 36);
            this.panel7.TabIndex = 163;
            // 
            // textBox4
            // 
            this.textBox4.AutoSize = false;
            this.textBox4.Dock = Wisej.Web.DockStyle.Left;
            this.textBox4.Location = new System.Drawing.Point(184, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 36);
            this.textBox4.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = Wisej.Web.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label3.Location = new System.Drawing.Point(119, 20);
            this.label3.Margin = new Wisej.Web.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new Wisej.Web.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(65, 36);
            this.label3.TabIndex = 138;
            this.label3.Text = "지하층수";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.AutoSize = false;
            this.textBox3.Dock = Wisej.Web.DockStyle.Left;
            this.textBox3.Location = new System.Drawing.Point(50, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 36);
            this.textBox3.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = Wisej.Web.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("@boxLabel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Margin = new Wisej.Web.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 36);
            this.label2.TabIndex = 136;
            this.label2.Text = "상층수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line2
            // 
            this.line2.Dock = Wisej.Web.DockStyle.Top;
            this.line2.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line2.Location = new System.Drawing.Point(20, 57);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(362, 1);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.label23);
            this.panel34.Controls.Add(this.label22);
            this.panel34.Dock = Wisej.Web.DockStyle.Top;
            this.panel34.Location = new System.Drawing.Point(20, 20);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(362, 37);
            this.panel34.TabIndex = 161;
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label23.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label23.Location = new System.Drawing.Point(32, 0);
            this.label23.Margin = new Wisej.Web.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(330, 24);
            this.label23.TabIndex = 134;
            this.label23.Text = "건물 구조";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label22.CssStyle = "border-radius: 11px;";
            this.label22.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label22.Location = new System.Drawing.Point(0, 3);
            this.label22.Margin = new Wisej.Web.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 22);
            this.label22.TabIndex = 133;
            this.label22.Text = "★";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Dock = Wisej.Web.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 245);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 14);
            this.panel5.TabIndex = 164;
            // 
            // panel89
            // 
            this.panel89.AutoSize = true;
            this.panel89.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel89.Controls.Add(this.panel2);
            this.panel89.Controls.Add(this.panel1);
            this.panel89.Controls.Add(this.panel3);
            this.panel89.Controls.Add(this.panel35);
            this.panel89.Controls.Add(this.line5);
            this.panel89.Dock = Wisej.Web.DockStyle.Top;
            this.panel89.Location = new System.Drawing.Point(0, 0);
            this.panel89.Name = "panel89";
            this.panel89.Padding = new Wisej.Web.Padding(20);
            this.panel89.Size = new System.Drawing.Size(402, 245);
            this.panel89.TabIndex = 159;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_bdDescription);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 169);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel2.Size = new System.Drawing.Size(362, 56);
            this.panel2.TabIndex = 170;
            // 
            // tb_bdDescription
            // 
            this.tb_bdDescription.AutoSize = false;
            this.tb_bdDescription.Dock = Wisej.Web.DockStyle.Fill;
            this.tb_bdDescription.Location = new System.Drawing.Point(123, 20);
            this.tb_bdDescription.Name = "tb_bdDescription";
            this.tb_bdDescription.Size = new System.Drawing.Size(239, 36);
            this.tb_bdDescription.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = Wisej.Web.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label5.Location = new System.Drawing.Point(0, 20);
            this.label5.Margin = new Wisej.Web.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 36);
            this.label5.TabIndex = 136;
            this.label5.Text = "부가 설명";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_bdFloorNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 113);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel1.Size = new System.Drawing.Size(362, 56);
            this.panel1.TabIndex = 169;
            // 
            // tb_bdFloorNo
            // 
            this.tb_bdFloorNo.AutoSize = false;
            this.tb_bdFloorNo.Dock = Wisej.Web.DockStyle.Fill;
            this.tb_bdFloorNo.Location = new System.Drawing.Point(123, 20);
            this.tb_bdFloorNo.Name = "tb_bdFloorNo";
            this.tb_bdFloorNo.Size = new System.Drawing.Size(239, 36);
            this.tb_bdFloorNo.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = Wisej.Web.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label4.Location = new System.Drawing.Point(0, 20);
            this.label4.Margin = new Wisej.Web.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 36);
            this.label4.TabIndex = 136;
            this.label4.Text = "계단수";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_bdFireID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = Wisej.Web.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 57);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel3.Size = new System.Drawing.Size(362, 56);
            this.panel3.TabIndex = 168;
            // 
            // tb_bdFireID
            // 
            this.tb_bdFireID.AutoSize = false;
            this.tb_bdFireID.Dock = Wisej.Web.DockStyle.Fill;
            this.tb_bdFireID.Location = new System.Drawing.Point(123, 20);
            this.tb_bdFireID.Name = "tb_bdFireID";
            this.tb_bdFireID.Size = new System.Drawing.Size(239, 36);
            this.tb_bdFireID.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = Wisej.Web.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 136;
            this.label1.Text = "동수신번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.tb_bdName);
            this.panel35.Controls.Add(this.label24);
            this.panel35.Dock = Wisej.Web.DockStyle.Top;
            this.panel35.Location = new System.Drawing.Point(20, 21);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(362, 36);
            this.panel35.TabIndex = 164;
            // 
            // tb_bdName
            // 
            this.tb_bdName.AutoSize = false;
            this.tb_bdName.Dock = Wisej.Web.DockStyle.Fill;
            this.tb_bdName.Location = new System.Drawing.Point(123, 0);
            this.tb_bdName.Name = "tb_bdName";
            this.tb_bdName.Size = new System.Drawing.Size(239, 36);
            this.tb_bdName.TabIndex = 138;
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = Wisej.Web.DockStyle.Left;
            this.label24.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Margin = new Wisej.Web.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 36);
            this.label24.TabIndex = 136;
            this.label24.Text = "건물명";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line5
            // 
            this.line5.Dock = Wisej.Web.DockStyle.Top;
            this.line5.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line5.Location = new System.Drawing.Point(20, 20);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(362, 1);
            // 
            // button53
            // 
            this.button53.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button53.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button53.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button53.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button53.Location = new System.Drawing.Point(302, 0);
            this.button53.Margin = new Wisej.Web.Padding(0);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(100, 32);
            this.button53.TabIndex = 34;
            this.button53.Text = "변경 저장";
            // 
            // label66
            // 
            this.label66.CssStyle = "\r\n";
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label66.Location = new System.Drawing.Point(0, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(163, 32);
            this.label66.TabIndex = 33;
            this.label66.Text = "건물 구조 편집";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.button53);
            this.panel136.Controls.Add(this.label66);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(20, 20);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(402, 52);
            this.panel136.TabIndex = 55;
            // 
            // Popup_BBCSiteForm
            // 
            this.animation2.GetAnimation(this).Duration = 150;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation1.GetAnimation(this).Duration = 150;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel136);
            this.Name = "Popup_BBCSiteForm";
            this.Padding = new Wisej.Web.Padding(20);
            this.Size = new System.Drawing.Size(442, 979);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_floorList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel89.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel panel22;
        private Wisej.Web.Panel panel89;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.TextBox tb_bdFireID;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel panel35;
        private Wisej.Web.TextBox tb_bdName;
        private Wisej.Web.Label label24;
        private Wisej.Web.Line line5;
        private Wisej.Web.Button button53;
        private Wisej.Web.Label label66;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Button button2;
        private Wisej.Web.Panel panel6;
        private Wisej.Web.TextBox textBox4;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox textBox3;
        private Wisej.Web.Label label2;
        private Wisej.Web.Line line2;
        private Wisej.Web.Panel panel34;
        private Wisej.Web.Label label23;
        private Wisej.Web.Label label22;
        private Wisej.Web.DataGridView dg_floorList;
        private Wisej.Web.DataGridViewTextBoxColumn floor_name;
        private Wisej.Web.DataGridViewTextBoxColumn floor_no;
        private Wisej.Web.DataGridViewTextBoxColumn floor_fire_no;
        private Wisej.Web.Animation animation1;
        private Wisej.Web.Animation animation2;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.TextBox tb_bdDescription;
        private Wisej.Web.Label label5;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.TextBox tb_bdFloorNo;
        private Wisej.Web.Label label4;
        private Wisej.Web.Panel panel7;
    }
}
