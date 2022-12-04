namespace simplepa2.UI.Pages
{
    partial class PA_MainFrame
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
            this.mainMenuBar = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.dashboardBarItems = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.bbsManagementBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.anchorBBSBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.reservationBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.presetBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.groupBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.iotApplicationBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.musicConfigurationBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.holidayBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.bbsConfigurationBarItems = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.deviceManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.siteManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.zoneManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.inputManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.outputManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.musicManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.emergencyManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.ampFailoverBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.bbsHistoryBarItems = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.bbsHistoryBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.deviceHistoryBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.fireCallHistoryBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.outCallHistoryBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.systemVerifyHistoryBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.systemConfBarItems = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.accountManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.emailManageBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.smsRegistrationBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.restAPIRegistrationBarItem = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.rightPanels = new Wisej.Web.Panel();
            this.contentsPanel = new Wisej.Web.Panel();
            this.topPanels = new Wisej.Web.Panel();
            this.dataSet1 = new simplepa2.DataSet1();
            this.eventvmTableAdapter = new simplepa2.DataSet1TableAdapters.EventvmTableAdapter();
            this.rightPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.Dock = Wisej.Web.DockStyle.Left;
            this.mainMenuBar.EnableKeyboardNavigation = true;
            this.mainMenuBar.ItemHeight = 55;
            this.mainMenuBar.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.dashboardBarItems,
            this.bbsManagementBarItem,
            this.bbsConfigurationBarItems,
            this.bbsHistoryBarItems,
            this.systemConfBarItems});
            this.mainMenuBar.Logo = "imgs\\myinfo-icon-9x9-777.png";
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.RightToLeft = Wisej.Web.RightToLeft.No;
            this.mainMenuBar.ShowUser = false;
            this.mainMenuBar.Size = new System.Drawing.Size(282, 646);
            this.mainMenuBar.TabIndex = 0;
            this.mainMenuBar.Text = "SimplePA";
            this.mainMenuBar.ItemClick += new Wisej.Web.Ext.NavigationBar.NavigationBarItemClickEventHandler(this.mainMenuBar_ItemClick);
            this.mainMenuBar.SelectedItemChanged += new System.EventHandler(this.mainMenuBar_SelectedItemChanged);
            // 
            // dashboardBarItems
            // 
            this.dashboardBarItems.AccessibleName = "dashboardBarItems";
            this.dashboardBarItems.Name = "NavigationBarItem";
            this.dashboardBarItems.Text = "대쉬보드";
            // 
            // bbsManagementBarItem
            // 
            this.bbsManagementBarItem.AccessibleName = "bbsManagementBarItem";
            this.bbsManagementBarItem.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.anchorBBSBarItem,
            this.reservationBarItem,
            this.presetBarItem,
            this.groupBarItem,
            this.iotApplicationBarItem,
            this.musicConfigurationBarItem,
            this.holidayBarItem});
            this.bbsManagementBarItem.Name = "NavigationBarItem";
            this.bbsManagementBarItem.Text = "방송운영";
            // 
            // anchorBBSBarItem
            // 
            this.anchorBBSBarItem.AccessibleName = "anchorBBSBarItem";
            this.anchorBBSBarItem.Name = "NavigationBarItem";
            this.anchorBBSBarItem.Text = "앵커방송";
            // 
            // reservationBarItem
            // 
            this.reservationBarItem.AccessibleName = "reservationBarItem";
            this.reservationBarItem.Name = "NavigationBarItem";
            this.reservationBarItem.Text = "예약방송";
            // 
            // presetBarItem
            // 
            this.presetBarItem.AccessibleName = "presetBarItem";
            this.presetBarItem.Name = "NavigationBarItem";
            this.presetBarItem.Text = "프리셋편집";
            // 
            // groupBarItem
            // 
            this.groupBarItem.AccessibleName = "groupBarItem";
            this.groupBarItem.Name = "NavigationBarItem";
            this.groupBarItem.Text = "그룹편집";
            // 
            // iotApplicationBarItem
            // 
            this.iotApplicationBarItem.AccessibleName = "iotApplicationBarItem";
            this.iotApplicationBarItem.Name = "NavigationBarItem";
            this.iotApplicationBarItem.Text = "IoT Application 방송";
            // 
            // musicConfigurationBarItem
            // 
            this.musicConfigurationBarItem.AccessibleName = "musicConfigurationBarItem";
            this.musicConfigurationBarItem.Name = "NavigationBarItem";
            this.musicConfigurationBarItem.Text = "음원 설정";
            // 
            // holidayBarItem
            // 
            this.holidayBarItem.AccessibleName = "holidayBarItem";
            this.holidayBarItem.Name = "NavigationBarItem";
            this.holidayBarItem.Text = "휴일 관리";
            // 
            // bbsConfigurationBarItems
            // 
            this.bbsConfigurationBarItems.AccessibleName = "bbsConfigurationBarItems";
            this.bbsConfigurationBarItems.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.deviceManageBarItem,
            this.siteManageBarItem,
            this.zoneManageBarItem,
            this.inputManageBarItem,
            this.outputManageBarItem,
            this.musicManageBarItem,
            this.emergencyManageBarItem,
            this.ampFailoverBarItem});
            this.bbsConfigurationBarItems.Name = "NavigationBarItem";
            this.bbsConfigurationBarItems.Text = "방송설정";
            // 
            // deviceManageBarItem
            // 
            this.deviceManageBarItem.AccessibleName = "deviceManageBarItem";
            this.deviceManageBarItem.Name = "NavigationBarItem";
            this.deviceManageBarItem.Text = "장비 관리";
            // 
            // siteManageBarItem
            // 
            this.siteManageBarItem.AccessibleName = "siteManageBarItem";
            this.siteManageBarItem.Name = "NavigationBarItem";
            this.siteManageBarItem.Text = "사이트 관리";
            // 
            // zoneManageBarItem
            // 
            this.zoneManageBarItem.AccessibleName = "zoneManageBarItem";
            this.zoneManageBarItem.Name = "NavigationBarItem";
            this.zoneManageBarItem.Text = "ZONE 관리";
            // 
            // inputManageBarItem
            // 
            this.inputManageBarItem.AccessibleName = "inputManageBarItem";
            this.inputManageBarItem.Name = "NavigationBarItem";
            this.inputManageBarItem.Text = "입력 관리";
            // 
            // outputManageBarItem
            // 
            this.outputManageBarItem.AccessibleName = "outputManageBarItem";
            this.outputManageBarItem.Name = "NavigationBarItem";
            this.outputManageBarItem.Text = "출력 관리";
            // 
            // musicManageBarItem
            // 
            this.musicManageBarItem.AccessibleName = "musicManageBarItem";
            this.musicManageBarItem.Name = "NavigationBarItem";
            this.musicManageBarItem.Text = "음량 관리";
            // 
            // emergencyManageBarItem
            // 
            this.emergencyManageBarItem.AccessibleName = "emergencyManageBarItem";
            this.emergencyManageBarItem.Name = "NavigationBarItem";
            this.emergencyManageBarItem.Text = "비상 방송";
            // 
            // ampFailoverBarItem
            // 
            this.ampFailoverBarItem.AccessibleName = "ampFailoverBarItem";
            this.ampFailoverBarItem.Name = "NavigationBarItem";
            this.ampFailoverBarItem.Text = "앰프 Failover";
            // 
            // bbsHistoryBarItems
            // 
            this.bbsHistoryBarItems.AccessibleName = "bbsHistoryBarItems";
            this.bbsHistoryBarItems.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.bbsHistoryBarItem,
            this.deviceHistoryBarItem,
            this.fireCallHistoryBarItem,
            this.outCallHistoryBarItem,
            this.systemVerifyHistoryBarItem});
            this.bbsHistoryBarItems.Name = "NavigationBarItem";
            this.bbsHistoryBarItems.Text = "방송기록";
            // 
            // bbsHistoryBarItem
            // 
            this.bbsHistoryBarItem.AccessibleName = "bbsHistoryBarItem";
            this.bbsHistoryBarItem.Name = "NavigationBarItem";
            this.bbsHistoryBarItem.Text = "방송 이력";
            // 
            // deviceHistoryBarItem
            // 
            this.deviceHistoryBarItem.AccessibleName = "deviceHistoryBarItem";
            this.deviceHistoryBarItem.Name = "NavigationBarItem";
            this.deviceHistoryBarItem.Text = "장비 이력";
            // 
            // fireCallHistoryBarItem
            // 
            this.fireCallHistoryBarItem.AccessibleName = "fireCallHistoryBarItem";
            this.fireCallHistoryBarItem.Name = "NavigationBarItem";
            this.fireCallHistoryBarItem.Text = "화재수신 이력";
            // 
            // outCallHistoryBarItem
            // 
            this.outCallHistoryBarItem.AccessibleName = "outCallHistoryBarItem";
            this.outCallHistoryBarItem.Name = "NavigationBarItem";
            this.outCallHistoryBarItem.Text = "외부수신 이력";
            // 
            // systemVerifyHistoryBarItem
            // 
            this.systemVerifyHistoryBarItem.AccessibleName = "systemVerifyHistoryBarItem";
            this.systemVerifyHistoryBarItem.Name = "NavigationBarItem";
            this.systemVerifyHistoryBarItem.Text = "시스템변경 이력";
            // 
            // systemConfBarItems
            // 
            this.systemConfBarItems.AccessibleName = "systemConfBarItems";
            this.systemConfBarItems.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.accountManageBarItem,
            this.emailManageBarItem,
            this.smsRegistrationBarItem,
            this.restAPIRegistrationBarItem});
            this.systemConfBarItems.Name = "NavigationBarItem";
            this.systemConfBarItems.Text = "시스템 설정";
            // 
            // accountManageBarItem
            // 
            this.accountManageBarItem.AccessibleName = "accountManageBarItem";
            this.accountManageBarItem.Name = "NavigationBarItem";
            this.accountManageBarItem.Text = "계정 등록 관리";
            // 
            // emailManageBarItem
            // 
            this.emailManageBarItem.AccessibleName = "emailManageBarItem";
            this.emailManageBarItem.Name = "NavigationBarItem";
            this.emailManageBarItem.Text = "시스템 이메일 등록";
            // 
            // smsRegistrationBarItem
            // 
            this.smsRegistrationBarItem.AccessibleName = "smsRegistrationBarItem";
            this.smsRegistrationBarItem.Name = "NavigationBarItem";
            this.smsRegistrationBarItem.Text = "SMS 등록";
            // 
            // restAPIRegistrationBarItem
            // 
            this.restAPIRegistrationBarItem.AccessibleName = "restAPIRegistrationBarItem";
            this.restAPIRegistrationBarItem.Name = "NavigationBarItem";
            this.restAPIRegistrationBarItem.Text = "REST API";
            // 
            // rightPanels
            // 
            this.rightPanels.AutoSize = true;
            this.rightPanels.Controls.Add(this.contentsPanel);
            this.rightPanels.Controls.Add(this.topPanels);
            this.rightPanels.Dock = Wisej.Web.DockStyle.Fill;
            this.rightPanels.Location = new System.Drawing.Point(282, 0);
            this.rightPanels.Name = "rightPanels";
            this.rightPanels.Size = new System.Drawing.Size(1385, 646);
            this.rightPanels.TabIndex = 1;
            // 
            // contentsPanel
            // 
            this.contentsPanel.BackColor = System.Drawing.Color.FromName("@table-row-background-focused");
            this.contentsPanel.CollapseSide = Wisej.Web.HeaderPosition.Right;
            this.contentsPanel.Dock = Wisej.Web.DockStyle.Fill;
            this.contentsPanel.Location = new System.Drawing.Point(0, 66);
            this.contentsPanel.Name = "contentsPanel";
            this.contentsPanel.Size = new System.Drawing.Size(1385, 580);
            this.contentsPanel.TabIndex = 0;
            // 
            // topPanels
            // 
            this.topPanels.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.topPanels.BackColor = System.Drawing.Color.FromName("@tabSelected");
            this.topPanels.Dock = Wisej.Web.DockStyle.Top;
            this.topPanels.Location = new System.Drawing.Point(0, 0);
            this.topPanels.Name = "topPanels";
            this.topPanels.Size = new System.Drawing.Size(1385, 66);
            this.topPanels.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventvmTableAdapter
            // 
            this.eventvmTableAdapter.ClearBeforeFill = true;
            // 
            // PA_MainFrame
            // 
            this.Controls.Add(this.rightPanels);
            this.Controls.Add(this.mainMenuBar);
            this.Name = "PA_MainFrame";
            this.Size = new System.Drawing.Size(1667, 646);
            this.Text = "PA_MainFrame";
            this.Load += new System.EventHandler(this.PA_MainFrame_Load);
            this.rightPanels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.Panel rightPanels;
        private Wisej.Web.Panel topPanels;
        private Wisej.Web.Ext.NavigationBar.NavigationBar mainMenuBar;
        private Wisej.Web.Panel contentsPanel;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem dashboardBarItems;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem bbsManagementBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem anchorBBSBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem reservationBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem presetBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem groupBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem iotApplicationBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem musicConfigurationBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem holidayBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem bbsConfigurationBarItems;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem siteManageBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem zoneManageBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem inputManageBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem outputManageBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem musicManageBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem emergencyManageBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem ampFailoverBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem bbsHistoryBarItems;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem bbsHistoryBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem deviceHistoryBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem fireCallHistoryBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem outCallHistoryBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem systemVerifyHistoryBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem systemConfBarItems;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem accountManageBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem emailManageBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem smsRegistrationBarItem;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem restAPIRegistrationBarItem;
        public Wisej.Web.Ext.NavigationBar.NavigationBarItem deviceManageBarItem;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.EventvmTableAdapter eventvmTableAdapter;
    }
}
