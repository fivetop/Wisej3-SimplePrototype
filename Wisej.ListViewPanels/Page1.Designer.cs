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
            this.listView1 = new Wisej.Web.ListView();
            this.button1 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.listView1.GridLineStyle = Wisej.Web.GridLineStyle.Both;
            this.listView1.ItemSize = new System.Drawing.Size(300, 80);
            this.listView1.Location = new System.Drawing.Point(13, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(632, 299);
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
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(807, 495);
            this.Text = "Page1";
            this.ResumeLayout(false);

		}

		#endregion

		private Web.ListView listView1;
		private Web.Button button1;
	}
}

