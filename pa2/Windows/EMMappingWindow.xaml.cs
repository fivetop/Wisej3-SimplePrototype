using System.Windows;
using System.Windows.Controls;
using pa.classes;
using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using gClass;
using System.Text.RegularExpressions;
using System;
using System.Linq;

namespace pa.Windows
{
    /// <summary>
    /// Interaction logic for IconsWindow.xaml
    /// </summary>
    public partial class EMMappingWindow : Window
    {
        public static RoutedCommand NewCommand = new RoutedCommand();
        public static RoutedCommand EditCommand = new RoutedCommand();
        public static RoutedCommand DeleteCommand = new RoutedCommand();
        public static RoutedCommand SaveCommand = new RoutedCommand();
        public static RoutedCommand CancelCommand = new RoutedCommand();

        public List<string> emData { get; set; } = new List<string>() { };
        public List<Device> list1 = new List<Device>();

        public EMMappingWindow()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (gl._emList.child.Count > 0)
                initLeft();
            else
            {
                MessageBox.Show("설정에서 R형 수신기 연동후 사용바랍니다.", "연동필요", MessageBoxButton.OK);
                Close();
            }
        }

        #region init 로직
        private void initLeft()
        {
            var d1 = gl.danteDevice._DanteDevice.Where(p=>p.device == 0).ToList();
            list1 = ObjectCopier.Clone(d1);
            dataGrid1.ItemsSource = null;
            dataGrid1.ItemsSource = list1;

            //floor = new ObservableCollection<string>() {};
            emData.Clear();
            foreach (EM_Data o in gl._emList.child)
            {
                emData.Add(o.getemData());
            }
            ComboBoxColumn.ItemsSource = null;
            ComboBoxColumn.ItemsSource = emData;
        }
        #endregion

        #region CRUD 신규,삭제 등 버튼 처리 로직
        private void _cmdSave_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        // 저장 처리 
        private async void _cmdSave_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (!saveLeft()) return;
            CommandManager.InvalidateRequerySuggested();
        }

        private void _cmdCancel_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void _cmdCancel_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
        #endregion

        #region add, edit save 로직, delete 로직

        private bool saveLeft()
        {
            foreach (Device mAsset in dataGrid1.Items.SourceCollection)
            {
                if (mAsset.emData == null || mAsset.emData == "")
                    continue;

                var sAsset = gl.danteDevice._DanteDevice.Find(p=>p.path == mAsset.path);
                if (sAsset != null)
                {
                    UpdateDante(sAsset.DeviceName, mAsset.emData);
                }
            }
            gl.XMLDanteDevice(false);
            return true;
        }

        private void UpdateDante(string deviceName, string emData)
        {
            var sst = gl.danteDevice._DanteDevice.Where(p => p.DeviceName == deviceName);
            string s1 = emData.Substring(9,2);
            int v1 = int.Parse(s1);

            if (sst.Count() < 1)
                return;
            var sst1 = sst.First(p => p.DeviceName == deviceName);
            if (sst1 == null)
                return;
            sst1.floor_em = v1;
            sst1.emData = emData;
        }
        #endregion

        private void _btnAuto_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("장치명을 보고 해당 층에 자동으로 할당 하시겠습니까?", "자동할당", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
                return;

            foreach (Device mAsset in dataGrid1.Items.SourceCollection)
            {
                var sAsset = gl._SpeakerList.asset.Find(p => p.path == mAsset.path);

                if (sAsset == null)
                    continue;
                foreach (EM_Data em1 in gl._emList.child)
                {
                    if (em1.CC == "00" && sAsset.GroupName.Contains("B"))
                    {
                        UpdateDante(sAsset.DeviceName, em1.emData);
                    }
                    else if (em1.CC != "00" && sAsset.GroupName.Contains("F"))
                    {
                        if (str2int(em1.CC) == str2int(sAsset.GroupName))
                        { 
                            UpdateDante(sAsset.DeviceName, em1.emData);
                        }
                    }
                }
            }
            gl.XMLDanteDevice(false);
            initLeft();
        }

        public int str2int(string t1)
        {
            int ret = 0;

            string t2 = Regex.Replace(t1, @"\D", "");
            ret = int.Parse(t2);
            return ret;

        }

    }
}
