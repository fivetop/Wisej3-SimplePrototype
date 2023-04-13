namespace KakaoTTSTest
{
    partial class Window1
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
            this.comboVoice = new Wisej.Web.ComboBox();
            this.tbTTSText = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.lbspd = new Wisej.Web.Label();
            this.comboProsody = new Wisej.Web.ComboBox();
            this.btCallTTS = new Wisej.Web.Button();
            this.comboVolume = new Wisej.Web.ComboBox();
            this.볼륨 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // comboVoice
            // 
            this.comboVoice.Items.AddRange(new object[] {
            "Anna",
            "Bentley",
            "Cameron",
            "Carter",
            "Casey",
            "Chase",
            "Claire",
            "Clara",
            "Cooper",
            "Cora",
            "Daisy",
            "Dakota",
            "David",
            "Dax",
            "Dean",
            "Della",
            "Demi",
            "Diana",
            "Dorothy",
            "Dream",
            "Elias",
            "Emily",
            "Emma",
            "Summer  "});
            this.comboVoice.Location = new System.Drawing.Point(110, 33);
            this.comboVoice.Name = "comboVoice";
            this.comboVoice.Size = new System.Drawing.Size(200, 22);
            this.comboVoice.TabIndex = 0;
            // 
            // tbTTSText
            // 
            this.tbTTSText.Location = new System.Drawing.Point(33, 247);
            this.tbTTSText.Name = "tbTTSText";
            this.tbTTSText.Size = new System.Drawing.Size(495, 22);
            this.tbTTSText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "화자 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "TTS 내용";
            // 
            // lbspd
            // 
            this.lbspd.AutoSize = true;
            this.lbspd.Location = new System.Drawing.Point(42, 96);
            this.lbspd.Name = "lbspd";
            this.lbspd.Size = new System.Drawing.Size(33, 15);
            this.lbspd.TabIndex = 4;
            this.lbspd.Text = "속도";
            // 
            // comboProsody
            // 
            this.comboProsody.Items.AddRange(new object[] {
            "slow",
            "medium",
            "fast"});
            this.comboProsody.Location = new System.Drawing.Point(110, 92);
            this.comboProsody.Name = "comboProsody";
            this.comboProsody.Size = new System.Drawing.Size(200, 22);
            this.comboProsody.TabIndex = 5;
            // 
            // btCallTTS
            // 
            this.btCallTTS.Location = new System.Drawing.Point(381, 348);
            this.btCallTTS.Name = "btCallTTS";
            this.btCallTTS.Size = new System.Drawing.Size(100, 27);
            this.btCallTTS.TabIndex = 6;
            this.btCallTTS.Text = "Start";
            this.btCallTTS.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboVolume
            // 
            this.comboVolume.Items.AddRange(new object[] {
            "soft",
            "medium",
            "loud"});
            this.comboVolume.Location = new System.Drawing.Point(110, 155);
            this.comboVolume.Name = "comboVolume";
            this.comboVolume.Size = new System.Drawing.Size(200, 22);
            this.comboVolume.TabIndex = 8;
            // 
            // 볼륨
            // 
            this.볼륨.AutoSize = true;
            this.볼륨.Location = new System.Drawing.Point(42, 159);
            this.볼륨.Name = "볼륨";
            this.볼륨.Size = new System.Drawing.Size(33, 15);
            this.볼륨.TabIndex = 7;
            this.볼륨.Text = "속도";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.Controls.Add(this.comboVolume);
            this.Controls.Add(this.볼륨);
            this.Controls.Add(this.btCallTTS);
            this.Controls.Add(this.comboProsody);
            this.Controls.Add(this.lbspd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTTSText);
            this.Controls.Add(this.comboVoice);
            this.Name = "Window1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.ComboBox comboVoice;
        private Wisej.Web.TextBox tbTTSText;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label lbspd;
        private Wisej.Web.ComboBox comboProsody;
        private Wisej.Web.Button btCallTTS;
        private Wisej.Web.ComboBox comboVolume;
        private Wisej.Web.Label 볼륨;
    }
}

