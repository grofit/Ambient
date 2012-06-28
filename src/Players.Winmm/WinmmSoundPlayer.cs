using System;
using CoreAudio;

namespace Players.Winmm
{
    public class WinmmSoundPlayer : ISoundPlayer
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public PlaybackState PlaybackState
        {
            get { throw new NotImplementedException(); }
        }

        public float Volume
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Play()
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
    }
}
