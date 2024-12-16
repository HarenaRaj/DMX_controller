namespace HLight
{
    partial class ControlForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EnvironmentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LedPanel
            // 
            this.LedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LedPanel.Location = new System.Drawing.Point(20, 60);
            this.LedPanel.Name = "LedPanel";
            this.LedPanel.Size = new System.Drawing.Size(129, 1044);
            this.LedPanel.TabIndex = 1;
            // 
            // EnvironmentPanel
            // 
            this.EnvironmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnvironmentPanel.Location = new System.Drawing.Point(149, 60);
            this.EnvironmentPanel.Name = "EnvironmentPanel";
            this.EnvironmentPanel.Size = new System.Drawing.Size(1710, 1044);
            this.EnvironmentPanel.TabIndex = 2;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 1124);
            this.Controls.Add(this.EnvironmentPanel);
            this.Controls.Add(this.LedPanel);
            this.Name = "ControlForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel LedPanel;
        private System.Windows.Forms.Panel EnvironmentPanel;
    }
}

