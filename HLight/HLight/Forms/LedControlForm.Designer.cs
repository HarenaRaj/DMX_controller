namespace HLight.Forms
{
    partial class LedControlForm
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
            ((System.ComponentModel.ISupportInitialize)(this.ChannelNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // NameText
            // 
            // 
            // 
            // 
            this.NameText.CustomButton.Image = null;
            this.NameText.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.NameText.CustomButton.Name = "";
            this.NameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameText.CustomButton.TabIndex = 1;
            this.NameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameText.CustomButton.UseSelectable = true;
            this.NameText.CustomButton.Visible = false;
            this.NameText.Lines = new string[0];
            this.NameText.Location = new System.Drawing.Point(228, 56);
            this.NameText.MaxLength = 32767;
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameText.SelectedText = "";
            this.NameText.SelectionLength = 0;
            this.NameText.SelectionStart = 0;
            this.NameText.ShortcutsEnabled = true;
            this.NameText.Size = new System.Drawing.Size(223, 23);
            this.NameText.TabIndex = 0;
            this.NameText.UseSelectable = true;
            this.NameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChannelNumeric
            // 
            this.ChannelNumeric.Location = new System.Drawing.Point(85, 53);
            this.ChannelNumeric.Name = "ChannelNumeric";
            this.ChannelNumeric.Size = new System.Drawing.Size(51, 26);
            this.ChannelNumeric.TabIndex = 1;
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(23, 60);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(56, 19);
            this.ChannelLabel.TabIndex = 2;
            this.ChannelLabel.Text = "Cannal :";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(176, 60);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 19);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Nom :";
            // 
            // LedControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 506);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ChannelLabel);
            this.Controls.Add(this.ChannelNumeric);
            this.Controls.Add(this.NameText);
            this.Name = "LedControlForm";
            ((System.ComponentModel.ISupportInitialize)(this.ChannelNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox NameText;
        private System.Windows.Forms.NumericUpDown ChannelNumeric;
        private MetroFramework.Controls.MetroLabel ChannelLabel;
        private MetroFramework.Controls.MetroLabel NameLabel;
    }
}