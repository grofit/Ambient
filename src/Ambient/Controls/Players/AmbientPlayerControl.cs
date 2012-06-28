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
    public partial class AmbientPlayerControl : UserControl, IPlayerControl
    {
        public event EventHandler Playing, Stopped;
        public event EventHandler ClickedPlay, ClickedStop, ClickedPause;
        public event EventHandler VolumeChanged, PanChanged, LoadingFile;

        private IMusicPlayer m_MusicPlayer;
        private Timer m_ProgressTimer;
        protected OpenFileDialog m_OpenFileDialog;

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

        public int Panning
        {
            get { return panSlider.Value; }
            set { panSlider.Value = value; }
        }

        public bool isLooping
        {
            get { return loopButton.Checked; }
            set { loopButton.Checked = value; }
        }

        public AmbientPlayerControl()
        {
            InitializeComponent();

            SetupTimer();
            SetupEvents();
            SetupDialogs();
        }

        private void SetupDialogs()
        {
            m_OpenFileDialog = new OpenFileDialog();
            m_OpenFileDialog.Filter = "*.wav, *.mp3, *.ogg, *.flac | *.wav;*.mp3;*.ogg;*.flac";
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
            pauseButton.Click += pauseButton_Click;
            stopButton.Click += stopButton_Click;
            loopButton.Click += loopButton_Click;
            volumeControl.ValueChanged += volumeBar_ValueChanged;
            panSlider.ValueChanged += panSlider_ValueChanged;
            
            m_ProgressTimer.Elapsed += m_ProgressTimer_Elapsed;
        }

        private void UpdateUI()
        {            
            progressBar.Value = (int)m_MusicPlayer.Position;
            progressBar.Text = string.Format("{0:00}:{1:00}",
                                             m_MusicPlayer.CurrentTime.Minutes,
                                             m_MusicPlayer.CurrentTime.Seconds);
        }

        #region Events

        private void volumeBar_ValueChanged(object sender, EventArgs e)
        {
            if (m_MusicPlayer != null)
            { m_MusicPlayer.Volume = GetConvertedFloatValue(Volume); }

            if (VolumeChanged != null)
            { VolumeChanged(this, EventArgs.Empty); }
        }

        void panSlider_ValueChanged(object sender, EventArgs e)
        {
            if (m_MusicPlayer != null)
            { m_MusicPlayer.Pan = GetConvertedFloatValue(Panning); }

            if (PanChanged != null)
            { PanChanged(this, EventArgs.Empty); }
        }

        private void loopButton_Click(object sender, EventArgs e)
        {
            if (m_MusicPlayer != null)
            { m_MusicPlayer.IsLooping = loopButton.Checked; }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (m_MusicPlayer != null)
            { m_MusicPlayer.Stop(); }

            if (ClickedStop != null)
            { ClickedStop(this, EventArgs.Empty); }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (m_MusicPlayer != null)
            { m_MusicPlayer.Pause(); }

            if (ClickedPause != null)
            { ClickedPause(this, EventArgs.Empty); }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (m_MusicPlayer != null)
            {
                if(m_MusicPlayer.HasEnded)
                { m_MusicPlayer.Rewind(); }
                
                m_MusicPlayer.Play();

                progressBar.Minimum = 0;
                progressBar.Maximum = (int)m_MusicPlayer.Length;
            }

            if (ClickedPlay != null)
            { ClickedPlay(this, EventArgs.Empty); }
        }

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

        private void m_ProgressTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (m_MusicPlayer != null)
            {
                if (InvokeRequired)
                { Invoke(new MethodInvoker(UpdateUI)); }
                else
                { UpdateUI(); }
            }
        }

        #endregion

        public void LoadFile(string file)
        {
            if(File.Exists(file))
            {
                if(m_MusicPlayer != null)
                {
                    m_MusicPlayer.Dispose();
                    m_MusicPlayer = null;
                }

                using(var fileStream = File.OpenRead(file))
                {
                    m_MusicPlayer = new IrrKlangMusicPlayer(file) { Volume = GetConvertedFloatValue(Volume) };
                    playerContainer.Text = string.Format("Ambient Track - [{0}]", 
                                                         Path.GetFileNameWithoutExtension(file));

                    m_OpenFileDialog.FileName = file;
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if(m_MusicPlayer != null)
            {
                m_MusicPlayer.Dispose();
                m_MusicPlayer = null;
            }

            if(m_ProgressTimer != null)
            {
                m_ProgressTimer.Stop();
                m_ProgressTimer.Dispose();
                m_ProgressTimer = null;
            }

            if(m_OpenFileDialog != null)
            {
                m_OpenFileDialog.Dispose();
                m_OpenFileDialog = null;
            }
        }

        protected float GetConvertedFloatValue(int value)
        {
            var absValue = Math.Abs(value);
            var convertedValue = (float)value / 100;
            return (value < 0) ? -convertedValue : convertedValue; 
        }

        public ISoundState GetState()
        {
            var soundState = new AmbientState();
            soundState.ColumnPosition = ColumnPosition;
            soundState.RowPosition = RowPosition;
            soundState.Filename = SelectedFilename;
            soundState.isLooping = isLooping;
            soundState.Volume = Volume;
            return soundState;
        }

        public void PopulateFromState(ISoundState soundState)
        {
            if(!(soundState is AmbientState))
            { throw new Exception(string.Format("Unable to cast [{0}] to AmbientState", soundState.GetType())); }

            var castState = (soundState as AmbientState);

            ColumnPosition = castState.ColumnPosition;
            RowPosition = castState.RowPosition;
            Volume = castState.Volume;
            isLooping = castState.isLooping;
            LoadFile(castState.Filename);
        }
    }
}