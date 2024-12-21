using System.Windows.Forms;

namespace HLight
{
    partial class HLedControl
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
            this.ChannelLabel = new MetroFramework.Controls.MetroLabel();
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.LebBox = new System.Windows.Forms.PictureBox();
            this.ledColorBox = new System.Windows.Forms.PictureBox();
            this.timerLed = new System.Windows.Forms.Timer(this.components);
            this.TimerFader = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LebBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChannelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChannelLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ChannelLabel.Location = new System.Drawing.Point(0, 0);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(133, 19);
            this.ChannelLabel.TabIndex = 0;
            this.ChannelLabel.Text = "1 - 16";
            this.ChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChannelLabel.UseCustomBackColor = true;
            this.ChannelLabel.UseCustomForeColor = true;
            this.ChannelLabel.UseStyleColors = true;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.NameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NameLabel.Location = new System.Drawing.Point(0, 138);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(133, 46);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Par Led (1)";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLabel.UseCustomBackColor = true;
            this.NameLabel.UseCustomForeColor = true;
            this.NameLabel.UseStyleColors = true;
            this.NameLabel.WrapToLine = true;
            // 
            // LebBox
            // 
            this.LebBox.BackColor = System.Drawing.Color.Transparent;
            this.LebBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LebBox.Enabled = false;
            this.LebBox.Location = new System.Drawing.Point(0, 19);
            this.LebBox.Name = "LebBox";
            this.LebBox.Size = new System.Drawing.Size(133, 120);
            this.LebBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LebBox.TabIndex = 3;
            this.LebBox.TabStop = false;
            // 
            // ledColorBox
            // 
            this.ledColorBox.BackColor = System.Drawing.Color.Transparent;
            this.ledColorBox.Location = new System.Drawing.Point(86, 22);
            this.ledColorBox.Name = "ledColorBox";
            this.ledColorBox.Size = new System.Drawing.Size(35, 35);
            this.ledColorBox.TabIndex = 4;
            this.ledColorBox.TabStop = false;
            // 
            // timerLed
            // 
            this.timerLed.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TimerFader
            // 
            this.TimerFader.Interval = 1;
            this.TimerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // HLedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ledColorBox);
            this.Controls.Add(this.LebBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ChannelLabel);
            this.Name = "HLedControl";
            this.Size = new System.Drawing.Size(133, 184);
            ((System.ComponentModel.ISupportInitialize)(this.LebBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledColorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroLabel ChannelLabel;
        public MetroFramework.Controls.MetroLabel NameLabel;
        public PictureBox LebBox;
        private PictureBox ledColorBox;
        private Timer timerLed;
        public Timer TimerFader;
    }
}
