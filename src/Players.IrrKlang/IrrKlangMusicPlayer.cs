using System;
using CoreAudio;

namespace Players.IrrKlang
{
    public class IrrKlangMusicPlayer : IrrKlangSoundPlayer, IMusicPlayer
    {
        private bool m_IsLooping; 

        public IrrKlangMusicPlayer(string Filename) : base(Filename)
        {

        }

        public TimeSpan TotalTime
        {
            get { return new TimeSpan(0,0,0,0, (int)m_Sound.PlayLength); }
        }

        public TimeSpan CurrentTime
        {
            get { return new TimeSpan(0, 0, 0, 0, m_Sound != null ? (int)m_Sound.PlayPosition : 0); }
            set
            {
                if (m_Sound != null)
                {
                    if(value.TotalMilliseconds < m_Sound.PlayLength)
                    {
                        m_Sound.PlayPosition = (uint)value.TotalMilliseconds;
                    }
                }
            }
        }

        public long Position
        {
            get
            {
                if (m_Sound != null)
                {
                    return m_Sound.PlayPosition != uint.MaxValue ? m_Sound.PlayPosition : 0;
                }
                return 0;
            }
            set
            {
                if(m_Sound != null)
                { m_Sound.PlayPosition = (uint)value; }
            }
        }

        public long Length
        {
            get { return m_Sound != null ? m_Sound.PlayLength : 0; }
            set { throw new NotImplementedException("IrrKlang does not support length changes"); }
        }

        public bool HasEnded
        {
            get { return m_Sound != null ? m_Sound.Finished : true; }
        }

        public void Pause()
        {
            if(m_Sound != null)
            { m_Sound.Paused = true; }
        }

        public bool IsLooping
        {
            get { return m_IsLooping; }
            set
            {
                m_IsLooping = value;
                if(m_Sound != null)
                { m_Sound.Looped = m_IsLooping; }
            }
        }

        public override void Play()
        {
            base.Play();

            if(m_Sound != null)
            { m_Sound.Looped = m_IsLooping; }
        }
    }
}
