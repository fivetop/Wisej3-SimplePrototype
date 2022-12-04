namespace simplepa2.UI.Components
{
    partial class Comp_InputDSPLineCard
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
            this.comp_InputDeviceCard1 = new simplepa2.UI.Components.Comp_InputDeviceCard();
            this.line1 = new Wisej.Web.Line();
            this.label1 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // comp_InputDeviceCard1
            // 
            this.comp_InputDeviceCard1.Name = "comp_InputDeviceCard1";
            this.comp_InputDeviceCard1.TabIndex = 0;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(276, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(291, 10);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Analog 1Ch";
            // 
            // Comp_InputDSPLineCard
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.comp_InputDeviceCard1);
            this.Name = "Comp_InputDSPLineCard";
            this.Size = new System.Drawing.Size(570, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Comp_InputDeviceCard comp_InputDeviceCard1;
        private Wisej.Web.Line line1;
        private Wisej.Web.Label label1;
    }
}
