using System;

namespace CoreAudio
{
    public interface ISoundPlayer : IDisposable
    {
        PlaybackState PlaybackState { get; }
        float Volume { get; set; }
        float Pan { get; set; }

        void Play();
        void Stop();
        void Rewind();
    }
}
