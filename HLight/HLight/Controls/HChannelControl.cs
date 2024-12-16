using HLight.Controls;
using HLight.Enums;
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

        private List<HTrackBar> _channelBars;

        private HTrackBar _channelBar;

        public HChannelControl()
        {
            InitializeComponent();
            _channelBars = new List<HTrackBar>();
        }

        public HChannelControl(List<HLedControl> ledControls, List<HLedControl> selectedLedControls) : this()
        {
            Init(ledControls, selectedLedControls);
            HTrackBar channelMasterDimmerBar = new HTrackBar();
            channelMasterDimmerBar.Location = new System.Drawing.Point(25, 55);
            channelMasterDimmerBar.Name = ChannelType.MasterDimmer.ToString();
            channelMasterDimmerBar.AutoSize = false;
            channelMasterDimmerBar.ChannelLabel.Text = ChanneTypeString.GetString(ChannelType.MasterDimmer);
            channelMasterDimmerBar.Type = ChannelType.MasterDimmer;
            channelMasterDimmerBar.Id = LedControls.Last().Led.Id;
            channelMasterDimmerBar.ChannelTrackBar.Value = 255;
            channelMasterDimmerBar.ChannelTrackBar.ValueChanged += new EventHandler(ChannelMasterDimmerTrackBar_ValueChanged);

            this.Controls.Add(channelMasterDimmerBar);
        }

        public void Init(List<HLedControl> ledControls, List<HLedControl> selectedLedControls)
        {
            SelectedLedControls = selectedLedControls;
            LedControls = ledControls;
            if (selectedLedControls.Count == 1)
            {
                ChannelNumeric.Text = ledControls.First().Led.ChannelBegin.ToString();
                NameText.Text = ledControls.First().Led.Name;
            }

            if (ledControls.Count > 0)
            {
                for (int i = 0; i < LedControls.Last().Led.StoreLed.Channels.Count; i++)
                {
                    _channelBar = _channelBars.FirstOrDefault(x => x.Type == LedControls.Last().Led.Channels[i].Type);
                    if (_channelBar == null)
                    {
                        _channelBar = new HTrackBar();
                    }

                    _channelBar.Location = new System.Drawing.Point(150 + (80 * i), 55);
                    _channelBar.Name = LedControls.Last().Led.Channels[i].Type.ToString();
                    _channelBar.AutoSize = false;
                    _channelBar.ChannelLabel.Text = ChanneTypeString.GetString(LedControls.Last().Led.StoreLed.Channels[i].Type);
                    _channelBar.Type = LedControls.Last().Led.Channels[i].Type;
                    _channelBar.Id = LedControls.Last().Led.Id;
                    _channelBar.ChannelTrackBar.ValueChanged += new EventHandler(ChannelTrackBar_ValueChanged);

                    switch (_channelBar.Type)
                    {
                        case ChannelType.Dimmer:
                            _channelBar.ChannelTrackBar.Value = LedControls.Last().Led.Channels
                                .Where(x => x.Type == ChannelType.Dimmer).FirstOrDefault().Value;
                            break;
                        case ChannelType.Red:
                            _channelBar.ChannelTrackBar.Value = LedControls.Last().Led.Channels
                                .Where(x => x.Type == ChannelType.Red).FirstOrDefault().Value;
                            break;
                        case ChannelType.Green:
                            _channelBar.ChannelTrackBar.Value = LedControls.Last().Led.Channels
                                .Where(x => x.Type == ChannelType.Green).FirstOrDefault().Value;
                            break;
                        case ChannelType.Blue:
                            _channelBar.ChannelTrackBar.Value = LedControls.Last().Led.Channels
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
            if (LedControls.Count == 1)
            {
                LedControls.First().ChangeName(NameText.Text);
            }
        }

        private void ChannelNumeric_TextChanged(object sender, System.EventArgs e)
        {
            if (LedControls.Count == 1)
            {
                LedControls.First().ChangeChannel((int)ChannelNumeric.Value);
            }
        }
    }
}
