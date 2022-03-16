using System;
using System.Windows;
using NAudio.Wave.SampleProviders;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using gClass;
using pa;

namespace LSNAudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        NAudioEngine m1;
        public string[] e1;

        public delegate void timetick();
        System.Windows.Threading.DispatcherTimer ticks = new System.Windows.Threading.DispatcherTimer();

        public MainWindow2()
        {
            InitializeComponent();
            m1 = NAudioEngine.Instance;
            m1.PlaybackStopped += PlaybackStopped;
        }

        private void PlaybackStopped(object sender, EventArgs e)
        {
            //Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string id = "";
            try
            {
                id = System.IO.File.ReadAllText("preMusic.txt");
            }
            catch (Exception e1)
            {
                id = "";
            }

            m1.DeviceCombo();
            _combo.ItemsSource = g1._SoundCardList.child;

            int s1 = 0;
            if (id != "")
            {
                s1 = int.Parse(id);
                _combo.SelectedIndex = s1; 
            }

            if (s1 < 0)
                s1 = 0;
            string fn = ""; //.ToString(); // e1[1];
            
            for (int i=1; i < e1.Length; i++)
            {
                fn = fn+e1[i]+" ";
            }

            string str2 = gl.appPathServer_music + fn;

            if (!System.IO.File.Exists(str2))
                str2 = gl.appPathServer_music + "띠링.mp3";
            m1.OpenFile(str2, s1-1);

            if (!m1.CanPlay)
            {
                g1.Log("Naudio err : CanPlay = false");
                Close();
                return;
            }

            _sliderTime.Maximum = m1.activeStream.TotalTime.TotalMilliseconds;
            _total.Text = m1.activeStream.TotalTime.ToString("mm':'ss':'ff");
            ticks.Interval = TimeSpan.FromMilliseconds(100);
            ticks.Tick += Ticks_Tick;
            ticks.Start();

            m1.Play();
            FileText.Text = fn;

        }

        private void Ticks_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = m1.activeStream.CurrentTime;
            _sliderTime.Value = timeSpan.TotalMilliseconds;
            _position.Text = timeSpan.ToString("mm':'ss':'ff");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (m1 == null) return;

            m1.DeviceCombo();
            _combo.ItemsSource = g1._SoundCardList.child;

            int s1 = _combo.SelectedIndex;

            string str2 = gl.appPathServer_music + "A Maidens Prayer.mp3";
            FileText.Text = str2;
            if (!System.IO.File.Exists(str2))
                str2 = gl.appPathServer_music + "띠링.mp3";
            m1.OpenFile(str2, s1-1);

            _sliderTime.Maximum = m1.activeStream.TotalTime.TotalMilliseconds;
            _total.Text = m1.activeStream.TotalTime.ToString("mm':'ss':'ff");
            ticks.Interval = TimeSpan.FromMilliseconds(100);
            ticks.Tick += Ticks_Tick;
            ticks.Start();

            m1.Play();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (m1 == null) return;
            m1.Stop();
            m1.Dispose();
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //int SliderValue = (int)_sliderTime.Value;
            //TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            //m1.activeStream.CurrentTime = ts;

        }

        private void _combo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var t1 = e.AddedItems[0];
            if (t1 == null)
                return;
            int reg1 = _combo.SelectedIndex;

            System.IO.File.WriteAllText("preMusic.txt",reg1.ToString());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            m1.Stop();
        }
    }
}
