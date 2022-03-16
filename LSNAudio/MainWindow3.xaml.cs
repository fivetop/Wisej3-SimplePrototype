using System;
using System.Windows;
using NAudio.Wave.SampleProviders;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using gClass;
using System.Collections.Generic;
using pa;

namespace LSNAudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow3 : Window
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

        SimpleMulti cur_play = null;

        // 시스템에 설정된 버철 사운드 카드 디바이스 번호
        // 시스템마다 다르므로 파일로 관리 
        
        // int[] device = { 0, 4, 1, 9, 10, 8, 6, 7 };

        // my pc
        //int[] device = { 0, 0, -1, -1, 1, -1, 0, 0, 0, 0, 0, 0 };


        public MainWindow3()
        {
            InitializeComponent();
/*
            // 파일저장 및 읽기 
            string str1 = string.Join(",", device);
            if (System.IO.File.Exists("SoundCardini.ini") == false)
            {
                System.IO.File.WriteAllText("SoundCardini.ini", str1);
            }
            string ini = System.IO.File.ReadAllText("SoundCardini.ini");
            string[] card = ini.Split(',');

            for (int i=0; i < 8; i++)
            {
                device[i] = int.Parse(card[i]);
            }
*/
            // 엔진 초기화 
            soundEngine = NAudioEngine.Instance;
            // 스펙트럼 처리 
            spectrumAnalyzer.RegisterSoundPlayer(soundEngine);
            message = RegisterWindowMessage("MultiSound");
            soundEngine.PlaybackStopped += PlaybackStopped;
            ComponentDispatcher.ThreadFilterMessage += ComponentDispatcher_ThreadFilterMessage;
        }

        private void PlaybackStopped(object sender, EventArgs e)
        {
            // 다음 진행 처리 
            playcnt++;
            int musiccnt = m1.Count;

            if (playcnt >= musiccnt)
            {
                string str11 = e1[0];
                IntPtr t2 = new IntPtr(Int16.Parse(str11));
                PostMessage((IntPtr)HWND_BROADCAST, message, t2, new IntPtr(5000)); // 
                Close();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string strid = e1[1];
            int idno = Int32.Parse(strid);
            IntPtr t2 = new IntPtr(idno);

            _State.Text = "다중방송" + e1[0].ToString() + ":" + e1[1].ToString() + ":" + Audiodev.ToString();

            PostMessage((IntPtr) HWND_BROADCAST, message, t2, new IntPtr(1000));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            string str1 = e1[1];
            IntPtr t2 = new IntPtr(Int16.Parse(str1));
            PostMessage((IntPtr)HWND_BROADCAST, message, t2, new IntPtr(5000)); // 
        }


        // wparam 99 lparam 1000 ~ 5000
        // rcv play message  99, 2000
        private void ComponentDispatcher_ThreadFilterMessage(ref MSG msg, ref bool handled)
        {
            if (message != msg.message)
                return;

            long s1 = msg.lParam.ToInt64();

            switch (s1)
            {
                case 2000:
                    //_State.Text = (msg.message.ToString() + ":" + msg.wParam.ToString() + ":" + msg.lParam.ToString());
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
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
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
