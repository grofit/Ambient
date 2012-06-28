using System;
using CoreAudio;

namespace Players.Bass.Net
{
    public class BassNetMusicPlayer : IMusicPlayer
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TimeSpan TotalTime
        {
            get { throw new NotImplementedException(); }
        }

        public TimeSpan CurrentTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public long Position
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public long Length
        {
            get { throw new NotImplementedException(); }
        }

        public float Volume
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public PlaybackState PlaybackState
        {
            get { throw new NotImplementedException(); }
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Rewind()
        {
            throw new NotImplementedException();
        }

        public BassNetMusicPlayer(string musicFile)
        {
            ProcessFile(musicStream);
        }

        private void ProcessFile(string musicFile)
        {
            Un4seen.Bass.Bass.
        }
    }
}
