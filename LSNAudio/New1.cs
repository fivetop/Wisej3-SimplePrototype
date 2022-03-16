
public class TestStream : IDisposable
{
private System.Threading.Thread _StreamThread;
private System.IO.Stream _Stream = new System.IO.MemoryStream();
private NAudio.Wave.WaveStream _WaveStream;
private NAudio.Wave.WaveOut _WaveOut;
private NAudio.Wave.SampleProviders.SampleChannel _SampleChannel;
private NAudio.Wave.SampleProviders.MeteringSampleProvider _MeteringSampleProvider;
private const long _ChunkSize = 16384; // Testing (64k=65536, 32k=32768 16k=16384)

public void Dispose()
{
    if (_WaveOut.PlaybackState != NAudio.Wave.PlaybackState.Stopped)
    {
        this.Stop();
    }
    _WaveStream.Close();
    _Stream.Close();
    _WaveStream.Dispose();
    _WaveOut.Dispose();
    _Stream.Dispose();
    _StreamThread.Abort();
    _StreamThread.Join();
    System.Diagnostics.Debug.WriteLine("=> Disposed");
}

public TestStream(string UriString)
{
    _StreamThread = new System.Threading.Thread(delegate(object o)
    {
        System.Net.WebResponse response = System.Net.WebRequest.Create(UriString).GetResponse();
        using (var stream = response.GetResponseStream())
        {
            byte[] buffer = new byte[_ChunkSize];
            int read;
            while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                var pos = _Stream.Position;
                _Stream.Position = _Stream.Length;
                _Stream.Write(buffer, 0, read);
                _Stream.Position = pos;
            }
        }
    });
    _StreamThread.Start();
    System.Diagnostics.Debug.WriteLine("=> Initialized");
}

public void Play()
{
    if (_Stream.Length < _ChunkSize * 5) // What increment should this be?
    {
        System.Diagnostics.Debug.WriteLine("=> Buffering");
        while (_Stream.Length < _ChunkSize * 5)
        { // Pre-buffering some data to allow NAudio to start playing
            System.Threading.Thread.Sleep(1000);
        }
    }
    _Stream.Position = 0;
    _WaveOut = new NAudio.Wave.WaveOut(NAudio.Wave.WaveCallbackInfo.FunctionCallback());
    _WaveStream = new NAudio.Wave.BlockAlignReductionStream(NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(_Stream)));
    _SampleChannel = new NAudio.Wave.SampleProviders.SampleChannel(_WaveStream);
    _SampleChannel.PreVolumeMeter += PreVolumeMeterValues;
    _MeteringSampleProvider = new NAudio.Wave.SampleProviders.MeteringSampleProvider(_SampleChannel);
    _MeteringSampleProvider.StreamVolume += PostVolumeMeterValues;
    _WaveOut.Init(new NAudio.Wave.SampleProviders.SampleToWaveProvider(_MeteringSampleProvider));
    _WaveOut.Play();
    System.Diagnostics.Debug.WriteLine("=> Playing");
}

public void Stop()
{
    _WaveOut.Stop();
    System.Diagnostics.Debug.WriteLine("=> Stopped");
}

public void SetVolume(float Volume)
{
    System.Diagnostics.Debug.WriteLine(String.Format("=> Volume Adjustment set to {0}", Volume));
    _SampleChannel.Volume = Volume;
}

private void PreVolumeMeterValues(object sender, NAudio.Wave.SampleProviders.StreamVolumeEventArgs e)
{
    System.Diagnostics.Debug.WriteLine(String.Format("Pre-Volume: {0} <==> {1}", e.MaxSampleValues[0], e.MaxSampleValues[1]));
}

private void PostVolumeMeterValues(object sender, NAudio.Wave.SampleProviders.StreamVolumeEventArgs e)
{
    System.Diagnostics.Debug.WriteLine(String.Format("Post-Volume: {0} <==> {1}", e.MaxSampleValues[0], e.MaxSampleValues[1]));
}
}