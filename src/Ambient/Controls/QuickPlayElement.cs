using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ambient.Controls
{
    public partial class QuickPlayElement : UserControl
    {
        [DefaultValue(1)]
        public int QuickPlayNumber
        {
            get { return Convert.ToInt32(quickPlayButton.Text); }
            set { quickPlayButton.Text = value.ToString(); }
        }

        public QuickPlayElement()
        {
            InitializeComponent();
        }
    }
}
