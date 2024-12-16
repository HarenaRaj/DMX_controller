using HLight.Enums;
using System.Windows.Forms;
using System.Drawing;
using HLight.Models;
using HLight.Forms;

namespace HLight
{
    public partial class HStoreLedControl : UserControl
    {
        public StoreLed Led {
            get
            {
                return _led;
            }
            set {
                _led = value;
            }
        }

        public bool ShowChannel { get; set; }


        private StoreLed _led;


        public HStoreLedControl()
        {
            InitializeComponent();
            
        }

        public HStoreLedControl(StoreLed led) : this() 
        {
            this.Led = led;
            this.LebBox.Image = setImageByType(this.Led.Type);
            this.NameLabel.Text = led.Name;
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

        private void LebBox_Click(object sender, System.EventArgs e)
        {
            
        }

        private void ChannelLabel_Click(object sender, System.EventArgs e)
        {
            LebBox_Click(sender, e);
        }
    }
}
