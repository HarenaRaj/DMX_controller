using HLight.Models;
using System.Windows.Forms;

namespace HLight.Forms
{
    public partial class LedControlForm : MetroFramework.Forms.MetroForm
    {
        public Led Led { get; set; }

        public LedControlForm()
        {
            InitializeComponent();
        }

        public LedControlForm(Led led) : this()
        {
            Led = led;

            for (int i = 0; i < Led.Channels.Count; i++)
            {
                var channelBar = new TrackBar();

                channelBar.Location = new System.Drawing.Point(78, 138);
                channelBar.Name = Led.Channels[i].Type.ToString();
                channelBar.Orientation = Orientation.Vertical;
                channelBar.Size = new System.Drawing.Size(69 * i, 319);
                channelBar.TabIndex = 3;
                channelBar.TickStyle = TickStyle.Both;

                this.Controls.Add(channelBar);
            }
        }
    }
}
