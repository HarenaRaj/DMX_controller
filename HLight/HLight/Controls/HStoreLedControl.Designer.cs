using System.Windows.Forms;

namespace HLight
{
    partial class HStoreLedControl
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
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.LebBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LebBox)).BeginInit();
            this.SuspendLayout();
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
            // LebBox
            // 
            this.LebBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LebBox.Enabled = false;
            this.LebBox.Location = new System.Drawing.Point(0, 0);
            this.LebBox.Name = "LebBox";
            this.LebBox.Size = new System.Drawing.Size(133, 135);
            this.LebBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LebBox.TabIndex = 3;
            this.LebBox.TabStop = false;
            this.LebBox.Click += new System.EventHandler(this.LebBox_Click);
            // 
            // HStoreLedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LebBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "HStoreLedControl";
            this.Size = new System.Drawing.Size(133, 184);
            ((System.ComponentModel.ISupportInitialize)(this.LebBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroLabel NameLabel;
        public PictureBox LebBox;
    }
}
