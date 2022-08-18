using System.Windows;
using System.Windows.Controls;
using pa.classes;
using System.Collections.Generic;
using System.Windows.Input;
using System.Linq;

namespace pa.Windows
{
    using DataClass;
    using gClass;
    using simplepa2;
    using static simplepa2.DataSet1;

    /// <summary>
    /// Interaction logic for IconsWindow.xaml
    /// </summary>
    public partial class SetupWindow : Window
    {
        public List<int> dsp_vol { get; set; } = new List<int>() { };

        public SetupWindow()
        {
            this.DataContext = g._BaseData;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var t1 = g.mainWindow.dBSqlite.Ds1.Device.Where(p => p.device == 2).ToList();
            cboType.ItemsSource = t1;
            cboType.DisplayMemberPath = "DeviceName";
            cboType.SelectedValuePath = "name";
            cboType.SelectedValue = g._BaseData.ServerIP;

            g.mainWindow.dBSqlite.Tam.MusicsTableAdapter.Fill(g.mainWindow.dBSqlite.Ds1.Musics);
            var mt2 = g.mainWindow.dBSqlite.Ds1.Musics.ToList();

            cboType2.ItemsSource = mt2;
            cboType2.DisplayMemberPath = "FileName";
            cboType2.SelectedValuePath = "FileName";
            cboType2.SelectedValue = g._BaseData.EmMusic;

            var t3 = new string[] { "R형 자동 검출", "R형 제조사 10", "R형 제조사 12"};

            cboType1.ItemsSource = t3;
            cboType1.SelectedValue = g._BaseData.Reserved16;

            for (int i = 1; i < 11; i++)
            {
                dsp_vol.Add(i);
            }
            cboType3.ItemsSource = null;
            cboType3.ItemsSource = dsp_vol;
            cboType3.SelectedIndex = (int)(g._BaseData.dsp_vol-1);
            cboType4.ItemsSource = null;
            cboType4.ItemsSource = dsp_vol;
            cboType4.SelectedIndex = (int)(g._BaseData.dsp_vol_em-1);

            var t4 = new string[] { "5층 이하, 연면적 3,000 이하", "5층 이상, 연면적 3,000 이상" };
            cboType6.ItemsSource = null;
            cboType6.ItemsSource = t4;
            cboType6.SelectedIndex = (int)(g._BaseData.Jigsangbalhwa - 1);

            List<string> cl = new List<string>();

            foreach (var n1 in gl.networkCardList)
            {
                cl.Add(n1.NetworkCardNo.ToString() + ":" + n1.NetworkCardmDNS.ToString() + ":" + n1.NetworkCardName);
            }
            _combo2.ItemsSource = cl.ToList();

            var t2 = gl.networkCardList.Find(p => p.NetworkCardName == gl.NetworkCardName); // cl.f .Find(p=>p.in);
            if (t2 == null)
            {
                // 캡처 카드 인덱스 찾기 
                _combo2.SelectedIndex = 0;
                return;
            }
            else
            {
                // 캡처 카드 인덱스 찾기 
                _combo2.SelectedItem = t2.NetworkCardNo.ToString() + ":" + t2.NetworkCardmDNS.ToString() + ":" + t2.NetworkCardName;
            }


        }

        private void cboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeviceRow t1 = (DeviceRow) e.AddedItems[0];
            if (t1 == null)
                return;
            g._BaseData.ServerIP = t1.DeviceName;
        }

        private void cboType2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MusicsRow t1 = (MusicsRow)e.AddedItems[0];
            if (t1 == null)
                return;
            g._BaseData.EmMusic = t1.FileName;

        }

        private void cboType1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string t1 = (string)e.AddedItems[0];
            if (t1 == null)
                return;
            g._BaseData.Reserved16 = t1;

        }

        private void _btn1_Click(object sender, RoutedEventArgs e)
        {
            // 일반방송
            int t1 = cboType3.SelectedIndex + 1;

            if (MessageBox.Show("전체 적용됩니다. 적용하시겠습니까?", "전체적용", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;

            var dsp1 = g.mainWindow._DanteDevice.Where(p => p.device == 0).ToList();

            foreach (var dsp in dsp1)
            {
                dsp.dsp_vol = t1;
            }
            g._BaseData.dsp_vol = t1;
            msg pkt = new msg("V", "0", "V", "1","");
        }

        private void _btn2_Click(object sender, RoutedEventArgs e)
        {
            // 비상방송 
            int t1 = cboType4.SelectedIndex + 1;

            if (MessageBox.Show("전체 적용됩니다. 적용하시겠습니까?", "전체적용", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;
            var dsp1 = g.mainWindow._DanteDevice.Where(p => p.device == 0).ToList();

            foreach (var dsp in dsp1)
            {
                dsp.dsp_vol_em = t1;
            }
            g._BaseData.dsp_vol_em = t1;
            msg pkt = new msg("V", "0", "V", "2", "");
            //g.mainWindow.s1.Send(pkt.pkt);
        }

        private void cboType6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int t1 = cboType6.SelectedIndex + 1;
            g._BaseData.Jigsangbalhwa = t1;
        }

        private void _combo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string t1 = (string)_combo2.SelectedValue;
            var t2 = t1.Split(':');
            string t3 = t2[2];
            if (t3 == "이더넷") return;

            System.IO.File.WriteAllText("NetworkCardName.ini", t1);
            g.Log("Change Network : " + t3);
        }

        private void _btnCancel_Click(object sender, RoutedEventArgs e)
        {
            g.mainWindow.dBSqlite.Tam.SimplepaTableAdapter.Update(g.mainWindow.dBSqlite.Ds1.Simplepa);
            Close();
        }

        private void cboType3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int t1 = cboType3.SelectedIndex + 1;
            g._BaseData.dsp_vol = t1;

        }

        private void cboType4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int t1 = cboType4.SelectedIndex + 1;
            g._BaseData.dsp_vol_em = t1;

        }
    }

}
