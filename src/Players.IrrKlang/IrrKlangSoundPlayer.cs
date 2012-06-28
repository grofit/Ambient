using CoreAudio;
using IrrKlang;

namespace Players.IrrKlang
{
    public class IrrKlangSoundPlayer : ISoundPlayer
    {
        protected static ISoundEngine Engine;
        
        protected ISound m_Sound;
        protected float m_Volume;
        protected float m_Pan;
        protected string m_Filename; 

        static IrrKlangSoundPlayer()
        {
            Engine = new ISoundEngine();
        }

        public IrrKlangSoundPlayer(string Filename)
        {
            m_Filename = Filename;
        }

        public void Dispose()
        {
            if(m_Sound != null)
            {
                m_Sound.Dispose();
                m_Sound = null;
                m_Filename = null;
            }
        }

        public PlaybackState PlaybackState
        {
            get
            {
                if (m_Sound != null)
                {
                    if(m_Sound.Paused) { return PlaybackState.Paused; }
                    if (m_Sound.Finished) { return PlaybackState.Stopped; }
                    return PlaybackState.Playing;
                }

                return PlaybackState.Idle;
            }
        }

        public float Volume
        {
            get { return m_Volume; }
            set
            {
                m_Volume = value;
                if (m_Sound != null)
                { m_Sound.Volume = m_Volume; }
            }
        }

        public float Pan
        {
            get { return m_Pan; }
            set
            {
                m_Pan = value;
                if(m_Sound != null)
                { m_Sound.Pan = m_Pan; }
            }
        }

        public virtual void Play()
        {
            if(m_Sound != null)
            {
                if(m_Sound.Paused)
                {
                    m_Sound.Paused = false;
                    return;
                }

                if(m_Sound.Finished)
                { 
                    m_Sound.Dispose();
                    m_Sound = null;
                }
            }

            if(m_Sound == null)
            {
                m_Sound = Engine.Play2D(m_Filename, false, false);
                m_Sound.Volume = m_Volume;
                m_Sound.Pan = m_Pan;
            }
        }

        public virtual void Stop()
        {
            if (m_Sound != null)
            { m_Sound.Stop(); }
        }

        public virtual void Rewind()
        {
            if(m_Sound != null)
            { m_Sound.PlayPosition = 0; }
        }
    }
}
