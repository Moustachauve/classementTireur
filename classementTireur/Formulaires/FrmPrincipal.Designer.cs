namespace classementTireur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.olvTireur = new BrightIdeasSoftware.ObjectListView();
            this.colNom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEquipe = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colDateDeNaissance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colAge = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colCategorie = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colGrouping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPrecision = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTireur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEquipes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAjouterTireur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTireurSelectionne = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjouterCible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjouterCibleGrouping = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjouterCiblePrecision = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuModifierTireur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupprimerTireur = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDetailsTireur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClassement = new System.Windows.Forms.ToolStripMenuItem();
            this.individuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClassementEquipes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuItemListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuAjouterCible = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuAjouterCibleGrouping = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuAjouterCiblePrecision = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuModifierTireur = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuSupprimerTireur = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuDetailsTireur = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSauvegarde = new System.Windows.Forms.SaveFileDialog();
            this.ofdOuverture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.olvTireur)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.cmnuItemListview.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvTireur
            // 
            this.olvTireur.AllColumns.Add(this.colNom);
            this.olvTireur.AllColumns.Add(this.colEquipe);
            this.olvTireur.AllColumns.Add(this.colDateDeNaissance);
            this.olvTireur.AllColumns.Add(this.colAge);
            this.olvTireur.AllColumns.Add(this.colCategorie);
            this.olvTireur.AllColumns.Add(this.colGrouping);
            this.olvTireur.AllColumns.Add(this.colPrecision);
            this.olvTireur.AllowColumnReorder = true;
            this.olvTireur.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvTireur.CellEditEnterChangesRows = true;
            this.olvTireur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNom,
            this.colEquipe,
            this.colDateDeNaissance,
            this.colAge,
            this.colCategorie,
            this.colGrouping,
            this.colPrecision});
            this.olvTireur.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTireur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTireur.EmptyListMsg = "Il n\'y a aucun tireur";
            this.olvTireur.EmptyListMsgFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvTireur.FullRowSelect = true;
            this.olvTireur.HeaderWordWrap = true;
            this.olvTireur.Location = new System.Drawing.Point(0, 24);
            this.olvTireur.MenuLabelGroupBy = "Grouper par \'{0}\'";
            this.olvTireur.MenuLabelLockGroupingOn = "Garder grouper par \'{0}\'";
            this.olvTireur.MenuLabelSelectColumns = "Afficher les colonnes...";
            this.olvTireur.MenuLabelSortAscending = "Classer en ordre croissant par \'{0}\'";
            this.olvTireur.MenuLabelSortDescending = "Classer en odre décroissant par \'{0}\'";
            this.olvTireur.MenuLabelTurnOffGroups = "Ne pas afficher les groupes";
            this.olvTireur.MenuLabelUnlockGroupingOn = "Ne plus garder grouper par \'{0}\'";
            this.olvTireur.MenuLabelUnsort = "";
            this.olvTireur.MultiSelect = false;
            this.olvTireur.Name = "olvTireur";
            this.olvTireur.SelectAllOnControlA = false;
            this.olvTireur.ShowCommandMenuOnRightClick = true;
            this.olvTireur.Size = new System.Drawing.Size(674, 527);
            this.olvTireur.TabIndex = 1;
            this.olvTireur.UseCompatibleStateImageBehavior = false;
            this.olvTireur.UseHotItem = true;
            this.olvTireur.UseTranslucentHotItem = true;
            this.olvTireur.View = System.Windows.Forms.View.Details;
            this.olvTireur.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.olvTireur_ItemsChanged);
            this.olvTireur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.olvTireur_MouseClick);
            // 
            // colNom
            // 
            this.colNom.AspectName = "Nom";
            this.colNom.CellPadding = null;
            this.colNom.Text = "Nom";
            this.colNom.UseInitialLetterForGroup = true;
            this.colNom.Width = 180;
            // 
            // colEquipe
            // 
            this.colEquipe.AspectName = "IdEquipe";
            this.colEquipe.CellPadding = null;
            this.colEquipe.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEquipe.IsEditable = false;
            this.colEquipe.Text = "Équipe";
            this.colEquipe.Width = 90;
            // 
            // colDateDeNaissance
            // 
            this.colDateDeNaissance.AspectName = "DateDeNaissance";
            this.colDateDeNaissance.AspectToStringFormat = "{0:d MMMM yyyy}";
            this.colDateDeNaissance.CellPadding = null;
            this.colDateDeNaissance.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDateDeNaissance.Text = "Date de naissance";
            this.colDateDeNaissance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDateDeNaissance.Width = 110;
            // 
            // colAge
            // 
            this.colAge.AspectName = "Age";
            this.colAge.CellPadding = null;
            this.colAge.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAge.IsEditable = false;
            this.colAge.Text = "Âge";
            this.colAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAge.Width = 50;
            // 
            // colCategorie
            // 
            this.colCategorie.AspectName = "CategorieTireur";
            this.colCategorie.CellPadding = null;
            this.colCategorie.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategorie.IsEditable = false;
            this.colCategorie.Text = "Catégorie";
            this.colCategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategorie.Width = 72;
            // 
            // colGrouping
            // 
            this.colGrouping.AspectName = "ColCibleGrouping.Moyenne";
            this.colGrouping.CellPadding = null;
            this.colGrouping.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGrouping.IsEditable = false;
            this.colGrouping.Text = "Moyenne grouping";
            this.colGrouping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGrouping.Width = 73;
            // 
            // colPrecision
            // 
            this.colPrecision.AspectName = "ColCiblePrecision.Moyenne";
            this.colPrecision.CellPadding = null;
            this.colPrecision.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrecision.IsEditable = false;
            this.colPrecision.Text = "Moyenne précision";
            this.colPrecision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrecision.Width = 73;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.mnuTireur,
            this.mnuClassement});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(674, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "Menu";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNouveau,
            this.mnuOuvrir,
            this.mnuEnregistrer,
            this.toolStripMenuItem5,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem6,
            this.fermerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // mnuNouveau
            // 
            this.mnuNouveau.Name = "mnuNouveau";
            this.mnuNouveau.Size = new System.Drawing.Size(166, 22);
            this.mnuNouveau.Text = "Nouveau...";
            this.mnuNouveau.Click += new System.EventHandler(this.mnuNouveau_Click);
            // 
            // mnuOuvrir
            // 
            this.mnuOuvrir.Name = "mnuOuvrir";
            this.mnuOuvrir.Size = new System.Drawing.Size(166, 22);
            this.mnuOuvrir.Text = "Ouvrir...";
            this.mnuOuvrir.Click += new System.EventHandler(this.mnuOuvrir_Click);
            // 
            // mnuEnregistrer
            // 
            this.mnuEnregistrer.Name = "mnuEnregistrer";
            this.mnuEnregistrer.Size = new System.Drawing.Size(166, 22);
            this.mnuEnregistrer.Text = "Enregistrer sous...";
            this.mnuEnregistrer.Click += new System.EventHandler(this.mnuEnregistrer_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(163, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(163, 6);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.fermerToolStripMenuItem.Text = "Quitter";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // mnuTireur
            // 
            this.mnuTireur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEquipes,
            this.toolStripMenuItem7,
            this.mnuAjouterTireur,
            this.mnuTireurSelectionne});
            this.mnuTireur.Name = "mnuTireur";
            this.mnuTireur.Size = new System.Drawing.Size(55, 20);
            this.mnuTireur.Text = "Tireurs";
            // 
            // mnuEquipes
            // 
            this.mnuEquipes.Name = "mnuEquipes";
            this.mnuEquipes.Size = new System.Drawing.Size(170, 22);
            this.mnuEquipes.Text = "Équipes...";
            this.mnuEquipes.Click += new System.EventHandler(this.mnuEquipes_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuAjouterTireur
            // 
            this.mnuAjouterTireur.Name = "mnuAjouterTireur";
            this.mnuAjouterTireur.Size = new System.Drawing.Size(170, 22);
            this.mnuAjouterTireur.Text = "Ajouter un tireur...";
            this.mnuAjouterTireur.Click += new System.EventHandler(this.ajouterUnTireurToolStripMenuItem_Click);
            // 
            // mnuTireurSelectionne
            // 
            this.mnuTireurSelectionne.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjouterCible,
            this.toolStripMenuItem1,
            this.mnuModifierTireur,
            this.mnuSupprimerTireur,
            this.toolStripMenuItem2,
            this.mnuDetailsTireur});
            this.mnuTireurSelectionne.Name = "mnuTireurSelectionne";
            this.mnuTireurSelectionne.Size = new System.Drawing.Size(170, 22);
            this.mnuTireurSelectionne.Text = "Tireur sélectionné";
            // 
            // mnuAjouterCible
            // 
            this.mnuAjouterCible.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjouterCibleGrouping,
            this.mnuAjouterCiblePrecision});
            this.mnuAjouterCible.Name = "mnuAjouterCible";
            this.mnuAjouterCible.Size = new System.Drawing.Size(164, 22);
            this.mnuAjouterCible.Text = "Ajouter une cible";
            // 
            // mnuAjouterCibleGrouping
            // 
            this.mnuAjouterCibleGrouping.Name = "mnuAjouterCibleGrouping";
            this.mnuAjouterCibleGrouping.Size = new System.Drawing.Size(124, 22);
            this.mnuAjouterCibleGrouping.Text = "Grouping";
            this.mnuAjouterCibleGrouping.Click += new System.EventHandler(this.mnuAjouterCibleGrouping_Click);
            // 
            // mnuAjouterCiblePrecision
            // 
            this.mnuAjouterCiblePrecision.Name = "mnuAjouterCiblePrecision";
            this.mnuAjouterCiblePrecision.Size = new System.Drawing.Size(124, 22);
            this.mnuAjouterCiblePrecision.Text = "Précision";
            this.mnuAjouterCiblePrecision.Click += new System.EventHandler(this.mnuAjouterCiblePrecision_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuModifierTireur
            // 
            this.mnuModifierTireur.Name = "mnuModifierTireur";
            this.mnuModifierTireur.Size = new System.Drawing.Size(164, 22);
            this.mnuModifierTireur.Text = "Modifier";
            this.mnuModifierTireur.Click += new System.EventHandler(this.mnuModifierTireur_Click);
            // 
            // mnuSupprimerTireur
            // 
            this.mnuSupprimerTireur.Name = "mnuSupprimerTireur";
            this.mnuSupprimerTireur.Size = new System.Drawing.Size(164, 22);
            this.mnuSupprimerTireur.Text = "Supprimer";
            this.mnuSupprimerTireur.Click += new System.EventHandler(this.mnuSupprimerTireur_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuDetailsTireur
            // 
            this.mnuDetailsTireur.Name = "mnuDetailsTireur";
            this.mnuDetailsTireur.Size = new System.Drawing.Size(164, 22);
            this.mnuDetailsTireur.Text = "Détails...";
            this.mnuDetailsTireur.Click += new System.EventHandler(this.mnuDetailsTireur_Click);
            // 
            // mnuClassement
            // 
            this.mnuClassement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individuelToolStripMenuItem,
            this.mnuClassementEquipes});
            this.mnuClassement.Name = "mnuClassement";
            this.mnuClassement.Size = new System.Drawing.Size(85, 20);
            this.mnuClassement.Text = "Classements";
            // 
            // individuelToolStripMenuItem
            // 
            this.individuelToolStripMenuItem.Name = "individuelToolStripMenuItem";
            this.individuelToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.individuelToolStripMenuItem.Text = "Individuel";
            this.individuelToolStripMenuItem.Click += new System.EventHandler(this.individuelToolStripMenuItem_Click);
            // 
            // mnuClassementEquipes
            // 
            this.mnuClassementEquipes.Name = "mnuClassementEquipes";
            this.mnuClassementEquipes.Size = new System.Drawing.Size(135, 22);
            this.mnuClassementEquipes.Text = "Par équipes";
            this.mnuClassementEquipes.Click += new System.EventHandler(this.mnuClassementEquipes_Click);
            // 
            // cmnuItemListview
            // 
            this.cmnuItemListview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuAjouterCible,
            this.toolStripMenuItem3,
            this.cmnuModifierTireur,
            this.cmnuSupprimerTireur,
            this.toolStripMenuItem4,
            this.cmnuDetailsTireur});
            this.cmnuItemListview.Name = "cmnuItemListview";
            this.cmnuItemListview.Size = new System.Drawing.Size(165, 104);
            // 
            // cmnuAjouterCible
            // 
            this.cmnuAjouterCible.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuAjouterCibleGrouping,
            this.cmnuAjouterCiblePrecision});
            this.cmnuAjouterCible.Name = "cmnuAjouterCible";
            this.cmnuAjouterCible.Size = new System.Drawing.Size(164, 22);
            this.cmnuAjouterCible.Text = "Ajouter une cible";
            // 
            // cmnuAjouterCibleGrouping
            // 
            this.cmnuAjouterCibleGrouping.Name = "cmnuAjouterCibleGrouping";
            this.cmnuAjouterCibleGrouping.Size = new System.Drawing.Size(124, 22);
            this.cmnuAjouterCibleGrouping.Text = "Grouping";
            this.cmnuAjouterCibleGrouping.Click += new System.EventHandler(this.mnuAjouterCibleGrouping_Click);
            // 
            // cmnuAjouterCiblePrecision
            // 
            this.cmnuAjouterCiblePrecision.Name = "cmnuAjouterCiblePrecision";
            this.cmnuAjouterCiblePrecision.Size = new System.Drawing.Size(124, 22);
            this.cmnuAjouterCiblePrecision.Text = "Précision";
            this.cmnuAjouterCiblePrecision.Click += new System.EventHandler(this.mnuAjouterCiblePrecision_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 6);
            // 
            // cmnuModifierTireur
            // 
            this.cmnuModifierTireur.Name = "cmnuModifierTireur";
            this.cmnuModifierTireur.Size = new System.Drawing.Size(164, 22);
            this.cmnuModifierTireur.Text = "Modifier";
            this.cmnuModifierTireur.Click += new System.EventHandler(this.mnuModifierTireur_Click);
            // 
            // cmnuSupprimerTireur
            // 
            this.cmnuSupprimerTireur.Name = "cmnuSupprimerTireur";
            this.cmnuSupprimerTireur.Size = new System.Drawing.Size(164, 22);
            this.cmnuSupprimerTireur.Text = "Supprimer";
            this.cmnuSupprimerTireur.Click += new System.EventHandler(this.mnuSupprimerTireur_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(161, 6);
            // 
            // cmnuDetailsTireur
            // 
            this.cmnuDetailsTireur.Name = "cmnuDetailsTireur";
            this.cmnuDetailsTireur.Size = new System.Drawing.Size(164, 22);
            this.cmnuDetailsTireur.Text = "Détails...";
            this.cmnuDetailsTireur.Click += new System.EventHandler(this.mnuDetailsTireur_Click);
            // 
            // sfdSauvegarde
            // 
            this.sfdSauvegarde.DefaultExt = "dtir";
            this.sfdSauvegarde.Filter = "Base de donnée de tireur|*.dtir";
            // 
            // ofdOuverture
            // 
            this.ofdOuverture.DefaultExt = "dtir";
            this.ofdOuverture.Filter = "Base de donnée de tireur|*.dtir";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 551);
            this.Controls.Add(this.olvTireur);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(544, 300);
            this.Name = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.olvTireur)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.cmnuItemListview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTireur;
        private System.Windows.Forms.ToolStripMenuItem mnuAjouterTireur;
        private System.Windows.Forms.ToolStripMenuItem mnuTireurSelectionne;
        private System.Windows.Forms.ToolStripMenuItem mnuAjouterCible;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuModifierTireur;
        private System.Windows.Forms.ToolStripMenuItem mnuSupprimerTireur;
        private System.Windows.Forms.ToolStripMenuItem mnuDetailsTireur;
        private System.Windows.Forms.ContextMenuStrip cmnuItemListview;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmnuAjouterCible;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cmnuModifierTireur;
        private System.Windows.Forms.ToolStripMenuItem cmnuSupprimerTireur;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cmnuDetailsTireur;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClassement;
        private System.Windows.Forms.ToolStripMenuItem mnuClassementEquipes;
        private System.Windows.Forms.ToolStripMenuItem mnuAjouterCibleGrouping;
        private System.Windows.Forms.ToolStripMenuItem mnuAjouterCiblePrecision;
        private System.Windows.Forms.ToolStripMenuItem cmnuAjouterCibleGrouping;
        private System.Windows.Forms.ToolStripMenuItem cmnuAjouterCiblePrecision;
        private BrightIdeasSoftware.ObjectListView olvTireur;
        private BrightIdeasSoftware.OLVColumn colNom;
        private BrightIdeasSoftware.OLVColumn colDateDeNaissance;
        private BrightIdeasSoftware.OLVColumn colAge;
        private BrightIdeasSoftware.OLVColumn colCategorie;
        private BrightIdeasSoftware.OLVColumn colGrouping;
        private BrightIdeasSoftware.OLVColumn colPrecision;
        private System.Windows.Forms.ToolStripMenuItem mnuNouveau;
        private System.Windows.Forms.ToolStripMenuItem mnuOuvrir;
        private System.Windows.Forms.ToolStripMenuItem mnuEnregistrer;
        private System.Windows.Forms.SaveFileDialog sfdSauvegarde;
        private System.Windows.Forms.OpenFileDialog ofdOuverture;
        private BrightIdeasSoftware.OLVColumn colEquipe;
        private System.Windows.Forms.ToolStripMenuItem mnuEquipes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem individuelToolStripMenuItem;
    }
}

