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
            this.NameGroupLabel = new MetroFramework.Controls.MetroLabel();
            this.NameGroupText = new MetroFramework.Controls.MetroTextBox();
            this.SceneLabel = new MetroFramework.Controls.MetroLabel();
            this.ScenePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AnimationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AnimationLabel = new MetroFramework.Controls.MetroLabel();
            this.LedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LedLabel = new MetroFramework.Controls.MetroLabel();
            this.AddLedButton = new MetroFramework.Controls.MetroButton();
            this.LedGroupTabControl = new MetroFramework.Controls.MetroTabControl();
            this.LedTabPage = new MetroFramework.Controls.MetroTabPage();
            this.SceneTabPage = new MetroFramework.Controls.MetroTabPage();
            this.AddSceneButton = new MetroFramework.Controls.MetroButton();
            this.LedGroupTabControl.SuspendLayout();
            this.LedTabPage.SuspendLayout();
            this.SceneTabPage.SuspendLayout();
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
            // ScenePanel
            // 
            this.ScenePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScenePanel.AutoScroll = true;
            this.ScenePanel.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.ScenePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScenePanel.Location = new System.Drawing.Point(127, 22);
            this.ScenePanel.Name = "ScenePanel";
            this.ScenePanel.Size = new System.Drawing.Size(441, 117);
            this.ScenePanel.TabIndex = 7;
            // 
            // AnimationPanel
            // 
            this.AnimationPanel.AutoScroll = true;
            this.AnimationPanel.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.AnimationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnimationPanel.Location = new System.Drawing.Point(127, 162);
            this.AnimationPanel.Name = "AnimationPanel";
            this.AnimationPanel.Size = new System.Drawing.Size(441, 117);
            this.AnimationPanel.TabIndex = 9;
            // 
            // AnimationLabel
            // 
            this.AnimationLabel.AutoSize = true;
            this.AnimationLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.AnimationLabel.Location = new System.Drawing.Point(14, 193);
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
            this.SceneTabPage.Controls.Add(this.AnimationPanel);
            this.SceneTabPage.Controls.Add(this.SceneLabel);
            this.SceneTabPage.Controls.Add(this.AnimationLabel);
            this.SceneTabPage.Controls.Add(this.ScenePanel);
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
            this.Size = new System.Drawing.Size(640, 415);
            this.LedGroupTabControl.ResumeLayout(false);
            this.LedTabPage.ResumeLayout(false);
            this.LedTabPage.PerformLayout();
            this.SceneTabPage.ResumeLayout(false);
            this.SceneTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NameGroupLabel;
        private MetroFramework.Controls.MetroTextBox NameGroupText;
        private MetroFramework.Controls.MetroLabel SceneLabel;
        private System.Windows.Forms.FlowLayoutPanel ScenePanel;
        private System.Windows.Forms.FlowLayoutPanel AnimationPanel;
        private MetroFramework.Controls.MetroLabel AnimationLabel;
        private System.Windows.Forms.FlowLayoutPanel LedPanel;
        private MetroFramework.Controls.MetroLabel LedLabel;
        private MetroFramework.Controls.MetroButton AddLedButton;
        private MetroFramework.Controls.MetroTabControl LedGroupTabControl;
        private MetroFramework.Controls.MetroTabPage LedTabPage;
        private MetroFramework.Controls.MetroTabPage SceneTabPage;
        private MetroFramework.Controls.MetroButton AddSceneButton;
    }
}
