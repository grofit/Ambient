using System;

namespace CoreAudio
{
    public interface IMusicPlayer : IDisposable
    {
        TimeSpan TotalTime { get;}
        TimeSpan CurrentTime { get; set; }
        long Position { get; set; }
        long Length { get; }
        bool HasEnded { get; }
        bool IsLooping { get; set; }

        float Volume { get; set; }
        float Pan { get; set; }
        PlaybackState PlaybackState { get; }

        void Play();
        void Pause();
        void Stop();
        void Rewind();
    }
}