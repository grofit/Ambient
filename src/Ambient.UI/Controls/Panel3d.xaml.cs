using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace Ambient.UI.Controls
{
    /// <summary>
    /// Interaction logic for Panel3d.xaml
    /// </summary>
    public partial class Panel3d : UserControl
    {
        public Transform3DGroup PanelTransformGroup
        {
            get { return InternalTransformGroup; }
            set { InternalTransformGroup = value; }
        }

        public Panel3d()
        {
            InitializeComponent();
        }
    }
}
