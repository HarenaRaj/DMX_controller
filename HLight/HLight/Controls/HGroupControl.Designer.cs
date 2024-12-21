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
            this.LedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LedLabel = new MetroFramework.Controls.MetroLabel();
            this.AddLedButton = new MetroFramework.Controls.MetroButton();
            this.LedGroupTabControl = new MetroFramework.Controls.MetroTabControl();
            this.LedTabPage = new MetroFramework.Controls.MetroTabPage();
            this.SceneTabPage = new MetroFramework.Controls.MetroTabPage();
            this.AddAnimationButton = new MetroFramework.Controls.MetroButton();
            this.PlayPauseButton = new MetroFramework.Controls.MetroButton();
            this.SceneTabControl = new MetroFramework.Controls.MetroTabControl();
            this.Bank1 = new MetroFramework.Controls.MetroTabPage();
            this.BankPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bank2 = new MetroFramework.Controls.MetroTabPage();
            this.BankPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bank3 = new MetroFramework.Controls.MetroTabPage();
            this.BankPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bank4 = new MetroFramework.Controls.MetroTabPage();
            this.BankPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bank5 = new MetroFramework.Controls.MetroTabPage();
            this.BankPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bank6 = new MetroFramework.Controls.MetroTabPage();
            this.BankPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bank7 = new MetroFramework.Controls.MetroTabPage();
            this.BankPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bank8 = new MetroFramework.Controls.MetroTabPage();
            this.BankPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.AnimationTabPage = new MetroFramework.Controls.MetroTabPage();
            this.AnimationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AnimationLabel = new MetroFramework.Controls.MetroLabel();
            this.AddSceneButton = new MetroFramework.Controls.MetroButton();
            this.TimerSpeed = new System.Windows.Forms.Timer(this.components);
            this.TimerAnimation = new System.Windows.Forms.Timer(this.components);
            this.SceneContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnimationContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.DeleteAnimationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LedContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.DeleteLedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteGroupButton = new System.Windows.Forms.PictureBox();
            this.LedGroupTabControl.SuspendLayout();
            this.LedTabPage.SuspendLayout();
            this.SceneTabPage.SuspendLayout();
            this.SceneTabControl.SuspendLayout();
            this.Bank1.SuspendLayout();
            this.Bank2.SuspendLayout();
            this.Bank3.SuspendLayout();
            this.Bank4.SuspendLayout();
            this.Bank5.SuspendLayout();
            this.Bank6.SuspendLayout();
            this.Bank7.SuspendLayout();
            this.Bank8.SuspendLayout();
            this.AnimationTabPage.SuspendLayout();
            this.SceneContextMenu.SuspendLayout();
            this.AnimationContextMenu.SuspendLayout();
            this.LedContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteGroupButton)).BeginInit();
            this.SuspendLayout();
            // 
            // NameGroupLabel
            // 
            this.NameGroupLabel.AutoSize = true;
            this.NameGroupLabel.Enabled = false;
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
            this.SceneLabel.Location = new System.Drawing.Point(14, 91);
            this.SceneLabel.Name = "SceneLabel";
            this.SceneLabel.Size = new System.Drawing.Size(47, 15);
            this.SceneLabel.TabIndex = 5;
            this.SceneLabel.Text = "Scènes :";
            // 
            // LedPanel
            // 
            this.LedPanel.AutoScroll = true;
            this.LedPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LedPanel.Location = new System.Drawing.Point(126, 21);
            this.LedPanel.Name = "LedPanel";
            this.LedPanel.Size = new System.Drawing.Size(491, 153);
            this.LedPanel.TabIndex = 11;
            // 
            // LedLabel
            // 
            this.LedLabel.AutoSize = true;
            this.LedLabel.Enabled = false;
            this.LedLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.LedLabel.Location = new System.Drawing.Point(14, 91);
            this.LedLabel.Name = "LedLabel";
            this.LedLabel.Size = new System.Drawing.Size(36, 15);
            this.LedLabel.TabIndex = 10;
            this.LedLabel.Text = "Leds :";
            // 
            // AddLedButton
            // 
            this.AddLedButton.Location = new System.Drawing.Point(311, 14);
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
            this.LedGroupTabControl.Controls.Add(this.AnimationTabPage);
            this.LedGroupTabControl.Location = new System.Drawing.Point(3, 55);
            this.LedGroupTabControl.Name = "LedGroupTabControl";
            this.LedGroupTabControl.SelectedIndex = 1;
            this.LedGroupTabControl.Size = new System.Drawing.Size(1191, 861);
            this.LedGroupTabControl.TabIndex = 13;
            this.LedGroupTabControl.UseSelectable = true;
            this.LedGroupTabControl.Click += new System.EventHandler(this.LedGroupTabControl_Click);
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
            this.LedTabPage.Click += new System.EventHandler(this.LedTabPage_Click);
            // 
            // SceneTabPage
            // 
            this.SceneTabPage.Controls.Add(this.AddAnimationButton);
            this.SceneTabPage.Controls.Add(this.PlayPauseButton);
            this.SceneTabPage.Controls.Add(this.SceneLabel);
            this.SceneTabPage.Controls.Add(this.SceneTabControl);
            this.SceneTabPage.HorizontalScrollbarBarColor = true;
            this.SceneTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.SceneTabPage.HorizontalScrollbarSize = 10;
            this.SceneTabPage.Location = new System.Drawing.Point(4, 38);
            this.SceneTabPage.Name = "SceneTabPage";
            this.SceneTabPage.Size = new System.Drawing.Size(1183, 819);
            this.SceneTabPage.TabIndex = 1;
            this.SceneTabPage.Text = "Liste des scènes";
            this.SceneTabPage.VerticalScrollbarBarColor = true;
            this.SceneTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.SceneTabPage.VerticalScrollbarSize = 10;
            // 
            // AddAnimationButton
            // 
            this.AddAnimationButton.BackgroundImage = global::HLight.Properties.Resources.Add;
            this.AddAnimationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddAnimationButton.Location = new System.Drawing.Point(608, 67);
            this.AddAnimationButton.Name = "AddAnimationButton";
            this.AddAnimationButton.Size = new System.Drawing.Size(40, 40);
            this.AddAnimationButton.TabIndex = 12;
            this.AddAnimationButton.UseSelectable = true;
            this.AddAnimationButton.UseStyleColors = true;
            this.AddAnimationButton.Click += new System.EventHandler(this.AddAnimationButton_Click);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackgroundImage = global::HLight.Properties.Resources.Play;
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayPauseButton.Location = new System.Drawing.Point(608, 21);
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
            this.SceneTabControl.Location = new System.Drawing.Point(126, 21);
            this.SceneTabControl.Name = "SceneTabControl";
            this.SceneTabControl.SelectedIndex = 0;
            this.SceneTabControl.Size = new System.Drawing.Size(476, 153);
            this.SceneTabControl.TabIndex = 11;
            this.SceneTabControl.UseSelectable = true;
            // 
            // Bank1
            // 
            this.Bank1.AutoScroll = true;
            this.Bank1.Controls.Add(this.BankPanel1);
            this.Bank1.HorizontalScrollbar = true;
            this.Bank1.HorizontalScrollbarBarColor = false;
            this.Bank1.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank1.HorizontalScrollbarSize = 10;
            this.Bank1.Location = new System.Drawing.Point(4, 34);
            this.Bank1.Name = "Bank1";
            this.Bank1.Size = new System.Drawing.Size(468, 115);
            this.Bank1.TabIndex = 0;
            this.Bank1.Text = "1";
            this.Bank1.VerticalScrollbar = true;
            this.Bank1.VerticalScrollbarBarColor = false;
            this.Bank1.VerticalScrollbarHighlightOnWheel = false;
            this.Bank1.VerticalScrollbarSize = 10;
            // 
            // BankPanel1
            // 
            this.BankPanel1.AutoSize = true;
            this.BankPanel1.BackColor = System.Drawing.Color.White;
            this.BankPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BankPanel1.Location = new System.Drawing.Point(0, 0);
            this.BankPanel1.Name = "BankPanel1";
            this.BankPanel1.Size = new System.Drawing.Size(468, 0);
            this.BankPanel1.TabIndex = 2;
            // 
            // Bank2
            // 
            this.Bank2.Controls.Add(this.BankPanel2);
            this.Bank2.HorizontalScrollbarBarColor = true;
            this.Bank2.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank2.HorizontalScrollbarSize = 10;
            this.Bank2.Location = new System.Drawing.Point(4, 34);
            this.Bank2.Name = "Bank2";
            this.Bank2.Size = new System.Drawing.Size(468, 115);
            this.Bank2.TabIndex = 1;
            this.Bank2.Text = "2";
            this.Bank2.VerticalScrollbar = true;
            this.Bank2.VerticalScrollbarBarColor = true;
            this.Bank2.VerticalScrollbarHighlightOnWheel = true;
            this.Bank2.VerticalScrollbarSize = 10;
            // 
            // BankPanel2
            // 
            this.BankPanel2.AutoSize = true;
            this.BankPanel2.BackColor = System.Drawing.Color.White;
            this.BankPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.BankPanel2.Location = new System.Drawing.Point(0, 0);
            this.BankPanel2.Name = "BankPanel2";
            this.BankPanel2.Size = new System.Drawing.Size(468, 0);
            this.BankPanel2.TabIndex = 3;
            // 
            // Bank3
            // 
            this.Bank3.Controls.Add(this.BankPanel3);
            this.Bank3.HorizontalScrollbarBarColor = true;
            this.Bank3.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank3.HorizontalScrollbarSize = 10;
            this.Bank3.Location = new System.Drawing.Point(4, 34);
            this.Bank3.Name = "Bank3";
            this.Bank3.Size = new System.Drawing.Size(468, 115);
            this.Bank3.TabIndex = 2;
            this.Bank3.Text = "3";
            this.Bank3.VerticalScrollbar = true;
            this.Bank3.VerticalScrollbarBarColor = true;
            this.Bank3.VerticalScrollbarHighlightOnWheel = true;
            this.Bank3.VerticalScrollbarSize = 10;
            // 
            // BankPanel3
            // 
            this.BankPanel3.AutoSize = true;
            this.BankPanel3.BackColor = System.Drawing.Color.White;
            this.BankPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.BankPanel3.Location = new System.Drawing.Point(0, 0);
            this.BankPanel3.Name = "BankPanel3";
            this.BankPanel3.Size = new System.Drawing.Size(468, 0);
            this.BankPanel3.TabIndex = 3;
            // 
            // Bank4
            // 
            this.Bank4.Controls.Add(this.BankPanel4);
            this.Bank4.HorizontalScrollbarBarColor = true;
            this.Bank4.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank4.HorizontalScrollbarSize = 10;
            this.Bank4.Location = new System.Drawing.Point(4, 34);
            this.Bank4.Name = "Bank4";
            this.Bank4.Size = new System.Drawing.Size(468, 115);
            this.Bank4.TabIndex = 3;
            this.Bank4.Text = "4";
            this.Bank4.VerticalScrollbar = true;
            this.Bank4.VerticalScrollbarBarColor = true;
            this.Bank4.VerticalScrollbarHighlightOnWheel = true;
            this.Bank4.VerticalScrollbarSize = 10;
            // 
            // BankPanel4
            // 
            this.BankPanel4.AutoSize = true;
            this.BankPanel4.BackColor = System.Drawing.Color.White;
            this.BankPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.BankPanel4.Location = new System.Drawing.Point(0, 0);
            this.BankPanel4.Name = "BankPanel4";
            this.BankPanel4.Size = new System.Drawing.Size(468, 0);
            this.BankPanel4.TabIndex = 3;
            // 
            // Bank5
            // 
            this.Bank5.Controls.Add(this.BankPanel5);
            this.Bank5.HorizontalScrollbarBarColor = true;
            this.Bank5.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank5.HorizontalScrollbarSize = 10;
            this.Bank5.Location = new System.Drawing.Point(4, 34);
            this.Bank5.Name = "Bank5";
            this.Bank5.Size = new System.Drawing.Size(468, 115);
            this.Bank5.TabIndex = 4;
            this.Bank5.Text = "5";
            this.Bank5.VerticalScrollbar = true;
            this.Bank5.VerticalScrollbarBarColor = true;
            this.Bank5.VerticalScrollbarHighlightOnWheel = true;
            this.Bank5.VerticalScrollbarSize = 10;
            // 
            // BankPanel5
            // 
            this.BankPanel5.AutoSize = true;
            this.BankPanel5.BackColor = System.Drawing.Color.White;
            this.BankPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.BankPanel5.Location = new System.Drawing.Point(0, 0);
            this.BankPanel5.Name = "BankPanel5";
            this.BankPanel5.Size = new System.Drawing.Size(468, 0);
            this.BankPanel5.TabIndex = 3;
            // 
            // Bank6
            // 
            this.Bank6.AutoScroll = true;
            this.Bank6.Controls.Add(this.BankPanel6);
            this.Bank6.HorizontalScrollbar = true;
            this.Bank6.HorizontalScrollbarBarColor = false;
            this.Bank6.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank6.HorizontalScrollbarSize = 10;
            this.Bank6.Location = new System.Drawing.Point(4, 34);
            this.Bank6.Name = "Bank6";
            this.Bank6.Size = new System.Drawing.Size(468, 115);
            this.Bank6.TabIndex = 5;
            this.Bank6.Text = "6";
            this.Bank6.VerticalScrollbar = true;
            this.Bank6.VerticalScrollbarBarColor = true;
            this.Bank6.VerticalScrollbarHighlightOnWheel = true;
            this.Bank6.VerticalScrollbarSize = 10;
            // 
            // BankPanel6
            // 
            this.BankPanel6.AutoSize = true;
            this.BankPanel6.BackColor = System.Drawing.Color.White;
            this.BankPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.BankPanel6.Location = new System.Drawing.Point(0, 0);
            this.BankPanel6.Name = "BankPanel6";
            this.BankPanel6.Size = new System.Drawing.Size(442, 0);
            this.BankPanel6.TabIndex = 3;
            // 
            // Bank7
            // 
            this.Bank7.Controls.Add(this.BankPanel7);
            this.Bank7.HorizontalScrollbarBarColor = true;
            this.Bank7.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank7.HorizontalScrollbarSize = 10;
            this.Bank7.Location = new System.Drawing.Point(4, 34);
            this.Bank7.Name = "Bank7";
            this.Bank7.Size = new System.Drawing.Size(468, 115);
            this.Bank7.TabIndex = 6;
            this.Bank7.Text = "7";
            this.Bank7.VerticalScrollbar = true;
            this.Bank7.VerticalScrollbarBarColor = true;
            this.Bank7.VerticalScrollbarHighlightOnWheel = true;
            this.Bank7.VerticalScrollbarSize = 10;
            // 
            // BankPanel7
            // 
            this.BankPanel7.AutoSize = true;
            this.BankPanel7.BackColor = System.Drawing.Color.White;
            this.BankPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.BankPanel7.Location = new System.Drawing.Point(0, 0);
            this.BankPanel7.Name = "BankPanel7";
            this.BankPanel7.Size = new System.Drawing.Size(468, 0);
            this.BankPanel7.TabIndex = 3;
            // 
            // Bank8
            // 
            this.Bank8.Controls.Add(this.BankPanel8);
            this.Bank8.HorizontalScrollbarBarColor = true;
            this.Bank8.HorizontalScrollbarHighlightOnWheel = false;
            this.Bank8.HorizontalScrollbarSize = 10;
            this.Bank8.Location = new System.Drawing.Point(4, 34);
            this.Bank8.Name = "Bank8";
            this.Bank8.Size = new System.Drawing.Size(468, 115);
            this.Bank8.TabIndex = 7;
            this.Bank8.Text = "8";
            this.Bank8.VerticalScrollbar = true;
            this.Bank8.VerticalScrollbarBarColor = true;
            this.Bank8.VerticalScrollbarHighlightOnWheel = true;
            this.Bank8.VerticalScrollbarSize = 10;
            // 
            // BankPanel8
            // 
            this.BankPanel8.AutoSize = true;
            this.BankPanel8.BackColor = System.Drawing.Color.White;
            this.BankPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.BankPanel8.Location = new System.Drawing.Point(0, 0);
            this.BankPanel8.Name = "BankPanel8";
            this.BankPanel8.Size = new System.Drawing.Size(468, 0);
            this.BankPanel8.TabIndex = 3;
            // 
            // AnimationTabPage
            // 
            this.AnimationTabPage.Controls.Add(this.AnimationPanel);
            this.AnimationTabPage.Controls.Add(this.AnimationLabel);
            this.AnimationTabPage.HorizontalScrollbarBarColor = true;
            this.AnimationTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.AnimationTabPage.HorizontalScrollbarSize = 10;
            this.AnimationTabPage.Location = new System.Drawing.Point(4, 38);
            this.AnimationTabPage.Name = "AnimationTabPage";
            this.AnimationTabPage.Size = new System.Drawing.Size(1183, 819);
            this.AnimationTabPage.TabIndex = 2;
            this.AnimationTabPage.Text = "Liste des animations";
            this.AnimationTabPage.VerticalScrollbarBarColor = true;
            this.AnimationTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.AnimationTabPage.VerticalScrollbarSize = 10;
            // 
            // AnimationPanel
            // 
            this.AnimationPanel.AutoScroll = true;
            this.AnimationPanel.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.AnimationPanel.BackColor = System.Drawing.Color.Transparent;
            this.AnimationPanel.Location = new System.Drawing.Point(126, 21);
            this.AnimationPanel.Name = "AnimationPanel";
            this.AnimationPanel.Size = new System.Drawing.Size(491, 153);
            this.AnimationPanel.TabIndex = 11;
            // 
            // AnimationLabel
            // 
            this.AnimationLabel.AutoSize = true;
            this.AnimationLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.AnimationLabel.Location = new System.Drawing.Point(14, 90);
            this.AnimationLabel.Name = "AnimationLabel";
            this.AnimationLabel.Size = new System.Drawing.Size(69, 15);
            this.AnimationLabel.TabIndex = 10;
            this.AnimationLabel.Text = "Animations :";
            // 
            // AddSceneButton
            // 
            this.AddSceneButton.Location = new System.Drawing.Point(455, 14);
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
            // TimerAnimation
            // 
            this.TimerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // SceneContextMenu
            // 
            this.SceneContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SceneContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteMenuItem});
            this.SceneContextMenu.Name = "SceneContextMenu";
            this.SceneContextMenu.Size = new System.Drawing.Size(168, 36);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(167, 32);
            this.DeleteMenuItem.Text = "Supprimer";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteSceneMenuItem_Click);
            // 
            // AnimationContextMenu
            // 
            this.AnimationContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AnimationContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteAnimationMenuItem});
            this.AnimationContextMenu.Name = "SceneContextMenu";
            this.AnimationContextMenu.Size = new System.Drawing.Size(168, 36);
            // 
            // DeleteAnimationMenuItem
            // 
            this.DeleteAnimationMenuItem.Name = "DeleteAnimationMenuItem";
            this.DeleteAnimationMenuItem.Size = new System.Drawing.Size(167, 32);
            this.DeleteAnimationMenuItem.Text = "Supprimer";
            this.DeleteAnimationMenuItem.Click += new System.EventHandler(this.DeleteAnimationMenuItem_Click);
            // 
            // LedContextMenu
            // 
            this.LedContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LedContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteLedMenuItem});
            this.LedContextMenu.Name = "SceneContextMenu";
            this.LedContextMenu.Size = new System.Drawing.Size(168, 36);
            // 
            // DeleteLedMenuItem
            // 
            this.DeleteLedMenuItem.Name = "DeleteLedMenuItem";
            this.DeleteLedMenuItem.Size = new System.Drawing.Size(167, 32);
            this.DeleteLedMenuItem.Text = "Supprimer";
            this.DeleteLedMenuItem.Click += new System.EventHandler(this.DeleteLedMenuItem_Click);
            // 
            // DeleteGroupButton
            // 
            this.DeleteGroupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteGroupButton.Image = global::HLight.Properties.Resources.Delete;
            this.DeleteGroupButton.Location = new System.Drawing.Point(626, 11);
            this.DeleteGroupButton.Name = "DeleteGroupButton";
            this.DeleteGroupButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteGroupButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteGroupButton.TabIndex = 15;
            this.DeleteGroupButton.TabStop = false;
            this.DeleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            // 
            // HGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteGroupButton);
            this.Controls.Add(this.AddSceneButton);
            this.Controls.Add(this.LedGroupTabControl);
            this.Controls.Add(this.AddLedButton);
            this.Controls.Add(this.NameGroupLabel);
            this.Controls.Add(this.NameGroupText);
            this.Name = "HGroupControl";
            this.Size = new System.Drawing.Size(665, 304);
            this.Click += new System.EventHandler(this.HGroupControl_Click);
            this.LedGroupTabControl.ResumeLayout(false);
            this.LedTabPage.ResumeLayout(false);
            this.LedTabPage.PerformLayout();
            this.SceneTabPage.ResumeLayout(false);
            this.SceneTabPage.PerformLayout();
            this.SceneTabControl.ResumeLayout(false);
            this.Bank1.ResumeLayout(false);
            this.Bank1.PerformLayout();
            this.Bank2.ResumeLayout(false);
            this.Bank2.PerformLayout();
            this.Bank3.ResumeLayout(false);
            this.Bank3.PerformLayout();
            this.Bank4.ResumeLayout(false);
            this.Bank4.PerformLayout();
            this.Bank5.ResumeLayout(false);
            this.Bank5.PerformLayout();
            this.Bank6.ResumeLayout(false);
            this.Bank6.PerformLayout();
            this.Bank7.ResumeLayout(false);
            this.Bank7.PerformLayout();
            this.Bank8.ResumeLayout(false);
            this.Bank8.PerformLayout();
            this.AnimationTabPage.ResumeLayout(false);
            this.AnimationTabPage.PerformLayout();
            this.SceneContextMenu.ResumeLayout(false);
            this.AnimationContextMenu.ResumeLayout(false);
            this.LedContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteGroupButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NameGroupLabel;
        private MetroFramework.Controls.MetroLabel SceneLabel;
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
        private MetroFramework.Controls.MetroTabPage Bank1;
        private MetroFramework.Controls.MetroTabPage Bank2;
        private MetroFramework.Controls.MetroTabPage Bank3;
        private MetroFramework.Controls.MetroTabPage Bank5;
        private MetroFramework.Controls.MetroTabPage Bank6;
        private MetroFramework.Controls.MetroTabPage Bank7;
        private MetroFramework.Controls.MetroTabPage Bank4;
        private MetroFramework.Controls.MetroTabPage Bank8;
        private MetroFramework.Controls.MetroButton AddAnimationButton;
        public System.Windows.Forms.Timer TimerAnimation;
        private System.Windows.Forms.FlowLayoutPanel BankPanel1;
        private System.Windows.Forms.FlowLayoutPanel BankPanel2;
        private System.Windows.Forms.FlowLayoutPanel BankPanel3;
        private System.Windows.Forms.FlowLayoutPanel BankPanel4;
        private System.Windows.Forms.FlowLayoutPanel BankPanel5;
        private System.Windows.Forms.FlowLayoutPanel BankPanel6;
        private System.Windows.Forms.FlowLayoutPanel BankPanel7;
        private System.Windows.Forms.FlowLayoutPanel BankPanel8;
        private MetroFramework.Controls.MetroContextMenu SceneContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private MetroFramework.Controls.MetroContextMenu AnimationContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteAnimationMenuItem;
        private MetroFramework.Controls.MetroContextMenu LedContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteLedMenuItem;
        private System.Windows.Forms.PictureBox DeleteGroupButton;
        private MetroFramework.Controls.MetroTabPage AnimationTabPage;
        private System.Windows.Forms.FlowLayoutPanel AnimationPanel;
        private MetroFramework.Controls.MetroLabel AnimationLabel;
        public MetroFramework.Controls.MetroTabControl SceneTabControl;
    }
}
