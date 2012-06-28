
using NAudio.Wave;

namespace Players.NAudio
{
    public class LoopedStream : WaveStream
    {
        private WaveStream m_SourceStream;

        public LoopedStream(WaveStream source)
        {
            m_SourceStream = source;
        }


        public override WaveFormat WaveFormat
        {
            get { return m_SourceStream.WaveFormat; }
        }

        public override long Length
        {
            get { return long.MaxValue / 32; }
        }

        public override long Position
        {
            get { return m_SourceStream.Position; }
            set { m_SourceStream.Position = value; }
        }

        public override bool HasData(int count)
        {
            // infinite loop
            return true;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int read = 0;
            while (read < count)
            {
                int required = count - read;
                int readThisTime = m_SourceStream.Read(buffer, offset + read, required);
                if (readThisTime < required)
                {
                    m_SourceStream.Position = 0;
                }

                if (m_SourceStream.Position >= m_SourceStream.Length)
                {
                    m_SourceStream.Position = 0;
                }
                read += readThisTime;
            }
            return read;
        }

        protected override void Dispose(bool disposing)
        {
            m_SourceStream.Dispose();
            base.Dispose(disposing);
        }
    }
}