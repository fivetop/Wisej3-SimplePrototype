namespace simplepa2.UI.Widget
{
    partial class Widget_BBSMultiDeck
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
            this.pn_multiDeck = new Wisej.Web.Panel();
            this.pn_deckSpace = new Wisej.Web.Panel();
            this.pn_labelSpace = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.pn_multiDeck.SuspendLayout();
            this.pn_labelSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_multiDeck
            // 
            this.pn_multiDeck.BackColor = System.Drawing.Color.White;
            this.pn_multiDeck.Controls.Add(this.pn_deckSpace);
            this.pn_multiDeck.Controls.Add(this.pn_labelSpace);
            this.pn_multiDeck.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_multiDeck.Location = new System.Drawing.Point(0, 0);
            this.pn_multiDeck.MinimumSize = new System.Drawing.Size(760, 0);
            this.pn_multiDeck.Name = "pn_multiDeck";
            this.pn_multiDeck.Padding = new Wisej.Web.Padding(20);
            this.pn_multiDeck.Size = new System.Drawing.Size(760, 440);
            this.pn_multiDeck.TabIndex = 51;
            // 
            // pn_deckSpace
            // 
            this.pn_deckSpace.AutoScroll = true;
            this.pn_deckSpace.BackColor = System.Drawing.Color.FromArgb(244, 245, 251);
            this.pn_deckSpace.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_deckSpace.Location = new System.Drawing.Point(20, 57);
            this.pn_deckSpace.Name = "pn_deckSpace";
            this.pn_deckSpace.Size = new System.Drawing.Size(720, 363);
            this.pn_deckSpace.TabIndex = 163;
            // 
            // pn_labelSpace
            // 
            this.pn_labelSpace.Controls.Add(this.label1);
            this.pn_labelSpace.Dock = Wisej.Web.DockStyle.Top;
            this.pn_labelSpace.Location = new System.Drawing.Point(20, 20);
            this.pn_labelSpace.Name = "pn_labelSpace";
            this.pn_labelSpace.Size = new System.Drawing.Size(720, 37);
            this.pn_labelSpace.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("@boxMTitle", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@bTextNormal");
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new Wisej.Web.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 24);
            this.label1.TabIndex = 134;
            this.label1.Text = "다원화 방송 Deck 상태 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Widget_BBSMultiDeck
            // 
            this.Controls.Add(this.pn_multiDeck);
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.MinimumSize = new System.Drawing.Size(650, 440);
            this.Name = "Widget_BBSMultiDeck";
            this.Size = new System.Drawing.Size(760, 440);
            this.pn_multiDeck.ResumeLayout(false);
            this.pn_labelSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pn_multiDeck;
        private Wisej.Web.Panel pn_deckSpace;
        private Wisej.Web.Panel pn_labelSpace;
        private Wisej.Web.Label label1;
    }
}
