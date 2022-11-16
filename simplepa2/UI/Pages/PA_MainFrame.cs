using simplepa2.UI.Views;
using System;
using Wisej.Web;
using Wisej.Web.Ext.NavigationBar;

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

        public PA_MainFrame()
        {
            InitializeComponent();

            if (view_topPanelBar == null)
            {
                view_topPanelBar = new View_TopPanelBar
                {
                    Parent = this.topPanels
                };
                view_topPanelBar.BringToFront();
            }

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

        private void openContentsView(string barText)
        {
            switch (barText)
            {
                case "대쉬보드":
                    bringFrontView("View_DashBoard", true);
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

        private void PA_MainFrame_Load(object sender, EventArgs e)
        {
            openContentsView("대쉬보드");
        }
    }
}
