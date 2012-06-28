using System.IO;
using CoreAudio;

namespace Players.NAudio
{
    public class NAudioSoundPlayer : NAudioMusicPlayer, ISoundPlayer
    {
        public NAudioSoundPlayer(FileStream soundStream, WavePlayerType wavePlayerType)
            : base(soundStream, wavePlayerType)
        {
        }
    }
}
