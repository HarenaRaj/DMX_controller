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
            this.LedContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.DeleteLedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UniversePanel = new System.Windows.Forms.Panel();
            this.GroupParentPanel = new System.Windows.Forms.Panel();
            this.AddGroupButton = new MetroFramework.Controls.MetroButton();
            this.GroupPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LedContextMenu.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.UniversePanel.SuspendLayout();
            this.GroupParentPanel.SuspendLayout();
            this.SuspendLayout();
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
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.White;
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(20, 60);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 10, 0, 10);
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(1839, 49);
            this.MenuStrip.TabIndex = 1;
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // LedPanel
            // 
            this.LedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LedPanel.Location = new System.Drawing.Point(20, 109);
            this.LedPanel.Name = "LedPanel";
            this.LedPanel.Size = new System.Drawing.Size(129, 995);
            this.LedPanel.TabIndex = 3;
            // 
            // UniversePanel
            // 
            this.UniversePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UniversePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UniversePanel.Controls.Add(this.GroupParentPanel);
            this.UniversePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UniversePanel.Location = new System.Drawing.Point(149, 109);
            this.UniversePanel.Name = "UniversePanel";
            this.UniversePanel.Size = new System.Drawing.Size(1710, 995);
            this.UniversePanel.TabIndex = 4;
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
            this.GroupParentPanel.Size = new System.Drawing.Size(704, 993);
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
            // 
            // GroupPanel
            // 
            this.GroupPanel.AutoScroll = true;
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.GroupPanel.Size = new System.Drawing.Size(700, 989);
            this.GroupPanel.TabIndex = 1;
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 1124);
            this.Controls.Add(this.UniversePanel);
            this.Controls.Add(this.LedPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "ControlForm";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LedContextMenu.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.UniversePanel.ResumeLayout(false);
            this.GroupParentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroContextMenu LedContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteLedMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel LedPanel;
        private System.Windows.Forms.Panel UniversePanel;
        private System.Windows.Forms.Panel GroupParentPanel;
        private MetroFramework.Controls.MetroButton AddGroupButton;
        private System.Windows.Forms.FlowLayoutPanel GroupPanel;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}

