using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using Ambient.Controls.Players;
using Ambient.States;

namespace Ambient
{
    public partial class MainUI : Form
    {
        public int MaxPlayerRows { get; set; }
        public int MaxPlayerColumns { get; set; }

        private Control contextSourceControl;

        public MainUI()
        {
            InitializeComponent();
            SetupDefaultTableLayout();
            SetupEvents();
            ResetUI();
        }

        private void SetupDefaultTableLayout()
        {
            if (MaxPlayerColumns == 0)
            { MaxPlayerColumns = 3; }

            if(MaxPlayerRows == 0)
            { MaxPlayerRows = 3; }
        }

        private void SetupEvents()
        {
            playerContextMenuStrip.Opening += playerContextMenuStrip_Opening;
            removePlayerToolStripMenuItem.Click += removePlayerToolStripMenuItem_Click;
            ambientPlayerToolStripMenuItem.Click += ambientPlayerToolStripMenuItem_Click;
            intervalSoundPlayerToolStripMenuItem.Click += intervalSoundPlayerToolStripMenuItem_Click;
            randomSoundPlayerToolStripMenuItem.Click += randomSoundPlayerToolStripMenuItem_Click;

            importSoundSetToolStripMenuItem.Click += importSoundSetToolStripMenuItem_Click;
            exportSoundSetToolStripMenuItem.Click += exportSoundSetToolStripMenuItem_Click;

            newSoundSetToolStripMenuItem.Click += (s, e) => ResetUI(); 
            exitToolStripMenuItem.Click += (s, e) => Close();
        }

        private void ResetUI()
        {
            if(tablePanel.Controls.Count > 0)
            { ClearUIControls(); }

            for (int cols = 0; cols < MaxPlayerColumns; cols++)
            {
                for(int rows = 0; rows < MaxPlayerRows; rows++)
                {
                    var placeholder = new PlaceholderControl();
                    placeholder.ContextMenuStrip = playerContextMenuStrip;
                    tablePanel.Controls.Add(placeholder, cols, rows);
                }
            }
        }

        private void ClearUIControls()
        {
            var totalControls = new List<Control>();
            foreach(Control control in tablePanel.Controls)
            { totalControls.Add(control); }

            foreach(var control in totalControls)
            {
                tablePanel.Controls.Remove(control);
                control.Dispose();
            }
            totalControls.Clear();
        }

        public Point GetColumnRowFromControl(Control control)
        {
            if(!tablePanel.Contains(control))
            { throw new Exception("table does not contain control"); }

            var column = tablePanel.GetColumn(control);
            var row = tablePanel.GetRow(control);
            return new Point(column, row);
        }

        void playerContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextSourceControl = playerContextMenuStrip.SourceControl;
            if(playerContextMenuStrip.SourceControl is PlaceholderControl)
            {
                removePlayerToolStripMenuItem.Enabled = false;
                addPlayerToolStripMenuItem.Enabled = true;
            }
            else
            {
                removePlayerToolStripMenuItem.Enabled = true;
                addPlayerToolStripMenuItem.Enabled = false;
            }
        }

        void removePlayerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var columnRow = GetColumnRowFromControl(contextSourceControl);
            tablePanel.Controls.Remove(contextSourceControl);
            
            var placeholder = new PlaceholderControl();
            placeholder.ContextMenuStrip = playerContextMenuStrip;
            tablePanel.Controls.Add(placeholder, columnRow.X, columnRow.Y);
        }

        void randomSoundPlayerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var columnRow = GetColumnRowFromControl(contextSourceControl);
            tablePanel.Controls.Remove(contextSourceControl);
        }

        void intervalSoundPlayerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var columnRow = GetColumnRowFromControl(contextSourceControl);
            tablePanel.Controls.Remove(contextSourceControl);

            var intervalSoundPlayer = new IntervalSoundPlayerControl();
            intervalSoundPlayer.ColumnPosition = columnRow.X;
            intervalSoundPlayer.RowPosition = columnRow.Y;
            intervalSoundPlayer.ContextMenuStrip = playerContextMenuStrip;
            tablePanel.Controls.Add(intervalSoundPlayer, columnRow.X, columnRow.Y);
        }

        void ambientPlayerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var columnRow = GetColumnRowFromControl(contextSourceControl);
            tablePanel.Controls.Remove(contextSourceControl);

            var ambientPlayer = new AmbientPlayerControl();
            ambientPlayer.ColumnPosition = columnRow.X;
            ambientPlayer.RowPosition = columnRow.Y;
            ambientPlayer.ContextMenuStrip = playerContextMenuStrip;
            tablePanel.Controls.Add(ambientPlayer, columnRow.X, columnRow.Y);
        }

        void importSoundSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var document = XDocument.Load(openFileDialog.FileName);
                var completeState = StateImporter.GenerateState(document);
                PopulateFromState(completeState);
            }
        }

        void exportSoundSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tablePanel.Controls.Count > 0)
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var completeState = CreateState();
                    var generatedXml = StateExporter.GenerateStateXml(completeState);
                    generatedXml.Save(saveFileDialog.FileName);
                    MessageBox.Show("Saved Sound State");
                }
            }
        }

        private ICompleteState CreateState()
        {
            var completeState = new CompleteState();
            foreach(var control in tablePanel.Controls)
            {
                if (control is PlaceholderControl) { continue; }

                var soundState = (control as IPlayerControl).GetState();
                completeState.SoundStates.Add(soundState);
            }
            return completeState;
        }

        public void PopulateFromState(ICompleteState completeState)
        {
            if (tablePanel.Controls.Count > 0)
            { ClearUIControls(); }

            foreach(ISoundState state in completeState.SoundStates)
            {
                var control = PlayerControlFactory.GetSoundControl(state);
                tablePanel.Controls.Add(control as Control, control.ColumnPosition, control.RowPosition);
            }

            for(int column = 0; column < MaxPlayerColumns; column++)
            {
                for (int row = 0; row < MaxPlayerRows; row++)
                {
                    if(tablePanel.GetControlFromPosition(column, row) == null)
                    {
                        var placeholder = new PlaceholderControl();
                        placeholder.ContextMenuStrip = playerContextMenuStrip;
                        tablePanel.Controls.Add(placeholder, column, row);
                    }
                }
            }
        }
    }
}
