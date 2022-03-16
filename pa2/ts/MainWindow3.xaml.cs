using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Linq;
using I2MS2.Models;
using I2MS2.Windows;
using WebApi.Models;
using I2MS2.Library;
using System.Globalization;
using Microsoft.AspNet.SignalR.Client;
using MetroDemo;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;
using I2MS2.Chart;
using System.Windows.Threading;
using System.Collections.Generic;

namespace I2MS2
{

    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow3 : MetroWindow   
    {
        Boolean isReadyMainRun = false;
        private readonly MainWindowViewModel2 _viewModel;

        #region RouteCommand 버튼 관련 정의
        public static RoutedCommand SelectCommand = new RoutedCommand();
        public static RoutedCommand ViewFloorIPMCommand = new RoutedCommand();
        public static RoutedCommand ViewIPMCommand = new RoutedCommand();
        public static RoutedCommand SetIPMCommand = new RoutedCommand();
        public static RoutedCommand AssetListMenuCommand = new RoutedCommand();
        public static RoutedCommand LineLinkListMenuCommand = new RoutedCommand();
        public static RoutedCommand LocationListMenuCommand = new RoutedCommand();
        public static RoutedCommand CatalogListMenuCommand = new RoutedCommand();
        public static RoutedCommand ManufactureListMenuCommand = new RoutedCommand();
        public static RoutedCommand UserListMenuCommand = new RoutedCommand();
        public static RoutedCommand EventListMenuCommand = new RoutedCommand();
        public static RoutedCommand WorkOrderListMenuCommand = new RoutedCommand();
        public static RoutedCommand EnvironmentListMenuCommand = new RoutedCommand();
        public static RoutedCommand StatTerminalMenuCommand1 = new RoutedCommand();
        public static RoutedCommand StatTerminalMenuCommand2 = new RoutedCommand();
        public static RoutedCommand StatTerminalMenuCommand3 = new RoutedCommand();

        public static RoutedCommand DeleteCommand = new RoutedCommand();
        public static RoutedCommand AddBuildingCommand = new RoutedCommand();
        public static RoutedCommand EditBuildingCommand = new RoutedCommand();
        public static RoutedCommand AddFloorCommand = new RoutedCommand();
        public static RoutedCommand EditFloorCommand = new RoutedCommand();
        public static RoutedCommand AddRoomCommand = new RoutedCommand();
        public static RoutedCommand EditRoomCommand = new RoutedCommand();
        public static RoutedCommand AddRackCommand = new RoutedCommand();
        public static RoutedCommand EditRackCommand = new RoutedCommand();

        public static RoutedCommand AddAssetCommand = new RoutedCommand();
        public static RoutedCommand EditAssetCommand = new RoutedCommand();
        public static RoutedCommand RoomRackLayoutCommand = new RoutedCommand();

        public static RoutedCommand EnvironmentSettingMenuCommand = new RoutedCommand();
        public static RoutedCommand StatEventMenuCommand1 = new RoutedCommand();
        public static RoutedCommand StatEventMenuCommand2 = new RoutedCommand();
        public static RoutedCommand StatEventMenuCommand3 = new RoutedCommand();
        public static RoutedCommand PrintTemplateMenuCommand = new RoutedCommand();

        public static RoutedCommand ConfigICCommand = new RoutedCommand();
        public static RoutedCommand EnvironmentTargetMenuCommand = new RoutedCommand();

        public static RoutedCommand EtcViewOptionMenuCommand = new RoutedCommand();
        public static RoutedCommand Drawings3DManagerMenuCommand = new RoutedCommand();

        #endregion

        #region 초기화
        public MainWindow3()
        {
            g.main_window = this;

            _viewModel = new MainWindowViewModel2(DialogCoordinator.Instance);
            DataContext = _viewModel;

            InitializeComponent();

            _windowMainWindow.Height = g.screen_resolution.Height;
            _windowMainWindow.Width = g.screen_resolution.Width;

            //DB 미연결시 시뮬레이션 코드
            //selfSimulator();

            var u = g.user_list.Find(p => p.user_id == g.login_user_id);
            string user_name = u != null ? u.user_name : "";
            _txtUserName.Text = user_name;
            connect_signalr();  // 비동기로 호출...
            _evGrid.Height = 0;
        }

        // 비동기 호출됨 
        private async Task<bool> connect_signalr()
        {
            // SignalR 허브로 연결
            return await g.signalr.connect(g.signalr_uri_string);
        }

        #endregion

        #region 출력 메뉴 관리 Command
        // 선번장 목록 출력 
        private void _cmdLineLinkListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eLineLinkList);
        }

        private void _cmdLineLinkListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            LineLinkList window = new LineLinkList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 자산목록 출력 
        private void _cmdAssetListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eAssetList);
        }

        private void _cmdAssetListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetList window = new AssetList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 위치 목록 조회 출력 
        private void _cmdLocationListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eLocationList);
        }

        private void _cmdLocationListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            LocationList window = new LocationList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 환경 정보  조회 출력 
        private void _cmdEnvironmentListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eEnvironmentList);
        }

        private void _cmdEnvironmentListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            EnvironmentList window = new EnvironmentList();
            window.Owner = this;
            window.ShowDialog();
        }


        // 카탈록 출력 
        private void _cmdCatalogListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eCatalogList);
        }

        private void _cmdCatalogListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CatalogList window = new CatalogList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 제조사 출력 
        private void _cmdManufactureListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eManufactureList);
        }

        private void _cmdManufactureListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ManufactureList window = new ManufactureList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 연락처 / 사용자 목록 출력
        private void _cmdUserListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eUserList);
        }

        private void _cmdUserListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            UserList window = new UserList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 작업오더 목록 출력
        private void _cmdWorkOrderListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eWorkOrderList);
        }

        private void _cmdWorkOrderListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            WorkOrderList window = new WorkOrderList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 이벤트 목록 출력 
        private void _cmdEventListMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eEventList);
        }

        private void _cmdEventListMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            EventList window = new EventList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 링크다이어그램 변경 목록 출력
        private void _cmdLinkDiagramChangeHistMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eLinkDiagramChangeHistList);
        }

        private void _cmdLinkDiagramChangeHistMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        // 터미날 통계
        private void _cmdStatTerminalMenu1_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eStatTerminal1);
        }

        private void _cmdStatTerminalMenu1_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            StatTerminalMonth window = new StatTerminalMonth();
            window.Owner = this;
            window.ShowDialog();
        }
        private void _cmdStatTerminalMenu2_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eStatTerminal2);
        }

        private void _cmdStatTerminalMenu2_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            StatTerminalDay window = new StatTerminalDay();
            window.Owner = this;
            window.ShowDialog();
        }
        private void _cmdStatTerminalMenu3_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eStatTerminal3);
        }

        private void _cmdStatTerminalMenu3_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            StatTerminalHour window = new StatTerminalHour();
            window.Owner = this;
            window.ShowDialog();
        }
        // 이벤트 메뉴 통계 
        private void _cmdStatEventMenu1_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eStatEvent1);
        }
        private void _cmdStatEventMenu1_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            StatEnvironmentMonth window = new StatEnvironmentMonth();
            window.Owner = this;
            window.ShowDialog();
        }
        private void _cmdStatEventMenu2_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eStatEvent2);
        }

        private void _cmdStatEventMenu2_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            StatEnvironmentDay window = new StatEnvironmentDay();
            window.Owner = this;
            window.ShowDialog();
        }
        private void _cmdStatEventMenu3_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eStatEvent3);
        }

        private void _cmdStatEventMenu3_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            StatEnvironmentHour window = new StatEnvironmentHour();
            window.Owner = this;
            window.ShowDialog();
        }

        #endregion

        #region 좌측 트리 메뉴 관리 Command
        // 자산 추가 
        private void _cmdAddAsset_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eAddAsset))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
            {
                e.CanExecute = false;
                return;
            }
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            if (ast == null)
            {
                e.CanExecute = false;
                return;
            }
            int asset_id = ast.asset_id ?? 0;

            if (asset_id != 0)
            {
                int catalog_id = Etc.get_catalog_id_by_asset_id(asset_id);
                // 새시형스위치 경우에만 자산추가가 가능..
                e.CanExecute = CatalogType.is_sw_slot(catalog_id);
                return;
            }

            e.CanExecute = (ast_vm.disp_level == 6) || (ast_vm.disp_level == 7);
        }

        private async void _cmdAddAsset_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            int asset_id = 0;
            int location_id = 0;
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm != null)
            {
                asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
                asset_id = ast.asset_id ?? 0;
                location_id = ast.location_id;
            }

            // AssetManager에서 asset, asset_aux, rack_config, sw_config, asset_ext 를 책임진다.
            AssetManager am = new AssetManager(asset_id, location_id, true);
            am.Owner = Application.Current.MainWindow;
            var r = am.ShowDialog();

            int new_asset_id = g.result_asset_id;

            if ((r != null) && (r == true))
            {
                // 아래 공통 모듈에서 나머지 테이블들을 책임지고, 화면 갱신 등을 수행한다.
                bool b = await g.left_tree_handler.addAsset(new_asset_id);

                if (b)
                    // 다른 사용자에게도 알린다.
                    g.signalr.send_asset_to_signalr(new_asset_id, eAction.eAdd);
            }

        }
        // 자산 수정
        private void _cmdEditAsset_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eEditAsset))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
            {
                e.CanExecute = false;
                return;
            }
            int asset_id = ast_vm.asset_id ?? 0;
            e.CanExecute = asset_id != 0;
        }

        private void _cmdEditAsset_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
                return;
            int asset_id = ast_vm.asset_id ?? 0;
            int location_id = ast_vm.location_id;

            if (Etc.is_open_link_diagram(asset_id))
            {
                MessageBox.Show(g.tr_get("C_Error_Asset_3"));
                return;
            }

            AssetManager am = new AssetManager(asset_id, location_id, false);
            am.Owner = Application.Current.MainWindow;
            am.ShowDialog();
        }

        // 출력 템플릿 관리
        private void _cmdPrintTemplateMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.ePrintTemplate);
        }

        private void _cmdPrintTemplateMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PrintTemplateList window = new PrintTemplateList();
            window.Owner = this;
            window.ShowDialog();
        }

        // 선택 
        private void _cmdSelect_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }

        private void _cmdSelect_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
                return;
            AssetTreeVM ast_vm_md = _ctlLeftSide.getAssetTreeVMinMD(ast_vm);

            var l = g.location_list.Find(p => p.location_id == ast_vm.location_id);
            if (l == null)
                return;
            _selectLocation.Content = l.location_path;
            _selectLocationid.Content = l.location_id;
            //g.selected_location_id = l.location_id;
            g.DVModel.Location_Id = l.location_id;

            var flyout = this.Flyouts.Items[0] as Flyout;
            if (flyout == null) return;
            flyout.IsOpen = !flyout.IsOpen;
        }


        // 자산트리, 지능형트리, 즐겨찾기트리에서 사용
        // 지우기 
        private void _cmdDelete_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eDelete))
            {
                e.CanExecute = false;
                return;
            }
            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
            {
                e.CanExecute = false;
                return;
            }
            if (ast_vm.type == AssetTreeType.Site)
            {
                e.CanExecute = false;
                return;
            }

            int asset_id = ast_vm.asset_id ?? 0;
            if (asset_id == 0)
            {
                if (ast_vm.is_expander_visible == Visibility.Visible)
                {
                    e.CanExecute = false;
                    return;
                }
            }
            e.CanExecute = true;
        }

        private async void _cmdDelete_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
                return;
            int asset_id = ast_vm.asset_id ?? 0;
            int location_id = ast_vm.location_id;

            if (location_id < 19030005) return;
            if (MessageBox.Show(g.tr_get("C_Delete_Item"), g.tr_get("C_Confirm"), MessageBoxButton.YesNo) == MessageBoxResult.No)
                return;

            // 배선관리에 오픈되어 있으면 삭제가 안되게 함.
            if (Etc.is_open_link_diagram(asset_id))
            {
                MessageBox.Show(g.tr_get("C_Error_Asset_2"));
                return;
            }

            // 네트워크 스케줄러에 등록되어 있는 것은 삭제가 안되게 함.
            if (Etc.is_use_sw_card_in_network_scheduler(asset_id))
            {
                MessageBox.Show(g.tr_get("C_Error_Asset_4"));
                return;
            }

            int catalog_id = Etc.get_catalog_id_by_asset_id(asset_id);
            if (CatalogType.is_pc(catalog_id))
            {
                int outlet_asset_id = ast_vm._parant_ast_vm.asset_id ?? 0;
                int outlet_port_no = ast_vm._parant_ast_vm.port_no;
                // 단말 삭제루틴 호출
                await g.left_tree_handler.deleteTerminal(outlet_asset_id, outlet_port_no, asset_id);
                // 다른클라이언트에게 브로드캐스팅
                g.signalr.send_asset_to_signalr(asset_id, eAction.eRemove);
            }
            else if (asset_id > 0)
            {
                // 링크가 연결되어 있는 경우 삭제 불가
                if (Etc.is_use_link_diagram(asset_id))
                {
                    MessageBox.Show(g.tr_get("C_Error_Asset_1"));
                    return;
                }
                // 자산을 삭제...
                await g.left_tree_handler.deleteAsset(asset_id);
                // 다른클라이언트에게 브로드캐스팅
                g.signalr.send_asset_to_signalr(asset_id, eAction.eRemove);
            }
            else
            {
                // 장소를 삭제...
                await g.left_tree_handler.deleteLocation(location_id);
                // 다른클라이언트에게 브로드캐스팅
                g.signalr.send_location_to_signalr(location_id, eAction.eRemove);
            }

            // 삭제 후 바로위의 항목으로 이동하고 싶음....
        }

        // 빌딩 추가 
        private void _cmdAddBuilding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eAddBuilding))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = at.disp_level == 3;
        }

        private void _cmdAddBuilding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;
            var l = g.location_list.Find(p => p.location_id == location_id);
            if (l == null)
                return;

            int site_id = l.site_id ?? 0;

            BuildingManager window = new BuildingManager(site_id, 0);
            window.Owner = this;
            window.ShowDialog();
        }

        // 빌딩 수정 
        private void _cmdEditBuilding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eEditBuilding))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = at.disp_level == 4;
        }

        private void _cmdEditBuilding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);


            int location_id = ast.location_id;
            var l = g.location_list.Find(p => p.location_id == location_id);
            if (l == null)
                return;

            int site_id = l.site_id ?? 0;
            int building_id = l.building_id ?? 0;

            BuildingManager window = new BuildingManager(site_id, building_id);
            window.Owner = this;
            window.ShowDialog();
        }

        // 층 추가 
        private void _cmdAddFloor_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eAddFloor))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = at.disp_level == 4;
        }

        private void _cmdAddFloor_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;
            var l = g.location_list.Find(p => p.location_id == location_id);
            if (l == null)
                return;

            int building_id = l.building_id ?? 0;

            FloorManager window = new FloorManager(building_id, 0);
            window.Owner = this;
            window.ShowDialog();
        }

        // 층 수정 
        private void _cmdEditFloor_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eEditFloor))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = at.disp_level == 5;
        }

        private void _cmdEditFloor_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;
            var l = g.location_list.Find(p => p.location_id == location_id);
            if (l == null)
                return;

            int building_id = l.building_id ?? 0;
            int floor_id = l.floor_id ?? 0;

            FloorManager window = new FloorManager(building_id, floor_id);
            window.Owner = this;
            window.ShowDialog();
        }

        // 룸 추가 
        private void _cmdAddRoom_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eAddRoom))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = at.disp_level == 5;
        }

        private void _cmdAddRoom_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;
            var l = g.location_list.Find(p => p.location_id == location_id);
            if (l == null)
                return;

            int floor_id = l.floor_id ?? 0;

            RoomManager window = new RoomManager(floor_id, 0);
            window.Owner = this;
            window.ShowDialog();
        }
        // 룸 수정 
        private void _cmdEditRoom_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eEditRoom))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = at.disp_level == 6;
        }

        private void _cmdEditRoom_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;
            var l = g.location_list.Find(p => p.location_id == location_id);
            if (l == null)
                return;

            int floor_id = l.floor_id ?? 0;
            int room_id = l.room_id ?? 0;

            RoomManager window = new RoomManager(floor_id, room_id);
            window.Owner = this;
            window.ShowDialog();
        }

        // 랙추가 
        private void _cmdAddRack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eAddRack))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = at.disp_level == 6;
        }

        private void _cmdAddRack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;
            var l = g.location_list.Find(p => p.location_id == location_id);
            if (l == null)
                return;

            int room_id = l.room_id ?? 0;

            RackManager window = new RackManager(room_id, 0);
            window.Owner = this;
            window.ShowDialog();
        }

        // 랙 수정 
        private void _cmdEditRack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eEditRack))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at == null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = at.disp_level == 7;
        }

        private void _cmdEditRack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;
            var l = g.location_list.Find(p => p.location_id == location_id);
            if (l == null)
                return;

            int room_id = l.room_id ?? 0;
            int rack_id = l.rack_id ?? 0;

            RackManager window = new RackManager(room_id, rack_id);
            window.Owner = this;
            window.ShowDialog();
        }

        // 3D 도면 등록 관리
        private void _cmdDrawings3DManagerMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eDrawings3DManager);
        }

        private void _cmdDrawings3DManagerMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DrawingEditer window = new DrawingEditer();
            window.Owner = this;
            window.ShowDialog();
        }

        // 기타 표시 옵션 설정
        private void _cmdEtcViewOptionMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (g.select_site == null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = UserRight.is_ok(eUserRight.eEtcViewOption);
        }

        private void _cmdEtcViewOptionMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            EtcViewOption window = new EtcViewOption();
            window.Owner = this;
            window.ShowDialog();
        }



        // 환경 장치 층별 보기 
        private void _cmdViewFloorIPM_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
#if GS_DEL
            if (g._environment != 99)
            {
                e.CanExecute = false;
                return;
            }
#endif
            if (!UserRight.is_ok(eUserRight.eViewFloorIPM))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
            {
                e.CanExecute = false;
                return;
            }
            int location_id = ast_vm.location_id;
            var lo = g.location_list.Find(p => p.location_id == location_id);
            if (lo == null)
            {
                e.CanExecute = false;
                return;
            }
            int floor_id = lo.floor_id ?? 0;
            var f = g.floor_list.Find(p => p.floor_id == floor_id);
            if (f == null)
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }

        private void _cmdViewFloorIPM_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            int location_id = 0;
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;

            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            location_id = ast.location_id;

            var lo = g.location_list.Find(p => p.location_id == ast.location_id);
            if (lo == null)
                return;

            int floor_id = lo.floor_id ?? 0;
            var f = g.floor_list.Find(p => p.floor_id == floor_id);
            if (f == null)
                return;

            if (g.window.alive == 0)
            {
                g.window = new IPMFloorView(floor_id);
                g.window.Owner = Application.Current.MainWindow;
            }
            g.window.Show();

            var flyout = this.Flyouts.Items[0] as Flyout;
            if (flyout == null) return;
            flyout.IsOpen = !flyout.IsOpen;

        }

        // 환경 장치 보기 
        private void _cmdViewIPM_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
#if GS_DEL
            if (g._environment != 99)
            {
                e.CanExecute = false;
                return;
            }
#endif
            if (!UserRight.is_ok(eUserRight.eViewIPM))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
            {
                e.CanExecute = false;
                return;
            }
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            if (ast == null)
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = (ast.asset_id ?? 0) == 0;

            if (ast.asset_id != null)
            {
                int catalog_id = Etc.get_catalog_id_by_asset_id(ast.asset_id ?? 0);
                e.CanExecute = CatalogType.is_eb(catalog_id);
            }
        }

        private void _cmdViewIPM_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;

            IPMView window = new IPMView(location_id);
            window.Owner = Application.Current.MainWindow;
            window.Show();

            var flyout = this.Flyouts.Items[0] as Flyout;
            if (flyout == null) return;
            flyout.IsOpen = !flyout.IsOpen;

        }
        // 환경 장치 설정 
        private void _cmdSetIPM_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
#if GS_DEL
            if (g._environment != 99)
            {
                e.CanExecute = false;
                return;
            }
#endif
            if (!UserRight.is_ok(eUserRight.eViewIPM))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
            {
                e.CanExecute = false;
                return;
            }
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            if (ast == null)
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = (ast.asset_id ?? 0) == 0;

            if (ast.asset_id != null)
            {
                int catalog_id = Etc.get_catalog_id_by_asset_id(ast.asset_id ?? 0);
                e.CanExecute = CatalogType.is_eb(catalog_id);
            }
        }

        private void _cmdSetIPM_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
                return;
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            int location_id = ast.location_id;

            if (ast.asset_id == null) return;
            EnviromentManagerSet window = new EnviromentManagerSet(ast.asset_id ?? 0);
            window.Owner = Application.Current.MainWindow;
            window.ShowDialog();

            var flyout = this.Flyouts.Items[0] as Flyout;
            if (flyout == null) return;
            flyout.IsOpen = !flyout.IsOpen;

        }

        // 환경 장치 목표량 설정 
        private void _cmdEnvironmentTargetMenu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
#if GS_DEL
            if (g._environment != 99)
            {
                e.CanExecute = false;
                return;
            }
#endif
            if (!UserRight.is_ok(eUserRight.eViewIPM))
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }

        private void _cmdEnvironmentTargetMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            EnviromentTarget window = new EnviromentTarget();
            window.Owner = Application.Current.MainWindow;
            window.ShowDialog();
        }

        // 룸에 랙 설정 
        private void _cmdRoomRackLayoutMount_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (!UserRight.is_ok(eUserRight.eRoomRackLayoutMount))
            {
                e.CanExecute = false;
                return;
            }

            AssetTreeVM ast_vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (ast_vm == null)
            {
                e.CanExecute = false;
                return;
            }
            asset_tree ast = g.asset_tree_list.Find(at => at.asset_tree_id == ast_vm.asset_tree_id);
            if (ast == null)
            {
                e.CanExecute = false;
                return;
            }
            int asset_id = ast.asset_id ?? 0;

            if (asset_id != 0)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = (ast_vm.disp_level == 5) || (ast_vm.disp_level == 6);
        }

        private void _cmdCRoomRackLayout_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM at = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            if (at != null)
            {
                AssetTreeVM ast_vm = _ctlLeftSide.getAndCopyAssetTreeVM(at);
                if (ast_vm == null) return;   // 우측버튼 처리시 문제 // 2015.11.27 romee
                RoomAndRackLayoutManager window = new RoomAndRackLayoutManager(ast_vm);
                window.Owner = Application.Current.MainWindow;
                window.ShowDialog();
            }
        }

        // 컨트롤러 설정 
        private void _cmdConfigIC_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
            if (!UserRight.is_ok(eUserRight.eConfigIC))
            {
                return;
            }

            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
            {
                return;
            }
            int asset_id = ast_vm.asset_id ?? 0;
            if (asset_id == 0)
            {
                return;
            }
            int catalog_id = Etc.get_catalog_id_by_asset_id(asset_id);
            if (catalog_id == 412002)
                e.CanExecute = true;
            return;
            //e.CanExecute = CatalogType.is_eb(catalog_id);
        }

        private void _cmdConfigIC_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AssetTreeVM ast_vm = get_tree_vm();
            if (ast_vm == null)
                return;
            int asset_id = ast_vm.asset_id ?? 0;
            int location_id = ast_vm.location_id;

            var lo = g.location_list.Find(p => p.location_id == location_id);
            if (lo == null)
                return;

            int floor_id = lo.floor_id ?? 0;

            location_id = Etc.get_location_id_by_floor_id(floor_id);

            IEMountManager window = new IEMountManager(location_id, asset_id);
            window.Owner = Application.Current.MainWindow;
            window.ShowDialog();
        }

        #endregion

        #region // 윈도우 이벤트
        //윈도우 로딩 이벤트
        private void _windowMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (Reg.get_dcim() > 1) // DCIM 처리 romee
            {
                int ret1 = Reg.get_dcim();
                ret1 = 79300001;            //IEMS
                g.selected_site_id = ret1;  
                selectSiteEvent(ret1);
            }

            if (isReadyMainRun == false)
            {
                isReadyMainRun = true;
                if (g.selected_site_id == 0)
                {
                    // 본 프로그램은 SSO를 지원합니다. 
                    MessageBox.Show(this, " Support single sign on !!", "SimpleWIN");
                    Application.Current.Shutdown(-1);
                }
                else 
                {
                    if (_ctlLeftSide != null)
                    { 
                        g.left_tree_handler._ctlLeftSide = _ctlLeftSide;
                    }

                    g.window = new IPMFloorView(89100001);
                    g.window.Owner = Application.Current.MainWindow;

                }
            }
            initListView();
            EventAlarm();
            _ctlLeftSide.InitLeftSide(g.selected_site_id);
        }

        List<listHeader> _listHeader = new List<listHeader>();
        List<EventPrintList> _print_list = new List<EventPrintList>();

        private void initListView()
        {
            // 리소스 스트링을 디비화 할 필요 있음 
            _listHeader.Clear();
            _listHeader.Add(new listHeader { h_width = 0, h_title = "ID", h_bind = "event_hist_id" });
            _listHeader.Add(new listHeader { h_width = 60, h_title = "C_No", h_bind = "RowNumber" });
            _listHeader.Add(new listHeader { h_width = 130, h_title = "C_Date", h_bind = "write_time" });
            _listHeader.Add(new listHeader { h_width = 100, h_title = "M_Prop2_Group", h_bind = "event_type" });
            _listHeader.Add(new listHeader { h_width = 450, h_title = "C_Brief", h_bind = "event_text" });
            _listHeader.Add(new listHeader { h_width = 380, h_title = "C_Location_Name", h_bind = "location_id" });
            _lvGridView.Columns.Clear();
            // 동적 생성 
            for (int i = 0; i < _listHeader.Count; i++)
            {
                listHeader l1 = _listHeader[i];
                TextBlock t1 = new TextBlock();
                t1.Text = I2MSR.Properties.Resources.ResourceManager.GetString(l1.h_title);
                //t1.Style = Application.Current.Resources["I2MS_ListViewColHeaderText"] as Style;
                t1.Foreground = Brushes.White;
                Border b2 = new Border();
                b2.BorderThickness = new Thickness(0);
                b2.Child = t1;

                GridViewColumn g1 = new GridViewColumn();
                g1.DisplayMemberBinding = new Binding(l1.h_bind);
                if (i == 1)
                {
                    GridViewExtensions.SetIsContentCentered(g1, true);
                }
                g1.Header = b2;
                g1.Width = l1.h_width;

                if (i == 3)
                {
                    g1.DisplayMemberBinding = null;
                    var bind1 = new Binding(l1.h_bind);
                    var bind2 = new Binding(l1.h_bind) { Converter = new MyConverter() };
                    var textBlockFactory = new FrameworkElementFactory(typeof(TextBlock));
                    textBlockFactory.SetBinding(TextBlock.TextProperty, bind1);
                    textBlockFactory.SetBinding(TextBlock.ForegroundProperty, bind2);
                    var cellTemplate = new DataTemplate { VisualTree = textBlockFactory };
                    g1.CellTemplate = cellTemplate;
                }


                _lvGridView.Columns.Add(g1);
            }


        }

        public void EventAlarm()
        {
            // 데이터 취합 
            int i = 1;
            var tdb1 = from a in g.event_hist_list
                       join b in g.event_list on a.event_id equals b.event_id
                       orderby a.event_hist_id descending

                       select new EventPrintList()
                       {
                           RowNumber = i++,

                           event_hist_id = a.event_hist_id,
                           event_type = getevent_type(a.event_type),
                           event_id = a.event_id,
                           event_text = a.event_text,
                           asset = a.asset_id,
                           location = a.location_id,
                           location_id = a.location_id == null ? "" : getLocationName(a.location_id),
                           catalog_group_id = a.catalog_group_id,
                           catalog_id = a.catalog_id,
                           asset_id = a.asset_id == null ? "" : getAssetName(a.asset_id, a.port_no),
                           port_no = a.port_no,
                           terminal_asset_id = a.terminal_asset_id == null ? "" : getAssetName(a.asset_id, a.port_no),
                           mac = a.mac,
                           ipv4 = a.ipv4,
                           user_id = a.user_id,
                           is_confirm = a.is_confirm,
                           confirm_user_id = a.confirm_user_id,
                           write_time = a.write_time == null ? "" : string.Format("{0}", a.write_time.ToString("yyyy-MM-dd HH:mm:ss")),
                           wo_id = a.wo_id,

                           popup_screen = b.popup_screen,
                           send_email = b.send_email,
                           send_sms = b.send_sms,
                       };

            int j = 1;
            var tdb2 = from a in tdb1.Take(40)
                       select new EventPrintList()
                       {
                           RowNumber = j++,
                           event_hist_id = a.event_hist_id,
                           event_type = a.event_type,
                           event_id = a.event_id,
                           event_text = a.event_text,
                           asset = a.asset,
                           location = a.location,
                           location_id = a.location_id,
                           catalog_group_id = a.catalog_group_id,
                           catalog_id = a.catalog_id,
                           asset_id = a.asset_id,
                           port_no = a.port_no,
                           terminal_asset_id = a.terminal_asset_id,
                           mac = a.mac,
                           ipv4 = a.ipv4,
                           user_id = a.user_id,
                           is_confirm = a.is_confirm,
                           confirm_user_id = a.confirm_user_id,
                           write_time = a.write_time,
                           wo_id = a.wo_id,

                           popup_screen = a.popup_screen,
                           send_email = a.send_email,
                           send_sms = a.send_sms,
                           event_desc = a.event_desc,
                       };
            _print_list.Clear();
            _print_list = tdb2.ToList();

            // Row Num 삽입
            for (int j1 = 0; j1 < _print_list.Count(); j1++)
            {
                EventPrintList t1 = _print_list[j1];
                t1.RowNumber = j1 + 1;
            }

            //            initListView();
            _lvManufacture.ItemsSource = _print_list; // _manufacture_list;
        }

        private string getLocationName(int? id)
        {
            int lid = id ?? 0;
            string ret = "";

            if (lid == 0) return ret;
            var a1 = g.location_list.Find(p => p.location_id == lid);
            if (a1 != null)
            {
                ret = a1.location_path;
            }
            return ret;
        }

        private string getevent_type(string id)
        {
            string lid = id.Trim();
            string ret = "Information";

            switch (lid)
            {
                case "I": ret = "Information"; break;
                case "W": ret = "Warning"; break;
                case "E": ret = "Error"; break;
            }
            return ret;
        }

        private string getBuildingName(int? id)
        {
            int lid = id ?? 0;
            string ret = "";

            if (lid == 0) return ret;
            var a1 = g.building_list.Find(p => p.building_id == lid);
            if (a1 != null)
            {
                ret = a1.building_name;
            }
            return ret;
        }

        private string getFloorName(int? id)
        {
            int lid = id ?? 0;
            string ret = "";

            if (lid == 0) return ret;
            var a1 = g.floor_list.Find(p => p.floor_id == lid);
            if (a1 != null)
            {
                ret = a1.floor_name;
            }
            return ret;
        }

        private string getAssetName(int? id, int? port)
        {
            int lid = id ?? 0;
            int lport = port ?? 0;
            string ret = "";

            if (lid == 0 || lport == 0)
                return ret;
            var a1 = g.asset_list.Find(p => p.asset_id == lid);
            if (a1 != null)
            {
                ret = string.Format("{0}/{1}", a1.asset_name, lport);
            }
            return ret;
        }

        //Page1 Region2 에서 site를 더블클릭 했을때 호출
        //사이트 정보를 변경한다
        public void selectSiteEvent(int id)
        {
            site st = g.site_list.Find(at => at.site_id == id);
            if (st == null)
                return;
            g.select_site = st;

            try
            {
                g.selected_building_id = g.building_list.Find(p => p.site_id == id).building_id;
            }
            catch { }
        }

        //윈도우 리사이즈 이벤트
        private void _windowMainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //윈도우 사이즈 변화에 따라 페이지 프래임 사이즈를 변경한다
            // minimum 1280x1024
            if (_gridCenter.ActualWidth > 1280)
                MainTabControl.Width = _gridCenter.ActualWidth - 20;
            if (_gridCenter.ActualHeight > (800))
                MainTabControl.Height = _gridCenter.ActualHeight - 20;

            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                // max -> normal bug 
                if (MainTabControl.Width > 1280)
                    MainTabControl.Width = _gridCenter.ActualWidth - 20;
                //g._dash2.InvalidateVisual();
            }
            //Console.WriteLine("Main Size : {0}", Width);
        }

        // 시그널R 재연결하는 루틴으로 디버그를 장시간(30초? 이상)하는 경우 연결이 끊기는 거에 대비하기 위한... (개발자를 위한 기능)
        // 향후 더 보강을 하려면 리커넥트를 자동으로 하는 것 정도...
        private async void _imgConnect_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (g.signalr.State == ConnectionState.Disconnected)
            {
                await g.signalr.connect(g.signalr_uri_string);
            }
        }

        // 댓쉬보드 로딩시 처리 
        private void _framePage2View_LoadCompleted(object sender, NavigationEventArgs e)
        {
        }

        #endregion

        #region // 버튼 처리 , 윈도우 유틸 처리 
        // Help 처리 필요 
        // 버젼 표기 romee 2015.09.03
        // 리프레쉬 처리 
        private void _windowMainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
            }
            // 패스워드 초기화 컴맨드 2017-01-17 romee ctrl+F12
            if (e.Key == Key.F12 && Keyboard.Modifiers == ModifierKeys.Control)
            {
                user node = g.user_list.Find(p => p.login_id == "system" && p.user_group == "S");

                node.login_password = DESEncrypt.EncryptSHA_AES("system");
                g.webapi.put("user", 90001, node, typeof(user));
            }

            if (e.Key == Key.F1)
            {
                var obj = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                string version = string.Format("Application Version {0}.0.4.{1}", obj.Major, obj.Revision);

                PopUpWindow popup_window = new PopUpWindow("Version Info. : " + version);
                popup_window.Title = "About Box";
                popup_window.Show();

                //MessageBox.Show(this, "Version : " + version);
            }
        }

        // 회사 사이트로 이동 처리 
        private void LaunchMahAppsOnCompany(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lssimple.com/");
        }

        // 테마 버튼 클릭시 메뉴 등록 처리 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        // 로그 오프 처리 
        private void _btnLogoff_Click(object sender, RoutedEventArgs e)
        {
            //Window win = new WindowFloor();
            //win.Show();

            if (g.window.alive == 0)
            {
                g.window = new IPMFloorView(89201123);
                g.window.Owner = Application.Current.MainWindow;
            }
            g.window.Show();
            /*
                if (MessageBox.Show(g.tr_get("C_LogOutConfirm"), g.tr_get("C_Confirm"), MessageBoxButton.YesNo) == MessageBoxResult.No)
                    return;
                System.Windows.Forms.Application.Restart();
                System.Windows.Application.Current.Shutdown();
            */
        }

        // 로케이션 윈도우 보이기 처리 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var flyout = this.Flyouts.Items[0] as Flyout;
            if (flyout == null)
            {
                return;
            }
            flyout.IsOpen = !flyout.IsOpen;
        }

        // 시험 용 
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Window win = new Window1Test();
            //win.Show();

            //g._P2DashBoard._p_main.Update();
            Width = Width + 5;
        }

        // 트리에 따른 선택 
        private AssetTreeVM get_tree_vm()
        {
            AssetTreeVM vm = null;
            vm = (AssetTreeVM)_ctlLeftSide._tvAssetTree.SelectedItem;
            return vm;
        }

        // 메인탭 로딩후 
        private void MainTabControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataViewModel tempmodel1 = new DataViewModel();

            tempmodel1.Location_Id = Etc.get_location_id_by_site_id(g.selected_site_id);

            g._dash1.DataContext = tempmodel1;
            g._dash2.DataContext = tempmodel1;
            g._dash3.DataContext = tempmodel1;
            g._dash5.DataContext = tempmodel1;

            g.DVModel = tempmodel1;
            g.DVModel.Location_Id = 0;

        }

        private void MainTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        // 알람 상세 내용 확인용 
        private void _lvEvent_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
/*
            EventVM vm = _lvEvent.SelectedItem as EventVM;

            EventViewer window = new EventViewer(vm);
            window.Owner = this;
            window.ShowDialog();

            if (window._ret == 1)
            {// 트리 로케이션 처리 
                _ctlLeftSide.searchlocation(vm.location_id);
            }
            else if (window._ret == 2)
            {// 트리 자산 처리  
                _ctlLeftSide.searchasset(vm.asset_id);
            }
*/
        }
        // 선택 변경시 처리 
        private void _lvEvent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // 알람 내용 보이기 처리 
        public async Task<bool> updateEvent(int event_hist_id)
        {
            event_hist eh = (event_hist)await g.webapi.get("event_hist", event_hist_id, typeof(event_hist));
            if (eh == null)
                return false;

            if (eh.asset_id > 0 && String.IsNullOrEmpty(eh.ipv4)) // romee/1/22   // 서버에서 ipv4를 저장하지 않으므로 이벤트 수신시 해당 ipv4 저장 처리 
            {
                asset ast = g.asset_list.Find(p => p.asset_id == eh.asset_id); 
                if (ast != null)
                {
                    eh.ipv4 = ast.ipv4;
                }
            }
            var find = g.event_hist_list.Find(p => p.event_hist_id == event_hist_id);
            if (find == null)
                g.event_hist_list.Add(eh);

            int event_id = eh.event_id;
            var e = g.event_list.Find(p => p.event_id == event_id);
            var el = g.event_lang_list.Find(p => (p.event_id == event_id) && (p.lang_id == g.lang_id));
            if ((e == null) || (el == null))
                return false;
            bool popup_screen = e.popup_screen == "Y";
            string msg = eh.event_text;
            eEventType event_type = Common.get_event_type(eh.event_type);

            int cr = msg.IndexOf(". ");
            if (cr != -1)
                msg = msg.Insert(cr + 1, "\r\n");

            // 7건까지만 표시
            if (g.popup_event_list.Count > 7)
            {
                g.popup_event_list.RemoveAt(6);
            }

            // 이벤트가 하나도 없는 경우 새로운 이벤트가 왔으니 가장 마지막 하단은 기초 정보표시용 템플릿으로....
            if (g.popup_event_list.Count == 0)
            {
                EventVM vm0 = new EventVM();
                vm0.base_text = "Event";
                vm0.template = "base";
                g.popup_event_list.Add(vm0);
            }
            else
            {
                g.popup_event_list[g.popup_event_list.Count - 1].base_text = string.Format("Event");
            }

            EventVM vm = new EventVM();
            vm.template = "data";
            vm.event_hist_id = event_hist_id;
            vm.event_type = event_type;
            vm.event_text = msg;
            vm.location_id = eh.location_id ?? 0;
            vm.asset_id = eh.asset_id ?? 0;
            vm.port_no = eh.port_no ?? 0;
            vm.catalog_id = eh.catalog_id ?? 0;
            vm.ip_addr = eh.ipv4;
            vm.mac_addr = eh.mac;
            vm.wo_id = eh.wo_id ?? 0;
            vm.write_time = eh.write_time;
            vm.is_confirm = eh.is_confirm == "Y";
            vm.confirm_user_id = eh.confirm_user_id ?? 0;
            g.popup_event_list.Insert(0, vm);


            this.flyoutsControl.DataContext = g.popup_event_list[0];
            var flyout = this.flyoutsControl.Items[1] as Flyout;
            if (flyout == null) return false;
            flyout.IsOpen = true; // =  !flyout.IsOpen;
            var t = new DispatcherTimer(TimeSpan.FromSeconds(2), DispatcherPriority.Normal, Tick1, this.Dispatcher);

            //g._dash2.EventAlarm();
            EventAlarm();
            /*
            int i = 0;
            Object[] obj = new object[] { i.ToString() };
            _lvEvent.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal,
                    new Action(delegate()
                    {
                        _lvEvent.ItemsSource = null;
                        _lvEvent.ItemsSource = g.popup_event_list;
                    }));
            */
            return true;
        }

        private void _btnClose_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext;
            int idx = _lvEvent.Items.IndexOf(item);
            _lvEvent.SelectedIndex = idx;

            if (idx >= 0)
            {
                EventVM vm = _lvEvent.SelectedItem as EventVM;
                if (vm.template == "base")
                    g.popup_event_list.Clear();
                else
                {
                    if (g.popup_event_list.Count < 3)
                        g.popup_event_list.Clear();
                    else
                        g.popup_event_list.Remove(vm);
                }
                _lvEvent.ItemsSource = null;
                _lvEvent.ItemsSource = g.popup_event_list;
            }
        }

        // 1초후 알람차 자동 지우기 처리 
        void Tick1(object sender, EventArgs e)
        {
            var t1 = (DispatcherTimer)sender;
            t1.Stop();
            var flyout = this.flyoutsControl.Items[1] as Flyout;
            if (flyout == null) return;
            if(flyout.IsOpen)
                flyout.IsOpen = false;
        }

        // 메뉴 보이기 처리 
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;

        }

        // 이벤트 창 항목 클릭시 해당 층별뷰 보이기 처리 
        private void _lvManufacture_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EventPrintList vm = (EventPrintList)_lvManufacture.SelectedItem;
            if (vm == null) return;
            if (vm.event_hist_id == 0) return;

            int p;
            p = (int)vm.location == null ? 0 : (int)vm.location;
            if (p > 0)
                g.left_tree_handler._ctlLeftSide.searchlocation(p);
            /*
                                int p1;
                                p1 = (int)vm.asset == null ? 0 : (int)vm.asset;
                                if (p1 > 0)
                                    g.left_tree_handler._ctlLeftSide.searchasset(p);
            */

            var lo = g.location_list.Find(l => l.location_id == p);
            if (lo == null)
                return;

            int floor_id = lo.floor_id ?? 0;
            var f1 = g.floor_list.Find(f => f.floor_id == floor_id);
            if (f1 == null)
                return;

            if (g.window.alive == 0)
            {
                g.window = new IPMFloorView(floor_id);
                g.window.Owner = Application.Current.MainWindow;
            }
            g.window.SelectRack(lo.rack_id ?? 0);
            g.window.Show();
        }

        // 하단 이벤트 창 보이기/ 안보이기 처리 
        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (_evGrid.ActualHeight == 0)
                _evGrid.Height = 200;
            else
                _evGrid.Height = 0;
        }
        #endregion

    }

    #region IValueConverter

    public class EventBorderConverter : IValueConverter
    {
        private Color red = (Color)App.Current.Resources["_colorRed"];         // error
        private Color green = (Color)App.Current.Resources["_colorGreen"];     // info
        private Color blue = (Color)App.Current.Resources["_colorBlue"];
        private Color yellow = (Color)App.Current.Resources["_colorYellow"];    // Warnning

        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value == null)
                return Colors.Transparent;

            eEventType type = (eEventType)value;

            switch (type)
            {
                case eEventType.eInfo:
                    return green;
                case eEventType.eWarnning:
                    return yellow;
                case eEventType.eError:
                    return red;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value;
        }
    }
    #endregion

}
