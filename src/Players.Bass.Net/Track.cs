using System;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

namespace Players.Bass.Net
{
    public class Track
    {
        public string Filename { get; private set; }
        public long TrackLength { get; private set; }

        private TAG_INFO m_Tags;
        private int m_Channel;
        private SYNCPROC m_TrackSync;
        private int m_NextTrackSync;
        private long m_NextTrackPos;

        public Track(string filename)
        {
            Filename = filename;
            m_Tags = BassTags.BASS_TAG_GetFromFile(Filename);
            
            if (m_Tags == null)
            { throw new ArgumentException("File not valid!"); }

            CreateStream();
        }

        public override string ToString()
        {
            return String.Format("{0} [{1}]", m_Tags, Utils.FixTimespan(m_Tags.duration, "HHMMSS"));
        }

        private void CreateStream()
        {
            m_Channel = Un4seen.Bass.Bass.BASS_StreamCreateFile(Filename, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_DECODE | BASSFlag.BASS_STREAM_PRESCAN);
            
            if (m_Channel == 0)
            { throw new Exception(string.Format("Unable to create stream from file [{0}]", Filename)); }

            TrackLength = Un4seen.Bass.Bass.BASS_ChannelGetLength(m_Channel);
        }
    }
}
