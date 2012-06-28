namespace Ambient
{
    partial class MainUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambientPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalSoundPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSoundPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.setupQuickSoundButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quickSound1 = new System.Windows.Forms.ToolStripButton();
            this.quickSound2 = new System.Windows.Forms.ToolStripButton();
            this.quickSound3 = new System.Windows.Forms.ToolStripButton();
            this.quickSound4 = new System.Windows.Forms.ToolStripButton();
            this.quickSound5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.newSoundSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.importSoundSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSoundSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.playerContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.AutoSize = true;
            this.tablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel.ColumnCount = 3;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tablePanel.Location = new System.Drawing.Point(0, 49);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 3;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.Size = new System.Drawing.Size(284, 176);
            this.tablePanel.TabIndex = 0;
            // 
            // playerContextMenuStrip
            // 
            this.playerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.toolStripSeparator1,
            this.removePlayerToolStripMenuItem});
            this.playerContextMenuStrip.Name = "playerContextMenuStrip";
            this.playerContextMenuStrip.Size = new System.Drawing.Size(153, 54);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ambientPlayerToolStripMenuItem,
            this.intervalSoundPlayerToolStripMenuItem,
            this.randomSoundPlayerToolStripMenuItem});
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            // 
            // ambientPlayerToolStripMenuItem
            // 
            this.ambientPlayerToolStripMenuItem.Name = "ambientPlayerToolStripMenuItem";
            this.ambientPlayerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ambientPlayerToolStripMenuItem.Text = "Ambient Player";
            // 
            // intervalSoundPlayerToolStripMenuItem
            // 
            this.intervalSoundPlayerToolStripMenuItem.Name = "intervalSoundPlayerToolStripMenuItem";
            this.intervalSoundPlayerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.intervalSoundPlayerToolStripMenuItem.Text = "Interval Sound Player";
            // 
            // randomSoundPlayerToolStripMenuItem
            // 
            this.randomSoundPlayerToolStripMenuItem.Name = "randomSoundPlayerToolStripMenuItem";
            this.randomSoundPlayerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.randomSoundPlayerToolStripMenuItem.Text = "Random Sound Player";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removePlayerToolStripMenuItem.Text = "Remove Player";
            // 
            // generalTooltip
            // 
            this.generalTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSoundSetToolStripMenuItem,
            this.toolStripSeparator3,
            this.importSoundSetToolStripMenuItem,
            this.exportSoundSetToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupQuickSoundButton,
            this.toolStripSeparator2,
            this.quickSound1,
            this.quickSound2,
            this.quickSound3,
            this.quickSound4,
            this.quickSound5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 225);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
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
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(284, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // newSoundSetToolStripMenuItem
            // 
            this.newSoundSetToolStripMenuItem.Name = "newSoundSetToolStripMenuItem";
            this.newSoundSetToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newSoundSetToolStripMenuItem.Text = "New Sound Set";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // importSoundSetToolStripMenuItem
            // 
            this.importSoundSetToolStripMenuItem.Name = "importSoundSetToolStripMenuItem";
            this.importSoundSetToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.importSoundSetToolStripMenuItem.Text = "Import Sound Set";
            // 
            // exportSoundSetToolStripMenuItem
            // 
            this.exportSoundSetToolStripMenuItem.Name = "exportSoundSetToolStripMenuItem";
            this.exportSoundSetToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exportSoundSetToolStripMenuItem.Text = "Export Sound Set";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Sound State Files (*.xml) |*.xml;";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Sound State Files (*.xml) |*.xml;";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.playerContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.ContextMenuStrip playerContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambientPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervalSoundPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomSoundPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolTip generalTooltip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton setupQuickSoundButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton quickSound1;
        private System.Windows.Forms.ToolStripButton quickSound2;
        private System.Windows.Forms.ToolStripButton quickSound3;
        private System.Windows.Forms.ToolStripButton quickSound4;
        private System.Windows.Forms.ToolStripButton quickSound5;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripMenuItem newSoundSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem importSoundSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSoundSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}