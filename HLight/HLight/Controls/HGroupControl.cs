using HLight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace HLight.Controls
{
    public partial class HGroupControl : UserControl
    {
        public List<HLedControl> SelectedLedControls { get; set; }
        public List<HLedControl> LedControls { get; set; }
        public Group Group { get; set; }

        public List<Animation> Animations { get; set; }

        private Animation _currentAnimation;
        private bool _isPlay = false;
        private bool _isPlayAnimation = false;
        private int _iAuto = 0;
        private int _iAutoAnimation = 0;
        private HTrackBar _channelMasterSpeedBar;
        private HTrackBar _channelFaderBar;

        public HGroupControl()
        {
            InitializeComponent();
            LedControls = new List<HLedControl>();
            Group = new Group();
            Group.Leds = new List<Led>();
            Group.ScenePages = new List<ScenePage>();
            Animations = new List<Animation>();
        }

        public HGroupControl(List<HLedControl> selectedLedControls, 
            HTrackBar channelMasterSpeedBar, 
            HTrackBar channelFaderBar) : this()
        {
            SelectedLedControls = selectedLedControls;
            _channelMasterSpeedBar = channelMasterSpeedBar;
            _channelFaderBar = channelFaderBar;
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

                ScenePage scenePage;
                if (Group.ScenePages.Any(x => x.Name == SceneTabControl.SelectedTab.Name))
                {
                    scenePage = Group.ScenePages.Where(x => x.Name == SceneTabControl.SelectedTab.Name).FirstOrDefault();
                }
                else
                {
                    scenePage = new ScenePage()
                    {
                        Name = SceneTabControl.SelectedTab.Name,
                        Scenes = new List<Scene>()
                    };
                }

                var scene = new Scene()
                {
                    Id = scenePage.Scenes.Count + 1,
                    Name = (scenePage.Scenes.Count + 1).ToString(),
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
                buttonScene.Location = new System.Drawing.Point(((buttonScene.Width + 5) * (SceneTabControl.SelectedTab.Controls.Count - 2)), 0);
                buttonScene.Name = scene.Name;
                buttonScene.Text = scene.Name;
                buttonScene.Click += ButtonScene_Click;
                buttonScene.Scene = scene;
                SceneTabControl.SelectedTab.Controls.Add(buttonScene);
                scenePage.Scenes.Add(scene);

                if (!Group.ScenePages.Contains(scenePage))
                {
                    Group.ScenePages.Add(scenePage);
                }
            }
        }

        private void ButtonScene_Click(object sender, EventArgs e)
        {
            var sceneButton = (HSceneButton)sender;
            changeSceneChannel(sceneButton.Scene);
        }

        private void changeSceneChannel(Scene scene)
        {
            foreach (var ledControl in LedControls)
            {
                var currentLed = scene.Leds.Where(x => x.Id == ledControl.Led.Id).FirstOrDefault();
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

        private void startAutoScene()
        {
            this.PlayPauseButton.BackgroundImage = global::HLight.Properties.Resources.Pause;
            TimerSpeed.Start();
            TimerAnimation.Stop();
        }

        private void pauseAutoScene()
        {
            TimerSpeed.Stop();
            this.PlayPauseButton.BackgroundImage = global::HLight.Properties.Resources.Play;
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            if (LedControls.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une (1) LED");
            }
            else if (SceneTabControl.SelectedTab.Controls.Count <= 3)
            {
                MessageBox.Show("Veuillez ajouter au moins deux (2) Scènes");
            }
            else
            {
                _isPlay = !_isPlay;
                if (_isPlay)
                {
                    startAutoScene();
                }
                else
                {
                    pauseAutoScene();
                }
            }
        }

        private void TimerSpeed_Tick(object sender, EventArgs e)
        {
            if (_iAuto + 2 >= SceneTabControl.SelectedTab.Controls.Count) _iAuto = 0;
            ButtonScene_Click(SceneTabControl.SelectedTab.Controls[_iAuto + 2], e);
            _iAuto++;
        }

        private void AddAnimationButton_Click(object sender, EventArgs e)
        {
            var currentIndex = SceneTabControl.SelectedIndex;
            var scenePage = Group.ScenePages[currentIndex];
            var animation = new Animation()
            {
                Name = (Animations.Count + 1).ToString(),
                Scenes = scenePage.Scenes,
                Fader = _channelFaderBar.ChannelTrackBar.Value,
                Speed = _channelMasterSpeedBar.ChannelTrackBar.Value,
            };

            var buttonAnimation = new HAnimationButton();
            buttonAnimation.Location = new System.Drawing.Point(((buttonAnimation.Width + 5) * (AnimationPanel.Controls.Count)), 0);
            buttonAnimation.Name = animation.Name;
            buttonAnimation.Text = animation.Name;
            buttonAnimation.Click += ButtonAnimation_Click;
            buttonAnimation.Animation = animation;
            AnimationPanel.Controls.Add(buttonAnimation);
            Animations.Add(animation);
        }

        private void ButtonAnimation_Click(object sender, EventArgs e)
        {
            var animation = ((HAnimationButton)sender).Animation;
            if (_currentAnimation == animation)
            {
                _isPlayAnimation = !_isPlayAnimation;
            }
            else
            {
                _currentAnimation = animation;
                _isPlayAnimation = true;
            }

            if (_isPlayAnimation)
            {
                _iAutoAnimation = 0;
                TimerAnimation.Interval = Math.Abs(animation.Speed - _channelMasterSpeedBar.ChannelTrackBar.Maximum - _channelMasterSpeedBar.ChannelTrackBar.Minimum);

                foreach (var ledControl in LedControls)
                {
                    ledControl.TimerFader.Interval = animation.Fader;
                }

                TimerAnimation.Start();
                pauseAutoScene();
            }
            else TimerAnimation.Stop();
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            if (_iAutoAnimation >= _currentAnimation.Scenes.Count) _iAutoAnimation = 0;
            changeSceneChannel(_currentAnimation.Scenes[_iAutoAnimation]);
            _iAutoAnimation++;
        }
    }
}
