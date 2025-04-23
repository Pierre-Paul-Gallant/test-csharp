namespace ListeDisquesCompacts
{
    partial class FrmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.lsvMaCollection = new System.Windows.Forms.ListView();
            this.clhIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNbPistes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDureeTotale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(323, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // lsvMaCollection
            // 
            this.lsvMaCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvMaCollection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhIndex,
            this.clhGenre,
            this.clhNbPistes,
            this.clhDureeTotale});
            this.lsvMaCollection.FullRowSelect = true;
            this.lsvMaCollection.HideSelection = false;
            this.lsvMaCollection.Location = new System.Drawing.Point(12, 36);
            this.lsvMaCollection.MultiSelect = false;
            this.lsvMaCollection.Name = "lsvMaCollection";
            this.lsvMaCollection.Size = new System.Drawing.Size(299, 218);
            this.lsvMaCollection.TabIndex = 1;
            this.lsvMaCollection.UseCompatibleStateImageBehavior = false;
            this.lsvMaCollection.View = System.Windows.Forms.View.Details;
            this.lsvMaCollection.SelectedIndexChanged += new System.EventHandler(this.lsvMaCollection_SelectedIndexChanged);
            // 
            // clhIndex
            // 
            this.clhIndex.Text = "Index";
            this.clhIndex.Width = 45;
            // 
            // clhGenre
            // 
            this.clhGenre.Text = "Genre";
            this.clhGenre.Width = 64;
            // 
            // clhNbPistes
            // 
            this.clhNbPistes.Text = "Pistes";
            this.clhNbPistes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhNbPistes.Width = 48;
            // 
            // clhDureeTotale
            // 
            this.clhDureeTotale.Text = "Durée totale";
            this.clhDureeTotale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhDureeTotale.Width = 96;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 266);
            this.Controls.Add(this.lsvMaCollection);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma collection ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ListView lsvMaCollection;
        private System.Windows.Forms.ColumnHeader clhGenre;
        private System.Windows.Forms.ColumnHeader clhNbPistes;
        private System.Windows.Forms.ColumnHeader clhDureeTotale;
        private System.Windows.Forms.ColumnHeader clhIndex;
    }
}

