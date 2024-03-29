﻿using DataClass;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json.Linq;
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

        private View_DashBoard view_DashBoard;

        private View_BBSAnchor view_BBSAnchor = new View_BBSAnchor();
        private View_BBSReservation view_BBSReservation;
        private View_BBSPresetManage view_BBSPresetManage;
        
        private View_BBSIoTApplication view_BBSIotApplication;
        private View_BBSMusicManage view_BBSMusicManage = new View_BBSMusicManage();
        private View_BBSHolidayManage view_BBSHolidayManage;

        private View_BBCSite view_BBCSite;
        
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
        private View_SystemTest view_SystemTest;

        private View_BBCZone view_BBCZone = new View_BBCZone();
        private View_BBCDevice view_BBCDevice = new View_BBCDevice();
        private View_DashBoard2 view_DashBoard2 = new View_DashBoard2();
        private View_BBSGroupManage view_BBSGroupManage = new View_BBSGroupManage();
        private View_BBSGroupManage2 view_BBSGroupManage2 = new View_BBSGroupManage2();
        private View_BBSHolidayManage2 view_BBSHolidayManage2 = new View_BBSHolidayManage2();
        private View_BBSMusicManage2 view_BBSMusicManage2 = new View_BBSMusicManage2();
        private View_BBCEmergency2 view_BBCEMManager2 = new View_BBCEmergency2();
        private View_GroupManager2 view_GroupManager2 = new View_GroupManager2();
        private View_GroupPresetManager2 view_GroupPresetManager2 = new View_GroupPresetManager2();
        private View_BBCInput2 view_BBCInput2 = new View_BBCInput2();
        private View_BBCMusic2 view_BBCMusic2 = new View_BBCMusic2();
        private View_BBCOutput2 view_BBCOutput2 = new View_BBCOutput2();
        private View_SystemAccount2 view_SystemAccount2 = new View_SystemAccount2();
        private View_BBSEMManage2 view_BBSEMManage2 = new View_BBSEMManage2();
        private View_BBCEmergency2 view_BBCEmergency2 = new View_BBCEmergency2();
        private View_BBSAnchor2 view_BBSAnchor2 = new View_BBSAnchor2();
        private View_BBSPresetManage2 view_BBSPresetManage2 = new View_BBSPresetManage2();
        private View_BBSSchduleManage2 view_BBSSchduleManage2 = new View_BBSSchduleManage2();

        private List<View_BBSAnchor2> listBBSAnchor = new List<View_BBSAnchor2>();  // 다수 방 관리를 위한 View List

        public string user_name { get; set; }
        public string login_id { get; set; }
        #endregion

        public string guidstring { get; set; }

        public PA_MainFrame()
        {
            InitializeComponent();

            gweb.mainFrame = this;
            gweb.mgf.Add(this);
            guidstring = Guid.NewGuid().ToString();
            Application.Browser.LocalStorage.SetValue<string>("MainFrame", guidstring);

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
            gweb.dBSqlite.UsertreeGet(login_id);
            view_topPanelBar.User(user_name);
            AlertBox.Show("Log-In : " + user_name +"("+ login_id +")");
            gweb.dBSqlite.Eventsyslog("Log-In", user_name, login_id);
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

        internal void reDraw()
        {
            try
            {
                view_BBCDevice.reDraw();
                view_BBCEmergency2.reDraw();
                view_BBCInput2.reDraw();
                view_BBCOutput2.reDraw();
                view_BBCMusic2.reDraw();
                view_BBSEMManage2.reDraw();
                view_GroupManager2.reDraw();  // test version delete when release 
                view_BBSGroupManage.reDraw();
                view_BBSGroupManage2.reDraw();
                view_GroupPresetManager2.reDraw();
                view_BBCZone.reDraw();
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
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
                // 운영
                case "dashboardBarItems": view_DashBoard2 = bringFrontView<View_DashBoard2>("View_DashBoard2", true); break;
                //case "anchorBBSBarItem": view_BBSAnchor2 = bringFrontView<View_BBSAnchor2>("View_BBSAnchor2", false); break;
                case "anchorBBSBarItem": view_BBSAnchor = bringFrontView<View_BBSAnchor>("View_BBSAnchor", false); break;
                //case "reservationBarItem": view_BBSReservation = bringFrontView<View_BBSReservation>("View_BBSReservation", false); break;
                case "reservationBarItem": view_BBSSchduleManage2 = bringFrontView<View_BBSSchduleManage2>("View_BBSSchduleManage2", false); break;
                //case "presetBarItem": view_BBSPresetManage = bringFrontView<View_BBSPresetManage>("View_BBSPresetManage", false); break;
                case "presetBarItem": view_BBSPresetManage2 = bringFrontView<View_BBSPresetManage2>("View_BBSPresetManage2", false); break;
                //case "groupBarItem": view_BBSGroupManage = bringFrontView<View_BBSGroupManage>("View_BBSGroupManage", false); break;
                case "groupBarItem": view_BBSGroupManage2 = bringFrontView<View_BBSGroupManage2>("View_BBSGroupManage2", false); break;
                case "iotApplicationBarItem": view_BBSIotApplication = bringFrontView<View_BBSIoTApplication>("View_BBSIoTApplication", false); break;
                case "musicConfigurationBarItem": view_BBSMusicManage = bringFrontView<View_BBSMusicManage>("View_BBSMusicManage", false); break;
                case "holidayBarItem": view_BBSHolidayManage = bringFrontView<View_BBSHolidayManage>("View_BBSHolidayManage", false); break;
                // 설정 // navigationBarItem1 추가
                case "deviceManageBarItem": view_BBCDevice = bringFrontView<View_BBCDevice>("View_BBCDevice", false); break;
                case "navigationBarItem1": view_GroupManager2 = bringFrontView<View_GroupManager2>("View_GroupManager2", false); break;
                case "navigationBarItem4": view_GroupPresetManager2 = bringFrontView<View_GroupPresetManager2>("View_GroupPresetManager2", false); break;
                case "navigationBarItem2": view_BBSEMManage2 = bringFrontView<View_BBSEMManage2>("View_BBSEMManage2", false); break;
                case "siteManageBarItem": view_BBCSite = bringFrontView<View_BBCSite>("View_BBCSite", false); break;
                case "zoneManageBarItem": view_BBCZone = bringFrontView<View_BBCZone>("View_BBCZone", false); break;
                case "inputManageBarItem": view_BBCInput2 = bringFrontView<View_BBCInput2>("View_BBCInput2", false); break;
                case "outputManageBarItem": view_BBCOutput2 = bringFrontView<View_BBCOutput2>("View_BBCOutput2", false); break;
                case "musicManageBarItem": view_BBCMusic2 = bringFrontView<View_BBCMusic2>("View_BBCMusic2", false); break;
                case "emergencyManageBarItem": view_BBCEmergency2 = bringFrontView<View_BBCEmergency2>("View_BBCEmergency2", false); break;
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
                //case "restAPIRegistrationBarItem": view_SystemRestAPI = bringFrontView<View_SystemRestAPI>("View_SystemRestAPI", false); break;
                // 시험을 위하여 사용함 
                case "restAPIRegistrationBarItem": view_SystemTest = bringFrontView<View_SystemTest>("View_SystemTest", false); break;

            }
        }

        public event EventHandler FocusEvent;
        //public event EventHandler ReDraw;

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
            FocusEvent?.Invoke(view, null); 
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

        internal void RcvSigR(SignalRMsg msg1)
        {
            string addinfo = msg1.EMNAME;
            bool disp = true;

            switch (msg1.Msgtype)
            {
                case eSignalRMsgType.eEM:
                    view_DashBoard2.reDraw();
                    break;
                case eSignalRMsgType.eEM_FIRE:
                    view_DashBoard2.reDraw();
                    break;
                case eSignalRMsgType.eEM_PRESET_SW:
                    view_DashBoard2.reDraw2();
                    if(view_BBSEMManage2 != null) view_BBSEMManage2.reDraw();
                    break;
                case eSignalRMsgType.ePlay:
                    view_DashBoard2.reDraw2();
                    view_BBCEMManager2.reDraw();
                    break;
                case eSignalRMsgType.ePlayCheck :
                    view_DashBoard2.reDraw2();
                    disp = false;
                    break;
                case eSignalRMsgType.ePlayEnd:
                    disp = false;
                    view_DashBoard2.reDraw2();
                    if (msg1.state > 200000) // 예약방송 종료인 경우 => 방송종료 
                    { 
                        view_BBSAnchor2.UpdateSchedule(msg1.state, "방송종료");
                        view_BBSAnchor2.refresh2();
                    }
                    view_DashBoard2.reDraw3(msg1.EMNAME, msg1.seqno, "방송종료");
                    view_BBSAnchor2.refresh();
                    view_BBCEMManager2.reDraw();
                    break;
                case eSignalRMsgType.ePlaying:
                    disp = false;
                    if (msg1.state > 200000 && msg1.seqno > 1) // 예약방송 시작인 경우 => 방송시작 
                    {
                        gweb.dBSqlite.BSTreeUpdate(msg1.EMNAME, msg1.seqno, "방송시작");
                    }
                    view_DashBoard2.reDraw3(msg1.EMNAME, msg1.seqno, "방송시작");
                    view_DashBoard2.reDraw2();
                    view_BBCEMManager2.reDraw();
                    break;
                case eSignalRMsgType.eStop:
                    //view_BBCEMManager2.reDraw();
                    break;
                case eSignalRMsgType.eLoginUser:
                    break;
                case eSignalRMsgType.eLogoutUser:
                    disp = false;
                    break;
                case eSignalRMsgType.eScanEM:
                    view_BBSEMManage2.reDraw();
                    break;
                case eSignalRMsgType.eFindDSP:
                    if (msg1.state == 1)
                        reDraw();
                    else
                        AlertBox.Show("DSP 혹은 버철사운드를 확인 바랍니다..", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
                    break;
                case eSignalRMsgType.eReserved: // 예약방송 시작  => 방송중
                    view_BBSAnchor2.UpdateSchedule(msg1.state, "방송중");
                    view_BBSAnchor2.refresh2();
                    view_BBSAnchor2.refresh();
                    break;
            }

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

            var bSTreeRow = gweb.dBSqlite.BSTreeGet(BSTreeId);
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

        internal void sendSigR(eSignalRMsgType msgtype, string device_name = "", string dsp = "", int dsp_ch = 0, int device_ch = 0, string emname = "")
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.user = Application.Session["login_id"];
            msg1.EMNAME = "ALL";

            switch (msgtype)
            {
                case eSignalRMsgType.eVolume:
                    msg1.message = "Volume";
                    msg1.Msgtype = msgtype;
                    break;

                case eSignalRMsgType.eFileDown:
                    msg1.message = "eFileDown";
                    msg1.Msgtype = msgtype;
                    msg1.user_data1 = device_name;
                    break;

                case eSignalRMsgType.eOutChMove:
                    msg1.EMNAME = emname;
                    msg1.message = device_name;
                    msg1.Msgtype = msgtype;
                    msg1.state = dsp_ch;
                    msg1.user_data1 = dsp;
                    msg1.user_data4 = device_ch;
                    break;

                case eSignalRMsgType.eInChMove:
                    msg1.EMNAME = emname;
                    msg1.message = device_name; // pc
                    msg1.Msgtype = msgtype;
                    msg1.state = dsp_ch; // no
                    msg1.user_data1 = dsp; // ip
                    msg1.user_data4 = device_ch; // dsp ch cnt
                    break;

                case eSignalRMsgType.eScanAll:
                    msg1.Msgtype = msgtype;
                    msg1.message = "Scan All";
                    break;

                case eSignalRMsgType.eScanEM: // EM 정보 요청
                    msg1.Msgtype = msgtype;
                    msg1.message = "Scan EM";
                    break;

                case eSignalRMsgType.eScheduleDown: // EM 정보 요청
                    msg1.Msgtype = msgtype;
                    msg1.message = "eScheduleDown";
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

        private void mainMenuBar_TitleClick(object sender, EventArgs e)
        {
            this.mainMenuBar.CompactView = !this.mainMenuBar.CompactView;

        }

        // Close 처리 
        private void PA_MainFrame_Disposed(object sender, EventArgs e)
        {
            //Application.Browser.LocalStorage.RemoveValue("MainFrame");
            this.Dispose(true);

        }

        internal void Close()
        {
            MessageBox.Show("Server Disconnected..");
            this.Dispose(true);
        }
    }
}
