using Ambient.Controls.Players;

namespace Ambient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.setupQuickSoundButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quickSound1 = new System.Windows.Forms.ToolStripButton();
            this.quickSound2 = new System.Windows.Forms.ToolStripButton();
            this.quickSound3 = new System.Windows.Forms.ToolStripButton();
            this.quickSound4 = new System.Windows.Forms.ToolStripButton();
            this.quickSound5 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ambientPlayerControl2 = new AmbientPlayerControl();
            this.ambientPlayerControl1 = new AmbientPlayerControl();
            this.intervalSoundPlayerControl4 = new IntervalSoundPlayerControl();
            this.intervalSoundPlayerControl3 = new IntervalSoundPlayerControl();
            this.intervalSoundPlayerControl2 = new IntervalSoundPlayerControl();
            this.intervalSoundPlayerControl1 = new IntervalSoundPlayerControl();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupQuickSoundButton,
            this.toolStripSeparator1,
            this.quickSound1,
            this.quickSound2,
            this.quickSound3,
            this.quickSound4,
            this.quickSound5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 313);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolTip1.SetToolTip(this.toolStrip1, "The quick sound toolbar can be configured to have preloaded \r\nsound for you to fi" +
                    "re off with either clicking the buttons or by\r\npressing the coresponding number " +
                    "on the keyboard.");
            // 
            // setupQuickSoundButton
            // 
            this.setupQuickSoundButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setupQuickSoundButton.Image = global::Ambient.Properties.Resources.settings;
            this.setupQuickSoundButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.setupQuickSoundButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setupQuickSoundButton.Name = "setupQuickSoundButton";
            this.setupQuickSoundButton.Size = new System.Drawing.Size(36, 36);
            this.setupQuickSoundButton.Text = "Setup Quick Sounds";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // quickSound1
            // 
            this.quickSound1.Image = global::Ambient.Properties.Resources.hotbar;
            this.quickSound1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quickSound1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickSound1.Name = "quickSound1";
            this.quickSound1.Size = new System.Drawing.Size(36, 36);
            this.quickSound1.Text = "1";
            this.quickSound1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.quickSound1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.quickSound1.ToolTipText = "Quick Sound 1";
            // 
            // quickSound2
            // 
            this.quickSound2.Image = global::Ambient.Properties.Resources.hotbar;
            this.quickSound2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quickSound2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickSound2.Name = "quickSound2";
            this.quickSound2.Size = new System.Drawing.Size(36, 36);
            this.quickSound2.Text = "2";
            this.quickSound2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // quickSound3
            // 
            this.quickSound3.Image = global::Ambient.Properties.Resources.hotbar;
            this.quickSound3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quickSound3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickSound3.Name = "quickSound3";
            this.quickSound3.Size = new System.Drawing.Size(36, 36);
            this.quickSound3.Text = "3";
            this.quickSound3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // quickSound4
            // 
            this.quickSound4.Image = global::Ambient.Properties.Resources.hotbar;
            this.quickSound4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quickSound4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickSound4.Name = "quickSound4";
            this.quickSound4.Size = new System.Drawing.Size(36, 36);
            this.quickSound4.Text = "4";
            this.quickSound4.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // quickSound5
            // 
            this.quickSound5.Image = global::Ambient.Properties.Resources.hotbar;
            this.quickSound5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quickSound5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickSound5.Name = "quickSound5";
            this.quickSound5.Size = new System.Drawing.Size(36, 36);
            this.quickSound5.Text = "5";
            this.quickSound5.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadStateToolStripMenuItem,
            this.saveStateToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // loadStateToolStripMenuItem
            // 
            this.loadStateToolStripMenuItem.Name = "loadStateToolStripMenuItem";
            this.loadStateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.loadStateToolStripMenuItem.Text = "Load State";
            // 
            // saveStateToolStripMenuItem
            // 
            this.saveStateToolStripMenuItem.Name = "saveStateToolStripMenuItem";
            this.saveStateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveStateToolStripMenuItem.Text = "Save State";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(126, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Additional Information";
            // 
            // ambientPlayerControl2
            // 
            this.ambientPlayerControl2.isLooping = true;
            this.ambientPlayerControl2.Location = new System.Drawing.Point(12, 168);
            this.ambientPlayerControl2.Name = "ambientPlayerControl2";
            this.ambientPlayerControl2.Size = new System.Drawing.Size(258, 129);
            this.ambientPlayerControl2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ambientPlayerControl2, "Ambient tracks are used to give the main backing music ");
            this.ambientPlayerControl2.Volume = 50;
            // 
            // ambientPlayerControl1
            // 
            this.ambientPlayerControl1.isLooping = true;
            this.ambientPlayerControl1.Location = new System.Drawing.Point(12, 32);
            this.ambientPlayerControl1.Name = "ambientPlayerControl1";
            this.ambientPlayerControl1.Size = new System.Drawing.Size(258, 129);
            this.ambientPlayerControl1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.ambientPlayerControl1, "Ambient tracks are used to give the main backing music \r\nalthough can be used for" +
                    " other purposes. There are a total \r\nof 2 ambient tracks available which will be" +
                    " mixed in.");
            this.ambientPlayerControl1.Volume = 50;
            // 
            // intervalSoundPlayerControl4
            // 
            this.intervalSoundPlayerControl4.Interval = 10;
            this.intervalSoundPlayerControl4.Location = new System.Drawing.Point(468, 168);
            this.intervalSoundPlayerControl4.Name = "intervalSoundPlayerControl4";
            this.intervalSoundPlayerControl4.Size = new System.Drawing.Size(186, 129);
            this.intervalSoundPlayerControl4.TabIndex = 9;
            this.intervalSoundPlayerControl4.Volume = 100;
            // 
            // intervalSoundPlayerControl3
            // 
            this.intervalSoundPlayerControl3.Interval = 10;
            this.intervalSoundPlayerControl3.Location = new System.Drawing.Point(276, 168);
            this.intervalSoundPlayerControl3.Name = "intervalSoundPlayerControl3";
            this.intervalSoundPlayerControl3.Size = new System.Drawing.Size(186, 129);
            this.intervalSoundPlayerControl3.TabIndex = 8;
            this.intervalSoundPlayerControl3.Volume = 100;
            // 
            // intervalSoundPlayerControl2
            // 
            this.intervalSoundPlayerControl2.Interval = 10;
            this.intervalSoundPlayerControl2.Location = new System.Drawing.Point(468, 32);
            this.intervalSoundPlayerControl2.Name = "intervalSoundPlayerControl2";
            this.intervalSoundPlayerControl2.Size = new System.Drawing.Size(186, 129);
            this.intervalSoundPlayerControl2.TabIndex = 7;
            this.intervalSoundPlayerControl2.Volume = 100;
            // 
            // intervalSoundPlayerControl1
            // 
            this.intervalSoundPlayerControl1.Interval = 10;
            this.intervalSoundPlayerControl1.Location = new System.Drawing.Point(276, 32);
            this.intervalSoundPlayerControl1.Name = "intervalSoundPlayerControl1";
            this.intervalSoundPlayerControl1.Size = new System.Drawing.Size(186, 129);
            this.intervalSoundPlayerControl1.TabIndex = 6;
            this.intervalSoundPlayerControl1.Volume = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(663, 352);
            this.Controls.Add(this.intervalSoundPlayerControl4);
            this.Controls.Add(this.intervalSoundPlayerControl3);
            this.Controls.Add(this.intervalSoundPlayerControl2);
            this.Controls.Add(this.intervalSoundPlayerControl1);
            this.Controls.Add(this.ambientPlayerControl2);
            this.Controls.Add(this.ambientPlayerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ambient";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton setupQuickSoundButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton quickSound1;
        private System.Windows.Forms.ToolStripButton quickSound2;
        private System.Windows.Forms.ToolStripButton quickSound3;
        private System.Windows.Forms.ToolStripButton quickSound4;
        private System.Windows.Forms.ToolStripButton quickSound5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem loadStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private AmbientPlayerControl ambientPlayerControl1;
        private AmbientPlayerControl ambientPlayerControl2;
        private System.Windows.Forms.ToolTip toolTip1;
        private IntervalSoundPlayerControl intervalSoundPlayerControl1;
        private IntervalSoundPlayerControl intervalSoundPlayerControl2;
        private IntervalSoundPlayerControl intervalSoundPlayerControl3;
        private IntervalSoundPlayerControl intervalSoundPlayerControl4;

    }
}