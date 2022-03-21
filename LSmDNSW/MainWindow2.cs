using gClass;
using LSmDNS;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using static Wisej.CodeProject.DataSet1;

namespace LSmDNSW
{
    public partial class MainWindow : Window
    {
        //=======================================================================================
        // 선번장 등록 부분 
        //

        private void _btnMake_Click(object sender, RoutedEventArgs e)
        {
            var di1 = new DirectoryInfo(gl.appPathServer_speaker);
            var di2 = new DirectoryInfo(gl.appPathServer_image);

            if (di1.Exists == false)
                di1.Create();
            if (di2.Exists == false)
                di2.Create();

            foreach (var t1 in gl._emspl.child)
            {
                string str2 = di1.FullName + t1.file;
                System.IO.File.Create(str2);
                System.Threading.Thread.Sleep(100);
                string str3 = di2.FullName + t1.array[0] +" "+ t1.array[1] + " 층고유이름";
                System.IO.File.Create(str3);

                dBSqlite.SaveAssets(t1);
            }
            _txtBlock.Text = gl.appPathServer_speaker + gl._emspl.child.Count.ToString() + "개 파일 생성이 완료 되었습니다.";
            gl.XMLEmSpeakerPositionList(false);
        }

        private void _btnFile_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Data Files|*.csv"
            };
            dlg.InitialDirectory = gl.appPathServer;
            if (dlg.ShowDialog() == true)
            {
                txtFileName.Text = dlg.FileName;

                string[] d1 = System.IO.File.ReadAllLines(dlg.FileName, Encoding.GetEncoding(949));

                gl._emspl.child.Clear();
                foreach (var d2 in d1)
                {
                    EmSpeakerPosition em1 = new EmSpeakerPosition();
                    em1.array = d2.Split(',');
                    em1.file = em1.getfile();
                    gl._emspl.child.Add(em1);
                }
                _lvLeft4.ItemsSource = null;
                _lvLeft4.ItemsSource = gl._emspl.child;
                _lvLeft4.Items.Refresh();
            }
        }

        //=====================================================================================
        // 위치 등록 부분 
        //

        public List<string> floor { get; set; } = new List<string>() { };

        #region init 로직
        private void initLeft2()
        {
            if (gl.danteDevice._DanteDevice.Count < 1)
                return;
            dBSqlite.ReadFloor();

            dataGrid4.ItemsSource = null;
            dataGrid4.ItemsSource = dBSqlite.ds1.Assets.ToList();

            //floor = new ObservableCollection<string>() {};
            floor.Clear();
            foreach (var o in dBSqlite.ds1.Floorbases)
            {
                string t1 = "";
                t1 = o.buildingname + "/" + o.floor;
                floor.Add(t1);
            }
            ComboBoxColumn41.ItemsSource = null;
            ComboBoxColumn41.ItemsSource = floor;
        }

        //이미지 폴더에서 가져와 층 디비 생성 
        #endregion


        #region add, edit save 로직, delete 로직
        private void _btnSave_Click(object sender, RoutedEventArgs e)
        {

            if (!saveLeft()) return;
            MakeDeviceFloor();
        }


        private bool saveLeft()
        {
            foreach (Asset mAsset in dataGrid4.Items.SourceCollection)
            {
                if (mAsset.floor == null || mAsset.floor == "")
                    continue;

                var sAsset = dBSqlite.ds1.Assets.FirstOrDefault(p => p.path == mAsset.path);
                if (sAsset != null)
                {
                    var a1 = mAsset.floor.Split('/');
                    var floorInfo = dBSqlite.ds1.Floorbases.FirstOrDefault(p => p.buildingname == a1[0] && p.floor == a1[1]);

                    var floorMap = dBSqlite.ds1.Floormaps.FirstOrDefault(p => p.assetname == sAsset.path);
                    if (floorMap == null)
                    {
                        FloormapsRow nfloormap = dBSqlite.ds1.Floormaps.NewFloormapsRow();
                        nfloormap.assetname = sAsset.path;
                        nfloormap.buildingname = floorInfo.buildingname;
                        nfloormap.floor = floorInfo.floor;
                        nfloormap.content = "Speaker1";
                        nfloormap.filename = floorInfo.filename;
                        nfloormap.floororder = floorInfo.floororder;
                        nfloormap.left = floorInfo.left;
                        nfloormap.top = floorInfo.top;
                        dBSqlite.ds1.Floormaps.Rows.Add(nfloormap);

                        sAsset.floor = nfloormap.buildingname + "/" + nfloormap.floor;
                    }
                    else
                    {
                        floorMap.buildingname = floorInfo.buildingname;
                        floorMap.floor = floorInfo.floor;
                        floorMap.content = "Speaker1";
                        floorMap.filename = floorInfo.filename;
                        floorMap.floororder = floorInfo.floororder;

                        sAsset.floor = floorMap.buildingname + "/" + floorMap.floor;
                    }
                }
            }
            dBSqlite.dm1.AssetsTableAdapter.Update(dBSqlite.ds1.Assets);
            dBSqlite.dm1.FloormapsTableAdapter.Update(dBSqlite.ds1.Floormaps);
            return true;
        }

        // 디바이스 정보에 몇층에 설치 되는지정보를 등록함 
        private void MakeDeviceFloor()
        {
            gl.XMLEmSpeakerPositionList(true);
            gl.XMLDanteDevice(true);
            foreach (var t1 in gl._emspl.child)
            {
                var dv1 = gl.danteDevice._DanteDevice.Find(p => p.DeviceName == t1.DeviceName);
                if (dv1 == null)
                    continue;
                dv1.emData = t1.emData;
                int v1 = int.Parse(t1.array[7]);
                dv1.floor_em = v1; // 층정보 등록 

            }
            gl.XMLDanteDevice(false);
        }

        #endregion

        private void _btnAuto_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("장치명을 보고 해당 층에 자동으로 할당 하시겠습니까?", "자동할당", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
                return;

            foreach (Asset mAsset in dataGrid4.Items.SourceCollection)
            {
                var sAsset = dBSqlite.ds1.Assets.FirstOrDefault(p => p.path == mAsset.path);

                if (sAsset == null)
                    continue;

                var floorInfo = dBSqlite.ds1.Floorbases.FirstOrDefault(p => p.buildingname == mAsset.GroupName);

                if (floorInfo == null)
                    continue;
                var floorMap = dBSqlite.ds1.Floormaps.FirstOrDefault(p => p.assetname == sAsset.path);

                if (floorMap == null)
                {
                    FloormapsRow nfloormap = dBSqlite.ds1.Floormaps.NewFloormapsRow();
                    nfloormap.assetname = sAsset.path;
                    nfloormap.buildingname = floorInfo.buildingname;
                    nfloormap.floor = floorInfo.floor;
                    nfloormap.content = "Speaker1";
                    nfloormap.filename = floorInfo.filename;
                    nfloormap.floororder = floorInfo.floororder;
                    nfloormap.left = floorInfo.left;
                    nfloormap.top = floorInfo.top;
                    dBSqlite.ds1.Floormaps.Rows.Add(nfloormap);

                    sAsset.floor = nfloormap.buildingname + "/" + nfloormap.floor;
                }
                else
                {
                    floorMap.buildingname = floorInfo.buildingname;
                    floorMap.floor = floorInfo.floor;
                    floorMap.content = "Speaker1";
                    floorMap.filename = floorInfo.filename;
                    floorMap.floororder = floorInfo.floororder;

                    sAsset.floor = floorMap.buildingname + "/" + floorMap.floor;
                }
            }
            dBSqlite.dm1.AssetsTableAdapter.Update(dBSqlite.ds1.Assets);
            dBSqlite.dm1.FloormapsTableAdapter.Update(dBSqlite.ds1.Floormaps);
            initLeft2();
        }

        //=====================================================================================
        // 유지보수 부분 
        //

        List<string> ts = new List<string>();
        string oldfile = "";

        private void ReadAssetList()
        {
            // 폴더에서 자동으로 파일 확인후 디비에 등록 처리 
            var directoryInfo = new DirectoryInfo(gl.appPathServer + "Speaker");
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles("*.");

                foreach (var fileInfo in files)
                {
                    var aa = fileInfo.Name.Split(' ');

                    ts.Add(fileInfo.Name);
                }
            }
        }

        private void _btnUpdae_Click(object sender, RoutedEventArgs e)
        {
            string newfile = _txt2.Text;

            var nd = newfile.Split(' ');
            var od = oldfile.Split(' ');

            if (oldfile == newfile)
            {
                MessageBox.Show("파일 이름이 동일 합니다. ", "관리자 전용", MessageBoxButton.OK);
                return;
            }

            if (nd.Count() < 3)
            {
                MessageBox.Show("신규 파일명이 기존 형식과 다릅니다. (스페이스 분리 확인)", "관리자 전용", MessageBoxButton.OK);
                return;
            }

            if (MessageBox.Show("되돌릴수 없습니다. 변경 하시겠습니까?", "관리자 전용", MessageBoxButton.YesNo) == MessageBoxResult.No)
                return;

            string str2 = "";
            // 1. 새로 만들고
            str2 = gl.appPathServer + "Speaker\\" + newfile;
            System.IO.File.Create(str2);
            System.Threading.Thread.Sleep(100);

            // 2. 파일 지우고
            str2 = gl.appPathServer + "Speaker\\" + oldfile;
            System.IO.File.Delete(str2);
            System.Threading.Thread.Sleep(100);

            // 3. 파일변경 처리 
            // DanteDevice.xml
            // FloorTreeList.xml
            // SimpleSpeaker.xml

            gl.XMLDanteDevice(true);
            gl.XMLSimpleSpeaker(true);

            Device tt1 = new Device();
            Asset tt2 = new Asset();

            foreach (var t1 in gl.danteDevice._DanteDevice)
            {
                if (t1.DeviceName == od[3])
                {
                    tt1 = t1;
                    break;
                }
            }
            gl.danteDevice._DanteDevice.Remove(tt1);

            foreach (var t1 in gl._SpeakerList.asset)
            {
                if (t1.DeviceName == od[3])
                {
                    tt2 = t1;
                    break;
                }
            }
            gl._SpeakerList.asset.Remove(tt2);

            foreach (var t1 in dBSqlite.ds1.Floormaps)
            {
                if (t1.assetname == od[3])
                {
                    t1.Delete();
                    break;
                }
            }
            dBSqlite.dm1.FloormapsTableAdapter.Update(dBSqlite.ds1.Floormaps);

            gl.XMLDanteDevice(false);
            gl.XMLSimpleSpeaker(false);

            MessageBox.Show("완료 되었습니다. 장비검색에서 변경된 장치 검색/확인 바랍니다.", "관리자 전용", MessageBoxButton.OK);

            _txt1.Text = "변경 완료";
        }

        private void cboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t1 = e.AddedItems[0];
            if (t1 == null)
                return;
            _txt2.Text = (string)t1;
            oldfile = (string)t1;
        }

        public void StatusContent(string v)
        {
            _Status.Content = v;
        }

        int oldindex = 0;

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t1 = (TabControl)sender;
            if (t1 == null) return;
            if (t1.SelectedIndex == oldindex) return;

            switch (t1.SelectedIndex)
            {
                case 0:
                    StatusContent("초기 스피커 생성시 필요할 경우 사용합니다.");
                    break;
                case 1:
                    StatusContent("앰프/DSP/버철 사운드 카드를 Dante Protocol로 검색 할때 사용합니다.");
                    break;
                case 2:
                    gl.XMLDanteDevice(true);
                    StatusContent("앰프의 위치에 따른 DSP 채널을 지정할 경우 사용합니다.");
                    break;
                case 3:
                    gl.XMLDanteDevice(true);
                    StatusContent("스피커의 변경/유지보수가 필요할 경우 사용합니다.");
                    break;
            }
            oldindex = t1.SelectedIndex;

        }


        //=====================================================================================
        // 채널 조정 
        //


        private void initLeft()
        {
            gl.XMLDanteDevice(true);
            gl.XMLSimpleSpeaker(true);

            MakeSpeakerIP();

            foreach (var t1 in gl.danteDevice._DanteDevice)
            {
                t1.path = gl.sel(t1.DeviceName, t1.chspk);
            }
            var t2 = gl.danteDevice._DanteDevice.FindAll(p => p.device == 0);
            _lv2.ItemsSource = null;
            _lv2.ItemsSource = t2.ToList();
        }

        private static void MakeSpeakerIP()
        {
            foreach (Asset t1 in gl._SpeakerList.asset)
            {
                if (t1.DeviceName == "")
                {
                    t1.state = ""; // "Off-Line";
                    continue;
                }

                if (t1.ch != "1")
                {
                    var t4 = gl.danteDevice._DanteDevice.Find(p => p.name == t1.DeviceName || p.DeviceName == t1.DeviceName);
                    if (t4 == null)
                        continue;
                    var t3 = gl.danteDevice._DanteDevice.Find(p => (p.name == t1.DeviceName || p.DeviceName == t1.DeviceName) && p.chspk == t1.ch);

                    if (t3 == null)
                    {
                        Device t5 = gl.ObjectCopier.Clone(t4);
                        t5.chspk = t1.ch;
                        gl.danteDevice._DanteDevice.Add(t5);
                        gl.XMLDanteDevice(false);
                    }
                }

                var t2 = gl.danteDevice._DanteDevice.Find(p => p.name == t1.DeviceName || p.DeviceName == t1.DeviceName);
                if (t2 != null)
                {
                    t1.state = "On-Line";
                    t1.ip = t2.ip;
                    t1.Device = t2;
                    //AliveChk(t1.ip);
                }
                else
                {
                    t1.state = ""; // "Off-Line";
                }
            }
        }


        private void _btnSet_Click(object sender, RoutedEventArgs e)
        {
            SpeakerAssignDSP();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var t1 = (sender as Button).DataContext as Device;
            if (t1 == null)
                return;
            if (_lv2.SelectedItem == null) return;
            ComboBox a1 = (ComboBox)_lv2.Columns[4].GetCellContent(_lv2.SelectedItem);
            ComboBox a2 = (ComboBox)_lv2.Columns[3].GetCellContent(_lv2.SelectedItem);
            int chno = int.Parse(a1.Text);
            string dspname = a2.Text;
            SpeakerAssignDSP(t1,chno, dspname);
        }

        // DSP 각 채널에 스피커를 할당한다. 
        private static void SpeakerAssignDSP(Device r1, int chno, string dspname)
        {
            // 스피커와 DSP 를 가져온다. 
            int chno2 = chno;
            var src1 = gl.danteDevice._DanteDevice.Find(p => p.DeviceName == r1.DeviceName && p.chspk == r1.chspk);
            var dsp1 = gl.danteDevice._DanteDevice.Find(p => p.DeviceName == dspname);

            if (src1 == null)
                return;
            if (dsp1 == null)
                return;

            if (src1.ip == "")
                return;

            udpc1 = new udpClient();
            udpc1.OnReceiveMessage += Udpc1_OnReceiveMessage;
            udpc1.buf2.Clear();
            udpc1.rcv();

            if (dsp1.dsp_out_ch1.Count < chno)
            {
                chno2 = chno - dsp1.dsp_out_ch1.Count;
            }
            byte[] b1 = g.etc.hexatobyte(dsp1.dsp_out_ch1[chno2 - 1]);

            if (src1.chspk != "1")
            {
                b1[13] = (byte)int.Parse(src1.chspk);
            }
            udpc1.send(src1.ip, 4440, b1);
            Thread.Sleep(3000);
            udpc1.Close();

            src1.dsp_chno = chno;
            src1.dsp_name = dspname;
            src1.ip_dspctrl = dsp1.ip_dspctrl; //추적후 넣기 romee 2021-06-30
            gl.XMLDanteDevice(false);
        }

        private void _btnTest_Click(object sender, RoutedEventArgs e)
        {

        }



        //=====================================================================================
        // 입출력 채널 조정 
        //

        private void _btn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cboType3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string t1 = cboType3.SelectedValue.ToString();    
            var dv1 = gl.danteDevice._DanteDevice.Find(p => p.DeviceName == t1);
            if (dv1 == null)
                return;
            _lv21.ItemsSource = null;
            _lv21.ItemsSource = dv1.DSPChnnels;
        }


    }

}
