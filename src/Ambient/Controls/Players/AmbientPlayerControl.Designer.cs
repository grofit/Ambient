namespace Ambient.Controls.Players
{
    partial class AmbientPlayerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmbientPlayerControl));
            this.backgroundPainter = new ProgressODoom.GradientBackgroundPainter();
            this.borderPainter = new ProgressODoom.PlainBorderPainter();
            this.progressPainter = new ProgressODoom.StripedProgressPainter();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.playerContainer = new System.Windows.Forms.GroupBox();
            this.mainToolbar = new System.Windows.Forms.ToolStrip();
            this.loadFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.playButton = new System.Windows.Forms.ToolStripButton();
            this.pauseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loopButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panningLabel = new System.Windows.Forms.Label();
            this.panSlider = new System.Windows.Forms.TrackBar();
            this.leftPanLabel = new System.Windows.Forms.Label();
            this.rightPanLabel = new System.Windows.Forms.Label();
            this.centerPanLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressBar = new ProgressODoom.ProgressBarEx();
            this.volumeControl = new Ambient.Controls.VolumeControl();
            this.playerContainer.SuspendLayout();
            this.mainToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPainter
            // 
            this.backgroundPainter.BottomColor = System.Drawing.Color.White;
            this.backgroundPainter.GlossPainter = null;
            this.backgroundPainter.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // borderPainter
            // 
            this.borderPainter.Color = System.Drawing.Color.Black;
            this.borderPainter.RoundedCorners = true;
            this.borderPainter.Style = ProgressODoom.PlainBorderPainter.PlainBorderStyle.Flat;
            // 
            // progressPainter
            // 
            this.progressPainter.Animating = false;
            this.progressPainter.AnimationSpeed = 10;
            this.progressPainter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressPainter.GlossPainter = null;
            this.progressPainter.ProgressBorderPainter = this.borderPainter;
            this.progressPainter.StripeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressPainter.StripeSpacing = 1;
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(28, 28);
            this.stopButton.Text = "Stop";
            // 
            // playerContainer
            // 
            this.playerContainer.Controls.Add(this.progressLabel);
            this.playerContainer.Controls.Add(this.progressBar);
            this.playerContainer.Controls.Add(this.centerPanLabel);
            this.playerContainer.Controls.Add(this.rightPanLabel);
            this.playerContainer.Controls.Add(this.leftPanLabel);
            this.playerContainer.Controls.Add(this.panSlider);
            this.playerContainer.Controls.Add(this.panningLabel);
            this.playerContainer.Controls.Add(this.volumeControl);
            this.playerContainer.Controls.Add(this.mainToolbar);
            this.playerContainer.Controls.Add(this.label1);
            this.playerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerContainer.Location = new System.Drawing.Point(0, 0);
            this.playerContainer.Name = "playerContainer";
            this.playerContainer.Size = new System.Drawing.Size(200, 150);
            this.playerContainer.TabIndex = 2;
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
            this.pauseButton,
            this.stopButton,
            this.toolStripSeparator2,
            this.loopButton});
            this.mainToolbar.Location = new System.Drawing.Point(3, 116);
            this.mainToolbar.Name = "mainToolbar";
            this.mainToolbar.Size = new System.Drawing.Size(194, 31);
            this.mainToolbar.TabIndex = 14;
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
            // pauseButton
            // 
            this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(28, 28);
            this.pauseButton.Text = "Pause";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // loopButton
            // 
            this.loopButton.Checked = true;
            this.loopButton.CheckOnClick = true;
            this.loopButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loopButton.Image = global::Ambient.Properties.Resources.loop;
            this.loopButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(28, 28);
            this.loopButton.Text = "Loop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Volume";
            // 
            // panningLabel
            // 
            this.panningLabel.AutoSize = true;
            this.panningLabel.Location = new System.Drawing.Point(6, 40);
            this.panningLabel.Name = "panningLabel";
            this.panningLabel.Size = new System.Drawing.Size(26, 13);
            this.panningLabel.TabIndex = 17;
            this.panningLabel.Text = "Pan";
            // 
            // panSlider
            // 
            this.panSlider.LargeChange = 25;
            this.panSlider.Location = new System.Drawing.Point(60, 38);
            this.panSlider.Maximum = 100;
            this.panSlider.Minimum = -100;
            this.panSlider.Name = "panSlider";
            this.panSlider.Size = new System.Drawing.Size(134, 45);
            this.panSlider.SmallChange = 10;
            this.panSlider.TabIndex = 18;
            this.panSlider.TickFrequency = 100;
            // 
            // leftPanLabel
            // 
            this.leftPanLabel.AutoSize = true;
            this.leftPanLabel.Location = new System.Drawing.Point(62, 66);
            this.leftPanLabel.Name = "leftPanLabel";
            this.leftPanLabel.Size = new System.Drawing.Size(25, 13);
            this.leftPanLabel.TabIndex = 19;
            this.leftPanLabel.Text = "Left";
            // 
            // rightPanLabel
            // 
            this.rightPanLabel.AutoSize = true;
            this.rightPanLabel.Location = new System.Drawing.Point(165, 66);
            this.rightPanLabel.Name = "rightPanLabel";
            this.rightPanLabel.Size = new System.Drawing.Size(32, 13);
            this.rightPanLabel.TabIndex = 20;
            this.rightPanLabel.Text = "Right";
            // 
            // centerPanLabel
            // 
            this.centerPanLabel.AutoSize = true;
            this.centerPanLabel.Location = new System.Drawing.Point(109, 66);
            this.centerPanLabel.Name = "centerPanLabel";
            this.centerPanLabel.Size = new System.Drawing.Size(38, 13);
            this.centerPanLabel.TabIndex = 21;
            this.centerPanLabel.Text = "Center";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(6, 89);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(48, 13);
            this.progressLabel.TabIndex = 23;
            this.progressLabel.Text = "Progress";
            // 
            // progressBar
            // 
            this.progressBar.BackgroundPainter = this.backgroundPainter;
            this.progressBar.BorderPainter = this.borderPainter;
            this.progressBar.Location = new System.Drawing.Point(63, 89);
            this.progressBar.MarqueePercentage = 25;
            this.progressBar.MarqueeSpeed = 10;
            this.progressBar.MarqueeStep = 1;
            this.progressBar.Maximum = 100;
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressPadding = 0;
            this.progressBar.ProgressPainter = this.progressPainter;
            this.progressBar.ProgressType = ProgressODoom.ProgressType.Smooth;
            this.progressBar.ShowPercentage = false;
            this.progressBar.Size = new System.Drawing.Size(134, 21);
            this.progressBar.TabIndex = 22;
            this.progressBar.Value = 0;
            // 
            // volumeControl
            // 
            this.volumeControl.Location = new System.Drawing.Point(60, 15);
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Size = new System.Drawing.Size(134, 17);
            this.volumeControl.TabIndex = 15;
            this.volumeControl.Volume = 100;
            // 
            // AmbientPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playerContainer);
            this.Name = "AmbientPlayerControl";
            this.Size = new System.Drawing.Size(200, 150);
            this.playerContainer.ResumeLayout(false);
            this.playerContainer.PerformLayout();
            this.mainToolbar.ResumeLayout(false);
            this.mainToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressODoom.GradientBackgroundPainter backgroundPainter;
        private ProgressODoom.PlainBorderPainter borderPainter;
        private ProgressODoom.StripedProgressPainter progressPainter;
        protected System.Windows.Forms.ToolStripButton stopButton;
        protected System.Windows.Forms.GroupBox playerContainer;
        protected VolumeControl volumeControl;
        public System.Windows.Forms.ToolStrip mainToolbar;
        protected System.Windows.Forms.ToolStripButton loadFileButton;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton playButton;
        protected System.Windows.Forms.ToolStripButton pauseButton;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton loopButton;
        private System.Windows.Forms.TrackBar panSlider;
        private System.Windows.Forms.Label panningLabel;
        private System.Windows.Forms.Label centerPanLabel;
        private System.Windows.Forms.Label rightPanLabel;
        private System.Windows.Forms.Label leftPanLabel;
        private System.Windows.Forms.Label progressLabel;
        private ProgressODoom.ProgressBarEx progressBar;

    }
}