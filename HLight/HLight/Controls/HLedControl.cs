using HLight.Enums;
using System.Windows.Forms;
using System.Drawing;
using HLight.Models;

namespace HLight
{
    public partial class HLedControl : UserControl
    {
        public Led Led {
            get
            {
                return _led;
            }
            set {
                _led = value;
            }
        }
        private Led _led;

        public bool ShowChannel { get; set; }


        public HLedControl()
        {
            InitializeComponent();
        }

        public HLedControl(Led led) : this() 
        {
            this.Led = led;
            this.lebBox.Image = setImageByType(this.Led.Type);
            this.NameLabel.Text = led.Name;
        }

        public HLedControl(Led led, bool showChannel) : this(led)
        {
            this.ShowChannel = showChannel;
            if (showChannel)
            {
                this.ChannelLabel.Show();
                this.lebBox.Enabled = true;
            }
            else
            {
                this.ChannelLabel.Hide();
            }
        }

        private Image setImageByType(LedType type)
        {
            switch (type)
            {
                case LedType.LPC007H:
                    return global::HLight.Properties.Resources.lpc007h;
                case LedType.LPC007:
                    return global::HLight.Properties.Resources.lpc007;
                default:
                    return global::HLight.Properties.Resources.lpc007h;
            }
        }

        private void lebBox_Click(object sender, System.EventArgs e)
        {
            
        }

        private void ChannelLabel_Click(object sender, System.EventArgs e)
        {

        }
    }
}
