namespace GestionProjetInformatique
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ffffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherDeveParProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherDeveloppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportcreQ7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalRparComboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffffToolStripMenuItem,
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ffffToolStripMenuItem
            // 
            this.ffffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetsToolStripMenuItem});
            this.ffffToolStripMenuItem.Name = "ffffToolStripMenuItem";
            this.ffffToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.ffffToolStripMenuItem.Text = "Interfaces de mise A jour";
            // 
            // projetsToolStripMenuItem
            // 
            this.projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            this.projetsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.projetsToolStripMenuItem.Text = "Projets";
            this.projetsToolStripMenuItem.Click += new System.EventHandler(this.projetsToolStripMenuItem_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherDeveParProjetToolStripMenuItem,
            this.afficherDeveloppToolStripMenuItem,
            this.rapportcreQ7ToolStripMenuItem,
            this.crystalRparComboToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.formsToolStripMenuItem.Text = "Forms :";
            // 
            // afficherDeveParProjetToolStripMenuItem
            // 
            this.afficherDeveParProjetToolStripMenuItem.Name = "afficherDeveParProjetToolStripMenuItem";
            this.afficherDeveParProjetToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.afficherDeveParProjetToolStripMenuItem.Text = "AfficherDeveParProjet";
            this.afficherDeveParProjetToolStripMenuItem.Click += new System.EventHandler(this.afficherDeveParProjetToolStripMenuItem_Click);
            // 
            // afficherDeveloppToolStripMenuItem
            // 
            this.afficherDeveloppToolStripMenuItem.Name = "afficherDeveloppToolStripMenuItem";
            this.afficherDeveloppToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.afficherDeveloppToolStripMenuItem.Text = "Afficher developpeur par date";
            this.afficherDeveloppToolStripMenuItem.Click += new System.EventHandler(this.afficherDeveloppToolStripMenuItem_Click);
            // 
            // rapportcreQ7ToolStripMenuItem
            // 
            this.rapportcreQ7ToolStripMenuItem.Name = "rapportcreQ7ToolStripMenuItem";
            this.rapportcreQ7ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.rapportcreQ7ToolStripMenuItem.Text = "RapportcreQ7";
            this.rapportcreQ7ToolStripMenuItem.Click += new System.EventHandler(this.rapportcreQ7ToolStripMenuItem_Click);
            // 
            // crystalRparComboToolStripMenuItem
            // 
            this.crystalRparComboToolStripMenuItem.Name = "crystalRparComboToolStripMenuItem";
            this.crystalRparComboToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.crystalRparComboToolStripMenuItem.Text = "CrystalRparCombo";
            this.crystalRparComboToolStripMenuItem.Click += new System.EventHandler(this.crystalRparComboToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 270);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ffffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherDeveParProjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherDeveloppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportcreQ7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crystalRparComboToolStripMenuItem;
    }
}

