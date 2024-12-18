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
            this.GroupParentPanel = new System.Windows.Forms.Panel();
            this.AddGroupButton = new MetroFramework.Controls.MetroButton();
            this.GroupPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EnvironmentPanel.SuspendLayout();
            this.GroupParentPanel.SuspendLayout();
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
            this.EnvironmentPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EnvironmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnvironmentPanel.Controls.Add(this.GroupParentPanel);
            this.EnvironmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnvironmentPanel.Location = new System.Drawing.Point(149, 60);
            this.EnvironmentPanel.Name = "EnvironmentPanel";
            this.EnvironmentPanel.Size = new System.Drawing.Size(1710, 1044);
            this.EnvironmentPanel.TabIndex = 2;
            // 
            // GroupParentPanel
            // 
            this.GroupParentPanel.AutoScrollMargin = new System.Drawing.Size(50, 0);
            this.GroupParentPanel.BackColor = System.Drawing.Color.White;
            this.GroupParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GroupParentPanel.Controls.Add(this.AddGroupButton);
            this.GroupParentPanel.Controls.Add(this.GroupPanel);
            this.GroupParentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupParentPanel.Location = new System.Drawing.Point(1004, 0);
            this.GroupParentPanel.Name = "GroupParentPanel";
            this.GroupParentPanel.Size = new System.Drawing.Size(704, 1042);
            this.GroupParentPanel.TabIndex = 0;
            this.GroupParentPanel.Visible = false;
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddGroupButton.Location = new System.Drawing.Point(0, 0);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(700, 38);
            this.AddGroupButton.TabIndex = 0;
            this.AddGroupButton.Text = "Ajouter un groupe";
            this.AddGroupButton.UseSelectable = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // GroupPanel
            // 
            this.GroupPanel.AutoScroll = true;
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.GroupPanel.Size = new System.Drawing.Size(700, 1038);
            this.GroupPanel.TabIndex = 1;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 1124);
            this.Controls.Add(this.EnvironmentPanel);
            this.Controls.Add(this.LedPanel);
            this.Name = "ControlForm";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.EnvironmentPanel.ResumeLayout(false);
            this.GroupParentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel LedPanel;
        private System.Windows.Forms.Panel EnvironmentPanel;
        private System.Windows.Forms.Panel GroupParentPanel;
        private MetroFramework.Controls.MetroButton AddGroupButton;
        private System.Windows.Forms.FlowLayoutPanel GroupPanel;
    }
}

