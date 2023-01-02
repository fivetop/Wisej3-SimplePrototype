using DataClass;
using Microsoft.AspNet.SignalR;
using simplepa2.SignalR;
using simplepa2.UI.Views;
using simplepa2.win;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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

        public DBController dBSqlite { get; set; } = new DBController(); // DB 처리용 

        public string user_name { get; set; }
        public string login_id { get; set; }
        #endregion

        public PA_MainFrame()
        {
            InitializeComponent();

            gweb.mainFrame = this;
            gweb.mgf.Add(this);

            // 초기화 탑
            if (view_topPanelBar == null)
            {
                view_topPanelBar = new View_TopPanelBar
                {
                    Parent = this.topPanels
                };
                view_topPanelBar.BringToFront();
            }
        }

        public void hub()
        {
            gweb._hub.eRcvSignlR += _hub_eRcvSignlR;
        }

        private void _hub_eRcvSignlR(object sender, SignalRMsg e)
        {
            RcvSigR(e);
        }

        #region // 초기화 처리 
        private void PA_MainFrame_Load(object sender, EventArgs e)
        {
            dBSqlite.DBInit();
            //signalRClient.owner = this;
            //signalRClient.ConnectToSignalR();

            // 초기화 사용자 
            string t1 = Application.Session["login_id"];
            if (t1 == null)
            {
                Application.Session["isloggedon"] = "true";
                Application.Session["login_id"] = "hong";
                Application.Session["user_name"] = "홍길동";
            }
            gweb.Log("Start Simple PA 2.0");

            login_id = Application.Session["login_id"];
            user_name = Application.Session["user_name"];
            dBSqlite.UsertreeGet(login_id);
            view_topPanelBar.User(user_name);
            AlertBox.Show("Log-In : " + user_name +"("+ login_id +")");
            openContentsView("dashboardBarItems");
        }
        #endregion

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

        View_BBCAsset2 view_BBCAsset2  = new View_BBCAsset2();
        View_BBCDevice2 view_BBCDevice2  = new View_BBCDevice2();
        View_DashBoard2 view_DashBoard2  = new View_DashBoard2();
        View_BBSAnchor2 view_BBSAnchor2  = new View_BBSAnchor2();
        View_BBSGroupManage2 view_BBSGroupManage2  = new View_BBSGroupManage2();
        View_BBSHolidayManage2 view_BBSHolidayManage2  = new View_BBSHolidayManage2();
        View_BBSMusicManage2 view_BBSMusicManage2  = new View_BBSMusicManage2();
        View_BBCEmergency2 view_BBCEMManager2  = new View_BBCEmergency2();
        View_GroupManager2 view_GroupManager2  = new View_GroupManager2();
        View_BBCInput2 view_BBCInput2  = new View_BBCInput2();
        View_BBCMusic2 view_BBCMusic2 = new View_BBCMusic2();
        View_BBCOutput2 view_BBCOutput2  = new View_BBCOutput2();
        View_SystemAccount2 view_SystemAccount2  = new View_SystemAccount2();
        View_BBSEMManage2 view_BBSEMManage2 = new View_BBSEMManage2();
        View_BBSEMChannel2 view_BBSEMChannel2 = new View_BBSEMChannel2();

        public void openContentsView(string menuAccessibleName)
        {
            switch (menuAccessibleName)
            {
                // 운영
                case "dashboardBarItems": view_DashBoard2 = bringFrontView<View_DashBoard2>("View_DashBoard2", false); break;
                case "anchorBBSBarItem": view_BBSAnchor2 = bringFrontView<View_BBSAnchor2>("View_BBSAnchor2", false); break;
                case "reservationBarItem": view_BBSReservation = bringFrontView<View_BBSReservation>("View_BBSReservation", false); break;
                case "presetBarItem": view_BBSPresetManage = bringFrontView<View_BBSPresetManage>("View_BBSPresetManage", false); break;
                case "groupBarItem": view_BBSGroupManage = bringFrontView<View_BBSGroupManage>("View_BBSGroupManage", false); break;
                case "iotApplicationBarItem": view_BBSIotApplication = bringFrontView<View_BBSIoTApplication>("View_BBSIoTApplication", false); break;
                case "musicConfigurationBarItem": view_BBSMusicManage = bringFrontView<View_BBSMusicManage>("View_BBSMusicManage", false); break;
                case "holidayBarItem": view_BBSHolidayManage = bringFrontView<View_BBSHolidayManage>("View_BBSHolidayManage", false); break;
                // 설정 // navigationBarItem1 추가
                case "assetBarItem": view_BBCAsset2 = bringFrontView<View_BBCAsset2>("View_BBCAsset2", false); break;
                case "deviceManageBarItem": view_BBCDevice2 = bringFrontView<View_BBCDevice2>("View_BBCDevice2", false); break;
                case "navigationBarItem1": view_GroupManager2 = bringFrontView<View_GroupManager2>("View_GroupManager2", false); break;
                case "navigationBarItem2": view_BBSEMManage2 = bringFrontView<View_BBSEMManage2>("View_BBSEMManage2", false); break;
                case "navigationBarItem3": view_BBSEMChannel2 = bringFrontView<View_BBSEMChannel2>("View_BBSEMChannel2", false); break;
                case "siteManageBarItem": view_BBCSite = bringFrontView<View_BBCSite>("View_BBCSite", false); break;
                case "zoneManageBarItem": view_BBCZone = bringFrontView<View_BBCZone>("View_BBCZone", false); break;
                case "inputManageBarItem": view_BBCInput2 = bringFrontView<View_BBCInput2>("View_BBCInput2", false); break;
                case "outputManageBarItem": view_BBCOutput2 = bringFrontView<View_BBCOutput2>("View_BBCOutput2", false); break;
                case "musicManageBarItem": view_BBCMusic2 = bringFrontView<View_BBCMusic2>("View_BBCMusic2", false); break;
                case "emergencyManageBarItem": view_BBCEmergency = bringFrontView<View_BBCEmergency>("View_BBCEmergency", false); break;
                case "ampFailoverBarItem": view_BBCAmpFailover = bringFrontView<View_BBCAmpFailover>("View_BBCAmpFailover", false); break;
                // 기록               
                case "bbsHistoryBarItem": view_HistoryBBS = bringFrontView<View_HistoryBBS>("View_HistoryBBS", false); break;
                case "deviceHistoryBarItem": view_HistoryDevice = bringFrontView<View_HistoryDevice>("View_HistoryDevice", false); break;
                case "fireCallHistoryBarItem": view_HistoryFireSignal = bringFrontView<View_HistoryFireSignal>("View_HistoryFireSignal", false); break;
                case "outCallHistoryBarItem": view_HistoryOutMsgs = bringFrontView<View_HistoryOutMsgs>("View_HistoryOutMsgs", false); break;
                case "systemVerifyHistoryBarItem": view_HistorySystemChanges = bringFrontView<View_HistorySystemChanges>("View_HistorySystemChanges", false); break;
                //시스템    
                case "accountManageBarItem": view_SystemAccount = bringFrontView<View_SystemAccount>("View_SystemAccount", false); break;
                case "emailManageBarItem": view_SystemEmail = bringFrontView<View_SystemEmail>("View_SystemEmail", false); break;
                case "smsRegistrationBarItem": view_SystemSMSRegistration = bringFrontView<View_SystemSMSRegistration>("View_SystemSMSRegistration", false); break;
                case "restAPIRegistrationBarItem": view_SystemRestAPI = bringFrontView<View_SystemRestAPI>("View_SystemRestAPI", false); break;

            }

        }

        private T bringFrontView<T>(string viewName, Boolean bShinkNavBar)
        {
            
            var view = Application.FindComponent(o => o is Wisej.Web.Control && ((Wisej.Web.Control)o).Name == viewName);

            if (view == null)
            {
                Type type = Type.GetType("simplepa2.UI.Views."+viewName, true);
                view = (Wisej.Web.Control)Activator.CreateInstance(type);
                ((Wisej.Web.Control)view).Parent = this.contentsPanel;
                
            }
            ((Wisej.Web.Control)view).BringToFront();
            this.mainMenuBar.CompactView = bShinkNavBar;

            return (T)view;

        }
        #endregion

        #region // Logout, 


        public void Logout()
        {
            Application.Session["isloggedon"] = "false";
            Application.Session["login_id"] = "";
            Application.Session["user_name"] = "";

            Application.LoadTheme("LSMaterial-3"); //"Material-3" .
            Application.MainPage = new PA_Login();
            Application.MainPage.Show();
            this.Dispose(true);
        }

        #endregion

        #region // signal r 처리 

        internal void eRcvSigR(SignalRMsg message)
        {
            RcvSigR(message);
        }

        // 프리셋 메시지 올 경우 화면 출력용 
        // 8채널과 링크 출력용 
        public void LabelON(int id, bool v)
        {
            if (id == 9 && v == false)
            {
                //AlertBox.Show("SignalR Client Disconnected.");
                AlertBox.Show("<b>SignalR Client</b> Disconnected.", icon: MessageBoxIcon.Warning, alignment: ContentAlignment.MiddleCenter);

            }
        }


        internal void RcvSigR(SignalRMsg msg1)
        {
            string addinfo = msg1.EMNAME;
            bool disp = true;
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
                    view_DashBoard2.reDraw();
                    break;
                case eSignalRMsgType.eEM_FIRE:
                    dBSqlite.Eventvm("EM_FIRE", msg1.message, msg1.seqno.ToString());
                    break;
                case eSignalRMsgType.eEM_PRESET_SW:
                    string m0 = "PRESET_SW";
                    string m1 = msg1.EMNAME +":"+ msg1.seqno.ToString() + "번 프리셋 버튼";
                    string m2 = "OFF";

                    if (msg1.state == 1) m2 = "ON";
                    if (msg1.seqno == 0)
                        m1 = msg1.EMNAME + ":" + "All 프리셋 버튼";

                    switch (msg1.seqno)
                    {
                        case 0:
                            dBSqlite.Eventvm(m0, m1, m2);
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            dBSqlite.Eventvm(m0, m1, m2);
                            break;
                    }
                    dBSqlite.EMServerupdatePreset(msg1.EMNAME,msg1.seqno, msg1.state);
                    view_DashBoard2.reDraw2();
                    view_BBSEMManage2.reDraw();
                    break;
                case eSignalRMsgType.ePlay:
                    view_BBSEMChannel2.reDraw();
                    break;
                case eSignalRMsgType.ePlayCheck :
                    break;
                case eSignalRMsgType.ePlayEnd:
                    view_BBSEMChannel2.reDraw();
                    view_BBSAnchor2.refresh();
                    break;
                case eSignalRMsgType.ePlaying:
                    view_BBSEMChannel2.reDraw();
                    break;
                case eSignalRMsgType.eStop:
                    view_BBSEMChannel2.reDraw();
                    break;
                case eSignalRMsgType.eLoginUser:
                    break;
                case eSignalRMsgType.eLogoutUser:
                    break;
                case eSignalRMsgType.eFindDSP:
                    if (msg1.state == 1)
                    {
                        dBSqlite.LinkAssetDevice();
                        view_BBCDevice2.reDraw();
                    }
                    else
                        AlertBox.Show("DSP 혹은 버철사운드를 확인 바랍니다..", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
                    break;
            }
            //view_Dashboard.Refresh();
            //this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);

            if (disp)
            {
                Wisej.Web.Application.Update(this, () =>
                {
                    AlertBox.Show(msg1.message + ":" + addinfo);
                    gweb.Log(msg1.message + ":" + addinfo);
                    System.Diagnostics.Debug.WriteLine(msg1.message);
                });
            }
        }


        internal async Task<bool> sendSigR(eSignalRMsgType v1, int BSTreeId, List<AssetsRow> selAsset, List<MusicsRow> selMusic)
        {
            if (gweb._hub == null)
            {
                AlertBox.Show("가용한 EM Server가 없습니다.");
                return false;
            }

            var bSTreeRow = gweb.mainFrame.dBSqlite.BSTreeGet(BSTreeId);
            SignalRMsg msg1 = new SignalRMsg();
            msg1.user = Application.Session["login_id"];
            msg1.EMNAME = bSTreeRow.EMNAME;
            msg1.seqno = bSTreeRow.BSTreeId;
            msg1.chno = bSTreeRow.chno;
            msg1.Msgtype = v1;

            switch (v1)
            {
                case eSignalRMsgType.ePlay:
                    var t1 = selMusic.Select(p => new { p.MusicId });
                    msg1.musicsRows = t1.Select(p => p.MusicId).ToList();
                    var t2 = selAsset.Select(p => new { p.AssetId });
                    msg1.assetsRows = t2.Select(p => p.AssetId).ToList();
                    msg1.message = "Play";
                    break;
                case eSignalRMsgType.eStop:
                    msg1.message = "Stop";
                    break;
            }

            try
            {
                if (gweb._hub != null)
                    gweb._hub.MessageS2C2(msg1);
            }
            catch (Exception e1)
            {
            }
            return true;
        }

        internal void sendSigR(eSignalRMsgType eVolume, string device_name = "", string dsp = "", int dsp_ch = 0, int device_ch = 0)
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.user = Application.Session["login_id"];
            msg1.EMNAME = "ALL";

            switch (eVolume)
            {
                case eSignalRMsgType.eVolume:
                    msg1.message = "Volume";
                    msg1.Msgtype = eVolume;
                    break;

                case eSignalRMsgType.eOutChMove:
                    msg1.message = device_name;
                    msg1.Msgtype = eVolume;
                    msg1.state = dsp_ch;
                    msg1.user_data1 = dsp;
                    msg1.user_data4 = device_ch;
                    break;

                case eSignalRMsgType.eInChMove:
                    msg1.EMNAME = "ALL";
                    msg1.message = device_name; // pc
                    msg1.Msgtype = eVolume;
                    msg1.state = dsp_ch; // no
                    msg1.user_data1 = dsp; // ip
                    msg1.user_data4 = device_ch; // dsp ch cnt
                    break;

                case eSignalRMsgType.eScanAll:
                    msg1.Msgtype = eVolume;
                    msg1.message = "Scan All";
                    break;
            }

            try
            {
                if (gweb._hub != null)
                    gweb._hub.MessageS2C2(msg1);
            }
            catch (Exception e1)
            {
            }
        }

        public bool isSignalR()
        {
            if (gweb._hub == null)
                return false;
            return true;
        }

        #endregion


    }
}
