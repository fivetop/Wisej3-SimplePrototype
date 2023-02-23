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
    public partial class MainWindow : Window
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

        System.Collections.Generic.List<Music> m1 { get; set; } = new System.Collections.Generic.List<Music>();

        private uint message;
        private int playcnt = -1;

        public MainWindow()
        {
            InitializeComponent();
            // 엔진 초기화 
            soundEngine = NAudioEngine.Instance;
            // 스펙트럼 처리 
            spectrumAnalyzer.RegisterSoundPlayer(soundEngine);
            message = RegisterWindowMessage("MultiSound");
            soundEngine.PlaybackStopped += PlaybackStopped;
            ComponentDispatcher.ThreadFilterMessage += ComponentDispatcher_ThreadFilterMessage;
        }

        // 4. 한 음악이 끝나면 다음 음악으로 넘어가기 처리 
        private void PlaybackStopped(object sender, EventArgs e)
        {
            if (stopflag)
            {
                playcnt = 0;
                stopflag = false;
                m1.Clear();
                this.WindowState = WindowState.Minimized;
                soundEngine.Dispose();
                return;
            }
            // 다음 진행 처리 
            playcnt++;
            int musiccnt = m1.Count;

            g1.Log("play count : " + m1.Count.ToString() + " : "+playcnt.ToString());

            if (playcnt >= musiccnt)
            {
                m1.Clear();
                string str11 = e1[0];
                IntPtr t2 = new IntPtr(Audiochno);
                PostMessage((IntPtr)HWND_BROADCAST, message, t2, new IntPtr(5000)); // 
                //Close();
                this.WindowState = WindowState.Minimized;
                soundEngine.Dispose();
                return;
            }
            string fn = m1[playcnt].FileName;
            string str1 = gl.appPathServer_music + fn;

            if (!System.IO.File.Exists(str1))
                str1 = gl.appPathServer_music + "띠링.mp3";
            soundEngine.OpenFile(str1, null, Audiodev);
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
            Audiochno = Int32.Parse(str1);
            IntPtr t2 = new IntPtr(Audiochno);

            if (Audiochno < 5)
            {
                int ch = Audiochno - 1;
                this.Left = 100;
                this.Top = Audiochno * 180;
            }
            else
            {
                int ch = Audiochno - 4;
                this.Left = 420;
                this.Top = ch * 180;
            }

            if (g1._SoundCardList.child.Count < 1)
                _combo.SelectedIndex = -1;
            else if (g1._SoundCardList.child.Count > 7)
            {
                soundCard = g1._SoundCardList.child.Find(p => p.no == Audiochno);
                _combo.SelectedItem = soundCard;
                Audiodev = soundCard.deviceid;
            }
            if (_combo.SelectedIndex == -1)
                Audiodev = 0;

            this.WindowState = WindowState.Minimized;

            string strid = e1[1];
            idno = Int32.Parse(strid);
            statetext();

            if (g1._music.Count() < 1)
            { 
                g1._music = g1.dBSqlite.Dbread<List<Music>>("Musics");
                if (g1._music != null)
                {
                    g1._bstreec = g1.dBSqlite.Dbread<List<BSTreeC>>("BSTreeCs");
                    g1._schdulec = g1.dBSqlite.Dbread<List<SchduleC>>("Schdulecs");
                    string str2 = g1._music.Count().ToString() + " : " + g1._music.Count().ToString();
                    g1.Log("Server music&tree count :" + str2);
                }
                else
                { 
                    g1.Log("Server connect error ");
                }
            }
        }

        private void statetext()
        {
            _State.Text = "다중방송" + Audiochno.ToString() + ":" + idno.ToString() + ":" + Audiodev.ToString();
        }

        private void ReadMulti()
        {
            if (m1.Count > 0)
                return;
            //m1.Clear();
            g1._music = g1.dBSqlite.Dbread<List<Music>>("Musics");
            g1._bstreec = g1.dBSqlite.Dbread<List<BSTreeC>>("BSTreeCs");
            int bstreeid = idno - 100000;
            var t1 = g1._bstreec.Where(p => p.BSTreeId == bstreeid);
            var t3 = g1._music;

            var t2 = from p in t1
                     join p2 in t3 on p.MusicId equals p2.MusicId
                     select new Music
                     {
                         FileName = p2.FileName,
                         FileContent = p2.FileContent,
                         duration = p2.duration,
                     };
            m1 = t2.ToList();
            g1.Log("play count : " + m1.Count.ToString());
        }

        private void ReadMultiSch()
        {
            if (m1.Count > 0)
                return;
            //m1.Clear();
            g1._music = g1.dBSqlite.Dbread<List<Music>>("Musics");
            g1._schdulec = g1.dBSqlite.Dbread<List<SchduleC>>("SchduleCs");
            int bstreeid = idno - 200000;
            var t1 = g1._schdulec.Where(p => p.SchduleId == bstreeid);
            var t3 = g1._music;

            var t2 = from p in t1
                     join p2 in t3 on p.MusicId equals p2.MusicId
                     select new Music
                     {
                         FileName = p2.FileName,
                         FileContent = p2.FileContent,
                         duration = p2.duration,
                     };
            m1 = t2.ToList();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            string str1 = e1[0];
            IntPtr t2 = new IntPtr(Int16.Parse(str1));
            PostMessage((IntPtr)HWND_BROADCAST, message, t2, new IntPtr(5000)); // 
        }

        // 2. 방송 아이디를 받으면 플레이 처리 
        private bool Loadid()
        {
            SoundCard soundCard = null;
            IntPtr t2 = new IntPtr(Audiochno);

            if (idno > 200000)
            {
                ReadMultiSch();
            }
            else
            { 
                ReadMulti();
            }

            if (m1.Count < 1)
            {
                statetext();
                return false;
            }

            playcnt = 0;
            string fn = m1[playcnt].FileName;
            string str2 = gl.appPathServer_music + fn;
            if (!System.IO.File.Exists(str2))
                str2 = gl.appPathServer_music + "띠링.mp3";

            g1.Log("channel :" + t2.ToString() +" : "+ str2);

            try
            {
                soundCard = g1._SoundCardList.child.Find(p => p.no == Audiochno);
                if (soundCard == null)
                    Audiodev = -1;
                else
                    Audiodev = soundEngine.getSoundCard(soundCard.devicename);
            }
            catch (Exception e1)
            {
                Audiodev = -1;
            }

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
            idno = msg.lParam.ToInt32();
            // 중지 인경우 처리 
            if (idno == 1) 
            {
                Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                {
                    stopflag = true;
                    soundEngine.Stop();
                }));
                return;
            }

            if (idno < 100000) return;

            // data error 
            _State.Text = (msg.message.ToString() + ":" + s1.ToString() + ":" + idno.ToString());

            Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
            {
                if (Loadid())
                {
                    stopflag = false;
                    soundEngine.Play();
                    this.WindowState = WindowState.Normal;
                    //GC.Collect();
                    IntPtr t2 = new IntPtr(Audiochno);
                    PostMessage((IntPtr)HWND_BROADCAST, message, t2, new IntPtr(1000));
                }
            }));


            /*
            switch (s1)
            {
                case 2000:
                    int t1 = msg.wParam.ToInt32();
                    Title = t1.ToString();
                    if (t1 == 99)
                    {
                        if (soundEngine == null) return;
                        if (soundEngine.CanPlay)
                        {
                            soundEngine.Play();
                        }
                    }
                    break;
            }
            */
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
