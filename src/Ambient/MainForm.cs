using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Ambient.States;
using Ambient.States.PlayerStates;

namespace Ambient
{
    public partial class MainForm : Form
    {
        private OpenFileDialog m_OpenFileDialog;
        private SaveFileDialog m_SaveFileDialog;

        public MainForm()
        {
            InitializeComponent();

            SetupEvents();
            SetupDialogs();
        }

        private void SetupEvents()
        {
            KeyDown += MainForm_KeyDown;
            saveStateToolStripMenuItem.Click += saveStateToolStripMenuItem_Click;
            loadStateToolStripMenuItem.Click += loadStateToolStripMenuItem_Click;
        }

        private void loadStateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (m_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(m_OpenFileDialog.FileName))
                {
                    var xmlDocument = XDocument.Load(m_OpenFileDialog.FileName);
                    var completeState = StateImporter.GenerateStateXml(xmlDocument);
                    PopulateFromState(completeState);
                }
                else
                { MessageBox.Show(string.Format("Cannot Find File: {0}", m_OpenFileDialog.FileName)); }
            }
        }

        private void saveStateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (m_SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var generateXml = StateExporter.GenerateStateXml(CreateState());
                generateXml.Save(m_SaveFileDialog.FileName);
            }
        }

        private void SetupDialogs()
        {
            m_OpenFileDialog = new OpenFileDialog();
            m_OpenFileDialog.Filter = "*.xml (Saved States)|*.xml;";

            m_SaveFileDialog = new SaveFileDialog();
            m_SaveFileDialog.Filter = "*.xml (Saved State)| *.xml";
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        { Close(); }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.D1: { quickSound1.PerformClick(); } break;
                case Keys.D2: { quickSound2.PerformClick(); } break;
                case Keys.D3: { quickSound3.PerformClick(); } break;
                case Keys.D4: { quickSound4.PerformClick(); } break;
                case Keys.D5: { quickSound5.PerformClick(); } break;
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                m_OpenFileDialog.Dispose();
                m_OpenFileDialog = null;

                m_SaveFileDialog.Dispose();
                m_SaveFileDialog = null;
            }
            base.Dispose(disposing);
        }

        private CompleteState CreateState()
        {
            var completeState = new CompleteState();

            var ambientState1 = new AmbientState();
            ambientState1.Filename = ambientPlayerControl1.SelectedFilename;
            ambientState1.Volume = ambientPlayerControl1.Volume;
            ambientState1.isLooping = ambientPlayerControl1.isLooping;
            completeState.AmbientStates.Add(ambientState1);

            var ambientState2 = new AmbientState();
            ambientState2.Filename = ambientPlayerControl2.SelectedFilename;
            ambientState2.Volume = ambientPlayerControl2.Volume;
            ambientState2.isLooping = ambientPlayerControl2.isLooping;
            completeState.AmbientStates.Add(ambientState2);

            var soundState1 = new IntervalSoundState();
            soundState1.Filename = intervalSoundPlayerControl1.SelectedFilename;
            soundState1.Volume = intervalSoundPlayerControl1.Volume;
            soundState1.Interval = intervalSoundPlayerControl1.Interval;
            completeState.SoundStates.Add(soundState1);

            var soundState2 = new IntervalSoundState();
            soundState2.Filename = intervalSoundPlayerControl2.SelectedFilename;
            soundState2.Volume = intervalSoundPlayerControl2.Volume;
            soundState2.Interval = intervalSoundPlayerControl2.Interval;
            completeState.SoundStates.Add(soundState2);

            var soundState3 = new IntervalSoundState();
            soundState3.Filename = intervalSoundPlayerControl3.SelectedFilename;
            soundState3.Volume = intervalSoundPlayerControl3.Volume;
            soundState3.Interval = intervalSoundPlayerControl3.Interval;
            completeState.SoundStates.Add(soundState3);

            var soundState4 = new IntervalSoundState();
            soundState4.Filename = intervalSoundPlayerControl4.SelectedFilename;
            soundState4.Volume = intervalSoundPlayerControl4.Volume;
            soundState4.Interval = intervalSoundPlayerControl4.Interval;
            completeState.SoundStates.Add(soundState4);

            return completeState;
        }

        private void PopulateFromState(CompleteState state)
        {
            if(state.AmbientStates[0].Filename != string.Empty)
            {
                ambientPlayerControl1.Volume = state.AmbientStates[0].Volume;
                ambientPlayerControl1.LoadFile(state.AmbientStates[0].Filename);
                ambientPlayerControl1.isLooping = state.AmbientStates[0].isLooping;
            }

            if (state.AmbientStates[1].Filename != string.Empty)
            {
                ambientPlayerControl2.Volume = state.AmbientStates[1].Volume;
                ambientPlayerControl2.LoadFile(state.AmbientStates[1].Filename);
                ambientPlayerControl2.isLooping = state.AmbientStates[1].isLooping;
            }

            if (state.SoundStates[0].Filename != string.Empty)
            {
                intervalSoundPlayerControl1.Volume = state.SoundStates[0].Volume;
                intervalSoundPlayerControl1.Interval = state.SoundStates[0].Interval;
                intervalSoundPlayerControl1.LoadFile(state.SoundStates[0].Filename);
            }

            if (state.SoundStates[1].Filename != string.Empty)
            {
                intervalSoundPlayerControl2.Volume = state.SoundStates[1].Volume;
                intervalSoundPlayerControl2.Interval = state.SoundStates[1].Interval;
                intervalSoundPlayerControl2.LoadFile(state.SoundStates[1].Filename);
            }

            if (state.SoundStates[2].Filename != string.Empty)
            {
                intervalSoundPlayerControl3.Volume = state.SoundStates[2].Volume;
                intervalSoundPlayerControl3.Interval = state.SoundStates[2].Interval;
                intervalSoundPlayerControl3.LoadFile(state.SoundStates[2].Filename);
            }

            if (state.SoundStates[3].Filename != string.Empty)
            {
                intervalSoundPlayerControl4.Volume = state.SoundStates[3].Volume;
                intervalSoundPlayerControl4.Interval = state.SoundStates[3].Interval;
                intervalSoundPlayerControl4.LoadFile(state.SoundStates[3].Filename);
            }
        }
    }
}