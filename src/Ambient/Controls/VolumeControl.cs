using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ambient.Controls
{
    public partial class VolumeControl : UserControl
    {
        public event EventHandler ValueChanged;

        private bool m_IsMouseDown;

        public int Volume
        {
            get { return InternalBar.Value; }
            set { InternalBar.Value = value; }
        }

        protected int GetValueFromClick(Point clickPosition)
        {
            if (clickPosition.X <= 0) { return 0; }
            if (clickPosition.X >= Size.Width) { return InternalBar.Maximum; }

            float valueToSizeRatio = (float)Size.Width / InternalBar.Maximum;
            return (int)(clickPosition.X / valueToSizeRatio);
        }

        public VolumeControl()
        {
            InitializeComponent();
            SetupEvents();
        }

        private void SetupEvents()
        {
            InternalBar.MouseDown += new MouseEventHandler(InternalBar_MouseDown);
            InternalBar.MouseUp += new MouseEventHandler(InternalBar_MouseUp);
            InternalBar.MouseMove += new MouseEventHandler(InternalBar_MouseMove);
        }

        #region Events

        void InternalBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_IsMouseDown)
            {
                InternalBar.Value = GetValueFromClick(e.Location);
                if (ValueChanged != null)
                { ValueChanged(this, EventArgs.Empty); }
            }
        }

        void InternalBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (m_IsMouseDown)
            {
                if (e.Button == MouseButtons.Left)
                { m_IsMouseDown = false; }
            }
        }

        void InternalBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                InternalBar.Value = GetValueFromClick(e.Location);
                m_IsMouseDown = true;

                if (ValueChanged != null)
                { ValueChanged(this, EventArgs.Empty); }
            }
        }
        #endregion

    }
}