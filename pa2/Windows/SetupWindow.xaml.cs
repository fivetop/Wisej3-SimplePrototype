using System.Windows;
using System.Windows.Controls;
using pa.classes;
using System.Collections.Generic;
using System.Windows.Input;
using System.Linq;

namespace pa.Windows
{
using gClass;
    /// <summary>
    /// Interaction logic for IconsWindow.xaml
    /// </summary>
    public partial class SetupWindow : Window
    {
        public static RoutedCommand CancelCommand = new RoutedCommand();
        public List<int> dsp_vol { get; set; } = new List<int>() { };

        public SetupWindow()
        {
            this.DataContext = gl._BaseData;
            InitializeComponent();
        }

        #region CRUD 신규,삭제 등 버튼 처리 로직

        private void _cmdCancel_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void _cmdCancel_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var t1 = gl.danteDevice._DanteDevice.FindAll(p => p.device == 2);
            cboType.ItemsSource = t1;
            cboType.DisplayMemberPath = "DeviceName";
            cboType.SelectedValuePath = "name";
            cboType.SelectedValue = gl._BaseData.ServerIP;

            var t2 = gl._MusicList.music.ToList();

            cboType2.ItemsSource = t2;
            cboType2.DisplayMemberPath = "FileName";
            cboType2.SelectedValuePath = "FileName";
            cboType2.SelectedValue = gl._BaseData.Reserved14;

            var t3 = new string[] { "R형 자동 검출", "R형 제조사 10", "R형 제조사 12"};

            cboType1.ItemsSource = t3;
            cboType1.SelectedValue = gl._BaseData.Reserved16;

            for (int i = 1; i < 11; i++)
            {
                dsp_vol.Add(i);
            }
            cboType3.ItemsSource = null;
            cboType3.ItemsSource = dsp_vol;
            cboType3.SelectedIndex = gl._BaseData.dsp_vol-1;
            cboType4.ItemsSource = null;
            cboType4.ItemsSource = dsp_vol;
            cboType4.SelectedIndex = gl._BaseData.dsp_vol_em-1;

            var t4 = new string[] { "5층 이하, 연면적 3,000 이하", "5층 이상, 연면적 3,000 이상" };
            cboType6.ItemsSource = null;
            cboType6.ItemsSource = t4;
            cboType6.SelectedIndex = gl._BaseData.Jigsangbalhwa - 1;
        }

        private void cboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Device t1 = (Device) e.AddedItems[0];
            if (t1 == null)
                return;
            gl._BaseData.ServerIP = t1.DeviceName;
        }

        private void cboType2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Music t1 = (Music)e.AddedItems[0];
            if (t1 == null)
                return;
            gl._BaseData.Reserved14 = t1.FileName;

        }

        private void cboType1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string t1 = (string)e.AddedItems[0];
            if (t1 == null)
                return;
            gl._BaseData.Reserved16 = t1;

        }

        private void _btn1_Click(object sender, RoutedEventArgs e)
        {
            // 일반방송
            int t1 = cboType3.SelectedIndex + 1;

            if (MessageBox.Show("전체 적용됩니다. 적용하시겠습니까?", "전체적용", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;

            var dsp1 = gl.danteDevice._DanteDevice.Where(p => p.device == 0).ToList();

            foreach (var dsp in dsp1)
            {
                dsp.dsp_vol = t1;
            }
            gl._BaseData.dsp_vol = t1;
            gl.XMLSimplePA(false);
            gl.XMLDanteDevice(false);
            msg pkt = new msg("V", "0", "V", "1","");
            ///g.mainWindow.s1.Send(pkt.pkt);

        }

        private void _btn2_Click(object sender, RoutedEventArgs e)
        {
            // 비상방송 
            int t1 = cboType4.SelectedIndex + 1;

            if (MessageBox.Show("전체 적용됩니다. 적용하시겠습니까?", "전체적용", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;
            var dsp1 = gl.danteDevice._DanteDevice.Where(p => p.device == 0).ToList();

            foreach (var dsp in dsp1)
            {
                dsp.dsp_vol_em = t1;
            }
            gl._BaseData.dsp_vol_em = t1;
            gl.XMLSimplePA(false);
            gl.XMLDanteDevice(false);
            msg pkt = new msg("V", "0", "V", "2", "");
            //g.mainWindow.s1.Send(pkt.pkt);
        }

        private void cboType6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int t1 = cboType6.SelectedIndex + 1;
            gl._BaseData.Jigsangbalhwa = t1;
        }

        private void _btnMake_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (MessageBox.Show("R형 수신기에 적용된 동, 층, 계단을 등록합니다.(최초 1회). 적용하시겠습니까?", "적용", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;

            int d1 = int.Parse(txt21.Text) +1;
            int k1 = int.Parse(txt22.Text) +1;
            int f1 = int.Parse(txt23.Text) +1;

            g._emList.child.Clear();
            if (g._emList.child.Count == 0)
            {
                for (int d = 1; d < d1; d++)
                {
                    for (int k = 0; k < k1; k++)
                    {
                        for (int f = 0; f < f1; f++)
                        {
                            EM_Data t1 = new EM_Data();
                            t1.AA = d.ToString("D2");
                            t1.BB = k.ToString("D2");
                            t1.CC = f.ToString("D2");
                            t1.CMD = "F";
                            g._emList.child.Add(t1);
                        }
                    }
                }
            }
            */
        }
    }

}
