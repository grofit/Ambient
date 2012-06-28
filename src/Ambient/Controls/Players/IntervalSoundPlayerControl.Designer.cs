namespace Ambient.Controls.Players
{
    partial class IntervalSoundPlayerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntervalSoundPlayerControl));
            this.countdownBackgroundPainter = new ProgressODoom.PlainBackgroundPainter();
            this.countdownProgressPainter = new ProgressODoom.JavaProgressPainter();
            this.countdownProgressBar = new ProgressODoom.ProgressBarEx();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalControl = new System.Windows.Forms.NumericUpDown();
            this.playerContainer = new System.Windows.Forms.GroupBox();
            this.mainToolbar = new System.Windows.Forms.ToolStrip();
            this.loadFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.playButton = new System.Windows.Forms.ToolStripButton();
            this.resetCountdownButton = new System.Windows.Forms.ToolStripButton();
            this.stopCountdownButton = new System.Windows.Forms.ToolStripButton();
            this.volumeControl = new Ambient.Controls.VolumeControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intervalControl)).BeginInit();
            this.playerContainer.SuspendLayout();
            this.mainToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // countdownBackgroundPainter
            // 
            this.countdownBackgroundPainter.Color = System.Drawing.Color.White;
            this.countdownBackgroundPainter.GlossPainter = null;
            // 
            // countdownProgressPainter
            // 
            this.countdownProgressPainter.Color = System.Drawing.Color.SkyBlue;
            this.countdownProgressPainter.GlossPainter = null;
            this.countdownProgressPainter.ProgressBorderPainter = null;
            // 
            // countdownProgressBar
            // 
            this.countdownProgressBar.BackgroundPainter = this.countdownBackgroundPainter;
            this.countdownProgressBar.Location = new System.Drawing.Point(27, 84);
            this.countdownProgressBar.MarqueePercentage = 25;
            this.countdownProgressBar.MarqueeSpeed = 30;
            this.countdownProgressBar.MarqueeStep = 1;
            this.countdownProgressBar.Maximum = 10000;
            this.countdownProgressBar.Minimum = 0;
            this.countdownProgressBar.Name = "countdownProgressBar";
            this.countdownProgressBar.ProgressPadding = 0;
            this.countdownProgressBar.ProgressPainter = this.countdownProgressPainter;
            this.countdownProgressBar.ProgressType = ProgressODoom.ProgressType.Smooth;
            this.countdownProgressBar.ShowPercentage = false;
            this.countdownProgressBar.Size = new System.Drawing.Size(143, 20);
            this.countdownProgressBar.TabIndex = 26;
            this.countdownProgressBar.Text = "Replay Countdown";
            this.countdownProgressBar.Value = 10000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Seconds";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(7, 47);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(56, 13);
            this.intervalLabel.TabIndex = 27;
            this.intervalLabel.Text = "Play every";
            // 
            // intervalControl
            // 
            this.intervalControl.Location = new System.Drawing.Point(69, 47);
            this.intervalControl.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.intervalControl.Name = "intervalControl";
            this.intervalControl.Size = new System.Drawing.Size(74, 20);
            this.intervalControl.TabIndex = 28;
            this.intervalControl.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // playerContainer
            // 
            this.playerContainer.Controls.Add(this.intervalControl);
            this.playerContainer.Controls.Add(this.countdownProgressBar);
            this.playerContainer.Controls.Add(this.mainToolbar);
            this.playerContainer.Controls.Add(this.volumeControl);
            this.playerContainer.Controls.Add(this.label2);
            this.playerContainer.Controls.Add(this.label1);
            this.playerContainer.Controls.Add(this.intervalLabel);
            this.playerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerContainer.Location = new System.Drawing.Point(0, 0);
            this.playerContainer.Name = "playerContainer";
            this.playerContainer.Size = new System.Drawing.Size(200, 150);
            this.playerContainer.TabIndex = 30;
            this.playerContainer.TabStop = false;
            this.playerContainer.Text = "- No Sound Selected -";
            // 
            // mainToolbar
            // 
            this.mainToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileButton,
            this.toolStripSeparator1,
            this.playButton,
            this.resetCountdownButton,
            this.stopCountdownButton});
            this.mainToolbar.Location = new System.Drawing.Point(3, 116);
            this.mainToolbar.Name = "mainToolbar";
            this.mainToolbar.Size = new System.Drawing.Size(194, 31);
            this.mainToolbar.TabIndex = 30;
            // 
            // loadFileButton
            // 
            this.loadFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadFileButton.Image = ((System.Drawing.Image)(resources.GetObject("loadFileButton.Image")));
            this.loadFileButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(28, 28);
            this.loadFileButton.Text = "Load";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // playButton
            // 
            this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.playButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(28, 28);
            this.playButton.Text = "Play";
            // 
            // resetCountdownButton
            // 
            this.resetCountdownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetCountdownButton.Image = global::Ambient.Properties.Resources.reset_countdown;
            this.resetCountdownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resetCountdownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetCountdownButton.Name = "resetCountdownButton";
            this.resetCountdownButton.Size = new System.Drawing.Size(28, 28);
            this.resetCountdownButton.Text = "Reset countdown";
            // 
            // stopCountdownButton
            // 
            this.stopCountdownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopCountdownButton.Image = global::Ambient.Properties.Resources.stop_countdown;
            this.stopCountdownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stopCountdownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopCountdownButton.Name = "stopCountdownButton";
            this.stopCountdownButton.Size = new System.Drawing.Size(28, 28);
            this.stopCountdownButton.Text = "Stop Countdown";
            // 
            // volumeControl
            // 
            this.volumeControl.Location = new System.Drawing.Point(54, 14);
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Size = new System.Drawing.Size(143, 17);
            this.volumeControl.TabIndex = 22;
            this.volumeControl.Volume = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Volume";
            // 
            // IntervalSoundPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playerContainer);
            this.Name = "IntervalSoundPlayerControl";
            this.Size = new System.Drawing.Size(200, 150);
            ((System.ComponentModel.ISupportInitialize)(this.intervalControl)).EndInit();
            this.playerContainer.ResumeLayout(false);
            this.playerContainer.PerformLayout();
            this.mainToolbar.ResumeLayout(false);
            this.mainToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected VolumeControl volumeControl;
        protected System.Windows.Forms.ToolStripButton loadFileButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton playButton;
        protected System.Windows.Forms.Label label1;
        protected ProgressODoom.PlainBackgroundPainter countdownBackgroundPainter;
        protected ProgressODoom.JavaProgressPainter countdownProgressPainter;
        protected ProgressODoom.ProgressBarEx countdownProgressBar;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label intervalLabel;
        protected System.Windows.Forms.NumericUpDown intervalControl;
        protected System.Windows.Forms.GroupBox playerContainer;
        protected System.Windows.Forms.ToolStrip mainToolbar;
        protected System.Windows.Forms.ToolStripButton resetCountdownButton;
        protected System.Windows.Forms.ToolStripButton stopCountdownButton;
    }
}