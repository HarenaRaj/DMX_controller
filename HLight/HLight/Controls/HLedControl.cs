using HLight.Enums;
using System.Windows.Forms;
using System.Drawing;
using HLight.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HLight
{
    public partial class HLedControl : UserControl
    {
        public Led Led { get; set; }
        public Led OutputLed { get; set; }

        public bool IsSelected { get; set; }

        private int _tempR = 0;
        private int _tempG = 0;
        private int _tempB = 0;


        public HLedControl()
        {
            InitializeComponent();
            timerLed.Start();
            TimerFader.Start();
        }

        public HLedControl(Led led) : this() 
        {
            this.Led = led;
            this.OutputLed = new Led()
            {
                ChannelBegin = led.ChannelBegin,
                Channels = new List<LedChannel>(),
                StoreLed = led.StoreLed,
            };
            foreach (LedChannel channel in led.Channels)
            {
                var newChannel = new LedChannel()
                {
                    ChannelNumber = channel.ChannelNumber,
                    Type = channel.Type,
                    Value = channel.Value
                };
                this.OutputLed.Channels.Add(newChannel);
            }
            this.LebBox.Image = setImageByType(this.Led.StoreLed.Type);
            this.NameLabel.Text = led.Name;
            ChangeChannel(led.ChannelBegin);
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
            var channelD = Led.Channels.Where(x => x.Type == ChannelType.Dimmer).First();
            var channelR = OutputLed.Channels.Where(x => x.Type == ChannelType.Red).First();
            var channelG = OutputLed.Channels.Where(x => x.Type == ChannelType.Green).First();
            var channelB = OutputLed.Channels.Where(x => x.Type == ChannelType.Blue).First();
            if (TimerFader.Interval == 1)
            {
                channelR.Value = _tempR;
                channelG.Value = _tempG;
                channelB.Value = _tempB;
            }

            if (_tempR > channelR.Value) channelR.Value += 15; 
            else if (_tempR == channelR.Value) channelR.Value = _tempR; 
            else channelR.Value -= 15;

            if (_tempG > channelG.Value) channelG.Value += 15; 
            else if (_tempG == channelG.Value) channelG.Value = _tempG; 
            else channelG.Value -= 15;

            if (_tempB > channelB.Value) channelB.Value += 15; 
            else if (_tempR == channelB.Value) channelB.Value = _tempB; 
            else channelB.Value -= 15;

            ChangeColor(255, channelR.Value * channelD.Value / 255, 
                channelG.Value * channelD.Value / 255, 
                channelB.Value * channelD.Value / 255);
        }
    }
}
