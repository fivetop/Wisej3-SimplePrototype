namespace simplepa2.UI.Views
{
    partial class View_BBSPresetManage
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
            this.pn_PresetList = new Wisej.Web.Panel();
            this.pn_PresetItemList = new Wisej.Web.Panel();
            this.pn_PresetTopPanel = new Wisej.Web.Panel();
            this.bt_AddPreset = new Wisej.Web.Button();
            this.label15 = new Wisej.Web.Label();
            this.pn_Spacer = new Wisej.Web.Panel();
            this.pn_PresetWrapper = new Wisej.Web.Panel();
            this.pn_PresetDetails = new Wisej.Web.Panel();
            this.pn_PresetList.SuspendLayout();
            this.pn_PresetTopPanel.SuspendLayout();
            this.pn_PresetWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_PresetList
            // 
            this.pn_PresetList.BackColor = System.Drawing.Color.White;
            this.pn_PresetList.Controls.Add(this.pn_PresetItemList);
            this.pn_PresetList.Controls.Add(this.pn_PresetTopPanel);
            this.pn_PresetList.Dock = Wisej.Web.DockStyle.Left;
            this.pn_PresetList.Location = new System.Drawing.Point(20, 20);
            this.pn_PresetList.Name = "pn_PresetList";
            this.pn_PresetList.Padding = new Wisej.Web.Padding(20);
            this.pn_PresetList.Size = new System.Drawing.Size(580, 860);
            this.pn_PresetList.TabIndex = 41;
            // 
            // pn_PresetItemList
            // 
            this.pn_PresetItemList.AutoScroll = true;
            this.pn_PresetItemList.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_PresetItemList.ForeColor = System.Drawing.Color.FromArgb(171, 171, 171);
            this.pn_PresetItemList.Location = new System.Drawing.Point(20, 72);
            this.pn_PresetItemList.Name = "pn_PresetItemList";
            this.pn_PresetItemList.Size = new System.Drawing.Size(540, 768);
            this.pn_PresetItemList.TabIndex = 51;
            this.pn_PresetItemList.Text = "listPanel";
            // 
            // pn_PresetTopPanel
            // 
            this.pn_PresetTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.pn_PresetTopPanel.Controls.Add(this.bt_AddPreset);
            this.pn_PresetTopPanel.Controls.Add(this.label15);
            this.pn_PresetTopPanel.Dock = Wisej.Web.DockStyle.Top;
            this.pn_PresetTopPanel.Location = new System.Drawing.Point(20, 20);
            this.pn_PresetTopPanel.Name = "pn_PresetTopPanel";
            this.pn_PresetTopPanel.Size = new System.Drawing.Size(540, 52);
            this.pn_PresetTopPanel.TabIndex = 50;
            // 
            // bt_AddPreset
            // 
            this.bt_AddPreset.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.bt_AddPreset.BackColor = System.Drawing.Color.FromName("@button1BG");
            this.bt_AddPreset.Font = new System.Drawing.Font("@buttonTxt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bt_AddPreset.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.bt_AddPreset.Location = new System.Drawing.Point(440, 0);
            this.bt_AddPreset.Margin = new Wisej.Web.Padding(0);
            this.bt_AddPreset.Name = "bt_AddPreset";
            this.bt_AddPreset.Size = new System.Drawing.Size(100, 32);
            this.bt_AddPreset.TabIndex = 34;
            this.bt_AddPreset.Text = "추가";
            // 
            // label15
            // 
            this.label15.CssStyle = "\r\n";
            this.label15.Font = new System.Drawing.Font("@boxTitle", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(223, 32);
            this.label15.TabIndex = 33;
            this.label15.Text = "프리셋(Preset) 리스트";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_Spacer
            // 
            this.pn_Spacer.BackColor = System.Drawing.Color.Transparent;
            this.pn_Spacer.Dock = Wisej.Web.DockStyle.Left;
            this.pn_Spacer.Location = new System.Drawing.Point(600, 20);
            this.pn_Spacer.Name = "pn_Spacer";
            this.pn_Spacer.Size = new System.Drawing.Size(20, 860);
            this.pn_Spacer.TabIndex = 46;
            // 
            // pn_PresetWrapper
            // 
            this.pn_PresetWrapper.BackColor = System.Drawing.Color.FromArgb(238, 239, 248);
            this.pn_PresetWrapper.Controls.Add(this.pn_PresetDetails);
            this.pn_PresetWrapper.Controls.Add(this.pn_Spacer);
            this.pn_PresetWrapper.Controls.Add(this.pn_PresetList);
            this.pn_PresetWrapper.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_PresetWrapper.Location = new System.Drawing.Point(0, 0);
            this.pn_PresetWrapper.Margin = new Wisej.Web.Padding(0);
            this.pn_PresetWrapper.Name = "pn_PresetWrapper";
            this.pn_PresetWrapper.Padding = new Wisej.Web.Padding(20);
            this.pn_PresetWrapper.Size = new System.Drawing.Size(1400, 900);
            this.pn_PresetWrapper.TabIndex = 47;
            // 
            // pn_PresetDetails
            // 
            this.pn_PresetDetails.BackColor = System.Drawing.Color.White;
            this.pn_PresetDetails.Dock = Wisej.Web.DockStyle.Fill;
            this.pn_PresetDetails.Location = new System.Drawing.Point(620, 20);
            this.pn_PresetDetails.Name = "pn_PresetDetails";
            this.pn_PresetDetails.Padding = new Wisej.Web.Padding(20);
            this.pn_PresetDetails.Size = new System.Drawing.Size(760, 860);
            this.pn_PresetDetails.TabIndex = 47;
            // 
            // View_BBSPresetManage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pn_PresetWrapper);
            this.CssStyle = "background: /*#F0F0F0*/#eeeff8;";
            this.Dock = Wisej.Web.DockStyle.Fill;
            this.Name = "View_BBSPresetManage";
            this.Size = new System.Drawing.Size(1400, 900);
            this.pn_PresetList.ResumeLayout(false);
            this.pn_PresetTopPanel.ResumeLayout(false);
            this.pn_PresetWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pn_PresetList;
        private Wisej.Web.Panel pn_PresetItemList;
        private Wisej.Web.Panel pn_PresetTopPanel;
        private Wisej.Web.Button bt_AddPreset;
        private Wisej.Web.Label label15;
        private Wisej.Web.Panel pn_Spacer;
        private Wisej.Web.Panel pn_PresetWrapper;
        private Wisej.Web.Panel pn_PresetDetails;
    }
}
