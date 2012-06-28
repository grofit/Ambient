namespace Ambient
{
    partial class QuickPlayer
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
            this.quickPlayElement5 = new Ambient.Controls.QuickPlayElement();
            this.quickPlayElement4 = new Ambient.Controls.QuickPlayElement();
            this.quickPlayElement3 = new Ambient.Controls.QuickPlayElement();
            this.quickPlayElement2 = new Ambient.Controls.QuickPlayElement();
            this.quickPlayElement1 = new Ambient.Controls.QuickPlayElement();
            this.SuspendLayout();
            // 
            // quickPlayElement5
            // 
            this.quickPlayElement5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickPlayElement5.Dock = System.Windows.Forms.DockStyle.Top;
            this.quickPlayElement5.Location = new System.Drawing.Point(0, 196);
            this.quickPlayElement5.Name = "quickPlayElement5";
            this.quickPlayElement5.QuickPlayNumber = 5;
            this.quickPlayElement5.Size = new System.Drawing.Size(243, 49);
            this.quickPlayElement5.TabIndex = 9;
            // 
            // quickPlayElement4
            // 
            this.quickPlayElement4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickPlayElement4.Dock = System.Windows.Forms.DockStyle.Top;
            this.quickPlayElement4.Location = new System.Drawing.Point(0, 147);
            this.quickPlayElement4.Name = "quickPlayElement4";
            this.quickPlayElement4.QuickPlayNumber = 4;
            this.quickPlayElement4.Size = new System.Drawing.Size(243, 49);
            this.quickPlayElement4.TabIndex = 8;
            // 
            // quickPlayElement3
            // 
            this.quickPlayElement3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickPlayElement3.Dock = System.Windows.Forms.DockStyle.Top;
            this.quickPlayElement3.Location = new System.Drawing.Point(0, 98);
            this.quickPlayElement3.Name = "quickPlayElement3";
            this.quickPlayElement3.QuickPlayNumber = 3;
            this.quickPlayElement3.Size = new System.Drawing.Size(243, 49);
            this.quickPlayElement3.TabIndex = 7;
            // 
            // quickPlayElement2
            // 
            this.quickPlayElement2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickPlayElement2.Dock = System.Windows.Forms.DockStyle.Top;
            this.quickPlayElement2.Location = new System.Drawing.Point(0, 49);
            this.quickPlayElement2.Name = "quickPlayElement2";
            this.quickPlayElement2.QuickPlayNumber = 2;
            this.quickPlayElement2.Size = new System.Drawing.Size(243, 49);
            this.quickPlayElement2.TabIndex = 6;
            // 
            // quickPlayElement1
            // 
            this.quickPlayElement1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickPlayElement1.Dock = System.Windows.Forms.DockStyle.Top;
            this.quickPlayElement1.Location = new System.Drawing.Point(0, 0);
            this.quickPlayElement1.Name = "quickPlayElement1";
            this.quickPlayElement1.Size = new System.Drawing.Size(243, 49);
            this.quickPlayElement1.TabIndex = 5;
            // 
            // QuickPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 245);
            this.Controls.Add(this.quickPlayElement5);
            this.Controls.Add(this.quickPlayElement4);
            this.Controls.Add(this.quickPlayElement3);
            this.Controls.Add(this.quickPlayElement2);
            this.Controls.Add(this.quickPlayElement1);
            this.MaximizeBox = false;
            this.Name = "QuickPlayer";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private Ambient.Controls.QuickPlayElement quickPlayElement1;
        private Ambient.Controls.QuickPlayElement quickPlayElement2;
        private Ambient.Controls.QuickPlayElement quickPlayElement3;
        private Ambient.Controls.QuickPlayElement quickPlayElement4;
        private Ambient.Controls.QuickPlayElement quickPlayElement5;

    }
}