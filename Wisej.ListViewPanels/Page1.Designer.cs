namespace Wisej.ListViewPanels
{
	partial class Page1
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
            this.listView1 = new Wisej.Web.ListView();
            this.button1 = new Wisej.Web.Button();
            this.dataRepeater1 = new Wisej.Web.DataRepeater();
            this.button2 = new Wisej.Web.Button();
            this.membs = new Wisej.Web.BindingSource(this.components);
            this.label3 = new Wisej.Web.Label();
            this.panelOutOfStock = new Wisej.Web.Panel();
            this.panelInStock = new Wisej.Web.Panel();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.label1 = new Wisej.Web.Label();
            this.pictureBox3 = new Wisej.Web.PictureBox();
            this.label2 = new Wisej.Web.Label();
            this.productTitle = new Wisej.Web.Label();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.membs = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membs)).BeginInit();
            this.panelOutOfStock.SuspendLayout();
            this.panelInStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membs)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = Wisej.Web.DockStyle.Fill;
            this.listView1.GridLineStyle = Wisej.Web.GridLineStyle.Both;
            this.listView1.ItemSize = new System.Drawing.Size(300, 80);
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 352);
            this.listView1.TabIndex = 0;
            this.listView1.View = Wisej.Web.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.ClientSizeChanged += new System.EventHandler(this.listView1_ClientSizeChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Items";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataRepeater1.ItemHeaderVisible = false;
            this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 150);
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.button2);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label3);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.panelOutOfStock);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.productTitle);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.pictureBox1);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(510, 150);
            this.dataRepeater1.Location = new System.Drawing.Point(0, 0);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.PrefetchItems = 2;
            this.dataRepeater1.Size = new System.Drawing.Size(512, 352);
            this.dataRepeater1.TabIndex = 2;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromName("@switchOn");
            // 
            // membs
            // 
            this.membs.DataSource = typeof(Wisej.ListViewPanels.ProductModel);
            this.button2.DataBindings.Add(new Wisej.Web.Binding("Visible", this.membs, "InStock", true));
            this.button2.Font = new System.Drawing.Font("default", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ImageSource = "table-row-new";
            this.button2.Location = new System.Drawing.Point(349, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buy";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.DataBindings.Add(new Wisej.Web.Binding("Text", this.membs, "ProductDetail", true));
            this.label3.Location = new System.Drawing.Point(123, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "detail";
            // 
            // panelOutOfStock
            // 
            this.panelOutOfStock.Controls.Add(this.panelInStock);
            this.panelOutOfStock.Controls.Add(this.pictureBox3);
            this.panelOutOfStock.Controls.Add(this.label2);
            this.panelOutOfStock.Location = new System.Drawing.Point(116, 100);
            this.panelOutOfStock.Name = "panelOutOfStock";
            this.panelOutOfStock.Size = new System.Drawing.Size(130, 40);
            this.panelOutOfStock.TabIndex = 3;
            this.panelOutOfStock.TabStop = true;
            // 
            // panelInStock
            // 
            this.panelInStock.Controls.Add(this.pictureBox2);
            this.panelInStock.Controls.Add(this.label1);
            this.panelInStock.DataBindings.Add(new Wisej.Web.Binding("Visible", this.membs, "InStock", true));
            this.panelInStock.Location = new System.Drawing.Point(0, 0);
            this.panelInStock.Name = "panelInStock";
            this.panelInStock.Size = new System.Drawing.Size(130, 40);
            this.panelInStock.TabIndex = 2;
            this.panelInStock.TabStop = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ForeColor = System.Drawing.Color.FromName("@switchOn");
            this.pictureBox2.ImageSource = "icon-check";
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("defaultBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@switchOn");
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "In Stock";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ForeColor = System.Drawing.Color.FromName("@switchOff");
            this.pictureBox3.ImageSource = "icon-close";
            this.pictureBox3.Location = new System.Drawing.Point(5, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("defaultBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@switchOff");
            this.label2.Location = new System.Drawing.Point(42, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Out of Stock";
            // 
            // productTitle
            // 
            this.productTitle.AutoSize = true;
            this.productTitle.DataBindings.Add(new Wisej.Web.Binding("Text", this.membs, "ProductTitle", true));
            this.productTitle.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.productTitle.Location = new System.Drawing.Point(10, 10);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(37, 20);
            this.productTitle.TabIndex = 1;
            this.productTitle.Text = "title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new Wisej.Web.Binding("ImageSource", this.membs, "Image", true));
            this.pictureBox1.Location = new System.Drawing.Point(10, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(13, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.TabStop = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataRepeater1);
            this.splitContainer1.Panel2.TabStop = true;
            this.splitContainer1.Size = new System.Drawing.Size(896, 352);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 3;
            // 
            // membs
            // 
            this.membs.DataSource = typeof(Wisej.ListViewPanels.ProductModel);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1508, 583);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membs)).EndInit();
            this.panelOutOfStock.ResumeLayout(false);
            this.panelOutOfStock.PerformLayout();
            this.panelInStock.ResumeLayout(false);
            this.panelInStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membs)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Web.ListView listView1;
		private Web.Button button1;
        private Web.DataRepeater dataRepeater1;
        private Web.Button button2;
        private Web.Label label3;
        private Web.Panel panelOutOfStock;
        private Web.Panel panelInStock;
        private Web.PictureBox pictureBox2;
        private Web.Label label1;
        private Web.PictureBox pictureBox3;
        private Web.Label label2;
        private Web.Label productTitle;
        private Web.PictureBox pictureBox1;
        private Web.SplitContainer splitContainer1;
        private Web.BindingSource membs;
    }
}

