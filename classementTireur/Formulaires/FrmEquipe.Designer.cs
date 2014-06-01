namespace classementTireur
{
    partial class FrmEquipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipe));
            this.grpTireurs = new System.Windows.Forms.GroupBox();
            this.lsbTireurs = new System.Windows.Forms.ListBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.olvTireur = new BrightIdeasSoftware.ObjectListView();
            this.colNom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colDateDeNaissance = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colAge = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colCategorie = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colGrouping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPrecision = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblJoueursÉquipe = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNomEquipe = new System.Windows.Forms.Label();
            this.cboEquipeAfficher = new System.Windows.Forms.ComboBox();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.btnAjouterEquipe = new System.Windows.Forms.Button();
            this.grpTireurs.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTireur)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTireurs
            // 
            this.grpTireurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTireurs.Controls.Add(this.lsbTireurs);
            this.grpTireurs.Location = new System.Drawing.Point(12, 12);
            this.grpTireurs.Name = "grpTireurs";
            this.grpTireurs.Size = new System.Drawing.Size(204, 422);
            this.grpTireurs.TabIndex = 0;
            this.grpTireurs.TabStop = false;
            this.grpTireurs.Text = "Liste des tireurs sans équipe";
            // 
            // lsbTireurs
            // 
            this.lsbTireurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbTireurs.FormattingEnabled = true;
            this.lsbTireurs.IntegralHeight = false;
            this.lsbTireurs.Location = new System.Drawing.Point(6, 19);
            this.lsbTireurs.Name = "lsbTireurs";
            this.lsbTireurs.Size = new System.Drawing.Size(192, 397);
            this.lsbTireurs.TabIndex = 0;
            this.lsbTireurs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbTireurs_MouseDoubleClick);
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.btnSupprimer);
            this.grpDetails.Controls.Add(this.olvTireur);
            this.grpDetails.Controls.Add(this.lblJoueursÉquipe);
            this.grpDetails.Controls.Add(this.txtNom);
            this.grpDetails.Controls.Add(this.lblNomEquipe);
            this.grpDetails.Enabled = false;
            this.grpDetails.Location = new System.Drawing.Point(222, 41);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(571, 393);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Détails";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(464, 19);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(101, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer l\'équipe";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // olvTireur
            // 
            this.olvTireur.AllColumns.Add(this.colNom);
            this.olvTireur.AllColumns.Add(this.colDateDeNaissance);
            this.olvTireur.AllColumns.Add(this.colAge);
            this.olvTireur.AllColumns.Add(this.colCategorie);
            this.olvTireur.AllColumns.Add(this.colGrouping);
            this.olvTireur.AllColumns.Add(this.colPrecision);
            this.olvTireur.AllowColumnReorder = true;
            this.olvTireur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvTireur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNom,
            this.colDateDeNaissance,
            this.colAge,
            this.colCategorie,
            this.colGrouping,
            this.colPrecision});
            this.olvTireur.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTireur.EmptyListMsg = "";
            this.olvTireur.EmptyListMsgFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvTireur.FullRowSelect = true;
            this.olvTireur.HeaderWordWrap = true;
            this.olvTireur.Location = new System.Drawing.Point(9, 68);
            this.olvTireur.MultiSelect = false;
            this.olvTireur.Name = "olvTireur";
            this.olvTireur.SelectAllOnControlA = false;
            this.olvTireur.ShowCommandMenuOnRightClick = true;
            this.olvTireur.Size = new System.Drawing.Size(556, 319);
            this.olvTireur.TabIndex = 5;
            this.olvTireur.UseCompatibleStateImageBehavior = false;
            this.olvTireur.UseHotItem = true;
            this.olvTireur.UseTranslucentHotItem = true;
            this.olvTireur.View = System.Windows.Forms.View.Details;
            this.olvTireur.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTireur_MouseDoubleClick);
            // 
            // colNom
            // 
            this.colNom.AspectName = "Nom";
            this.colNom.CellPadding = null;
            this.colNom.Text = "Nom";
            this.colNom.UseInitialLetterForGroup = true;
            this.colNom.Width = 180;
            // 
            // colDateDeNaissance
            // 
            this.colDateDeNaissance.AspectName = "DateDeNaissance";
            this.colDateDeNaissance.AspectToStringFormat = "{0:d MMMM yyyy}";
            this.colDateDeNaissance.CellPadding = null;
            this.colDateDeNaissance.Groupable = false;
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
            this.colGrouping.Width = 70;
            // 
            // colPrecision
            // 
            this.colPrecision.AspectName = "ColCiblePrecision.Moyenne";
            this.colPrecision.CellPadding = null;
            this.colPrecision.IsEditable = false;
            this.colPrecision.Text = "Moyenne précision";
            this.colPrecision.Width = 70;
            // 
            // lblJoueursÉquipe
            // 
            this.lblJoueursÉquipe.AutoSize = true;
            this.lblJoueursÉquipe.Location = new System.Drawing.Point(6, 52);
            this.lblJoueursÉquipe.Name = "lblJoueursÉquipe";
            this.lblJoueursÉquipe.Size = new System.Drawing.Size(101, 13);
            this.lblJoueursÉquipe.TabIndex = 4;
            this.lblJoueursÉquipe.Text = "Joueurs de l\'équipe:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(98, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(176, 20);
            this.txtNom.TabIndex = 3;
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // lblNomEquipe
            // 
            this.lblNomEquipe.AutoSize = true;
            this.lblNomEquipe.Location = new System.Drawing.Point(6, 22);
            this.lblNomEquipe.Name = "lblNomEquipe";
            this.lblNomEquipe.Size = new System.Drawing.Size(86, 13);
            this.lblNomEquipe.TabIndex = 2;
            this.lblNomEquipe.Text = "Nom de l\'équipe:";
            // 
            // cboEquipeAfficher
            // 
            this.cboEquipeAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEquipeAfficher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipeAfficher.FormattingEnabled = true;
            this.cboEquipeAfficher.Location = new System.Drawing.Point(601, 12);
            this.cboEquipeAfficher.Name = "cboEquipeAfficher";
            this.cboEquipeAfficher.Size = new System.Drawing.Size(192, 21);
            this.cboEquipeAfficher.TabIndex = 0;
            this.cboEquipeAfficher.SelectedIndexChanged += new System.EventHandler(this.cboEquipeAfficher_SelectedIndexChanged);
            // 
            // lblEquipe
            // 
            this.lblEquipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Location = new System.Drawing.Point(552, 16);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(43, 13);
            this.lblEquipe.TabIndex = 1;
            this.lblEquipe.Text = "Équipe:";
            // 
            // btnAjouterEquipe
            // 
            this.btnAjouterEquipe.Location = new System.Drawing.Point(422, 12);
            this.btnAjouterEquipe.Name = "btnAjouterEquipe";
            this.btnAjouterEquipe.Size = new System.Drawing.Size(124, 23);
            this.btnAjouterEquipe.TabIndex = 1;
            this.btnAjouterEquipe.Text = "Ajouter une équipe";
            this.btnAjouterEquipe.UseVisualStyleBackColor = true;
            this.btnAjouterEquipe.Click += new System.EventHandler(this.btnAjouterEquipe_Click);
            // 
            // FrmEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 446);
            this.Controls.Add(this.btnAjouterEquipe);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpTireurs);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.cboEquipeAfficher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEquipe";
            this.Text = "Équipes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEquipe_FormClosing);
            this.grpTireurs.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTireur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTireurs;
        private System.Windows.Forms.ListBox lsbTireurs;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.ComboBox cboEquipeAfficher;
        private System.Windows.Forms.Label lblJoueursÉquipe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNomEquipe;
        private BrightIdeasSoftware.ObjectListView olvTireur;
        private BrightIdeasSoftware.OLVColumn colNom;
        private BrightIdeasSoftware.OLVColumn colDateDeNaissance;
        private BrightIdeasSoftware.OLVColumn colAge;
        private BrightIdeasSoftware.OLVColumn colCategorie;
        private BrightIdeasSoftware.OLVColumn colGrouping;
        private BrightIdeasSoftware.OLVColumn colPrecision;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouterEquipe;
    }
}