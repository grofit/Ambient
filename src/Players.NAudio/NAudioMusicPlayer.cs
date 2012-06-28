using System;
using System.IO;
using CoreAudio;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using PlaybackState=CoreAudio.PlaybackState;

namespace Players.NAudio
{
    public class NAudioMusicPlayer : IMusicPlayer
    {
        protected IWavePlayer m_WaveOut;
        protected BlockAlignReductionStream m_BlockAlignedStream;
        protected WaveStream m_MediaStream, m_ConvertedStream;
        protected WaveChannel32 m_Channel;
        protected WavePlayerType m_WavePlayerType;

        public TimeSpan TotalTime
        {
            get { return m_BlockAlignedStream.TotalTime; }
        }

        public TimeSpan CurrentTime
        {
            get { return m_BlockAlignedStream.CurrentTime; }
            set
            {
                if(value < TotalTime)
                { m_BlockAlignedStream.CurrentTime = value; }   
            }
        }

        public long Position
        {
            get { return m_BlockAlignedStream.Position; }
            set { m_BlockAlignedStream.Position = value; }
        }

        public long Length
        {
            get { return m_BlockAlignedStream.Length; }
        }

        public bool HasEnded
        {
            get { return (Position == Length); }
        }

        public bool IsLooping
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public float Volume
        {
            get { return m_Channel.Volume; }
            set { m_Channel.Volume = value; }
        }

        public PlaybackState PlaybackState
        {
            get { return m_WaveOut.PlaybackState.ToCorePlaybackState(); }
        }

        public void Play()
        {
            if (m_WaveOut.PlaybackState != global::NAudio.Wave.PlaybackState.Playing)
            { m_WaveOut.Play(); }
        }

        public void Pause() { m_WaveOut.Pause(); }

        public void Stop()
        {
            m_WaveOut.Stop();
            Rewind();
        }

        public void Rewind()
        { m_BlockAlignedStream.Position = 0; }

        public void Dispose()
        {
            if (m_Channel != null)
            {
                m_Channel.Dispose();
                m_Channel = null;
            }

            if (m_MediaStream != null)
            { 
                m_MediaStream.Dispose();
                m_MediaStream = null;
            }

            if (m_WaveOut != null)
            {
                m_WaveOut.Stop();
                m_WaveOut.Dispose();
                m_WaveOut = null;
            }

            if (m_ConvertedStream != null)
            {
                m_ConvertedStream.Dispose();
                m_ConvertedStream = null;
            }

            if (m_BlockAlignedStream != null)
            {
                m_BlockAlignedStream.Dispose();
                m_BlockAlignedStream = null;
            }
        }

        public NAudioMusicPlayer(FileStream musicStream, WavePlayerType wavePlayerType)
        {
            m_WavePlayerType = wavePlayerType;
            ProcessStream(musicStream);
        }

        private void ProcessStream(FileStream musicStream)
        {
            m_MediaStream = CreateMediaStream(musicStream);
            m_ConvertedStream = WaveFormatConversionStream.CreatePcmStream(m_MediaStream);
            m_BlockAlignedStream = new BlockAlignReductionStream(m_ConvertedStream);
            m_Channel = new WaveChannel32(m_BlockAlignedStream);

            m_WaveOut = CreateWavePlayer();
            m_WaveOut.Init(m_Channel);

            m_WaveOut.Volume = 1.0f;
            m_Channel.Volume = Volume;
        }

        private WaveStream CreateMediaStream(FileStream fileStream)
        {
            var fileExtension = Path.GetExtension(fileStream.Name).ToLower();

            switch (fileExtension)
            {
                case ".mp3": { return new Mp3FileReader(fileStream.Name); }
                case ".wav": { return new WaveFileReader(fileStream.Name); }
                default: { throw new Exception("Unsupported file"); }
            }
        }

        private IWavePlayer CreateWavePlayer()
        {
            switch(m_WavePlayerType)
            {
                case WavePlayerType.DirectSound: { return new DirectSoundOut(300); }
                case WavePlayerType.WasApi: { return new WasapiOut(AudioClientShareMode.Shared, false, 300); }
                default: { return new WaveOut(WaveCallbackInfo.FunctionCallback()); }
            }
        }
    }
}