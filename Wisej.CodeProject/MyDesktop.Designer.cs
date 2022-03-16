namespace Wisej.CodeProject
{
	partial class MyDesktop
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
            Wisej.Web.ImageListEntry imageListEntry10 = new Wisej.Web.ImageListEntry("imgs\\dPanel1.jpg", "dPanel1");
            Wisej.Web.ImageListEntry imageListEntry11 = new Wisej.Web.ImageListEntry("imgs\\dPanel2.jpg", "dPanel2");
            Wisej.Web.ImageListEntry imageListEntry12 = new Wisej.Web.ImageListEntry("imgs\\dPanel3.jpg", "dPanel3");
            this.desktopStart = new Wisej.Web.DesktopTaskBarItem();
            this.desktopDateTime = new Wisej.Web.DesktopTaskBarItemDateTime();
            this.justGage1 = new Wisej.Web.Ext.JustGage.JustGage();
            this.desktopCPU = new Wisej.Web.DesktopTaskBarItemControl();
            this.customWallpaper1 = new Wisej.Web.Ext.CustomWallpaper.CustomWallpaper(this.components);
            this.panel1 = new Wisej.Web.Panel();
            this.button10 = new Wisej.Web.Button();
            this.button9 = new Wisej.Web.Button();
            this.button8 = new Wisej.Web.Button();
            this.button7 = new Wisej.Web.Button();
            this.button6 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // desktopStart
            // 
            this.desktopStart.ImageSource = "icon-preview";
            this.desktopStart.Name = "desktopStart";
            this.desktopStart.ToolTipText = "Start";
            // 
            // desktopDateTime
            // 
            this.desktopDateTime.Name = "desktopDateTime";
            // 
            // justGage1
            // 
            this.justGage1.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.justGage1.ForeColor = System.Drawing.Color.White;
            this.justGage1.Label = "";
            this.justGage1.Name = "justGage1";
            this.justGage1.ShowMinMax = false;
            this.justGage1.ShowPointer = true;
            this.justGage1.Size = new System.Drawing.Size(60, 48);
            this.justGage1.Symbol = "%";
            this.justGage1.TabIndex = 0;
            this.justGage1.Text = "CPU%";
            this.justGage1.Value = 50F;
            this.justGage1.ValueColor = System.Drawing.Color.White;
            this.justGage1.Click += new System.EventHandler(this.justGage1_Click);
            // 
            // desktopCPU
            // 
            this.desktopCPU.Control = this.justGage1;
            this.desktopCPU.Name = "desktopCPU";
            this.desktopCPU.Position = Wisej.Web.LeftRightAlignment.Right;
            // 
            // customWallpaper1
            // 
            this.customWallpaper1.Images = new Wisej.Web.ImageListEntry[] {
        imageListEntry10,
        imageListEntry11,
        imageListEntry12};
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(9, 255, 255, 255);
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(150, 784);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            this.panel1.Text = "설정";
            // 
            // button10
            // 
            this.button10.Dock = Wisej.Web.DockStyle.Top;
            this.button10.Location = new System.Drawing.Point(0, 432);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(148, 48);
            this.button10.TabIndex = 9;
            this.button10.Text = "사용자관리";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Dock = Wisej.Web.DockStyle.Top;
            this.button9.Location = new System.Drawing.Point(0, 384);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 48);
            this.button9.TabIndex = 8;
            this.button9.Text = "장비내역";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Dock = Wisej.Web.DockStyle.Top;
            this.button8.Location = new System.Drawing.Point(0, 336);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 48);
            this.button8.TabIndex = 7;
            this.button8.Text = "스피커볼륨조정";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Dock = Wisej.Web.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(0, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "비상방송이력";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Dock = Wisej.Web.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "방송이력";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = Wisej.Web.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "알람/이벤트";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = Wisej.Web.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "음원관리";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = Wisej.Web.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "그룹관리";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = Wisej.Web.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "휴일관리";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = Wisej.Web.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "환경설정";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Items.AddRange(new Wisej.Web.DesktopTaskBarItem[] {
            this.desktopStart,
            this.desktopCPU,
            this.desktopDateTime});
            this.Name = "MyDesktop";
            this.Size = new System.Drawing.Size(876, 416);
            this.Wallpaper = "imgs/login2.jpg";
            this.Load += new System.EventHandler(this.MyDesktop_Load);
            this.Activated += new System.EventHandler(this.MyDesktop_Activated);
            this.ItemClick += new Wisej.Web.DesktopTaskBarItemClickEventHandler(this.MyDesktop_ItemClick);
            this.SizeChanged += new System.EventHandler(this.MyDesktop_SizeChanged);
            this.Resize += new System.EventHandler(this.MyDesktop_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private Web.DesktopTaskBarItem desktopStart;
		private Web.DesktopTaskBarItemDateTime desktopDateTime;
		private Web.DesktopTaskBarItemControl desktopCPU;
		private Web.Ext.JustGage.JustGage justGage1;
        private Web.Ext.CustomWallpaper.CustomWallpaper customWallpaper1;
        private Web.Panel panel1;
        private Web.Button button1;
        private Web.Button button4;
        private Web.Button button3;
        private Web.Button button2;
        private Web.Button button5;
        private Web.Button button9;
        private Web.Button button8;
        private Web.Button button7;
        private Web.Button button6;
        private Web.Button button10;
    }
}
