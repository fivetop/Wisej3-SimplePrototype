using DataClass;
using simplepa2.SignalR;
using simplepa2.UI.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using Wisej.Web.Ext.NavigationBar;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Pages
{
    public partial class PA_MainFrame : Wisej.Web.Page
    {
        #region // 화면 변수 선언 
        private View_TopPanelBar view_topPanelBar;

        private View_DashBoard view_Dashboard;

        private View_BBSAnchor view_BBSAnchor;
        private View_BBSReservation view_BBSReservation;
        private View_BBSPresetManage view_BBSPresetManage;
        private View_BBSGroupManage view_BBSGroupManage;
        private View_BBSIoTApplication view_BBSIotApplication;
        private View_BBSMusicManage view_BBSMusicManage;

        private View_BBSHolidayManage view_BBSHolidayManage;

        private View_BBCDevice view_BBCDevice;
        private View_BBCSite view_BBCSite;
        private View_BBCZone view_BBCZone;
        private View_BBCInput view_BBCInput;
        private View_BBCOutput view_BBCOutput;
        private View_BBCMusic view_BBCMusic;
        private View_BBCEmergency view_BBCEmergency;

        private View_BBCAmpFailover view_BBCAmpFailover;

        private View_HistoryBBS view_HistoryBBS;


        private View_HistoryDevice view_HistoryDevice;
        private View_HistoryFireSignal view_HistoryFireSignal;
        private View_HistoryOutMsgs view_HistoryOutMsgs;
        private View_HistorySystemChanges view_HistorySystemChanges;

        private View_SystemAccount view_SystemAccount;
        private View_SystemEmail view_SystemEmail;
        private View_SystemSMSRegistration view_SystemSMSRegistration;
        private View_SystemRestAPI view_SystemRestAPI;
        #endregion

        //public static SignalRClient signalRClient { get; set; } = new SignalRClient();
        public List<PlayItem> playItems { get; set; } = new List<PlayItem>(new PlayItem[9]);
        public DBController dBSqlite { get; set; } = new DBController();

        public PA_MainFrame()
        {
            InitializeComponent();

            gweb.mainFrame = this;

            // 초기화 탑
            if (view_topPanelBar == null)
            {
                view_topPanelBar = new View_TopPanelBar
                {
                    Parent = this.topPanels
                };
                view_topPanelBar.BringToFront();
            }

            // 초기화 플레이 
            for (int i = 1; i < 9; i++)
            {
                playItems[i] = new PlayItem();
                playItems[i].chno = i;
            }

            // 초기화 사용자 
            string t1 = Application.Session["user"];
            if (t1 == null)
            {
                Application.Session["isloggedon"] = "true";
                Application.Session["user"] = "Admin";
                Application.Session["user_name"] = "관리자";
            }
            gweb.Log("Start Simple PA 2.0");
        }

        private void PA_MainFrame_Load(object sender, EventArgs e)
        {
            dBSqlite.DBInit();
            //signalRClient.owner = this;
            //signalRClient.ConnectToSignalR();

            var t1 = Application.Session["user"];
            var t2 = Application.Session["user_name"];

            AlertBox.Show("Log-In : " + t2 + t1);

            openContentsView("dashboardBarItems");
        }


        internal void eRcvSigR(SignalRMsg message)
        {
            RcvSigR(message);
        }

        internal void eEMLoginEvent(Microsoft.AspNet.SignalR.Hubs.HubCallerContext context, int v)
        {
            string user_id;
            user_id = context.Headers["user_id"];
            string str1 = context.ConnectionId.ToString();

            string l1 = "EM connect";
            if (v == 1)
            {
                dBSqlite.Eventvm(l1, user_id, str1);
            }
            else 
            {
                l1 = "EM disconnect";
                dBSqlite.Eventvm(l1, user_id, str1);
            }
            this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
            view_Dashboard.Refresh ();
        }


        #region // 메뉴 처리 
        private void mainMenuBar_SelectedItemChanged(object sender, EventArgs e)
        {
            /*
            var barItems = (sender as NavigationBar).SelectedItem;
               
            
            string outMessages = $"Selected Text : {barItems.Text}\n" + " " + $"Name : {barItems.Name} \n"  + "  " + $"Nameof {nameof(barItems.Parent) }";
            AlertBox.Show(outMessages);
            Console.WriteLine(outMessages);
            */
        }

        private void mainMenuBar_ItemClick(object sender, NavigationBarItemClickEventArgs e)
        {
            var barItems = (e.Item as NavigationBarItem);

            // 01. 다른 Expand Fold 처리 
            shink_NavigationBarItems(barItems);

            string outMessages = $"Selected Text : {barItems.Text}\n" + " " + $"Name : {barItems.Name} \n" + "  " + $"Nameof {nameof(barItems.Parent)}";

            Console.WriteLine(outMessages);

            openContentsView(barItems.AccessibleName);

        }

        private void shink_NavigationBarItems(NavigationBarItem selectedNavBarItem)
        {
            if(selectedNavBarItem.Parent != null)  // 차일드 인 경우 
            {
                switch (selectedNavBarItem.Parent.AccessibleName)
                {
                    case "bbsManagementBarItem":
                        foldOtherNavBarItemsForNavBar(this.bbsManagementBarItem);
                        break;
                    case "bbsConfigurationBarItems":
                        foldOtherNavBarItemsForNavBar(this.bbsConfigurationBarItems);
                        break;
                    case "bbsHistoryBarItems":
                        foldOtherNavBarItemsForNavBar(this.bbsHistoryBarItems);
                        break;
                    case "systemConfBarItems":
                        foldOtherNavBarItemsForNavBar(this.systemConfBarItems);
                        break;
                }
            } 
            else   // 상위 메뉴 인 경우 
            {
                foldOtherNavBarItemsForNavBar(selectedNavBarItem);
            }
        }

        private void foldOtherNavBarItemsForNavBar(NavigationBarItem items)
        {
            this.bbsManagementBarItem.Expanded = false;
            this.bbsConfigurationBarItems.Expanded = false;
            this.bbsHistoryBarItems.Expanded = false;
            this.systemConfBarItems.Expanded = false;

            switch (items.AccessibleName)
            {
                case "bbsManagementBarItem":
                    this.bbsManagementBarItem.Expanded = true;
                    break;
                case "bbsConfigurationBarItems":
                    this.bbsConfigurationBarItems.Expanded = true;
                    break;
                case "bbsHistoryBarItems":
                    this.bbsHistoryBarItems.Expanded = true;
                    break;
                case "systemConfBarItems":
                    this.systemConfBarItems.Expanded = true;
                    break;
            }
        }

        public void openContentsView(string menuAccessibleName)
        {
            switch (menuAccessibleName)
            {
                case "dashboardBarItems":
                    view_Dashboard = (View_DashBoard) bringFrontView("View_DashBoard", false);                    
                    break;
                case "anchorBBSBarItem":
                    view_BBSAnchor = (View_BBSAnchor)bringFrontView("View_BBSAnchor", false);
                    break;
                case "reservationBarItem":
                    view_BBSReservation = (View_BBSReservation)bringFrontView("View_BBSReservation", false); 
                    break;
                case "presetBarItem":
                    view_BBSPresetManage = (View_BBSPresetManage)bringFrontView("View_BBSPresetManage", false);
                    break;
                case "groupBarItem":
                    view_BBSGroupManage = (View_BBSGroupManage)bringFrontView("View_BBSGroupManage", false);
                    break;
                case "iotApplicationBarItem":
                    view_BBSIotApplication = (View_BBSIoTApplication)bringFrontView("View_BBSIoTApplication", false);
                    break;
                case "musicConfigurationBarItem":
                    view_BBSMusicManage = (View_BBSMusicManage)bringFrontView("View_BBSMusicManage", false);
                    break;
                case "holidayBarItem":
                    view_BBSHolidayManage = (View_BBSHolidayManage)bringFrontView("View_BBSHolidayManage", false);
                    break;
                case "deviceManageBarItem":
                    view_BBCDevice = (View_BBCDevice)bringFrontView("View_BBCDevice", false);
                    break;
                case "siteManageBarItem":
                    view_BBCSite = (View_BBCSite)bringFrontView("View_BBCSite", false);
                    break;
                case "zoneManageBarItem":
                    view_BBCZone = (View_BBCZone)bringFrontView("View_BBCZone", false);
                    break;
                case "inputManageBarItem":
                    view_BBCInput = (View_BBCInput)bringFrontView("View_BBCInput", false);
                    break;
                case "outputManageBarItem":
                    view_BBCOutput = (View_BBCOutput)bringFrontView("View_BBCOutput", false);
                    break;
                case "musicManageBarItem":
                    view_BBCMusic = (View_BBCMusic)bringFrontView("View_BBCMusic", false);
                    break;
                case "emergencyManageBarItem":
                    view_BBCEmergency = (View_BBCEmergency)bringFrontView("View_BBCEmergency", false);
                    break;
                case "ampFailoverBarItem":
                    view_BBCAmpFailover = (View_BBCAmpFailover)bringFrontView("View_BBCAmpFailover", false);
                    break;
                case "bbsHistoryBarItem":
                    view_HistoryBBS = (View_HistoryBBS)bringFrontView("View_HistoryBBS", false);
                    break;
                case "deviceHistoryBarItem":
                    view_HistoryDevice = (View_HistoryDevice)bringFrontView("View_HistoryDevice", false);
                    break;
                case "fireCallHistoryBarItem":
                    view_HistoryFireSignal = (View_HistoryFireSignal)bringFrontView("View_HistoryFireSignal", false);
                    break;
                case "outCallHistoryBarItem":
                    view_HistoryOutMsgs = (View_HistoryOutMsgs)bringFrontView("View_HistoryOutMsgs", false);
                    break;
                case "systemVerifyHistoryBarItem":
                    view_HistorySystemChanges = (View_HistorySystemChanges)bringFrontView("View_HistorySystemChanges", false);
                    break;
                case "accountManageBarItem":
                    view_SystemAccount = (View_SystemAccount)bringFrontView("View_SystemAccount", false);
                    break;
                case "emailManageBarItem":
                    view_SystemEmail = (View_SystemEmail)bringFrontView("View_SystemEmail", false);
                    break;
                case "smsRegistrationBarItem":
                    view_SystemSMSRegistration = (View_SystemSMSRegistration)bringFrontView("View_SystemSMSRegistration", false);
                    break;
                case "restAPIRegistrationBarItem":
                    view_SystemRestAPI = (View_SystemRestAPI)bringFrontView("View_SystemRestAPI", false);
                    break;

            }

        }

        private Wisej.Web.Control bringFrontView(string viewName, Boolean bShinkNavBar)
        {
            
            Wisej.Web.Control view = (Wisej.Web.Control)Application.FindComponent(o => o is Wisej.Web.Control && ((Wisej.Web.Control)o).Name == viewName);

            if (view == null)
            {
                Type type = Type.GetType("simplepa2.UI.Views."+viewName, true);
                view = (Wisej.Web.Control)Activator.CreateInstance(type);
                view.Parent = this.contentsPanel;
                
            }
            view.BringToFront();
            this.mainMenuBar.CompactView = bShinkNavBar;
            
            return view;

        }
        #endregion

        #region // Logout, 


        public void Logout()
        {
            Application.Session["isloggedon"] = "false";
            Application.Session["user"] = "";
            Application.Session["user_name"] = "";

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Dispose(true);
        }

        #endregion

        internal void RcvSigR(SignalRMsg msg1)
        {
            string addinfo = "";
            LabelON(9, true);

            switch (msg1.Msgtype)
            {
                case eSignalRMsgType.eEM:
                    if (msg1.state == 1)
                        addinfo = "ONLINE";
                    else
                        addinfo = "OFFLINE";
                    dBSqlite.Eventvm(addinfo, msg1.EMNAME, addinfo);
                    dBSqlite.EMServerupdate(msg1.EMNAME, addinfo);
                    break;
                case eSignalRMsgType.eEM_FIRE:
                    if (msg1.seqno == 1)
                        LabelON(1, true);
                    else
                        LabelON(1, false);
                    break;
                case eSignalRMsgType.eEM_PRESET_SW:
                    presetdisp(msg1);
                    break;
                case eSignalRMsgType.ePlay:
                    break;
                case eSignalRMsgType.ePlayEnd:
                    //this.btnStart.Enabled = true;
                    //this.btnStop.Enabled = false;
                    break;
                case eSignalRMsgType.ePlaying:
                    break;
                case eSignalRMsgType.eStop:
                    break;
                case eSignalRMsgType.eLoginUser:
                    break;
                case eSignalRMsgType.eLogoutUser:
                    break;
                case eSignalRMsgType.eFindDSP:
                    if (msg1.state == 1)
                        ;//bSDeviceManager.reDraw();
                    else
                        AlertBox.Show("DSP 혹은 버철사운드를 확인 바랍니다..", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
                    break;
            }
            view_Dashboard.Refresh();


            //playItems = msg1.play8sig;
            if (playItems != null)
                PlayItemDisplay();

            this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
            // 각 뷰 리플레시 필요 

            Application.Update(this, () =>
            {
                AlertBox.Show(msg1.message + ":" + addinfo);
                gweb.Log(msg1.message + ":" + addinfo);
            });
        }

        // 8채널 출력용 
        private void PlayItemDisplay()
        {
        }

        // 프리셋 메시지 올 경우 화면 출력용 
        private void presetdisp(SignalRMsg msg1)
        {
        }

        // 8채널과 링크 출력용 
        public void LabelON(int id, bool v)
        {
            if (id == 9 && v == false)
            {
                //AlertBox.Show("SignalR Client Disconnected.");
                AlertBox.Show("<b>SignalR Client</b> Disconnected.", icon: MessageBoxIcon.Warning, alignment: ContentAlignment.MiddleCenter);

            }
        }


        internal void sendSigR(string v)
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = v;
            //if (signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
            //    signalRClient.proxy.Invoke("MessageC2S2", msg1);
        }

        internal Guid sendSigR(eSignalRMsgType v1, List<AssetsRow> selAsset, List<MusicsRow> selMusic, Guid guid)
        {

            if (gweb._hub == null)
            {
                AlertBox.Show("가용한 EM Server가 없습니다.");
                return Guid.Empty;
            }


            SignalRMsg msg1 = new SignalRMsg();
            msg1.user = Application.Session["user"];

            switch (v1)
            {
                case eSignalRMsgType.ePlay:
                    msg1.Guid = Guid.NewGuid();
                    msg1.message = "Play";
                    msg1.Msgtype = v1;
                    //msg1.assetsRows = selAsset;
                    //var t1 = selMusic.Select(p => new { p.MusicId }).ToList();
                    var t1 = selMusic.Select(p => new { p.MusicId });
                    msg1.musicsRows = t1.Select(p => p.MusicId).ToList();

                    var t2 = selAsset.Select(p => new { p.AssetId });
                    msg1.assetsRows = t2.Select(p => p.AssetId).ToList();
                    break;
                case eSignalRMsgType.eStop:
                    msg1.Guid = guid;
                    msg1.message = "Stop";
                    msg1.Msgtype = v1;
                    break;
            }

            try
            {
                if (gweb._hub != null)
                    gweb._hub.MessageS2C2(msg1);
                else
                {
                    AlertBox.Show("해당 EM Server가 없습니다.");
                    return Guid.Empty;
                }
                //if (signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                //    signalRClient.proxy.Invoke("MessageC2S2", msg1);
            }
            catch (Exception e1)
            {
            }
            return msg1.Guid;
        }


        internal void sendSigR(eSignalRMsgType eVolume, string device_name = "", string dsp = "", int dsp_ch = 0, int device_ch = 0)
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.user = Application.Session["user"];

            switch (eVolume)
            {
                case eSignalRMsgType.eVolume:
                    msg1.Guid = Guid.NewGuid();
                    msg1.message = "Volume";
                    msg1.Msgtype = eVolume;
                    break;

                case eSignalRMsgType.eOutChMove:
                    msg1.Guid = Guid.NewGuid();
                    msg1.message = device_name;
                    msg1.Msgtype = eVolume;
                    msg1.state = dsp_ch;
                    msg1.user_data1 = dsp;
                    msg1.user_data4 = device_ch;
                    break;

                case eSignalRMsgType.eInChMove:
                    msg1.Guid = Guid.NewGuid();
                    msg1.message = device_name; // pc
                    msg1.Msgtype = eVolume;
                    msg1.state = dsp_ch; // no
                    msg1.user_data1 = dsp; // ip
                    msg1.user_data4 = device_ch; // dsp ch cnt
                    break;

                case eSignalRMsgType.eScanAll:
                    msg1.Guid = Guid.NewGuid();
                    msg1.Msgtype = eVolume;
                    msg1.message = "Scan All";
                    break;
            }

            try
            {
                //if (isSignalR())
                //    signalRClient.proxy.Invoke("MessageC2S2", msg1);
            }
            catch (Exception e1)
            {
            }
        }

        public bool isSignalR()
        {
            //if (signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
            //    return true;
            //else
                return false;

        }


    }
}
