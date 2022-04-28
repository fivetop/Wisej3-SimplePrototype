namespace Wisej.CodeProject.Control
{
    partial class ListviewCTL
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
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = Wisej.Web.DockStyle.Fill;
            this.listView1.GridLineStyle = Wisej.Web.GridLineStyle.Both;
            this.listView1.ItemSize = new System.Drawing.Size(300, 80);
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 311);
            this.listView1.TabIndex = 2;
            this.listView1.View = Wisej.Web.View.Tile;
            // 
            // ListviewCTL
            // 
            this.Controls.Add(this.listView1);
            this.Name = "ListviewCTL";
            this.Size = new System.Drawing.Size(381, 311);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.ListView listView1;
    }
}
