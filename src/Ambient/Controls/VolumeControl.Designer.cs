namespace Ambient.Controls
{
    partial class VolumeControl
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
            this.InternalBar = new ProgressODoom.ProgressBarEx();
            this.backgroundPainter = new ProgressODoom.FruityLoopsBackgroundPainter();
            this.borderPainter = new ProgressODoom.PlainBorderPainter();
            this.progressPainter = new ProgressODoom.FruityLoopsProgressPainter();
            this.SuspendLayout();
            // 
            // InternalBar
            // 
            this.InternalBar.BackgroundPainter = this.backgroundPainter;
            this.InternalBar.BorderPainter = this.borderPainter;
            this.InternalBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InternalBar.Location = new System.Drawing.Point(0, 0);
            this.InternalBar.MarqueePercentage = 25;
            this.InternalBar.MarqueeSpeed = 30;
            this.InternalBar.MarqueeStep = 1;
            this.InternalBar.Maximum = 100;
            this.InternalBar.Minimum = 0;
            this.InternalBar.Name = "InternalBar";
            this.InternalBar.ProgressPadding = 0;
            this.InternalBar.ProgressPainter = this.progressPainter;
            this.InternalBar.ProgressType = ProgressODoom.ProgressType.Smooth;
            this.InternalBar.ShowPercentage = false;
            this.InternalBar.Size = new System.Drawing.Size(150, 19);
            this.InternalBar.TabIndex = 0;
            this.InternalBar.Value = 50;
            // 
            // backgroundPainter
            // 
            this.backgroundPainter.FruityType = ProgressODoom.FruityLoopsProgressPainter.FruityLoopsProgressType.DoubleLayer;
            this.backgroundPainter.GlossPainter = null;
            // 
            // borderPainter
            // 
            this.borderPainter.Color = System.Drawing.Color.Black;
            this.borderPainter.RoundedCorners = true;
            this.borderPainter.Style = ProgressODoom.PlainBorderPainter.PlainBorderStyle.Flat;
            // 
            // progressPainter
            // 
            this.progressPainter.FruityType = ProgressODoom.FruityLoopsProgressPainter.FruityLoopsProgressType.DoubleLayer;
            this.progressPainter.GlossPainter = null;
            this.progressPainter.ProgressBorderPainter = this.borderPainter;
            // 
            // VolumeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InternalBar);
            this.Name = "VolumeControl";
            this.Size = new System.Drawing.Size(150, 19);
            this.ResumeLayout(false);

        }

        #endregion

        public ProgressODoom.ProgressBarEx InternalBar;
        public ProgressODoom.FruityLoopsBackgroundPainter backgroundPainter;
        public ProgressODoom.PlainBorderPainter borderPainter;
        public ProgressODoom.FruityLoopsProgressPainter progressPainter;

    }
}