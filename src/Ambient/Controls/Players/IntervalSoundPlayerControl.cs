using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using Ambient.States;
using Ambient.States.PlayerStates;
using CoreAudio;
using Players.IrrKlang;
using Timer=System.Timers.Timer;

namespace Ambient.Controls.Players
{
    public partial class IntervalSoundPlayerControl : UserControl, IPlayerControl
    {
        public event EventHandler Playing, Stopped;
        public event EventHandler ClickedPlay;
        public event EventHandler VolumeChanged, IntervalChanged, LoadingFile;

        protected OpenFileDialog m_OpenFileDialog;
        private ISoundPlayer m_SoundPlayer;
        private Timer m_ProgressTimer;
        private DateTime m_LastPlay;

        public string SelectedFilename
        {
            get { return m_OpenFileDialog.FileName; }
        }

        public int ColumnPosition { get; set; }
        public int RowPosition { get; set; }

        public int Volume
        {
            get { return volumeControl.Volume; }
            set { volumeControl.Volume = value; }
        }

        public int Interval
        {
            get { return Convert.ToInt32(intervalControl.Value); }
            set { intervalControl.Value = value; }
        }

        public IntervalSoundPlayerControl()
        {
            InitializeComponent();
            SetupTimer();
            SetupEvents();
            SetupDialogs();
        }

        private void SetupTimer()
        {
            m_ProgressTimer = new Timer();
            m_ProgressTimer.Interval = 100;
            m_ProgressTimer.Start();
        }

        private void SetupEvents()
        {
            loadFileButton.Click += loadFileButton_Click;
            playButton.Click += playButton_Click;
            resetCountdownButton.Click += resetCountdownButton_Click;
            stopCountdownButton.Click += stopCountdownButton_Click;
            
            volumeControl.ValueChanged += volumeBar_ValueChanged;
            intervalControl.ValueChanged += intervalControl_ValueChanged;

            m_ProgressTimer.Elapsed += m_ProgressTimer_Elapsed;
        }

        private void SetupDialogs()
        {
            m_OpenFileDialog = new OpenFileDialog();
            m_OpenFileDialog.Filter = "*.wav, *.mp3, *.ogg, *.flac | *.wav;*.mp3;*.ogg;*.flac";
        }

        #region Events

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            if (m_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(m_OpenFileDialog.FileName))
                {
                    if (LoadingFile != null)
                    { LoadingFile(this, EventArgs.Empty); }
                    LoadFile(SelectedFilename);
                }
                else
                { MessageBox.Show(string.Format("Cannot Find File: {0}", SelectedFilename)); }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            PlaySound();

            if (ClickedPlay != null)
            { ClickedPlay(this, EventArgs.Empty); }
        }

        void stopCountdownButton_Click(object sender, EventArgs e)
        {
            StopCountdown();
        }

        void resetCountdownButton_Click(object sender, EventArgs e)
        {
            if (m_SoundPlayer != null)
            { ResetCountdown(); }
        }

        private void volumeBar_ValueChanged(object sender, EventArgs e)
        {
            if (m_SoundPlayer != null)
            { m_SoundPlayer.Volume = GetConvertedVolume(Volume); }

            if (VolumeChanged != null)
            { VolumeChanged(this, EventArgs.Empty); }
        }

        void intervalControl_ValueChanged(object sender, EventArgs e)
        {
            countdownProgressBar.Maximum = Interval*1000;
            ResetCountdown();

            if(IntervalChanged != null)
            { IntervalChanged(this, EventArgs.Empty); }
        }

        private void m_ProgressTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var elapsedTime = DateTime.Now - m_LastPlay;
            if(elapsedTime.TotalSeconds >= Interval)
            { PlaySound(); }

            UpdateCountdown(elapsedTime);
        }

        #endregion

        public void LoadFile(string file)
        {
            if (File.Exists(file))
            {
                if (m_SoundPlayer != null)
                {
                    m_SoundPlayer.Dispose();
                    m_SoundPlayer = null;
                }

                using (var fileStream = File.OpenRead(file))
                {
                    m_SoundPlayer = new IrrKlangSoundPlayer(file) { Volume = GetConvertedVolume(Volume) };
                    //m_SoundPlayer = new NAudioSoundPlayer(fileStream, WavePlayerType.DirectSound) { Volume = GetConvertedFloatValue(Volume) };

                    var fileName = Path.GetFileNameWithoutExtension(file);
                    if(fileName.Length > 40)
                    {
                        fileName.Remove(41);
                        fileName += "...";
                    }
                    playerContainer.Text = fileName;

                    m_OpenFileDialog.FileName = file;

                    StopCountdown();
                }
            }
        }

        private void PlaySound()
        {
            ResetCountdown();

            if (m_SoundPlayer != null)
            {
                if (m_SoundPlayer.PlaybackState == PlaybackState.Playing)
                { m_SoundPlayer.Stop(); }

                m_SoundPlayer.Play();
            }
        }

        private void UpdateCountdown(TimeSpan elapsedTime)
        {
            if(m_SoundPlayer != null)
            {
                var remainingMilliseconds = (Interval*1000) - elapsedTime.TotalMilliseconds;
                if(remainingMilliseconds < 0)
                { remainingMilliseconds = 0; }
                countdownProgressBar.Value = (int)remainingMilliseconds;
            }
        }

        private void ResetCountdown()
        {
            if(!m_ProgressTimer.Enabled)
            { m_ProgressTimer.Enabled = true; }

            m_LastPlay = DateTime.Now;
        }

        private void StopCountdown()
        {
            countdownProgressBar.Value = countdownProgressBar.Maximum;
            m_ProgressTimer.Enabled = false;
        }

        protected float GetConvertedVolume(int volume)
        {
            if (volume <= 0)
            { return 0.0f; }

            return (float)volume / 100;
        }

        public ISoundState GetState()
        {
            var soundState = new IntervalSoundState();
            soundState.ColumnPosition = ColumnPosition;
            soundState.RowPosition = RowPosition;
            soundState.Filename = SelectedFilename;
            soundState.Interval = Interval;
            soundState.Volume = Volume;
            return soundState;
        }

        public void PopulateFromState(ISoundState soundState)
        {
            if (!(soundState is IntervalSoundState))
            { throw new Exception(string.Format("Unable to cast [{0}] to IntervalSoundState", soundState.GetType())); }

            var castState = (soundState as IntervalSoundState);

            ColumnPosition = castState.ColumnPosition;
            RowPosition = castState.RowPosition;
            Volume = castState.Volume;
            Interval = castState.Interval;
            LoadFile(castState.Filename);
        }
    }
}