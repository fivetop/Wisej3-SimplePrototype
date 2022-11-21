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

        private View_DashBoard view_PADashboard;

        private View_BBSAnchor view_BBSAnchor;
        private View_BBSReservation view_BBSReservation;
        private View_BBSPresetManage view_BBSPresetManage;
        private View_BBSGroupManage view_BBSGroupManage;
        private View_BBSIoTApplication view_IotApplication;
        private View_BBSMusicManage view_MusicManage;

        private View_BBSHolidayManage view_BBSHolidayManage;

        private View_BBCDevice view_DeviceConfiguration;
        private View_BBCSite view_BBCSite;
        private View_BBCZone view_BBCZone;
        private View_BBCInput view_BBCInput;
        private View_BBCOutput view_BBCOut;
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

            openContentsView("대쉬보드");
        }


        internal void eRcvSigR(SignalRMsg message)
        {
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
            //view_PADashboard.Refresh ();
        }

        internal void eEMLogoutEvent()
        {
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

            string outMessages = $"Selected Text : {barItems.Text}\n" + " " + $"Name : {barItems.Name} \n" + "  " + $"Nameof {nameof(barItems.Parent)}";

            Console.WriteLine(outMessages);

            openContentsView(barItems.Text);

        }

        public void openContentsView(string barText)
        {
            switch (barText)
            {
                case "대쉬보드":
                    bringFrontView("View_DashBoard", false);
                    break;
                case "앵커방송":
                    bringFrontView("View_BBSAnchor", false);
                    break;
                case "예약방송":
                    bringFrontView("View_BBSReservation", false); 
                    break;
                case "프리셋편집":
                    bringFrontView("View_BBSPresetManage", false);
                    break;
                case "그룹편집":
                    bringFrontView("View_BBSGroupManage", false);
                    break;
                case "IoT Application 방송":
                    bringFrontView("View_BBSIoTApplication", false);
                    break;
                case "음원 설정":
                    bringFrontView("View_BBSMusicManage", false);
                    break;
                case "휴일 관리":
                    bringFrontView("View_BBSHolidayManage", false);
                    break;
                case "장비 관리": 
                    bringFrontView("View_BBCDevice", false);
                    break;
                case "사이트 관리": 
                    bringFrontView("View_BBCSite", false);
                    break;
                case "ZONE 관리":
                    bringFrontView("View_BBCZone", false);
                    break;
                case "입력 관리":
                    bringFrontView("View_BBCInput", false);
                    break;
                case "출력 관리":
                    bringFrontView("View_BBCOutput", false);
                    break;
                case "음량 관리":
                    bringFrontView("View_BBCMusic", false);
                    break;
                case "비상 방송": 
                    bringFrontView("View_BBCEmergency", false);
                    break;
                case "앰프 Failover": 
                    bringFrontView("View_BBCAmpFailover", false);
                    break;
                case "방송 이력":
                    bringFrontView("View_HistoryBBS", false);
                    break;
                case "장비 이력":
                    bringFrontView("View_HistoryDevice", false);
                    break;
                case "화재수신 이력":
                    bringFrontView("View_HistoryFireSignal", false);
                    break;
                case "외부수신 이력":
                    bringFrontView("View_HistoryOutMsgs", false);
                    break;
                case "시스템변경 이력":
                    bringFrontView("View_HistorySystemChanges", false);
                    break;
                case "계정 등록 관리":
                    bringFrontView("View_SystemAccount", false);
                    break;
                case "시스템 이메일 등록":
                    bringFrontView("View_SystemEmail", false);
                    break;
                case "SMS 등록":
                    bringFrontView("View_SystemSMSRegistration", false);
                    break;
                case "REST API":
                    bringFrontView("View_SystemRestAPI", false);
                    break;

            }

        }

        private void bringFrontView(string viewName, Boolean bShinkNavBar)
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
            LabelON(9, true);
            AlertBox.Show(msg1.message);

            this.eventvmTableAdapter.Fill(this.dataSet1.Eventvm);
            //evdataGridView1.Refresh();

            switch (msg1.Msgtype)
            {
                case eSignalRMsgType.eEM:
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
            playItems = msg1.play8sig;
            if (playItems != null)
                PlayItemDisplay();
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
