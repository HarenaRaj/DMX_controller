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


        private Led _led;


        public HLedControl()
        {
            InitializeComponent();
            timer.Start();
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
            var d = Led.Channels.Where(x => x.Type == ChannelType.Dimmer).First().Value;
            R = Led.Channels.Where(x => x.Type == ChannelType.Red).First().Value;
            G = Led.Channels.Where(x => x.Type == ChannelType.Green).First().Value;
            B = Led.Channels.Where(x => x.Type == ChannelType.Blue).First().Value;
            ChangeColor(255, R * d / 255, G * d / 255, B * d / 255);
        }
    }
}
