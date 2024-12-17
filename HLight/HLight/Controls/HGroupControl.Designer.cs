namespace HLight.Controls
{
    partial class HGroupControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameGroupLabel = new MetroFramework.Controls.MetroLabel();
            this.NameGroupText = new MetroFramework.Controls.MetroTextBox();
            this.SceneLabel = new MetroFramework.Controls.MetroLabel();
            this.AnimationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AnimationLabel = new MetroFramework.Controls.MetroLabel();
            this.LedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LedLabel = new MetroFramework.Controls.MetroLabel();
            this.AddLedButton = new MetroFramework.Controls.MetroButton();
            this.LedGroupTabControl = new MetroFramework.Controls.MetroTabControl();
            this.LedTabPage = new MetroFramework.Controls.MetroTabPage();
            this.SceneTabPage = new MetroFramework.Controls.MetroTabPage();
            this.PlayPauseButton = new MetroFramework.Controls.MetroButton();
            this.SceneTabControl = new MetroFramework.Controls.MetroTabControl();
            this.Bank1 = new MetroFramework.Controls.MetroTabPage();
            this.Bank2 = new MetroFramework.Controls.MetroTabPage();
            this.Bank3 = new MetroFramework.Controls.MetroTabPage();
            this.Bank5 = new MetroFramework.Controls.MetroTabPage();
            this.Bank6 = new MetroFramework.Controls.MetroTabPage();
            this.Bank7 = new MetroFramework.Controls.MetroTabPage();
            this.AddSceneButton = new MetroFramework.Controls.MetroButton();
            this.TimerSpeed = new System.Windows.Forms.Timer(this.components);
            this.Bank4 = new MetroFramework.Controls.MetroTabPage();
            this.Bank8 = new MetroFramework.Controls.MetroTabPage();
            this.LedGroupTabControl.SuspendLayout();
            this.LedTabPage.SuspendLayout();
            this.SceneTabPage.SuspendLayout();
            this.SceneTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameGroupLabel
            // 
            this.NameGroupLabel.AutoSize = true;
            this.NameGroupLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.NameGroupLabel.Location = new System.Drawing.Point(21, 14);
            this.NameGroupLabel.Name = "NameGroupLabel";
            this.NameGroupLabel.Size = new System.Drawing.Size(39, 15);
            this.NameGroupLabel.TabIndex = 4;
            this.NameGroupLabel.Text = "Nom :";
            this.NameGroupLabel.UseCustomBackColor = true;
            // 
            // NameGroupText
            // 
            // 
            // 
            // 
            this.NameGroupText.CustomButton.Image = null;
            this.NameGroupText.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.NameGroupText.CustomButton.Name = "";
            this.NameGroupText.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.NameGroupText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameGroupText.CustomButton.TabIndex = 1;
            this.NameGroupText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameGroupText.CustomButton.UseSelectable = true;
            this.NameGroupText.CustomButton.Visible = false;
            this.NameGroupText.Lines = new string[0];
            this.NameGroupText.Location = new System.Drawing.Point(134, 8);
            this.NameGroupText.MaxLength = 32767;
            this.NameGroupText.Name = "NameGroupText";
            this.NameGroupText.PasswordChar = '\0';
            this.NameGroupText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameGroupText.SelectedText = "";
            this.NameGroupText.SelectionLength = 0;
            this.NameGroupText.SelectionStart = 0;
            this.NameGroupText.ShortcutsEnabled = true;
            this.NameGroupText.Size = new System.Drawing.Size(123, 35);
            this.NameGroupText.TabIndex = 3;
            this.NameGroupText.UseSelectable = true;
            this.NameGroupText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameGroupText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SceneLabel
            // 
            this.SceneLabel.AutoSize = true;
            this.SceneLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.SceneLabel.Location = new System.Drawing.Point(14, 53);
            this.SceneLabel.Name = "SceneLabel";
            this.SceneLabel.Size = new System.Drawing.Size(47, 15);
            this.SceneLabel.TabIndex = 5;
            this.SceneLabel.Text = "Scènes :";
            // 
            // AnimationPanel
            // 
            this.AnimationPanel.AutoScroll = true;
            this.AnimationPanel.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.AnimationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnimationPanel.Location = new System.Drawing.Point(127, 204);
            this.AnimationPanel.Name = "AnimationPanel";
            this.AnimationPanel.Size = new System.Drawing.Size(441, 117);
            this.AnimationPanel.TabIndex = 9;
            // 
            // AnimationLabel
            // 
            this.AnimationLabel.AutoSize = true;
            this.AnimationLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.AnimationLabel.Location = new System.Drawing.Point(14, 235);
            this.AnimationLabel.Name = "AnimationLabel";
            this.AnimationLabel.Size = new System.Drawing.Size(69, 15);
            this.AnimationLabel.TabIndex = 8;
            this.AnimationLabel.Text = "Animations :";
            // 
            // LedPanel
            // 
            this.LedPanel.Location = new System.Drawing.Point(126, 21);
            this.LedPanel.Name = "LedPanel";
            this.LedPanel.Size = new System.Drawing.Size(441, 211);
            this.LedPanel.TabIndex = 11;
            // 
            // LedLabel
            // 
            this.LedLabel.AutoSize = true;
            this.LedLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.LedLabel.Location = new System.Drawing.Point(13, 52);
            this.LedLabel.Name = "LedLabel";
            this.LedLabel.Size = new System.Drawing.Size(36, 15);
            this.LedLabel.TabIndex = 10;
            this.LedLabel.Text = "Leds :";
            // 
            // AddLedButton
            // 
            this.AddLedButton.Location = new System.Drawing.Point(321, 14);
            this.AddLedButton.Name = "AddLedButton";
            this.AddLedButton.Size = new System.Drawing.Size(138, 25);
            this.AddLedButton.TabIndex = 12;
            this.AddLedButton.Text = "Ajout LED";
            this.AddLedButton.UseSelectable = true;
            this.AddLedButton.Click += new System.EventHandler(this.AddLedButton_Click);
            // 
            // LedGroupTabControl
            // 
            this.LedGroupTabControl.Controls.Add(this.LedTabPage);
            this.LedGroupTabControl.Controls.Add(this.SceneTabPage);
            this.LedGroupTabControl.Location = new System.Drawing.Point(3, 55);
            this.LedGroupTabControl.Name = "LedGroupTabControl";
            this.LedGroupTabControl.SelectedIndex = 1;
            this.LedGroupTabControl.Size = new System.Drawing.Size(1191, 861);
            this.LedGroupTabControl.TabIndex = 13;
            this.LedGroupTabControl.UseSelectable = true;
            // 
            // LedTabPage
            // 
            this.LedTabPage.Controls.Add(this.LedPanel);
            this.LedTabPage.Controls.Add(this.LedLabel);
            this.LedTabPage.HorizontalScrollbarBarColor = true;
            this.LedTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.LedTabPage.HorizontalScrollbarSize = 10;
            this.LedTabPage.Location = new System.Drawing.Point(4, 38);
            this.LedTabPage.Name = "LedTabPage";
            this.LedTabPage.Size = new System.Drawing.Size(1183, 819);
            this.LedTabPage.TabIndex = 0;
            this.LedTabPage.Text = "Liste de LED";
            this.LedTabPage.VerticalScrollbarBarColor = true;
            this.LedTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.LedTabPage.VerticalScrollbarSize = 10;
            // 
            // SceneTabPage
            // 
            this.SceneTabPage.Controls.Add(this.PlayPauseButton);
            this.SceneTabPage.Controls.Add(this.AnimationPanel);
            this.SceneTabPage.Controls.Add(this.SceneLabel);
            this.SceneTabPage.Controls.Add(this.AnimationLabel);
            this.SceneTabPage.Controls.Add(this.SceneTabControl);
            this.SceneTabPage.HorizontalScrollbarBarColor = true;
            this.SceneTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.SceneTabPage.HorizontalScrollbarSize = 10;
            this.SceneTabPage.Location = new System.Drawing.Point(4, 38);
            this.SceneTabPage.Name = "SceneTabPage";
            this.SceneTabPage.Size = new System.Drawing.Size(1183, 819);
            this.SceneTabPage.TabIndex = 1;
            this.SceneTabPage.Text = "Liste des scènes et animations";
            this.SceneTabPage.VerticalScrollbarBarColor = true;
            this.SceneTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.SceneTabPage.VerticalScrollbarSize = 10;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackgroundImage = global::HLight.Properties.Resources.Play;
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayPauseButton.Location = new System.Drawing.Point(575, 22);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(40, 40);
            this.PlayPauseButton.TabIndex = 10;
            this.PlayPauseButton.UseSelectable = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // SceneTabControl
            // 
            this.SceneTabControl.Controls.Add(this.Bank1);
            this.SceneTabControl.Controls.Add(this.Bank2);
            this.SceneTabControl.Controls.Add(this.Bank3);
            this.SceneTabControl.Controls.Add(this.Bank4);
            this.SceneTabControl.Controls.Add(this.Bank5);
            this.SceneTabControl.Controls.Add(this.Bank6);
            this.SceneTabControl.Controls.Add(this.Bank7);
            this.SceneTabControl.Controls.Add(this.Bank8);
            this.SceneTabControl.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.SceneTabControl.HotTrack = true;
            this.SceneTabControl.Location = new System.Drawing.Point(127, 22);
            this.SceneTabControl.Name = "SceneTabControl";
            this.SceneTabControl.SelectedIndex = 0;
            this.SceneTabControl.Size = new System.Drawing.Size(442, 164);
            this.SceneTabControl.TabIndex = 11;
            this.SceneTabControl.UseSelectable = true;
            // 
            // Bank1
            // 
            this.Bank1.AutoScroll = true;
            this.Bank1.HorizontalScrollbar = true;
            this.Bank1.HorizontalScrollbarBarColor = true;
            this.Bank1.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank1.HorizontalScrollbarSize = 10;
            this.Bank1.Location = new System.Drawing.Point(4, 34);
            this.Bank1.Name = "Bank1";
            this.Bank1.Size = new System.Drawing.Size(434, 126);
            this.Bank1.TabIndex = 0;
            this.Bank1.Text = "1";
            this.Bank1.VerticalScrollbarBarColor = false;
            this.Bank1.VerticalScrollbarHighlightOnWheel = false;
            this.Bank1.VerticalScrollbarSize = 10;
            // 
            // Bank2
            // 
            this.Bank2.HorizontalScrollbarBarColor = true;
            this.Bank2.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank2.HorizontalScrollbarSize = 10;
            this.Bank2.Location = new System.Drawing.Point(4, 34);
            this.Bank2.Name = "Bank2";
            this.Bank2.Size = new System.Drawing.Size(434, 126);
            this.Bank2.TabIndex = 1;
            this.Bank2.Text = "2";
            this.Bank2.VerticalScrollbarBarColor = true;
            this.Bank2.VerticalScrollbarHighlightOnWheel = false;
            this.Bank2.VerticalScrollbarSize = 10;
            // 
            // Bank3
            // 
            this.Bank3.HorizontalScrollbarBarColor = true;
            this.Bank3.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank3.HorizontalScrollbarSize = 10;
            this.Bank3.Location = new System.Drawing.Point(4, 34);
            this.Bank3.Name = "Bank3";
            this.Bank3.Size = new System.Drawing.Size(434, 126);
            this.Bank3.TabIndex = 2;
            this.Bank3.Text = "3";
            this.Bank3.VerticalScrollbarBarColor = true;
            this.Bank3.VerticalScrollbarHighlightOnWheel = false;
            this.Bank3.VerticalScrollbarSize = 10;
            // 
            // Bank5
            // 
            this.Bank5.HorizontalScrollbarBarColor = true;
            this.Bank5.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank5.HorizontalScrollbarSize = 10;
            this.Bank5.Location = new System.Drawing.Point(4, 34);
            this.Bank5.Name = "Bank5";
            this.Bank5.Size = new System.Drawing.Size(434, 126);
            this.Bank5.TabIndex = 4;
            this.Bank5.Text = "5";
            this.Bank5.VerticalScrollbarBarColor = true;
            this.Bank5.VerticalScrollbarHighlightOnWheel = false;
            this.Bank5.VerticalScrollbarSize = 10;
            // 
            // Bank6
            // 
            this.Bank6.HorizontalScrollbarBarColor = true;
            this.Bank6.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank6.HorizontalScrollbarSize = 10;
            this.Bank6.Location = new System.Drawing.Point(4, 34);
            this.Bank6.Name = "Bank6";
            this.Bank6.Size = new System.Drawing.Size(434, 126);
            this.Bank6.TabIndex = 5;
            this.Bank6.Text = "6";
            this.Bank6.VerticalScrollbarBarColor = true;
            this.Bank6.VerticalScrollbarHighlightOnWheel = false;
            this.Bank6.VerticalScrollbarSize = 10;
            // 
            // Bank7
            // 
            this.Bank7.HorizontalScrollbarBarColor = true;
            this.Bank7.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank7.HorizontalScrollbarSize = 10;
            this.Bank7.Location = new System.Drawing.Point(4, 34);
            this.Bank7.Name = "Bank7";
            this.Bank7.Size = new System.Drawing.Size(434, 126);
            this.Bank7.TabIndex = 6;
            this.Bank7.Text = "7";
            this.Bank7.VerticalScrollbarBarColor = true;
            this.Bank7.VerticalScrollbarHighlightOnWheel = false;
            this.Bank7.VerticalScrollbarSize = 10;
            // 
            // AddSceneButton
            // 
            this.AddSceneButton.Location = new System.Drawing.Point(465, 14);
            this.AddSceneButton.Name = "AddSceneButton";
            this.AddSceneButton.Size = new System.Drawing.Size(138, 25);
            this.AddSceneButton.TabIndex = 14;
            this.AddSceneButton.Text = "Ajout Scène";
            this.AddSceneButton.UseSelectable = true;
            this.AddSceneButton.Click += new System.EventHandler(this.AddSceneButton_Click);
            // 
            // TimerSpeed
            // 
            this.TimerSpeed.Tick += new System.EventHandler(this.TimerSpeed_Tick);
            // 
            // Bank4
            // 
            this.Bank4.HorizontalScrollbarBarColor = true;
            this.Bank4.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank4.HorizontalScrollbarSize = 10;
            this.Bank4.Location = new System.Drawing.Point(4, 34);
            this.Bank4.Name = "Bank4";
            this.Bank4.Size = new System.Drawing.Size(434, 126);
            this.Bank4.TabIndex = 3;
            this.Bank4.Text = "4";
            this.Bank4.VerticalScrollbarBarColor = true;
            this.Bank4.VerticalScrollbarHighlightOnWheel = false;
            this.Bank4.VerticalScrollbarSize = 10;
            // 
            // Bank8
            // 
            this.Bank8.HorizontalScrollbarBarColor = true;
            this.Bank8.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank8.HorizontalScrollbarSize = 10;
            this.Bank8.Location = new System.Drawing.Point(4, 34);
            this.Bank8.Name = "Bank8";
            this.Bank8.Size = new System.Drawing.Size(434, 126);
            this.Bank8.TabIndex = 7;
            this.Bank8.Text = "8";
            this.Bank8.VerticalScrollbarBarColor = true;
            this.Bank8.VerticalScrollbarHighlightOnWheel = false;
            this.Bank8.VerticalScrollbarSize = 10;
            // 
            // HGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddSceneButton);
            this.Controls.Add(this.LedGroupTabControl);
            this.Controls.Add(this.AddLedButton);
            this.Controls.Add(this.NameGroupLabel);
            this.Controls.Add(this.NameGroupText);
            this.Name = "HGroupControl";
            this.Size = new System.Drawing.Size(640, 498);
            this.LedGroupTabControl.ResumeLayout(false);
            this.LedTabPage.ResumeLayout(false);
            this.LedTabPage.PerformLayout();
            this.SceneTabPage.ResumeLayout(false);
            this.SceneTabPage.PerformLayout();
            this.SceneTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NameGroupLabel;
        private MetroFramework.Controls.MetroLabel SceneLabel;
        private System.Windows.Forms.FlowLayoutPanel AnimationPanel;
        private MetroFramework.Controls.MetroLabel AnimationLabel;
        private System.Windows.Forms.FlowLayoutPanel LedPanel;
        private MetroFramework.Controls.MetroLabel LedLabel;
        private MetroFramework.Controls.MetroButton AddLedButton;
        private MetroFramework.Controls.MetroTabControl LedGroupTabControl;
        private MetroFramework.Controls.MetroTabPage LedTabPage;
        private MetroFramework.Controls.MetroTabPage SceneTabPage;
        private MetroFramework.Controls.MetroButton AddSceneButton;
        public MetroFramework.Controls.MetroTextBox NameGroupText;
        private MetroFramework.Controls.MetroButton PlayPauseButton;
        public System.Windows.Forms.Timer TimerSpeed;
        private MetroFramework.Controls.MetroTabControl SceneTabControl;
        private MetroFramework.Controls.MetroTabPage Bank1;
        private MetroFramework.Controls.MetroTabPage Bank2;
        private MetroFramework.Controls.MetroTabPage Bank3;
        private MetroFramework.Controls.MetroTabPage Bank5;
        private MetroFramework.Controls.MetroTabPage Bank6;
        private MetroFramework.Controls.MetroTabPage Bank7;
        private MetroFramework.Controls.MetroTabPage Bank4;
        private MetroFramework.Controls.MetroTabPage Bank8;
    }
}
