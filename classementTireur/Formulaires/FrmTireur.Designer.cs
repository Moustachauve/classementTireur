namespace classementTireur
{
    partial class FrmTireur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTireur));
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDateDeNaissanceInfo = new System.Windows.Forms.Label();
            this.lblNomInfo = new System.Windows.Forms.Label();
            this.grpCibleGrouping = new System.Windows.Forms.GroupBox();
            this.olvCibleGrouping = new BrightIdeasSoftware.ObjectListView();
            this.colDateGrouping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colScore = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblMinGrouping = new System.Windows.Forms.Label();
            this.lblMaxGrouping = new System.Windows.Forms.Label();
            this.lblMoyenneGrouping = new System.Windows.Forms.Label();
            this.lblMinGroupingInfo = new System.Windows.Forms.Label();
            this.lblMaxGroupingInfo = new System.Windows.Forms.Label();
            this.lblMoyenneGroupingInfo = new System.Windows.Forms.Label();
            this.btnSuppGrouping = new System.Windows.Forms.Button();
            this.btnAjouterGrouping = new System.Windows.Forms.Button();
            this.grpCiblePrecision = new System.Windows.Forms.GroupBox();
            this.olvCiblePrecision = new BrightIdeasSoftware.ObjectListView();
            this.colDatePrecision = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colScorePrecision = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblMinPrecision = new System.Windows.Forms.Label();
            this.lblMaxPrecision = new System.Windows.Forms.Label();
            this.lblMoyennePrecision = new System.Windows.Forms.Label();
            this.lblMinPrecisionInfo = new System.Windows.Forms.Label();
            this.lblMaxPrecisionInfo = new System.Windows.Forms.Label();
            this.lblMoyennePrecisionInfo = new System.Windows.Forms.Label();
            this.btnSuppPrecision = new System.Windows.Forms.Button();
            this.btnAjouterPrecision = new System.Windows.Forms.Button();
            this.grpInfos.SuspendLayout();
            this.grpCibleGrouping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCibleGrouping)).BeginInit();
            this.grpCiblePrecision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCiblePrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfos
            // 
            this.grpInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfos.Controls.Add(this.lblDateDeNaissance);
            this.grpInfos.Controls.Add(this.lblNom);
            this.grpInfos.Controls.Add(this.lblDateDeNaissanceInfo);
            this.grpInfos.Controls.Add(this.lblNomInfo);
            this.grpInfos.Location = new System.Drawing.Point(12, 12);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(434, 47);
            this.grpInfos.TabIndex = 0;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations sur le tireur";
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Location = new System.Drawing.Point(335, 21);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(48, 13);
            this.lblDateDeNaissance.TabIndex = 7;
            this.lblDateDeNaissance.Text = "_DATE_";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(40, 21);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "_NOM_";
            // 
            // lblDateDeNaissanceInfo
            // 
            this.lblDateDeNaissanceInfo.AutoSize = true;
            this.lblDateDeNaissanceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDeNaissanceInfo.Location = new System.Drawing.Point(221, 21);
            this.lblDateDeNaissanceInfo.Name = "lblDateDeNaissanceInfo";
            this.lblDateDeNaissanceInfo.Size = new System.Drawing.Size(117, 13);
            this.lblDateDeNaissanceInfo.TabIndex = 5;
            this.lblDateDeNaissanceInfo.Text = "Date de naissance:";
            // 
            // lblNomInfo
            // 
            this.lblNomInfo.AutoSize = true;
            this.lblNomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomInfo.Location = new System.Drawing.Point(6, 21);
            this.lblNomInfo.Name = "lblNomInfo";
            this.lblNomInfo.Size = new System.Drawing.Size(36, 13);
            this.lblNomInfo.TabIndex = 4;
            this.lblNomInfo.Text = "Nom:";
            // 
            // grpCibleGrouping
            // 
            this.grpCibleGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpCibleGrouping.Controls.Add(this.olvCibleGrouping);
            this.grpCibleGrouping.Controls.Add(this.lblMinGrouping);
            this.grpCibleGrouping.Controls.Add(this.lblMaxGrouping);
            this.grpCibleGrouping.Controls.Add(this.lblMoyenneGrouping);
            this.grpCibleGrouping.Controls.Add(this.lblMinGroupingInfo);
            this.grpCibleGrouping.Controls.Add(this.lblMaxGroupingInfo);
            this.grpCibleGrouping.Controls.Add(this.lblMoyenneGroupingInfo);
            this.grpCibleGrouping.Controls.Add(this.btnSuppGrouping);
            this.grpCibleGrouping.Controls.Add(this.btnAjouterGrouping);
            this.grpCibleGrouping.Location = new System.Drawing.Point(12, 65);
            this.grpCibleGrouping.Name = "grpCibleGrouping";
            this.grpCibleGrouping.Size = new System.Drawing.Size(210, 306);
            this.grpCibleGrouping.TabIndex = 1;
            this.grpCibleGrouping.TabStop = false;
            this.grpCibleGrouping.Text = "Cibles de grouping";
            // 
            // olvCibleGrouping
            // 
            this.olvCibleGrouping.AllColumns.Add(this.colDateGrouping);
            this.olvCibleGrouping.AllColumns.Add(this.colScore);
            this.olvCibleGrouping.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDateGrouping,
            this.colScore});
            this.olvCibleGrouping.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCibleGrouping.EmptyListMsg = "Aucune cible de grouping";
            this.olvCibleGrouping.EmptyListMsgFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvCibleGrouping.FullRowSelect = true;
            this.olvCibleGrouping.Location = new System.Drawing.Point(6, 52);
            this.olvCibleGrouping.MultiSelect = false;
            this.olvCibleGrouping.Name = "olvCibleGrouping";
            this.olvCibleGrouping.SelectAllOnControlA = false;
            this.olvCibleGrouping.Size = new System.Drawing.Size(198, 219);
            this.olvCibleGrouping.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.olvCibleGrouping.TabIndex = 13;
            this.olvCibleGrouping.UseCompatibleStateImageBehavior = false;
            this.olvCibleGrouping.UseHotItem = true;
            this.olvCibleGrouping.UseTranslucentHotItem = true;
            this.olvCibleGrouping.View = System.Windows.Forms.View.Details;
            this.olvCibleGrouping.SelectedIndexChanged += new System.EventHandler(this.olvCibleGrouping_SelectedIndexChanged);
            // 
            // colDateGrouping
            // 
            this.colDateGrouping.AspectName = "Date";
            this.colDateGrouping.AspectToStringFormat = "{0:d MMMM yyyy}";
            this.colDateGrouping.CellPadding = null;
            this.colDateGrouping.Text = "Date";
            this.colDateGrouping.Width = 103;
            // 
            // colScore
            // 
            this.colScore.AspectName = "Score";
            this.colScore.AspectToStringFormat = "{0:F1}";
            this.colScore.CellPadding = null;
            this.colScore.FillsFreeSpace = true;
            this.colScore.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colScore.Text = "Score";
            this.colScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMinGrouping
            // 
            this.lblMinGrouping.AutoSize = true;
            this.lblMinGrouping.Location = new System.Drawing.Point(157, 36);
            this.lblMinGrouping.Name = "lblMinGrouping";
            this.lblMinGrouping.Size = new System.Drawing.Size(39, 13);
            this.lblMinGrouping.TabIndex = 12;
            this.lblMinGrouping.Text = "_VAL_";
            // 
            // lblMaxGrouping
            // 
            this.lblMaxGrouping.AutoSize = true;
            this.lblMaxGrouping.Location = new System.Drawing.Point(69, 36);
            this.lblMaxGrouping.Name = "lblMaxGrouping";
            this.lblMaxGrouping.Size = new System.Drawing.Size(39, 13);
            this.lblMaxGrouping.TabIndex = 11;
            this.lblMaxGrouping.Text = "_VAL_";
            // 
            // lblMoyenneGrouping
            // 
            this.lblMoyenneGrouping.AutoSize = true;
            this.lblMoyenneGrouping.Location = new System.Drawing.Point(69, 17);
            this.lblMoyenneGrouping.Name = "lblMoyenneGrouping";
            this.lblMoyenneGrouping.Size = new System.Drawing.Size(39, 13);
            this.lblMoyenneGrouping.TabIndex = 2;
            this.lblMoyenneGrouping.Text = "_VAL_";
            // 
            // lblMinGroupingInfo
            // 
            this.lblMinGroupingInfo.AutoSize = true;
            this.lblMinGroupingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinGroupingInfo.Location = new System.Drawing.Point(126, 36);
            this.lblMinGroupingInfo.Name = "lblMinGroupingInfo";
            this.lblMinGroupingInfo.Size = new System.Drawing.Size(31, 13);
            this.lblMinGroupingInfo.TabIndex = 10;
            this.lblMinGroupingInfo.Text = "Min:";
            // 
            // lblMaxGroupingInfo
            // 
            this.lblMaxGroupingInfo.AutoSize = true;
            this.lblMaxGroupingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxGroupingInfo.Location = new System.Drawing.Point(8, 36);
            this.lblMaxGroupingInfo.Name = "lblMaxGroupingInfo";
            this.lblMaxGroupingInfo.Size = new System.Drawing.Size(34, 13);
            this.lblMaxGroupingInfo.TabIndex = 9;
            this.lblMaxGroupingInfo.Text = "Max:";
            // 
            // lblMoyenneGroupingInfo
            // 
            this.lblMoyenneGroupingInfo.AutoSize = true;
            this.lblMoyenneGroupingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoyenneGroupingInfo.Location = new System.Drawing.Point(8, 17);
            this.lblMoyenneGroupingInfo.Name = "lblMoyenneGroupingInfo";
            this.lblMoyenneGroupingInfo.Size = new System.Drawing.Size(62, 13);
            this.lblMoyenneGroupingInfo.TabIndex = 8;
            this.lblMoyenneGroupingInfo.Text = "Moyenne:";
            // 
            // btnSuppGrouping
            // 
            this.btnSuppGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuppGrouping.Enabled = false;
            this.btnSuppGrouping.Location = new System.Drawing.Point(48, 277);
            this.btnSuppGrouping.Name = "btnSuppGrouping";
            this.btnSuppGrouping.Size = new System.Drawing.Size(75, 23);
            this.btnSuppGrouping.TabIndex = 2;
            this.btnSuppGrouping.Text = "Supprimer";
            this.btnSuppGrouping.UseVisualStyleBackColor = true;
            this.btnSuppGrouping.Click += new System.EventHandler(this.btnSuppGrouping_Click);
            // 
            // btnAjouterGrouping
            // 
            this.btnAjouterGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterGrouping.Location = new System.Drawing.Point(129, 277);
            this.btnAjouterGrouping.Name = "btnAjouterGrouping";
            this.btnAjouterGrouping.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterGrouping.TabIndex = 1;
            this.btnAjouterGrouping.Text = "Ajouter...";
            this.btnAjouterGrouping.UseVisualStyleBackColor = true;
            this.btnAjouterGrouping.Click += new System.EventHandler(this.btnAjouterGrouping_Click);
            // 
            // grpCiblePrecision
            // 
            this.grpCiblePrecision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCiblePrecision.Controls.Add(this.olvCiblePrecision);
            this.grpCiblePrecision.Controls.Add(this.lblMinPrecision);
            this.grpCiblePrecision.Controls.Add(this.lblMaxPrecision);
            this.grpCiblePrecision.Controls.Add(this.lblMoyennePrecision);
            this.grpCiblePrecision.Controls.Add(this.lblMinPrecisionInfo);
            this.grpCiblePrecision.Controls.Add(this.lblMaxPrecisionInfo);
            this.grpCiblePrecision.Controls.Add(this.lblMoyennePrecisionInfo);
            this.grpCiblePrecision.Controls.Add(this.btnSuppPrecision);
            this.grpCiblePrecision.Controls.Add(this.btnAjouterPrecision);
            this.grpCiblePrecision.Location = new System.Drawing.Point(236, 65);
            this.grpCiblePrecision.Name = "grpCiblePrecision";
            this.grpCiblePrecision.Size = new System.Drawing.Size(210, 306);
            this.grpCiblePrecision.TabIndex = 2;
            this.grpCiblePrecision.TabStop = false;
            this.grpCiblePrecision.Text = "Cibles de précision";
            // 
            // olvCiblePrecision
            // 
            this.olvCiblePrecision.AllColumns.Add(this.colDatePrecision);
            this.olvCiblePrecision.AllColumns.Add(this.colScorePrecision);
            this.olvCiblePrecision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDatePrecision,
            this.colScorePrecision});
            this.olvCiblePrecision.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCiblePrecision.EmptyListMsg = "Aucune cible de précision";
            this.olvCiblePrecision.EmptyListMsgFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvCiblePrecision.FullRowSelect = true;
            this.olvCiblePrecision.Location = new System.Drawing.Point(6, 52);
            this.olvCiblePrecision.MultiSelect = false;
            this.olvCiblePrecision.Name = "olvCiblePrecision";
            this.olvCiblePrecision.SelectAllOnControlA = false;
            this.olvCiblePrecision.Size = new System.Drawing.Size(198, 219);
            this.olvCiblePrecision.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.olvCiblePrecision.TabIndex = 14;
            this.olvCiblePrecision.UseCompatibleStateImageBehavior = false;
            this.olvCiblePrecision.UseHotItem = true;
            this.olvCiblePrecision.UseTranslucentHotItem = true;
            this.olvCiblePrecision.View = System.Windows.Forms.View.Details;
            // 
            // colDatePrecision
            // 
            this.colDatePrecision.AspectName = "Date";
            this.colDatePrecision.AspectToStringFormat = "{0:d MMMM yyyy}";
            this.colDatePrecision.CellPadding = null;
            this.colDatePrecision.Text = "Date";
            this.colDatePrecision.Width = 103;
            // 
            // colScorePrecision
            // 
            this.colScorePrecision.AspectName = "Score";
            this.colScorePrecision.AspectToStringFormat = "{0}%";
            this.colScorePrecision.CellPadding = null;
            this.colScorePrecision.FillsFreeSpace = true;
            this.colScorePrecision.Text = "Score";
            // 
            // lblMinPrecision
            // 
            this.lblMinPrecision.AutoSize = true;
            this.lblMinPrecision.Location = new System.Drawing.Point(157, 36);
            this.lblMinPrecision.Name = "lblMinPrecision";
            this.lblMinPrecision.Size = new System.Drawing.Size(39, 13);
            this.lblMinPrecision.TabIndex = 12;
            this.lblMinPrecision.Text = "_VAL_";
            // 
            // lblMaxPrecision
            // 
            this.lblMaxPrecision.AutoSize = true;
            this.lblMaxPrecision.Location = new System.Drawing.Point(69, 36);
            this.lblMaxPrecision.Name = "lblMaxPrecision";
            this.lblMaxPrecision.Size = new System.Drawing.Size(39, 13);
            this.lblMaxPrecision.TabIndex = 11;
            this.lblMaxPrecision.Text = "_VAL_";
            // 
            // lblMoyennePrecision
            // 
            this.lblMoyennePrecision.AutoSize = true;
            this.lblMoyennePrecision.Location = new System.Drawing.Point(69, 17);
            this.lblMoyennePrecision.Name = "lblMoyennePrecision";
            this.lblMoyennePrecision.Size = new System.Drawing.Size(39, 13);
            this.lblMoyennePrecision.TabIndex = 2;
            this.lblMoyennePrecision.Text = "_VAL_";
            // 
            // lblMinPrecisionInfo
            // 
            this.lblMinPrecisionInfo.AutoSize = true;
            this.lblMinPrecisionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPrecisionInfo.Location = new System.Drawing.Point(126, 36);
            this.lblMinPrecisionInfo.Name = "lblMinPrecisionInfo";
            this.lblMinPrecisionInfo.Size = new System.Drawing.Size(31, 13);
            this.lblMinPrecisionInfo.TabIndex = 10;
            this.lblMinPrecisionInfo.Text = "Min:";
            // 
            // lblMaxPrecisionInfo
            // 
            this.lblMaxPrecisionInfo.AutoSize = true;
            this.lblMaxPrecisionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPrecisionInfo.Location = new System.Drawing.Point(8, 36);
            this.lblMaxPrecisionInfo.Name = "lblMaxPrecisionInfo";
            this.lblMaxPrecisionInfo.Size = new System.Drawing.Size(34, 13);
            this.lblMaxPrecisionInfo.TabIndex = 9;
            this.lblMaxPrecisionInfo.Text = "Max:";
            // 
            // lblMoyennePrecisionInfo
            // 
            this.lblMoyennePrecisionInfo.AutoSize = true;
            this.lblMoyennePrecisionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoyennePrecisionInfo.Location = new System.Drawing.Point(8, 17);
            this.lblMoyennePrecisionInfo.Name = "lblMoyennePrecisionInfo";
            this.lblMoyennePrecisionInfo.Size = new System.Drawing.Size(62, 13);
            this.lblMoyennePrecisionInfo.TabIndex = 8;
            this.lblMoyennePrecisionInfo.Text = "Moyenne:";
            // 
            // btnSuppPrecision
            // 
            this.btnSuppPrecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuppPrecision.Enabled = false;
            this.btnSuppPrecision.Location = new System.Drawing.Point(48, 277);
            this.btnSuppPrecision.Name = "btnSuppPrecision";
            this.btnSuppPrecision.Size = new System.Drawing.Size(75, 23);
            this.btnSuppPrecision.TabIndex = 2;
            this.btnSuppPrecision.Text = "Supprimer";
            this.btnSuppPrecision.UseVisualStyleBackColor = true;
            this.btnSuppPrecision.Click += new System.EventHandler(this.btnSuppPrecision_Click);
            // 
            // btnAjouterPrecision
            // 
            this.btnAjouterPrecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterPrecision.Location = new System.Drawing.Point(129, 277);
            this.btnAjouterPrecision.Name = "btnAjouterPrecision";
            this.btnAjouterPrecision.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterPrecision.TabIndex = 1;
            this.btnAjouterPrecision.Text = "Ajouter...";
            this.btnAjouterPrecision.UseVisualStyleBackColor = true;
            this.btnAjouterPrecision.Click += new System.EventHandler(this.btnAjouterPrecision_Click);
            // 
            // FrmTireur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 383);
            this.Controls.Add(this.grpCiblePrecision);
            this.Controls.Add(this.grpCibleGrouping);
            this.Controls.Add(this.grpInfos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 10000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 281);
            this.Name = "FrmTireur";
            this.Text = "_NOM_";
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.grpCibleGrouping.ResumeLayout(false);
            this.grpCibleGrouping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCibleGrouping)).EndInit();
            this.grpCiblePrecision.ResumeLayout(false);
            this.grpCiblePrecision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCiblePrecision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.GroupBox grpCibleGrouping;
        private System.Windows.Forms.Button btnSuppGrouping;
        private System.Windows.Forms.Button btnAjouterGrouping;
        private System.Windows.Forms.Label lblDateDeNaissanceInfo;
        private System.Windows.Forms.Label lblNomInfo;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDateDeNaissance;
        private System.Windows.Forms.Label lblMaxGroupingInfo;
        private System.Windows.Forms.Label lblMoyenneGroupingInfo;
        private System.Windows.Forms.Label lblMinGroupingInfo;
        private System.Windows.Forms.Label lblMinGrouping;
        private System.Windows.Forms.Label lblMaxGrouping;
        private System.Windows.Forms.Label lblMoyenneGrouping;
        private System.Windows.Forms.GroupBox grpCiblePrecision;
        private System.Windows.Forms.Label lblMinPrecision;
        private System.Windows.Forms.Label lblMaxPrecision;
        private System.Windows.Forms.Label lblMoyennePrecision;
        private System.Windows.Forms.Label lblMinPrecisionInfo;
        private System.Windows.Forms.Label lblMaxPrecisionInfo;
        private System.Windows.Forms.Label lblMoyennePrecisionInfo;
        private System.Windows.Forms.Button btnSuppPrecision;
        private System.Windows.Forms.Button btnAjouterPrecision;
        private BrightIdeasSoftware.ObjectListView olvCibleGrouping;
        private BrightIdeasSoftware.OLVColumn colDateGrouping;
        private BrightIdeasSoftware.OLVColumn colScore;
        private BrightIdeasSoftware.ObjectListView olvCiblePrecision;
        private BrightIdeasSoftware.OLVColumn colDatePrecision;
        private BrightIdeasSoftware.OLVColumn colScorePrecision;
    }
}