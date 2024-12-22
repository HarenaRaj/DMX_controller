using HLight.Controls;
using HLight.Enums;
using HLight.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HLight.Forms
{
    public partial class HChannelControl : UserControl
    {
        public List<HLedControl> LedControls { get; set; }
        public List<HLedControl> SelectedLedControls { get; set; }
        public List<HGroupControl> GroupControls { get; set; }

        public HTrackBar ChannelMasterDimmerBar { get; set; }
        public HTrackBar ChannelMasterSpeedBar { get; set; }
        public HTrackBar ChannelFaderBar { get; set; }

        private List<HTrackBar> _channelBars;

        private HTrackBar _channelBar;

        private LedRepository _ledRepository;

        public HChannelControl()
        {
            InitializeComponent();
            _channelBars = new List<HTrackBar>();
            _ledRepository = LedRepository.GetInstance();
        }

        public HChannelControl(List<HLedControl> ledControls, 
            List<HLedControl> selectedLedControls, 
            List<HGroupControl> groupControls) : this()
        {
            Init(ledControls, selectedLedControls, groupControls);
            HTrackBar channelMasterDimmerBar = new HTrackBar();
            channelMasterDimmerBar.Location = new System.Drawing.Point(25, 55);
            channelMasterDimmerBar.Name = ChannelType.MasterDimmer.ToString();
            channelMasterDimmerBar.AutoSize = false;
            channelMasterDimmerBar.ChannelLabel.Text = ChanneTypeString.GetString(ChannelType.MasterDimmer);
            channelMasterDimmerBar.Type = ChannelType.MasterDimmer;
            channelMasterDimmerBar.ChannelTrackBar.Value = 255;
            channelMasterDimmerBar.ChannelTrackBar.ValueChanged += new EventHandler(ChannelMasterDimmerTrackBar_ValueChanged);

            HTrackBar channelMasterSpeedBar = new HTrackBar();
            channelMasterSpeedBar.Location = new System.Drawing.Point(105, 55);
            channelMasterSpeedBar.Name = ChannelType.MasterDimmer.ToString();
            channelMasterSpeedBar.AutoSize = false;
            channelMasterSpeedBar.ChannelLabel.Text = ChanneTypeString.GetString(ChannelType.MasterSpeed);
            channelMasterSpeedBar.Type = ChannelType.MasterSpeed;
            channelMasterSpeedBar.ChannelTrackBar.Maximum = 5000;
            channelMasterSpeedBar.ChannelTrackBar.Minimum = 100;
            channelMasterSpeedBar.ChannelTrackBar.Value = channelMasterSpeedBar.ChannelTrackBar.Maximum;
            channelMasterSpeedBar.ChannelTrackBar.ValueChanged += new EventHandler(ChannelMasterSpeedTrackBar_ValueChanged);

            HTrackBar channelFaderBar = new HTrackBar();
            channelFaderBar.Location = new System.Drawing.Point(185, 55);
            channelFaderBar.Name = ChannelType.Fader.ToString();
            channelFaderBar.AutoSize = false;
            channelFaderBar.ChannelLabel.Text = ChanneTypeString.GetString(ChannelType.Fader);
            channelFaderBar.Type = ChannelType.Fader;
            channelFaderBar.ChannelTrackBar.Maximum = 100;
            channelFaderBar.ChannelTrackBar.Minimum = 1;
            channelFaderBar.ChannelTrackBar.Value = channelFaderBar.ChannelTrackBar.Minimum;
            channelFaderBar.ChannelTrackBar.RightToLeft = RightToLeft.Yes;
            channelFaderBar.ChannelTrackBar.ValueChanged += new EventHandler(ChannelFaderTrackBar_ValueChanged);

            ChannelMasterDimmerBar = channelMasterDimmerBar;
            ChannelMasterSpeedBar = channelMasterSpeedBar;
            ChannelFaderBar = channelFaderBar;

            this.Controls.Add(channelMasterDimmerBar);
            this.Controls.Add(channelMasterSpeedBar);
            this.Controls.Add(channelFaderBar);
        }

        private void ChannelFaderTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var channel = (TrackBar)sender;
            foreach (var ledControl in LedControls)
            {
                ledControl.TimerFader.Interval = channel.Value;
            }
        }

        private void ChannelMasterSpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var channel = (TrackBar)sender;
            foreach (var groupControl in GroupControls)
            {
                groupControl.TimerSpeed.Interval = Math.Abs(channel.Value - channel.Maximum - channel.Minimum);
            }
        }

        public void Init(List<HLedControl> ledControls, List<HLedControl> selectedLedControls, List<HGroupControl> groupControls)
        {
            SelectedLedControls = selectedLedControls;
            LedControls = ledControls;
            GroupControls = groupControls;
            if (selectedLedControls.Count == 1)
            {
                ChannelNumeric.Text = selectedLedControls.First().Led.ChannelBegin.ToString();
                NameText.Text = selectedLedControls.First().Led.Name;
            }

            if (selectedLedControls.Count > 0)
            {
                for (int i = 0; i < SelectedLedControls.Last().Led.Channels.Count; i++)
                {
                    _channelBar = _channelBars.FirstOrDefault(x => x.Type == LedControls.Last().Led.Channels[i].Type);
                    if (_channelBar == null)
                    {
                        _channelBar = new HTrackBar();
                    }

                    _channelBar.Location = new System.Drawing.Point(310 + (80 * i), 55);
                    _channelBar.Name = SelectedLedControls.Last().Led.Channels[i].Type.ToString();
                    _channelBar.AutoSize = false;
                    _channelBar.ChannelLabel.Text = ChanneTypeString.GetString(SelectedLedControls.Last().Led.Channels[i].Type);
                    _channelBar.Type = SelectedLedControls.Last().Led.Channels[i].Type;
                    _channelBar.Id = SelectedLedControls.Last().Led.Key;
                    _channelBar.ChannelTrackBar.ValueChanged += new EventHandler(ChannelTrackBar_ValueChanged);

                    switch (_channelBar.Type)
                    {
                        case ChannelType.Dimmer:
                            _channelBar.ChannelTrackBar.Value = SelectedLedControls.Last().Led.Channels
                                .Where(x => x.Type == ChannelType.Dimmer).FirstOrDefault().Value;
                            break;
                        case ChannelType.Red:
                            _channelBar.ChannelTrackBar.Value = SelectedLedControls.Last().Led.Channels
                                .Where(x => x.Type == ChannelType.Red).FirstOrDefault().Value;
                            break;
                        case ChannelType.Green:
                            _channelBar.ChannelTrackBar.Value = SelectedLedControls.Last().Led.Channels
                                .Where(x => x.Type == ChannelType.Green).FirstOrDefault().Value;
                            break;
                        case ChannelType.Blue:
                            _channelBar.ChannelTrackBar.Value = SelectedLedControls.Last().Led.Channels
                                .Where(x => x.Type == ChannelType.Blue).FirstOrDefault().Value;
                            break;
                    }

                    if (!_channelBars.Any(x => x.Type == _channelBar.Type))
                    {
                        _channelBars.Add(_channelBar);
                        this.Controls.Add(_channelBar);
                    }
                }
            }
        }

        private void ChannelMasterDimmerTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var masterDimmerValue = ((TrackBar)sender).Value;
            foreach (var ledControl in LedControls)
            {
                var dimmer = ledControl.Led.Channels.Where(x => x.Type == ChannelType.Dimmer).FirstOrDefault();
                dimmer.Value = masterDimmerValue;
            }
            var channelDimmerBar = _channelBars.Where(x => x.Type == ChannelType.Dimmer).FirstOrDefault();
            channelDimmerBar.ChannelTrackBar.Value = masterDimmerValue;
        }

        private void ChannelTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var trackBar = (TrackBar)sender;
            var type = ((HTrackBar)((TrackBar)sender).Parent).Type;
            foreach (var ledControl in SelectedLedControls)
            {
                var channel = ledControl.Led.Channels.Where(x => x.Type == type).FirstOrDefault();
                channel.Value = trackBar.Value;
            }
        }

        private void NameText_TextChanged(object sender, System.EventArgs e)
        {
            if (SelectedLedControls.Count == 1)
            {
                SelectedLedControls.First().ChangeName(NameText.Text);
                _ledRepository.UpdateName(SelectedLedControls[0].Led.Key, NameText.Text);
            }
        }

        private void ChannelNumeric_TextChanged(object sender, System.EventArgs e)
        {
            if (SelectedLedControls.Count == 1)
            {
                SelectedLedControls.First().ChangeChannel((int)ChannelNumeric.Value);
            }
        }

        private void ChannelNumeric_ValueChanged(object sender, EventArgs e)
        {
            _ledRepository.UpdateChannelNumber(SelectedLedControls[0].Led.Key, (int)ChannelNumeric.Value);
        }
    }
}
