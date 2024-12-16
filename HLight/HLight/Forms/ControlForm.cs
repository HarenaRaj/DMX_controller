using HLight.Enums;
using HLight.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HLight
{
    public partial class ControlForm : MetroFramework.Forms.MetroForm
    {
        private List<Led> Leds = new List<Led>()
        {
            new Led() {
                Id = 1,
                ChannelBegin = 1,
                Name = "Par Led LPC007H",
                NumberChannel = 7,
                Type = LedType.LPC007H,
                Channels = new List<Channel>()
                {
                    new Channel() {Id = 1, ChannelNumber = 1, Type = ChannelType.Dimmer},
                    new Channel() {Id = 2, ChannelNumber = 2, Type = ChannelType.Red},
                    new Channel() {Id = 3, ChannelNumber = 3, Type = ChannelType.Green},
                    new Channel() {Id = 4, ChannelNumber = 4, Type = ChannelType.Blue},
                    new Channel() {Id = 5, ChannelNumber = 5, Type = ChannelType.Strobe},
                    new Channel() {Id = 6, ChannelNumber = 6, Type = ChannelType.SetProgram},
                    new Channel() {Id = 7, ChannelNumber = 7, Type = ChannelType.Speed},
                }
            },
            new Led() {
                Id = 2,
                ChannelBegin = 1,
                Name = "Par Led LPC007",
                NumberChannel = 7,
                Type = LedType.LPC007,
                Channels = new List<Channel>()
                {
                    new Channel() {Id = 1, ChannelNumber = 1, Type = ChannelType.Dimmer},
                    new Channel() {Id = 2, ChannelNumber = 2, Type = ChannelType.Red},
                    new Channel() {Id = 3, ChannelNumber = 3, Type = ChannelType.Green},
                    new Channel() {Id = 4, ChannelNumber = 4, Type = ChannelType.Blue},
                    new Channel() {Id = 5, ChannelNumber = 5, Type = ChannelType.Strobe},
                    new Channel() {Id = 6, ChannelNumber = 6, Type = ChannelType.SetProgram},
                    new Channel() {Id = 7, ChannelNumber = 7, Type = ChannelType.Speed},
                }
            }
        };
        public ControlForm()
        {
            InitializeComponent();
            foreach (var led in Leds)
            {
                var lebBox = new HLedControl(led, false);
                lebBox.Name = led.Name;
                lebBox.Size = new Size(80, 120);
                lebBox.Cursor = Cursors.Hand;
                lebBox.Click += new System.EventHandler(this.ledBox_Click);
                this.LedPanel.Controls.Add(lebBox);
            }
        }

        private void ledBox_Click(object sender, System.EventArgs e)
        {
            var ledControl = (HLedControl) sender;
            var controlCount = this.EnvironmentPanel.Controls.Count;
            var existLedControls = this.EnvironmentPanel.Controls.OfType<HLedControl>().Where(x => x.Led.Type == ledControl.Led.Type);
            var newLed = new Led()
            {
                ChannelBegin = ledControl.Led.ChannelBegin,
                Name = $"{ledControl.Led.Name} {existLedControls.Count() + 1}",
                NumberChannel = ledControl.Led.NumberChannel,
                Type = ledControl.Led.Type,
                Channels = ledControl.Led.Channels
            };

            var newLedControl = new HLedControl(newLed, true);
            newLedControl.Size = new Size(80, 120);
            newLedControl.Location = new Point(newLedControl.Size.Width * controlCount);
            this.EnvironmentPanel.Controls.Add(newLedControl);
        }
    }
}
