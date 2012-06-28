using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ambient.Controls.Players
{
    public partial class PlaceholderControl : UserControl
    {
        private Pen rectanglePen;

        public PlaceholderControl()
        {
            InitializeComponent();
            CreatePen();
            SetStyle(ControlStyles.UserPaint, true);
            
        }

        private void CreatePen()
        {
            rectanglePen = new Pen(Color.Black, 1)
                               {
                                   DashStyle = DashStyle.Dash,
                                   DashCap = DashCap.Round
                               };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var deflatedRect = DisplayRectangle;
            deflatedRect.Inflate(-2, -2);
            e.Graphics.DrawRectangle(rectanglePen, deflatedRect);
        }
    }
}
