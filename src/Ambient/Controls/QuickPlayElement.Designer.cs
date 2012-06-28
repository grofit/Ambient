namespace Ambient.Controls
{
    partial class QuickPlayElement
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
            this.quickPlayLabel = new System.Windows.Forms.Label();
            this.quickPlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quickPlayLabel
            // 
            this.quickPlayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickPlayLabel.Location = new System.Drawing.Point(42, 0);
            this.quickPlayLabel.Name = "quickPlayLabel";
            this.quickPlayLabel.Size = new System.Drawing.Size(111, 43);
            this.quickPlayLabel.TabIndex = 0;
            this.quickPlayLabel.Text = "No Track Selected";
            this.quickPlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quickPlayButton
            // 
            this.quickPlayButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.quickPlayButton.Image = global::Ambient.Properties.Resources.hotbar;
            this.quickPlayButton.Location = new System.Drawing.Point(0, 0);
            this.quickPlayButton.Name = "quickPlayButton";
            this.quickPlayButton.Size = new System.Drawing.Size(42, 43);
            this.quickPlayButton.TabIndex = 1;
            this.quickPlayButton.Text = "1";
            this.quickPlayButton.UseVisualStyleBackColor = true;
            // 
            // QuickPlayElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quickPlayLabel);
            this.Controls.Add(this.quickPlayButton);
            this.Name = "QuickPlayElement";
            this.Size = new System.Drawing.Size(153, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label quickPlayLabel;
        private System.Windows.Forms.Button quickPlayButton;
    }
}
