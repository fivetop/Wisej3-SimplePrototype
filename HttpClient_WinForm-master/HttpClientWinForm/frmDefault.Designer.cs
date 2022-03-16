namespace HttpClientWinForm
{
    partial class frmDefault
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_InputArea = new System.Windows.Forms.Panel();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.labelQueryString = new System.Windows.Forms.Label();
            this.textBoxQueryString = new System.Windows.Forms.TextBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.radioButtonPost = new System.Windows.Forms.RadioButton();
            this.radioButtonGet = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxOutputArea = new System.Windows.Forms.TextBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.panel_InputArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_InputArea
            // 
            this.panel_InputArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_InputArea.Controls.Add(this.btnClearScreen);
            this.panel_InputArea.Controls.Add(this.labelQueryString);
            this.panel_InputArea.Controls.Add(this.textBoxQueryString);
            this.panel_InputArea.Controls.Add(this.labelMethod);
            this.panel_InputArea.Controls.Add(this.radioButtonPost);
            this.panel_InputArea.Controls.Add(this.radioButtonGet);
            this.panel_InputArea.Controls.Add(this.btnSubmit);
            this.panel_InputArea.Controls.Add(this.labelAddress);
            this.panel_InputArea.Controls.Add(this.textBoxAddress);
            this.panel_InputArea.Location = new System.Drawing.Point(52, 18);
            this.panel_InputArea.Name = "panel_InputArea";
            this.panel_InputArea.Size = new System.Drawing.Size(502, 121);
            this.panel_InputArea.TabIndex = 0;
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.Location = new System.Drawing.Point(41, 79);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(87, 23);
            this.btnClearScreen.TabIndex = 8;
            this.btnClearScreen.Text = "aaa";
            this.btnClearScreen.UseVisualStyleBackColor = true;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // labelQueryString
            // 
            this.labelQueryString.AutoSize = true;
            this.labelQueryString.Location = new System.Drawing.Point(38, 52);
            this.labelQueryString.Name = "labelQueryString";
            this.labelQueryString.Size = new System.Drawing.Size(50, 12);
            this.labelQueryString.TabIndex = 7;
            this.labelQueryString.Text = "POST：";
            this.labelQueryString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxQueryString
            // 
            this.textBoxQueryString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQueryString.Location = new System.Drawing.Point(159, 49);
            this.textBoxQueryString.Name = "textBoxQueryString";
            this.textBoxQueryString.Size = new System.Drawing.Size(299, 21);
            this.textBoxQueryString.TabIndex = 6;
            this.textBoxQueryString.Text = "user=11&password=22";
            // 
            // labelMethod
            // 
            this.labelMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(159, 84);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(31, 12);
            this.labelMethod.TabIndex = 5;
            this.labelMethod.Text = "ss：";
            this.labelMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButtonPost
            // 
            this.radioButtonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPost.AutoSize = true;
            this.radioButtonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonPost.Location = new System.Drawing.Point(295, 82);
            this.radioButtonPost.Name = "radioButtonPost";
            this.radioButtonPost.Size = new System.Drawing.Size(56, 16);
            this.radioButtonPost.TabIndex = 4;
            this.radioButtonPost.TabStop = true;
            this.radioButtonPost.Text = "POST";
            this.radioButtonPost.UseVisualStyleBackColor = true;
            // 
            // radioButtonGet
            // 
            this.radioButtonGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonGet.AutoSize = true;
            this.radioButtonGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonGet.Location = new System.Drawing.Point(241, 82);
            this.radioButtonGet.Name = "radioButtonGet";
            this.radioButtonGet.Size = new System.Drawing.Size(48, 16);
            this.radioButtonGet.TabIndex = 3;
            this.radioButtonGet.TabStop = true;
            this.radioButtonGet.Text = "GET";
            this.radioButtonGet.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(371, 79);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "aaas";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(37, 24);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(40, 12);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "URL：";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Location = new System.Drawing.Point(159, 21);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(299, 21);
            this.textBoxAddress.TabIndex = 0;
            this.textBoxAddress.Text = "http://localhost:44284/api/user";
            // 
            // textBoxOutputArea
            // 
            this.textBoxOutputArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputArea.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxOutputArea.Location = new System.Drawing.Point(52, 179);
            this.textBoxOutputArea.Multiline = true;
            this.textBoxOutputArea.Name = "textBoxOutputArea";
            this.textBoxOutputArea.ReadOnly = true;
            this.textBoxOutputArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputArea.Size = new System.Drawing.Size(501, 161);
            this.textBoxOutputArea.TabIndex = 1;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(52, 347);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(0, 12);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTip
            // 
            this.labelTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(52, 154);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(0, 12);
            this.labelTip.TabIndex = 3;
            this.labelTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDefault
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.textBoxOutputArea);
            this.Controls.Add(this.panel_InputArea);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MinimizeBox = false;
            this.Name = "frmDefault";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DingStudio Http Client - HTTP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDefault_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.frmDefault_ResizeEnd);
            this.panel_InputArea.ResumeLayout(false);
            this.panel_InputArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_InputArea;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton radioButtonPost;
        private System.Windows.Forms.RadioButton radioButtonGet;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.TextBox textBoxOutputArea;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox textBoxQueryString;
        private System.Windows.Forms.Label labelQueryString;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Button btnClearScreen;
    }
}

