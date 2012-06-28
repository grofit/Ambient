
using NAudio.Wave;

namespace Players.NAudio
{
    public static class Extensions
    {
        public static CoreAudio.PlaybackState ToCorePlaybackState(this PlaybackState playbackState)
        {
            switch(playbackState)
            {
                case PlaybackState.Playing: { return CoreAudio.PlaybackState.Playing; }
                case PlaybackState.Paused: { return CoreAudio.PlaybackState.Paused; }
                case PlaybackState.Stopped: { return CoreAudio.PlaybackState.Stopped; }
                default: return CoreAudio.PlaybackState.Idle;
            }
        }

        public static PlaybackState ToNAudioPlaybackState(this CoreAudio.PlaybackState playbackState)
        {
            switch (playbackState)
            {
                case CoreAudio.PlaybackState.Playing: { return PlaybackState.Playing; }
                case CoreAudio.PlaybackState.Paused: { return PlaybackState.Paused; }
                default: return PlaybackState.Stopped;
            }
        }
    }
}
