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

        public List<Animation> Animations { get; set; }

        private List<HGroupControl> _groupControls;
        private Animation _currentAnimation;
        private FlowLayoutPanel _currentPanel;
        private HSceneButton _currentSceneButton;
        private HAnimationButton _currentAnimationButton;
        private HLedLabel _currentLedLabel;
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
            List<HGroupControl> groupControls,
            HTrackBar channelMasterSpeedBar, 
            HTrackBar channelFaderBar) : this()
        {
            SelectedLedControls = selectedLedControls;
            _groupControls = groupControls;
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
                        var ledLabel = new HLedLabel();
                        ledLabel.AutoSize = true;
                        ledLabel.FontSize = MetroFramework.MetroLabelSize.Small;
                        ledLabel.Name = led.Led.Name;
                        ledLabel.Size = new System.Drawing.Size(39, 15);
                        ledLabel.TabIndex = 4;
                        ledLabel.Text = led.Led.Name;
                        ledLabel.UseCustomBackColor = true;
                        ledLabel.LedControl = led;
                        ledLabel.MouseDown += LedLabel_Click;
                        this.LedPanel.Controls.Add(ledLabel);
                        LedControls.Add(led);
                        Group.Leds.Add(led.Led);
                    }
                }
            }
        }

        private void LedLabel_Click(object sender, MouseEventArgs e)
        {
            var ledLabel = (HLedLabel)sender;
            if (e.Button == MouseButtons.Right)
            {
                LedContextMenu.Show(ledLabel, e.X, e.Y);
                _currentLedLabel = ledLabel;
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

                var lastScene = scenePage.Scenes.LastOrDefault();
                int index;
                if (lastScene == null) index = 1;
                else index = lastScene.Order + 1;
                var scene = new Scene()
                {
                    Order = index,
                    Name = index.ToString(),
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
                buttonScene.MouseDown += ButtonScene_Click;
                buttonScene.Scene = scene;
                var pannel = SceneTabControl.SelectedTab.Controls.OfType<Control>().Where(x => x is FlowLayoutPanel).FirstOrDefault();
                pannel.Controls.Add(buttonScene);
                scenePage.Scenes.Add(scene);

                if (!Group.ScenePages.Contains(scenePage))
                {
                    Group.ScenePages.Add(scenePage);
                }
            }
        }

        private void ButtonScene_Click(object sender, MouseEventArgs e)
        {
            var buttonScene = (HSceneButton)sender; 
            if (e.Button == MouseButtons.Right)
            {
                SceneContextMenu.Show(buttonScene, 10, 10);
                _currentSceneButton = buttonScene;
            }
            else
            {
                var sceneButton = (HSceneButton)sender;
                changeSceneChannel(sceneButton.Scene);
            }
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
            _currentPanel = (FlowLayoutPanel) SceneTabControl.SelectedTab.Controls.OfType<Control>()
                .Where(x => x is FlowLayoutPanel).First();
            if (LedControls.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une (1) LED");
            }
            else if (_currentPanel.Controls.Count < 2)
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
            if (_iAuto >= _currentPanel.Controls.Count) _iAuto = 0;
            var sceneControl = (HSceneButton)_currentPanel.Controls[_iAuto];
            changeSceneChannel(sceneControl.Scene);
            _iAuto++;
        }

        private void AddAnimationButton_Click(object sender, EventArgs e)
        {
            var currentIndex = SceneTabControl.SelectedIndex;
            var scenePage = Group.ScenePages[currentIndex];
            var lastAnimation = Animations.LastOrDefault();
            int index;
            if (lastAnimation == null) index = 1;
            else index = lastAnimation.Order + 1;
            var animation = new Animation()
            {
                Name = index.ToString(),
                Scenes = scenePage.Scenes,
                Fader = _channelFaderBar.ChannelTrackBar.Value,
                Speed = _channelMasterSpeedBar.ChannelTrackBar.Value,
            };

            var buttonAnimation = new HAnimationButton();
            buttonAnimation.Location = new System.Drawing.Point(((buttonAnimation.Width + 5) * (AnimationPanel.Controls.Count)), 0);
            buttonAnimation.Name = animation.Name;
            buttonAnimation.Text = animation.Name;
            buttonAnimation.MouseDown += ButtonAnimation_Click;
            buttonAnimation.Animation = animation;
            AnimationPanel.Controls.Add(buttonAnimation);
            Animations.Add(animation);
        }

        private void ButtonAnimation_Click(object sender, MouseEventArgs e)
        {
            var buttonAnimation = (HAnimationButton)sender;
            if (e.Button == MouseButtons.Right)
            {
                AnimationContextMenu.Show(buttonAnimation, 10, 10);
                _currentAnimationButton = buttonAnimation;
            }
            else
            {
                var animation = buttonAnimation.Animation;
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
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            if (_iAutoAnimation >= _currentAnimation.Scenes.Count) _iAutoAnimation = 0;
            changeSceneChannel(_currentAnimation.Scenes[_iAutoAnimation]);
            _iAutoAnimation++;
        }

        private void DeleteSceneMenuItem_Click(object sender, EventArgs e)
        {
            _currentPanel = SceneTabControl.SelectedTab.Controls.OfType<FlowLayoutPanel>().First();
            var scenePage = Group.ScenePages.Where(x => x.Name == SceneTabControl.SelectedTab.Name).FirstOrDefault();
            scenePage.Scenes.Remove(_currentSceneButton.Scene);
            _currentPanel.Controls.Remove(_currentSceneButton);
        }

        private void DeleteAnimationMenuItem_Click(object sender, EventArgs e)
        {
            Animations.Remove(_currentAnimationButton.Animation);
            AnimationPanel.Controls.Remove(_currentAnimationButton);
        }

        private void DeleteLedMenuItem_Click(object sender, EventArgs e)
        {
            this.LedPanel.Controls.Remove(_currentLedLabel);
            LedControls.Remove(_currentLedLabel.LedControl);
            Group.Leds.Remove(_currentLedLabel.LedControl.Led);
        }

        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this._groupControls.Remove(this);
        }
    }
}
