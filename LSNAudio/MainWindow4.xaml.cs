using System;
using System.Windows;
using NAudio.Wave.SampleProviders;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using gClass;
using System.Collections.Generic;
using pa;
using System.Linq;

namespace LSNAudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow4 : Window
    {
        NAudioEngine soundEngine;

        public const uint HWND_BROADCAST = 0xffff;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern uint RegisterWindowMessage(string lpString);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        public string[] e1;

        System.Collections.Generic.List<Music> m1 = new System.Collections.Generic.List<Music>();

        private uint message;
        private int playcnt = -1;

        bool cur_play = false;

        public MainWindow4()
        {
            InitializeComponent();
            // 엔진 초기화 
            soundEngine = NAudioEngine.Instance;
            // 스펙트럼 처리 
            spectrumAnalyzer.RegisterSoundPlayer(soundEngine);
            message = RegisterWindowMessage("MultiSound");
            soundEngine.PlaybackStopped += PlaybackStopped;
            ComponentDispatcher.ThreadFilterMessage += ComponentDispatcher_ThreadFilterMessage;
            g1.dBSqlite.DBInit();

        }

        // 4. 한 음악이 끝나면 다음 음악으로 넘어가기 처리 
        private void PlaybackStopped(object sender, EventArgs e)
        {
            if (stopflag)
            {
                cur_play = false;
                this.WindowState = WindowState.Minimized;
                //soundEngine.Dispose();
                return;
            }
            
            g1.dBSqlite.Tam.SimplepaTableAdapter.Fill(g1.dBSqlite.ds1.Simplepa);
            var _BaseData = g1.dBSqlite.ds1.Simplepa.FirstOrDefault();
            string fn = _BaseData.EmMusic;

            if (!System.IO.File.Exists(fn))
                fn = @"재난위험경보(3분).mp3";

            string str2 = gl.appPathServer_music + fn;
            if (!System.IO.File.Exists(str2))
                str2 = gl.appPathServer_music + "띠링.mp3";

            soundEngine.OpenFile(str2, null, Audiodev);
            soundEngine.Play();
            FileText.Text = fn;
        }

        int Audiochno = 0;
        int Audiodev = 0;

        // 1. 초기 위도우 살때 오디오 채널 셋팅 
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SoundCard soundCard = null;

            g1.XMLSimpleSoundCard(true);

            soundEngine.DeviceCombo();
            _combo.ItemsSource = g1._SoundCardList.child;

            string str1 = e1[0];
            Audiochno = 1;
            IntPtr t2 = new IntPtr(Audiochno);

            this.Left = 100;
            this.Top = 160;

            if (g1._SoundCardList.child.Count < 1)
                _combo.SelectedIndex = -1;
            else if (g1._SoundCardList.child.Count > 7)
            {
                soundCard = g1._SoundCardList.child.Find(p => p.no == 1);
                _combo.SelectedItem = soundCard;
                Audiodev = soundCard.deviceid;
            }
            if (_combo.SelectedIndex == -1)
                Audiodev = 0;

            this.WindowState = WindowState.Minimized;

            string strid = e1[1];
            idno = Int32.Parse(strid);
            statetext();
        }

        private void statetext()
        {
            //_State.Text = "다중방송" + e1[0].ToString() + ":" + e1[1].ToString();
            //_State.Text = "다중방송" + e1[0].ToString() + ":" + e1[1].ToString() + ":" + Audiodev.ToString();
            _State.Text = "비상방송" + Audiochno.ToString() + ":" + idno.ToString() + ":" + Audiodev.ToString();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            IntPtr t2 = new IntPtr(Audiochno);
            PostMessage((IntPtr)HWND_BROADCAST, message, t2, new IntPtr(5000)); // 
        }

        // 2. 방송 아이디를 받으면 플레이 처리 
        private bool Loadid()
        {
            if (cur_play == true) return false;
            cur_play = true;
            SoundCard soundCard = null;
            IntPtr t2 = new IntPtr(Audiochno);

            g1.dBSqlite.Tam.SimplepaTableAdapter.Fill(g1.dBSqlite.ds1.Simplepa);
            var _BaseData = g1.dBSqlite.ds1.Simplepa.FirstOrDefault();
            string fn = _BaseData.EmMusic;

            string str2 = gl.appPathServer_music + fn;
            if (!System.IO.File.Exists(str2))
                str2 = gl.appPathServer_music + "띠링.mp3";

            soundCard = g1._SoundCardList.child.Find(p => p.no == 1);
            Audiodev = soundEngine.getSoundCard(soundCard.devicename);

            soundEngine.OpenFile(str2, Audiodev); // debug
            if (!soundEngine.CanPlay)
            {
                string str11 = e1[0];
                IntPtr t12 = new IntPtr(Int16.Parse(str11));
                PostMessage((IntPtr)HWND_BROADCAST, message, t12, new IntPtr(5000)); // 

                g1.Log("Naudio err : CanPlay = false : " + str11);
                //Close();
                return false;
            }
            statetext();
            Title = _State.Text;
            FileText.Text = fn;

            PostMessage((IntPtr)HWND_BROADCAST, message, t2, new IntPtr(1000));
            return true;
        }


        // wparam 99 lparam 1000 ~ 5000
        // rcv play message  99, 2000

        // 3. 방송 아이디는 서버로 부터 받음 채널번호 : 방송 아이디 
        int idno = 0;
        bool stopflag = false;

        private void ComponentDispatcher_ThreadFilterMessage(ref MSG msg, ref bool handled)
        {
            if (message != msg.message)
                return;
            int s1 = msg.wParam.ToInt32();
            if (s1 != Audiochno)
                return;

            if (soundEngine == null) return;
            int tidno = msg.lParam.ToInt32();
            // 중지 인경우 처리 
            if (tidno == 1) 
            {
                Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                {
                    idno = 1;
                    cur_play = false;
                    stopflag = true;
                    if(soundEngine.IsPlaying)
                        soundEngine.Stop();
                }));
                return;
            }

            if (tidno != 999999) return;

            // data error 
            idno = 999999;
            _State.Text = "비상방송" + ":" + s1.ToString() + ":" + idno.ToString();

            Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
            {
                if (Loadid())
                {
                    stopflag = false;
                    soundEngine.Play();
                    this.WindowState = WindowState.Normal;
                    //GC.Collect();
                }
            }));

        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            return;
            if (soundEngine == null) return;
            if (soundEngine.CanPlay)
                soundEngine.Play();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (soundEngine == null) return;
            soundEngine.Dispose();
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
