namespace Wisej.CodeProject.Popups
{
	partial class StartPopup
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
            this.label1 = new Wisej.Web.Label();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.btnBackgroundTasks = new Wisej.Web.Button();
            this.btnIntegration = new Wisej.Web.Button();
            this.imageList = new Wisej.Web.ImageList(this.components);
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("default", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple PA 설정";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnBackgroundTasks);
            this.flowLayoutPanel1.Controls.Add(this.btnIntegration);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 241);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // btnBackgroundTasks
            // 
            this.btnBackgroundTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackgroundTasks.ImageSource = "Resources\\add-alarm-button.svg?color=#FFD700";
            this.btnBackgroundTasks.Location = new System.Drawing.Point(3, 3);
            this.btnBackgroundTasks.Name = "btnBackgroundTasks";
            this.btnBackgroundTasks.Padding = new Wisej.Web.Padding(30, 0, 10, 0);
            this.btnBackgroundTasks.Size = new System.Drawing.Size(180, 68);
            this.btnBackgroundTasks.TabIndex = 0;
            this.btnBackgroundTasks.Text = "환경설정";
            this.btnBackgroundTasks.Click += new System.EventHandler(this.btnBackgroundTasks_Click);
            // 
            // btnIntegration
            // 
            this.btnIntegration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntegration.ImageList = this.imageList;
            this.btnIntegration.ImageSource = "Resources\\black-plane.svg?color=#BF3FB6";
            this.btnIntegration.Location = new System.Drawing.Point(189, 3);
            this.btnIntegration.Name = "btnIntegration";
            this.btnIntegration.Padding = new Wisej.Web.Padding(30, 0, 10, 0);
            this.btnIntegration.Size = new System.Drawing.Size(180, 68);
            this.btnIntegration.TabIndex = 1;
            this.btnIntegration.Text = "그룹관리";
            this.btnIntegration.Click += new System.EventHandler(this.btnIntegration_Click);
            // 
            // imageList
            // 
            this.imageList.ImageSize = new System.Drawing.Size(38, 38);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageList = this.imageList;
            this.button1.ImageSource = "Resources\\film-roll.svg?color=#7FBF3F";
            this.button1.Location = new System.Drawing.Point(375, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new Wisej.Web.Padding(30, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(180, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "휴일관리";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageList = this.imageList;
            this.button2.ImageSource = "Resources\\black-keyboard-with-white-keys.svg?color=#BF3F3F";
            this.button2.Location = new System.Drawing.Point(3, 77);
            this.button2.Name = "button2";
            this.button2.Padding = new Wisej.Web.Padding(30, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(180, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "알람/이벤트";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageList = this.imageList;
            this.button3.ImageSource = "Resources\\painter-palette.svg?color=#00FDFF";
            this.button3.Location = new System.Drawing.Point(189, 77);
            this.button3.Name = "button3";
            this.button3.Padding = new Wisej.Web.Padding(30, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(180, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "음원관리";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageList = this.imageList;
            this.button4.ImageSource = "Resources\\clapperboard-1.svg?color=#FF7700";
            this.button4.Location = new System.Drawing.Point(375, 77);
            this.button4.Name = "button4";
            this.button4.Padding = new Wisej.Web.Padding(30, 0, 10, 0);
            this.button4.Size = new System.Drawing.Size(180, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "방송이력";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StartPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(157, 0, 0, 0);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "StartPopup";
            this.Size = new System.Drawing.Size(609, 375);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Label label1;
		private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.Button btnBackgroundTasks;
		private Web.ImageList imageList;
		private Web.Button btnIntegration;
		private Web.Button button1;
		private Web.Button button2;
		private Web.Button button3;
		private Web.Button button4;
	}
}
