using HLight.Enums;
using System;
using System.Windows.Forms;

namespace HLight.Controls
{
    public partial class HTrackBar : UserControl
    {
        public ChannelType Type { get; set; }
        public Guid Id { get; set; }
        public HTrackBar()
        {
            InitializeComponent();
        }
    }
}
