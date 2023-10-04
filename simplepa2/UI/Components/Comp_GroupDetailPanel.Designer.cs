namespace simplepa2.UI.Components
{
    partial class Comp_GroupDetailPanel
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
            this.panel3 = new Wisej.Web.Panel();
            this.panel32 = new Wisej.Web.Panel();
            this.panel89 = new Wisej.Web.Panel();
            this.pn_zone = new Wisej.Web.Panel();
            this.panel37 = new Wisej.Web.Panel();
            this.lb_zone = new Wisej.Web.Label();
            this.panel36 = new Wisej.Web.Panel();
            this.tb_groupName = new Wisej.Web.TextBox();
            this.label24 = new Wisej.Web.Label();
            this.line2 = new Wisej.Web.Line();
            this.panel34 = new Wisej.Web.Panel();
            this.label23 = new Wisej.Web.Label();
            this.label22 = new Wisej.Web.Label();
            this.panel136 = new Wisej.Web.Panel();
            this.bt_Delete = new Wisej.Web.Button();
            this.bt_reset = new Wisej.Web.Button();
            this.bt_store = new Wisej.Web.Button();
            this.label66 = new Wisej.Web.Label();
            this.emServerTableAdapter1 = new simplepa2.DataSet1TableAdapters.EMServerTableAdapter();
            this.dataSet11 = new simplepa2.DataSet1();
            this.dataSet12 = new simplepa2.DataSet1();
            this.validation1 = new Wisej.Web.Validation(this.components);
            this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
            this.assetGroupsTableAdapter1 = new simplepa2.DataSet1TableAdapters.AssetGroupsTableAdapter();
            this.panel3.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel89.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel136.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel32);
            this.panel3.Controls.Add(this.panel136);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(20);
            this.panel3.Size = new System.Drawing.Size(760, 860);
            this.panel3.TabIndex = 49;
            // 
            // panel32
            // 
            this.panel32.AutoScroll = true;
            this.panel32.Controls.Add(this.panel89);
            this.panel32.Dock = Wisej.Web.DockStyle.Fill;
            this.panel32.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.panel32.Location = new System.Drawing.Point(20, 72);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(720, 768);
            this.panel32.TabIndex = 51;
            this.panel32.Text = "listPanel";
            // 
            // panel89
            // 
            this.panel89.AutoSize = true;
            this.panel89.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.panel89.Controls.Add(this.pn_zone);
            this.panel89.Controls.Add(this.panel37);
            this.panel89.Controls.Add(this.panel36);
            this.panel89.Controls.Add(this.line2);
            this.panel89.Controls.Add(this.panel34);
            this.panel89.Dock = Wisej.Web.DockStyle.Fill;
            this.panel89.Location = new System.Drawing.Point(0, 0);
            this.panel89.Name = "panel89";
            this.panel89.Padding = new Wisej.Web.Padding(20);
            this.panel89.Size = new System.Drawing.Size(720, 768);
            this.panel89.TabIndex = 159;
            // 
            // pn_zone
            // 
            this.pn_zone.AutoSize = true;
            this.pn_zone.BackColor = System.Drawing.Color.FromName("@bgCardinCard");
            this.pn_zone.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_zone.Location = new System.Drawing.Point(20, 170);
            this.pn_zone.Name = "pn_zone";
            this.pn_zone.Padding = new Wisej.Web.Padding(12);
            this.pn_zone.Size = new System.Drawing.Size(680, 578);
            this.pn_zone.TabIndex = 173;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.lb_zone);
            this.panel37.Dock = Wisej.Web.DockStyle.Top;
            this.panel37.Location = new System.Drawing.Point(20, 114);
            this.panel37.Name = "panel37";
            this.panel37.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel37.Size = new System.Drawing.Size(680, 56);
            this.panel37.TabIndex = 166;
            // 
            // lb_zone
            // 
            this.lb_zone.AutoEllipsis = true;
            this.lb_zone.BackColor = System.Drawing.Color.Transparent;
            this.lb_zone.Dock = Wisej.Web.DockStyle.Left;
            this.lb_zone.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_zone.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.lb_zone.Location = new System.Drawing.Point(0, 20);
            this.lb_zone.Margin = new Wisej.Web.Padding(0);
            this.lb_zone.Name = "lb_zone";
            this.lb_zone.Size = new System.Drawing.Size(123, 36);
            this.lb_zone.TabIndex = 136;
            this.lb_zone.Text = "지역 선택";
            this.lb_zone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.tb_groupName);
            this.panel36.Controls.Add(this.label24);
            this.panel36.Dock = Wisej.Web.DockStyle.Top;
            this.panel36.Location = new System.Drawing.Point(20, 58);
            this.panel36.Name = "panel36";
            this.panel36.Padding = new Wisej.Web.Padding(0, 20, 0, 0);
            this.panel36.Size = new System.Drawing.Size(680, 56);
            this.panel36.TabIndex = 165;
            // 
            // tb_groupName
            // 
            this.tb_groupName.AutoSize = false;
            this.tb_groupName.Location = new System.Drawing.Point(57, 14);
            this.tb_groupName.Name = "tb_groupName";
            this.tb_groupName.Size = new System.Drawing.Size(321, 36);
            this.tb_groupName.TabIndex = 137;
            this.tb_groupName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_groupName_Validating);
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label24.Location = new System.Drawing.Point(0, 14);
            this.label24.Margin = new Wisej.Web.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 36);
            this.label24.TabIndex = 136;
            this.label24.Text = "그룹명";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line2
            // 
            this.line2.Dock = Wisej.Web.DockStyle.Top;
            this.line2.LineColor = System.Drawing.Color.FromArgb(228, 234, 246);
            this.line2.Location = new System.Drawing.Point(20, 57);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(680, 1);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.label23);
            this.panel34.Controls.Add(this.label22);
            this.panel34.Dock = Wisej.Web.DockStyle.Top;
            this.panel34.Location = new System.Drawing.Point(20, 20);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(680, 37);
            this.panel34.TabIndex = 161;
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("default", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label23.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label23.Location = new System.Drawing.Point(32, 0);
            this.label23.Margin = new Wisej.Web.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(437, 24);
            this.label23.TabIndex = 134;
            this.label23.Text = "지역 선택";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(91, 153, 255);
            this.label22.CssStyle = "border-radius: 11px;";
            this.label22.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.label22.Location = new System.Drawing.Point(0, 1);
            this.label22.Margin = new Wisej.Web.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 22);
            this.label22.TabIndex = 133;
            this.label22.Text = "★";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.bt_Delete);
            this.panel136.Controls.Add(this.bt_reset);
            this.panel136.Controls.Add(this.bt_store);
            this.panel136.Controls.Add(this.label66);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(20, 20);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(720, 52);
            this.panel136.TabIndex = 50;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_Delete.BackColor = System.Drawing.Color.FromName("@bStatusRed");
            this.bt_Delete.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_Delete.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_Delete.Location = new System.Drawing.Point(620, 0);
            this.bt_Delete.Margin = new Wisej.Web.Padding(0);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(100, 32);
            this.bt_Delete.TabIndex = 36;
            this.bt_Delete.Text = "삭제";
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_reset.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.bt_reset.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_reset.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_reset.Location = new System.Drawing.Point(402, 0);
            this.bt_reset.Margin = new Wisej.Web.Padding(0);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(100, 32);
            this.bt_reset.TabIndex = 35;
            this.bt_reset.Text = "초기화";
            this.bt_reset.Visible = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_store
            // 
            this.bt_store.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_store.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_store.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_store.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_store.Location = new System.Drawing.Point(511, 0);
            this.bt_store.Margin = new Wisej.Web.Padding(0);
            this.bt_store.Name = "bt_store";
            this.bt_store.Size = new System.Drawing.Size(100, 32);
            this.bt_store.TabIndex = 34;
            this.bt_store.Text = "저장";
            this.bt_store.Click += new System.EventHandler(this.bt_store_Click);
            // 
            // label66
            // 
            this.label66.CssStyle = "\r\n";
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label66.Location = new System.Drawing.Point(0, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(418, 32);
            this.label66.TabIndex = 33;
            this.label66.Text = "그룹 편집";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emServerTableAdapter1
            // 
            this.emServerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // assetGroupsTableAdapter1
            // 
            this.assetGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // Comp_GroupDetailPanel
            // 
            this.Controls.Add(this.panel3);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "Comp_GroupDetailPanel";
            this.Size = new System.Drawing.Size(760, 860);
            this.Load += new System.EventHandler(this.Comp_GroupDetailPanel_Load);
            this.panel3.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel89.ResumeLayout(false);
            this.panel89.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.panel36.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel3;
        private Wisej.Web.Panel panel32;
        private Wisej.Web.Panel panel89;
        private Wisej.Web.Panel pn_zone;
        private Wisej.Web.Panel panel37;
        private Wisej.Web.Label lb_zone;
        private Wisej.Web.Panel panel36;
        private Wisej.Web.TextBox tb_groupName;
        private Wisej.Web.Label label24;
        private Wisej.Web.Line line2;
        private Wisej.Web.Panel panel34;
        private Wisej.Web.Label label23;
        private Wisej.Web.Label label22;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button bt_reset;
        private Wisej.Web.Button bt_store;
        private Wisej.Web.Label label66;
        private DataSet1TableAdapters.EMServerTableAdapter emServerTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1 dataSet12;
        private Wisej.Web.Validation validation1;
        private Wisej.Web.ErrorProvider errorProvider1;
        private DataSet1TableAdapters.AssetGroupsTableAdapter assetGroupsTableAdapter1;
        private Wisej.Web.Button bt_Delete;
    }
}
