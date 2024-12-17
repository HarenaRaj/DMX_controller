using HLight.Enums;
using System.Windows.Forms;
using System.Drawing;
using HLight.Models;
using System;
using System.Linq;

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

        public bool IsSelected { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        private int _tempR = 0;
        private int _tempG = 0;
        private int _tempB = 0;

        private Led _led;


        public HLedControl()
        {
            InitializeComponent();
            timerLed.Start();
            TimerFader.Start();
        }

        public HLedControl(Led led) : this() 
        {
            this.Led = led;
            this.LebBox.Image = setImageByType(this.Led.StoreLed.Type);
            this.NameLabel.Text = led.Name;
            ChangeChannel(1);
        }

        public void ChangeName(string newName)
        {
            this.NameLabel.Text = newName;
            this.Led.Name = newName;
        }

        public void ChangeChannel(int channel)
        {
            this.ChannelLabel.Text = $"{channel.ToString()} - {channel + this.Led.StoreLed.NumberChannel - 1}";
            this.Led.ChannelBegin = channel;
        }

        public void SetSelected(bool isSelected)
        {
            this.IsSelected = isSelected;
            if (isSelected)
            {
                this.BackColor = Color.FromArgb(255, 0, 174, 219);
            }
            else
            {
                this.BackColor = SystemColors.ControlLight;
            }
        }

        public void ChangeColor(int a, int r, int g, int b)
        {
            Bitmap bitmap = new Bitmap(20, 20);
            ledColorBox.Image = bitmap;

            r = r < 0 ? 0 : r > 255 ? 255 : r;
            g = g < 0 ? 0 : g > 255 ? 255 : g;
            b = b < 0 ? 0 : b > 255 ? 255 : b;

            using (Graphics graph = Graphics.FromImage(bitmap))
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(a, r, g, b));
                int diameter = 20;

                graph.FillEllipse(brush, 0, 0, diameter, diameter);
            }

            ledColorBox.Refresh();
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

        private void timer_Tick(object sender, EventArgs e)
        {
            _tempR = Led.Channels.Where(x => x.Type == ChannelType.Red).First().Value;
            _tempG = Led.Channels.Where(x => x.Type == ChannelType.Green).First().Value;
            _tempB = Led.Channels.Where(x => x.Type == ChannelType.Blue).First().Value;
        }

        private void timerFader_Tick(object sender, EventArgs e)
        {
            var d = Led.Channels.Where(x => x.Type == ChannelType.Dimmer).First().Value;
            if (TimerFader.Interval == 1)
            {
                R = _tempR;
                G = _tempG;
                B = _tempB;
            }
            if (_tempR > R) R += 15; else if (_tempR == R) R = _tempR; else R -= 15;
            if (_tempG > G) G += 15; else if (_tempG == G) G = _tempG; else G -= 15;
            if (_tempB > B) B += 15; else if (_tempR == B) B = _tempB; else B -= 15;
            ChangeColor(255, R * d / 255, G * d / 255, B * d / 255);
        }
    }
}
