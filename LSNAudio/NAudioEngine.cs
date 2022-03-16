// (c) Copyright Jacob Johnston.
// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Threading;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using pa;

namespace LSNAudio
{
    public class NAudioEngine : INotifyPropertyChanged, ISpectrumPlayer, IDisposable
    {
        #region Fields
        private static NAudioEngine instance;

        private readonly DispatcherTimer positionTimer = new DispatcherTimer(DispatcherPriority.ApplicationIdle);

        private readonly int fftDataSize = (int)FFTDataSize.FFT2048;
        private bool disposed;
        private bool canPlay;
        private bool isPlaying;
        private WaveOut waveOutDevice;
        public WaveStream activeStream;
        private WaveChannel32 inputStream;
        private SampleAggregator sampleAggregator;

        private SampleAggregator s1;
        private SampleAggregator s2;

        private WaveStream _WaveStream;
        private WaveOut _WaveOut;
        private SampleChannel _SampleChannel;
        private MeteringSampleProvider _MeteringSampleProvider;

        private Action<float> setVolumeDelegate;

        public EventHandler PostVolumeMeter;
        public EventHandler PlaybackStopped;
        public Object PlayItem;

        private bool inChannelTimerUpdate;
        private double channelLength;
        private double channelPosition;
        private bool inChannelSet;

        #endregion

        #region Singleton Pattern
        public static NAudioEngine Instance
        {
            get
            {
                if (instance == null)
                    instance = new NAudioEngine();
                return instance;
            }
        }

        private NAudioEngine()
        {
            positionTimer.Interval = TimeSpan.FromMilliseconds(50);
            positionTimer.Tick += positionTimer_Tick;

        }

        void positionTimer_Tick(object sender, EventArgs e)
        {
            if (ActiveStream == null) return;
            inChannelTimerUpdate = true;
            ChannelPosition = ((double)ActiveStream.Position / (double)ActiveStream.Length) * ActiveStream.TotalTime.TotalSeconds;
            inChannelTimerUpdate = false;
        }
        public void Dispose()
        {
            Dispose(true);            
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    StopAndCloseStream();
                }
                disposed = true;
            }
        }
        #endregion

        #region ISpectrumPlayer
        public bool GetFFTData(float[] fftDataBuffer)
        {
            sampleAggregator.GetFFTResults(fftDataBuffer);
            return isPlaying;
        }

        public int GetFFTFrequencyIndex(int frequency)
        {
            double maxFrequency;
            if (ActiveStream != null)
                maxFrequency = ActiveStream.WaveFormat.SampleRate / 2.0d;
            else
                maxFrequency = 22050; // Assume a default 44.1 kHz sample rate.
            return (int)((frequency / maxFrequency) * (fftDataSize / 2));
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion

        #region Private Utility Methods
        private void StopAndCloseStream()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (activeStream != null)
            {
                inputStream.Close();
                inputStream = null;
                ActiveStream.Close();
                ActiveStream = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }        
        #endregion

        #region Public Methods
        public void Stop()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            IsPlaying = false;
            CanPlay = true;
        }

        public void Play()
        {
            if (CanPlay)
            {
                waveOutDevice.Play();
                IsPlaying = true;
                CanPlay = false;
            }
        }

        public void setVolume(float v)
        {
            setVolumeDelegate?.Invoke(v);
        }

        public int getSoundCard(string devicename)
        {
            int no = 0;

            if (WaveOut.DeviceCount <= 0) 
                return no;

            for (var deviceId = -1; deviceId < WaveOut.DeviceCount; deviceId++)
            {
                var capabilities = WaveOut.GetCapabilities(deviceId);

                if (capabilities.ProductName.Contains(devicename))
                { 
                    no = deviceId;
                    break;
                }
            }
            return no;
        }

        public void OpenFile(string path, int deviceNum)
        {
            Stop();

            StopAndCloseStream();

            if (System.IO.File.Exists(path))
            {
                try
                {
                    waveOutDevice = new WaveOut() { DesiredLatency = 100 , DeviceNumber = deviceNum};
                    ActiveStream = new Mp3FileReader(path);
                    inputStream = new WaveChannel32(ActiveStream);
                    inputStream.Sample += inputStream_Sample;
                    inputStream.PadWithZeroes = false;

                    var waveChannel = new SampleChannel(inputStream, true);
                    waveChannel.PreVolumeMeter += OnPreVolumeMeter;

                    setVolumeDelegate = vol => waveChannel.Volume = vol;

                    var postVolumeMeter = new MeteringSampleProvider(waveChannel);
                    postVolumeMeter.StreamVolume += OnPostVolumeMeter;

                    waveOutDevice.Init(new SampleToWaveProvider(postVolumeMeter));
                    waveOutDevice.PlaybackStopped += WaveOutDevice_PlaybackStopped;
                    //waveOutDevice.Init(inputStream);

                    CanPlay = true;

                    sampleAggregator = new SampleAggregator(fftDataSize);
                    s1 = new SampleAggregator(fftDataSize);

                }
                catch
                {
                    ActiveStream = null;
                    CanPlay = false;
                }
            }
        }

        public void OpenFile(string path, Object p1, int deviceNum)
        {
            PlayItem = new object();
            PlayItem = p1;

            Stop();

            StopAndCloseStream();            

            if (System.IO.File.Exists(path))
            {
                try
                {
                    waveOutDevice = new WaveOut() { DesiredLatency = 100, DeviceNumber = deviceNum };
                    ActiveStream = new Mp3FileReader(path);
                    inputStream = new WaveChannel32(ActiveStream);
                    inputStream.Sample += inputStream_Sample;
                    inputStream.PadWithZeroes = false;

                    var waveChannel = new SampleChannel(inputStream, true);
                    waveChannel.PreVolumeMeter += OnPreVolumeMeter;

                    setVolumeDelegate = vol => waveChannel.Volume = vol;

                    var postVolumeMeter = new MeteringSampleProvider(waveChannel);
                    postVolumeMeter.StreamVolume += OnPostVolumeMeter;

                    waveOutDevice.Init(new SampleToWaveProvider(postVolumeMeter));
                    waveOutDevice.PlaybackStopped += WaveOutDevice_PlaybackStopped;
                    //waveOutDevice.DeviceNumber = 1;
                    //waveOutDevice.Init(inputStream);
                    CanPlay = true;

                    sampleAggregator = new SampleAggregator(fftDataSize);
                    s1 = new SampleAggregator(fftDataSize);
                    ChannelLength = inputStream.TotalTime.TotalSeconds;

                }
                catch
                {
                    ActiveStream = null;
                    CanPlay = false;
                }
            }
        }

        public void DeviceCombo()
        {
            if (WaveOut.DeviceCount <= 0) 
                return;

            for (var deviceId = -1; deviceId < WaveOut.DeviceCount; deviceId++)
            {
                var capabilities = WaveOut.GetCapabilities(deviceId);
                string dev = ($"Device {deviceId} ({capabilities.ProductName})");

                SoundCard sc = new SoundCard();
                sc.no = 0;
                sc.deviceid = deviceId;
                sc.devicename = capabilities.ProductName;
                sc.dev = dev;

                if (capabilities.ProductName.Contains("DVS Transmit"))
                {
                    if (sc.devicename.Contains("  1")) sc.no = 1;
                    if (sc.devicename.Contains("  3")) sc.no = 2;
                    if (sc.devicename.Contains("  5")) sc.no = 3;
                    if (sc.devicename.Contains("  7")) sc.no = 4;
                    if (sc.devicename.Contains("  9")) sc.no = 5;
                    if (sc.devicename.Contains(" 11")) sc.no = 6;
                    if (sc.devicename.Contains(" 13")) sc.no = 7;
                    if (sc.devicename.Contains(" 15")) sc.no = 8;

                }
                var t1 = g1._SoundCardList.child.FindLast(p=>p.devicename == sc.devicename);

                if (t1 == null)
                {
                    g1._SoundCardList.child.Add(sc);
                    g1.XMLSimpleSoundCard(false);
                    //g1.Log($"Device {sc.no} {deviceId} ({capabilities.ProductName})");
                }
                else
                {
                    if (t1.deviceid != sc.deviceid)
                    { 
                        t1.deviceid = sc.deviceid;
                        g1.XMLSimpleSoundCard(false);
                        //g1.Log($"Device {sc.no} {deviceId} ({capabilities.ProductName})");
                    }
                }
            }
            return;
        }

        private void WaveOutDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            PlaybackStopped?.Invoke(PlayItem, e);
            PlayItem = null;
        }

        void OnPreVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            // we know it is stereo
            //waveformPainter1.AddMax(e.MaxSampleValues[0]);
            //waveformPainter2.AddMax(e.MaxSampleValues[1]);
        }

        void OnPostVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            if (ActiveStream.Length == ActiveStream.Position)
            {
                activeStream.Position = 0;
                Stop(); // waveOutDevice.Stop(); // .PlaybackState = PlaybackState.Stopped;
            }
            PostVolumeMeter?.Invoke(sender, e);
            //s1.Add(e.MaxSampleValues[0], e.MaxSampleValues[1]);
           // we know it is stereo
            //volumeMeter1.Amplitude = e.MaxSampleValues[0];
            //volumeMeter2.Amplitude = e.MaxSampleValues[1];
            //Console.WriteLine("======================"+e.MaxSampleValues[0].ToString() +" : "+ e.MaxSampleValues[1].ToString());
        }



        #endregion

        #region Public Properties
        public WaveStream ActiveStream
        {
            get { return activeStream; }
            protected set
            {
                WaveStream oldValue = activeStream;
                activeStream = value;
                if (oldValue != activeStream)
                    NotifyPropertyChanged("ActiveStream");
            }
        }

        public bool CanPlay
        {
            get { return canPlay; }
            protected set
            {
                bool oldValue = canPlay;
                canPlay = value;
                if (oldValue != canPlay)
                    NotifyPropertyChanged("CanPlay");
            }
        }

        public bool IsPlaying
        {
            get { return isPlaying; }
            protected set
            {
                bool oldValue = isPlaying;
                isPlaying = value;
                if (oldValue != isPlaying)
                    NotifyPropertyChanged("IsPlaying");
                positionTimer.IsEnabled = value;
            }
        }

        public double ChannelLength
        {
            get { return channelLength; }
            protected set
            {
                double oldValue = channelLength;
                channelLength = value;
                if (oldValue != channelLength)
                    NotifyPropertyChanged("ChannelLength");
            }
        }


        public double ChannelPosition
        {
            get { return channelPosition; }
            set
            {
                if (!inChannelSet)
                {
                    inChannelSet = true; // Avoid recursion
                    double oldValue = channelPosition;
                    double position = value; // Math.Max(0, Math.Min(value, ChannelLength));
                    if (!inChannelTimerUpdate && ActiveStream != null)
                        ActiveStream.Position = (long)((position / ActiveStream.TotalTime.TotalSeconds) * ActiveStream.Length);
                    channelPosition = position;
                    if (oldValue != channelPosition)
                        NotifyPropertyChanged("ChannelPosition");
                    inChannelSet = false;
                }
            }
        }
        #endregion

        #region Event Handlers
        private void inputStream_Sample(object sender, SampleEventArgs e)
        {
            if (isPlaying == false)
            {
                //inputStream.Close();
                //inputStream.Position = inputStream.Length;
                //waveOutDevice. .PlaybackStopped(); // .PlaybackState = PlaybackState.Stopped;
                return;
            }
            sampleAggregator.Add(e.Left, e.Right);

            //Console.WriteLine(e.Left.ToString() +":" +e.Left.ToString());
        }

        #endregion
    }
}
