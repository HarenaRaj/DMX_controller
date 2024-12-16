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
            this.ChannelLabel = new MetroFramework.Controls.MetroLabel();
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.lebBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lebBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChannelLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ChannelLabel.Location = new System.Drawing.Point(0, 0);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(133, 19);
            this.ChannelLabel.TabIndex = 0;
            this.ChannelLabel.Text = "1 - 16";
            this.ChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChannelLabel.Click += new System.EventHandler(this.ChannelLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.NameLabel.Location = new System.Drawing.Point(0, 138);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(133, 46);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Par Led (1)";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLabel.WrapToLine = true;
            // 
            // lebBox
            // 
            this.lebBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lebBox.Enabled = false;
            this.lebBox.Location = new System.Drawing.Point(0, 19);
            this.lebBox.Name = "lebBox";
            this.lebBox.Size = new System.Drawing.Size(133, 120);
            this.lebBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lebBox.TabIndex = 3;
            this.lebBox.TabStop = false;
            this.lebBox.Click += new System.EventHandler(this.lebBox_Click);
            // 
            // HLedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lebBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ChannelLabel);
            this.Name = "HLedControl";
            this.Size = new System.Drawing.Size(133, 184);
            ((System.ComponentModel.ISupportInitialize)(this.lebBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ChannelLabel;
        private MetroFramework.Controls.MetroLabel NameLabel;
        private PictureBox lebBox;
    }
}
