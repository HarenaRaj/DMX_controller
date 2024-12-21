namespace HLight.Forms
{
    partial class HChannelControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameText = new MetroFramework.Controls.MetroTextBox();
            this.ChannelNumeric = new System.Windows.Forms.NumericUpDown();
            this.ChannelLabel = new MetroFramework.Controls.MetroLabel();
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.LedInfoPanel = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelNumeric)).BeginInit();
            this.LedInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameText
            // 
            // 
            // 
            // 
            this.NameText.CustomButton.Image = null;
            this.NameText.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.NameText.CustomButton.Name = "";
            this.NameText.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.NameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameText.CustomButton.TabIndex = 1;
            this.NameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameText.CustomButton.UseSelectable = true;
            this.NameText.CustomButton.Visible = false;
            this.NameText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NameText.Lines = new string[0];
            this.NameText.Location = new System.Drawing.Point(250, 4);
            this.NameText.MaxLength = 32767;
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameText.SelectedText = "";
            this.NameText.SelectionLength = 0;
            this.NameText.SelectionStart = 0;
            this.NameText.ShortcutsEnabled = true;
            this.NameText.Size = new System.Drawing.Size(223, 40);
            this.NameText.TabIndex = 0;
            this.NameText.UseSelectable = true;
            this.NameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // ChannelNumeric
            // 
            this.ChannelNumeric.Location = new System.Drawing.Point(95, 7);
            this.ChannelNumeric.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.ChannelNumeric.Name = "ChannelNumeric";
            this.ChannelNumeric.Size = new System.Drawing.Size(60, 26);
            this.ChannelNumeric.TabIndex = 1;
            this.ChannelNumeric.TextChanged += new System.EventHandler(this.ChannelNumeric_TextChanged);
            this.ChannelNumeric.ValueChanged += new System.EventHandler(this.ChannelNumeric_ValueChanged);
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ChannelLabel.Location = new System.Drawing.Point(33, 14);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(40, 15);
            this.ChannelLabel.TabIndex = 2;
            this.ChannelLabel.Text = "Canal :";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.NameLabel.Location = new System.Drawing.Point(186, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Nom :";
            // 
            // LedInfoPanel
            // 
            this.LedInfoPanel.Controls.Add(this.NameLabel);
            this.LedInfoPanel.Controls.Add(this.ChannelLabel);
            this.LedInfoPanel.Controls.Add(this.ChannelNumeric);
            this.LedInfoPanel.Controls.Add(this.NameText);
            this.LedInfoPanel.HorizontalScrollbarBarColor = true;
            this.LedInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LedInfoPanel.HorizontalScrollbarSize = 10;
            this.LedInfoPanel.Location = new System.Drawing.Point(15, 12);
            this.LedInfoPanel.Name = "LedInfoPanel";
            this.LedInfoPanel.Size = new System.Drawing.Size(512, 49);
            this.LedInfoPanel.TabIndex = 3;
            this.LedInfoPanel.VerticalScrollbarBarColor = true;
            this.LedInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LedInfoPanel.VerticalScrollbarSize = 10;
            // 
            // HChannelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LedInfoPanel);
            this.Name = "HChannelControl";
            this.Size = new System.Drawing.Size(1067, 458);
            ((System.ComponentModel.ISupportInitialize)(this.ChannelNumeric)).EndInit();
            this.LedInfoPanel.ResumeLayout(false);
            this.LedInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox NameText;
        private System.Windows.Forms.NumericUpDown ChannelNumeric;
        private MetroFramework.Controls.MetroLabel ChannelLabel;
        private MetroFramework.Controls.MetroLabel NameLabel;
        public MetroFramework.Controls.MetroPanel LedInfoPanel;
    }
}