namespace simplepa2.UI.Components
{
    partial class Comp_InputDeviceCard
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
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::simplepa2.Properties.Resources.nav_quit_777;
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AVIO USB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "2 x 2 Dante 1Ch";
            // 
            // Comp_InputDeviceCard
            // 
            this.BackColor = System.Drawing.Color.FromName("@tabFace");
            this.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Comp_InputDeviceCard";
            this.Size = new System.Drawing.Size(270, 80);
            this.Click += new System.EventHandler(this.Comp_InputDeviceCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
    }
}
