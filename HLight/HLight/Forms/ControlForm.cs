using HLight.Controls;
using HLight.Enums;
using HLight.Forms;
using HLight.Models;
using HLight.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HLight
{
    public partial class ControlForm : MetroFramework.Forms.MetroForm
    {
        private HChannelControl _channelControl;

        //private List<StoreLed> _storeLeds = new List<StoreLed>()
        //{
        //    new StoreLed() {
        //        Id = 1,
        //        Name = "Par Led LPC007H",
        //        NumberChannel = 7,
        //        Type = LedType.LPC007H,
        //        Channels = new List<StoreLedChannel>()
        //        {
        //            new StoreLedChannel() {Id = 1, ChannelNumber = 1, Type = ChannelType.Dimmer},
        //            new StoreLedChannel() {Id = 2, ChannelNumber = 2, Type = ChannelType.Red},
        //            new StoreLedChannel() {Id = 3, ChannelNumber = 3, Type = ChannelType.Green},
        //            new StoreLedChannel() {Id = 4, ChannelNumber = 4, Type = ChannelType.Blue},
        //            new StoreLedChannel() {Id = 5, ChannelNumber = 5, Type = ChannelType.Strobe},
        //            new StoreLedChannel() {Id = 6, ChannelNumber = 6, Type = ChannelType.SetProgram},
        //            new StoreLedChannel() {Id = 7, ChannelNumber = 7, Type = ChannelType.Speed},
        //        }
        //    },
        //    new StoreLed() {
        //        Id = 2,
        //        Name = "Par Led LPC007",
        //        NumberChannel = 7,
        //        Type = LedType.LPC007,
        //        Channels = new List<StoreLedChannel>()
        //        {
        //            new StoreLedChannel() {Id = 1, ChannelNumber = 1, Type = ChannelType.Dimmer},
        //            new StoreLedChannel() {Id = 2, ChannelNumber = 2, Type = ChannelType.Red},
        //            new StoreLedChannel() {Id = 3, ChannelNumber = 3, Type = ChannelType.Green},
        //            new StoreLedChannel() {Id = 4, ChannelNumber = 4, Type = ChannelType.Blue},
        //            new StoreLedChannel() {Id = 5, ChannelNumber = 5, Type = ChannelType.Strobe},
        //            new StoreLedChannel() {Id = 6, ChannelNumber = 6, Type = ChannelType.SetProgram},
        //            new StoreLedChannel() {Id = 7, ChannelNumber = 7, Type = ChannelType.Speed},
        //        }
        //    }
        //};
        private List<StoreLed> _storeLeds;

        private List<HLedControl> _ledControls = new List<HLedControl>();

        private List<HLedControl> _selectedLedControls = new List<HLedControl>();

        private List<HGroupControl> _groupControls = new List<HGroupControl>();

        private bool _ctrlPressed;

        private StoreLedRepository _storeLedRepository;
        private LedRepository _ledRepository;
        public ControlForm()
        {
            InitializeComponent();

            _ledRepository = LedRepository.GetInstance();
            _storeLedRepository = StoreLedRepository.GetInstance();
            _storeLeds = _storeLedRepository.GetStoreLeds();

            foreach (var led in _storeLeds)
            {
                var lebBox = new HStoreLedControl(led);
                lebBox.Name = led.Name;
                lebBox.Size = new Size(80, 120);
                lebBox.Cursor = Cursors.Hand;
                lebBox.MouseDown += this.ledBox_Click;
                this.LedPanel.Controls.Add(lebBox);
            }
        }

        private void ledBox_Click(object sender, MouseEventArgs e)
        {
            var ledControl = (HStoreLedControl) sender;
            var controlCount = this.UniversePanel.Controls.Count;
            var existLedControls = this.UniversePanel.Controls.OfType<HLedControl>().Where(x => x.Led.StoreLed.Type == ledControl.Led.Type);
            var newLed = new Led()
            {
                Key = Guid.NewGuid(),
                ChannelBegin = 1,
                Name = $"{ledControl.Led.Name} {existLedControls.Count() + 1}",
                StoreLed = ledControl.Led,
                Channels = new List<LedChannel>()
            };

            foreach (var channel in ledControl.Led.Channels)
            {
                var newChannel = new LedChannel()
                {
                    ChannelNumber = channel.ChannelNumber,
                    Value = channel.Type == ChannelType.Dimmer ? 255 : 0,
                    Type = channel.Type
                };
                newLed.Channels.Add(newChannel);
            }

            var newLedControl = new HLedControl(newLed);
            newLedControl.Size = new Size(80, 120);
            newLedControl.Cursor = Cursors.Hand;
            newLedControl.Location = new Point(newLedControl.Size.Width * controlCount);
            newLedControl.MouseDown += this.ledControl_Click;
            newLedControl.KeyDown += NewLedControl_KeyDown;
            newLedControl.KeyUp += NewLedControl_KeyUp;
            ControlExtension.Draggable(newLedControl, true);
            _ledControls.Add(newLedControl);
            this.UniversePanel.Controls.Add(newLedControl);
        }

        private void NewLedControl_KeyUp(object sender, KeyEventArgs e)
        {
            _ctrlPressed = false;
        }

        private void NewLedControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                _ctrlPressed = true;
            }
        }

        private void ledControl_Click(object sender, MouseEventArgs e)
        {
            var ledControl = (HLedControl)sender;
            var currentLed = _ledControls.Where(x => x.Led.Key == ledControl.Led.Key).FirstOrDefault();
            currentLed.SetSelected(true);
            
            if (e.Button == MouseButtons.Right)
            {
                LedContextMenu.Show(ledControl, e.X, e.Y);
                if (_selectedLedControls.Count < 2)
                {
                    this.unselectOtherLeds(currentLed);
                }
            }
            else
            {
                if (!_ctrlPressed)
                {
                    this.unselectOtherLeds(currentLed);
                }
                _selectedLedControls = _ledControls.Where(x => x.IsSelected).ToList();
                this.setSelectedGroups(_selectedLedControls);
                if (_channelControl == null || _channelControl.IsDisposed)
                {
                    _channelControl = new HChannelControl(_ledControls, _selectedLedControls, _groupControls);
                }
                else
                {
                    _channelControl.Init(_ledControls, _selectedLedControls, _groupControls);
                }
                _channelControl.Dock = DockStyle.Bottom;
                UniversePanel.Controls.Add(_channelControl);
                GroupParentPanel.Show();
            }
        }

        private void unselectOtherLeds(HLedControl currentLed)
        {
            foreach (var ledControl in _ledControls)
            {
                if (ledControl.Led.Key != currentLed.Led.Key)
                {
                    ledControl.SetSelected(false);
                }
            }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            var groupPanel = new HGroupControl(_selectedLedControls,
                this._groupControls,
                _channelControl.ChannelMasterSpeedBar, 
                _channelControl.ChannelFaderBar);
            groupPanel.NameGroupText.Text = "Groupe " + (this._groupControls.Count + 1);
            this._groupControls.Add(groupPanel);
            this.GroupPanel.Controls.Add(groupPanel);
        }

        private void setSelectedGroups(List<HLedControl> selectedLeds)
        {
            foreach (var groupControl in _groupControls)
            {
                groupControl.SelectedLedControls = selectedLeds;
            }
        }

        private void DeleteLedMenuItem_Click(object sender, EventArgs e)
        {
            _selectedLedControls = _ledControls.Where(x => x.IsSelected).ToList();
            foreach (var ledControl in _selectedLedControls)
            {
                UniversePanel.Controls.Remove(ledControl);
            }
        }

        private void UniversPanel_Click(object sender, EventArgs e)
        {
            foreach (var ledControl in _ledControls)
            {
                ledControl.SetSelected(false);
            }
        }
    }
}
