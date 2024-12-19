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
            this.components = new System.ComponentModel.Container();
            this.LedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UniversPanel = new System.Windows.Forms.Panel();
            this.GroupParentPanel = new System.Windows.Forms.Panel();
            this.AddGroupButton = new MetroFramework.Controls.MetroButton();
            this.GroupPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LedContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.DeleteLedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UniversPanel.SuspendLayout();
            this.GroupParentPanel.SuspendLayout();
            this.LedContextMenu.SuspendLayout();
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
            // UniversPanel
            // 
            this.UniversPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UniversPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UniversPanel.Controls.Add(this.GroupParentPanel);
            this.UniversPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UniversPanel.Location = new System.Drawing.Point(149, 60);
            this.UniversPanel.Name = "UniversPanel";
            this.UniversPanel.Size = new System.Drawing.Size(1710, 1044);
            this.UniversPanel.TabIndex = 2;
            this.UniversPanel.Click += new System.EventHandler(this.UniversPanel_Click);
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
            // LedContextMenu
            // 
            this.LedContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LedContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteLedMenuItem});
            this.LedContextMenu.Name = "LedContextMenu";
            this.LedContextMenu.Size = new System.Drawing.Size(168, 36);
            // 
            // DeleteLedMenuItem
            // 
            this.DeleteLedMenuItem.Name = "DeleteLedMenuItem";
            this.DeleteLedMenuItem.Size = new System.Drawing.Size(167, 32);
            this.DeleteLedMenuItem.Text = "Supprimer";
            this.DeleteLedMenuItem.Click += new System.EventHandler(this.DeleteLedMenuItem_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 1124);
            this.Controls.Add(this.UniversPanel);
            this.Controls.Add(this.LedPanel);
            this.Name = "ControlForm";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.UniversPanel.ResumeLayout(false);
            this.GroupParentPanel.ResumeLayout(false);
            this.LedContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel LedPanel;
        private System.Windows.Forms.Panel UniversPanel;
        private System.Windows.Forms.Panel GroupParentPanel;
        private MetroFramework.Controls.MetroButton AddGroupButton;
        private System.Windows.Forms.FlowLayoutPanel GroupPanel;
        private MetroFramework.Controls.MetroContextMenu LedContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteLedMenuItem;
    }
}

