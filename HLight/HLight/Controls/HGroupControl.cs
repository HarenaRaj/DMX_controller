using HLight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HLight.Controls
{
    public partial class HGroupControl : UserControl
    {
        public List<HLedControl> SelectedLedControls { get; set; }
        public List<HLedControl> LedControls { get; set; }
        public Group Group { get; set; }

        private bool _isPlay = false;
        private int _iAuto = 0;

        private Animation _pulseAnimation { get; set; }
        public HGroupControl()
        {
            InitializeComponent();
            LedControls = new List<HLedControl>();
            Group = new Group();
            Group.Leds = new List<Led>();
            Group.Scenes = new List<Scene>();
            _pulseAnimation = new Animation();
        }

        public HGroupControl(List<HLedControl> selectedLedControls) : this()
        {
            SelectedLedControls = selectedLedControls;
        }

        private void AddLedButton_Click(object sender, EventArgs e)
        {
            if (SelectedLedControls.Count == 0)
            {
                MessageBox.Show("Veuillez selectionner au moins une (1) LED pour l'ajouter dans ce groupe");
            }
            else
            {
                LedGroupTabControl.SelectedIndex = 0;
                foreach (var led in SelectedLedControls)
                {
                    if (!LedControls.Contains(led))
                    {
                        var ledLabel = new MetroFramework.Controls.MetroLabel();
                        ledLabel.AutoSize = true;
                        ledLabel.FontSize = MetroFramework.MetroLabelSize.Small;
                        ledLabel.Name = led.Led.Name;
                        ledLabel.Size = new System.Drawing.Size(39, 15);
                        ledLabel.TabIndex = 4;
                        ledLabel.Text = led.Led.Name;
                        ledLabel.UseCustomBackColor = true;
                        this.LedPanel.Controls.Add(ledLabel);
                        LedControls.Add(led);
                        Group.Leds.Add(led.Led);
                    }
                }

                _pulseAnimation.Channels = new List<List<Channel>> { new List<Channel>() };
                for (int i = 0; i < LedControls.Count; i++)
                {

                }
            }
        }

        private void AddSceneButton_Click(object sender, EventArgs e)
        {
            if (LedControls.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une (1) LED");
            }
            else
            {
                LedGroupTabControl.SelectedIndex = 1;
                var scene = new Scene()
                {
                    Id = Group.Scenes.Count + 1,
                    Name = (Group.Scenes.Count + 1).ToString(),
                    Leds = new List<Led>()
                };

                foreach (var led in LedControls)
                {
                    var newLed = new Led()
                    {
                        Id = led.Led.Id,
                        Name = led.Led.Name,
                        ChannelBegin = led.Led.ChannelBegin,
                        Channels = new List<Channel>(),
                        IdStoreLed = led.Led.IdStoreLed,
                        StoreLed = led.Led.StoreLed
                    };
                    foreach (var channel in led.Led.Channels)
                    {
                        var newChannel = new Channel()
                        {
                            ChannelNumber = channel.ChannelNumber,
                            Id = channel.Id,
                            Type = channel.Type,
                            Value = channel.Value
                        };
                        newLed.Channels.Add(newChannel);
                    }
                    scene.Leds.Add(newLed);
                }
                var buttonScene = new HSceneButton();
                buttonScene.Location = new System.Drawing.Point(((buttonScene.Width + 5) * SceneTabControl.SelectedTab.Controls.Count - 2), 0);
                buttonScene.Name = scene.Name;
                buttonScene.Text = scene.Name;
                buttonScene.Click += ButtonScene_Click;
                buttonScene.Scene = scene;
                SceneTabControl.SelectedTab.Controls.Add(buttonScene);
                Group.Scenes.Add(scene);
            }
        }

        private void ButtonScene_Click(object sender, EventArgs e)
        {
            var sceneButton = (HSceneButton)sender;
            foreach (var ledControl in LedControls)
            {
                var currentLed = sceneButton.Scene.Leds.Where(x => x.Id == ledControl.Led.Id).FirstOrDefault();
                if (currentLed != null)
                {
                    foreach (var currentChannel in currentLed.Channels)
                    {
                        var channel = ledControl.Led.Channels.Where(x => x.Type == currentChannel.Type).FirstOrDefault();
                        channel.Value = currentChannel.Value;
                    }
                }
                else
                {
                    foreach (var channel in ledControl.Led.Channels)
                    {
                        channel.Value = 0;
                    }
                }
            }
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            _isPlay = !_isPlay;
            if (_isPlay) TimerSpeed.Start();
            else TimerSpeed.Stop();
        }

        private void TimerSpeed_Tick(object sender, EventArgs e)
        {
            if (_iAuto >= SceneTabControl.SelectedTab.Controls.Count) _iAuto = 0;
            ButtonScene_Click(SceneTabControl.SelectedTab.Controls[_iAuto], e);
            _iAuto++;
        }
    }
}
