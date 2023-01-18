namespace simplepa2.UI.Popups
{
    partial class Form_FilePlayerMusicSelector
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
            this.panel1 = new Wisej.Web.Panel();
            this.panel136 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.panel2 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.panel4 = new Wisej.Web.Panel();
            this.panel5 = new Wisej.Web.Panel();
            this.button2 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.pMusicSelBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new simplepa2.DataSet1();
            this.bindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.musicsTableAdapter = new simplepa2.DataSet1TableAdapters.MusicsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel136.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMusicSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel136);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(871, 476);
            this.panel1.TabIndex = 0;
            // 
            // panel136
            // 
            this.panel136.BackColor = System.Drawing.Color.Transparent;
            this.panel136.Controls.Add(this.button1);
            this.panel136.Controls.Add(this.button5);
            this.panel136.Dock = Wisej.Web.DockStyle.Top;
            this.panel136.Location = new System.Drawing.Point(20, 20);
            this.panel136.Name = "panel136";
            this.panel136.Size = new System.Drawing.Size(831, 52);
            this.panel136.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.button1.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button1.Location = new System.Drawing.Point(631, 0);
            this.button1.Margin = new Wisej.Web.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "입력";
            this.button1.Visible = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromName("@button2BG");
            this.button5.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.button5.Location = new System.Drawing.Point(731, 0);
            this.button5.Margin = new Wisej.Web.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 35;
            this.button5.Text = "닫기";
            this.button5.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 384);
            this.panel2.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = Wisej.Web.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 384);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Dock = Wisej.Web.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(440, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 384);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = Wisej.Web.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(390, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 384);
            this.panel5.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button2.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.button2.BackgroundImageSource = "Images/music-crrl-2.png";
            this.button2.Location = new System.Drawing.Point(9, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 33);
            this.button2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromName("@bPanelBGline1");
            this.button3.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.button3.BackgroundImageSource = "Images/music-crrl-1.png";
            this.button3.Location = new System.Drawing.Point(9, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 33);
            this.button3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(390, 384);
            this.dataGridView2.TabIndex = 1;
            // 
            // pMusicSelBindingSource
            // 
            this.pMusicSelBindingSource.DataMember = "bind";
            this.pMusicSelBindingSource.DataSource = typeof(simplepa2.PMusicSel);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Musics";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // musicsTableAdapter
            // 
            this.musicsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_FilePlayerMusicSelector
            // 
            this.ClientSize = new System.Drawing.Size(871, 476);
            this.Controls.Add(this.panel1);
            this.HeaderBackColor = System.Drawing.Color.FromName("@button1BG");
            this.Name = "Form_FilePlayerMusicSelector";
            this.Text = "음원 선택기";
            this.panel1.ResumeLayout(false);
            this.panel136.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMusicSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel136;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button5;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Button button3;
        private Wisej.Web.Button button2;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.BindingSource pMusicSelBindingSource;
        private DataSet1 dataSet1;
        private Wisej.Web.BindingSource bindingSource1;
        private DataSet1TableAdapters.MusicsTableAdapter musicsTableAdapter;
    }
}