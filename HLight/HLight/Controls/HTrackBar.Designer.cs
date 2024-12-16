namespace HLight.Controls
{
    partial class HTrackBar
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
            this.ChannelTrackBar = new System.Windows.Forms.TrackBar();
            this.ChannelLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ChannelTrackBar
            // 
            this.ChannelTrackBar.AutoSize = false;
            this.ChannelTrackBar.LargeChange = 50;
            this.ChannelTrackBar.Location = new System.Drawing.Point(21, 3);
            this.ChannelTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTrackBar.Maximum = 255;
            this.ChannelTrackBar.Name = "ChannelTrackBar";
            this.ChannelTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ChannelTrackBar.Size = new System.Drawing.Size(80, 321);
            this.ChannelTrackBar.TabIndex = 0;
            this.ChannelTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChannelLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ChannelLabel.Location = new System.Drawing.Point(0, 324);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(100, 62);
            this.ChannelLabel.TabIndex = 1;
            this.ChannelLabel.Text = "metroLabel1";
            this.ChannelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChannelLabel.WrapToLine = true;
            // 
            // HTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChannelLabel);
            this.Controls.Add(this.ChannelTrackBar);
            this.Name = "HTrackBar";
            this.Size = new System.Drawing.Size(100, 386);
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TrackBar ChannelTrackBar;
        public MetroFramework.Controls.MetroLabel ChannelLabel;
    }
}
