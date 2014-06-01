namespace classementTireur
{
    partial class FrmClassementTireur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassementTireur));
            this.olvClassement = new BrightIdeasSoftware.ObjectListView();
            this.colNom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colCategorie = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colMoyenneGrouping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colMoyennePrecision = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmnuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuSortByName = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuSortByCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuActualiser = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.olvClassement)).BeginInit();
            this.cmnuRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvClassement
            // 
            this.olvClassement.AllColumns.Add(this.colNom);
            this.olvClassement.AllColumns.Add(this.colCategorie);
            this.olvClassement.AllColumns.Add(this.colMoyenneGrouping);
            this.olvClassement.AllColumns.Add(this.colMoyennePrecision);
            this.olvClassement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNom,
            this.colCategorie,
            this.colMoyenneGrouping,
            this.colMoyennePrecision});
            this.olvClassement.ContextMenuStrip = this.cmnuRightClick;
            this.olvClassement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvClassement.FullRowSelect = true;
            this.olvClassement.Location = new System.Drawing.Point(0, 0);
            this.olvClassement.Name = "olvClassement";
            this.olvClassement.ShowFilterMenuOnRightClick = false;
            this.olvClassement.Size = new System.Drawing.Size(484, 441);
            this.olvClassement.SortGroupItemsByPrimaryColumn = false;
            this.olvClassement.TabIndex = 0;
            this.olvClassement.UseCompatibleStateImageBehavior = false;
            this.olvClassement.View = System.Windows.Forms.View.Details;
            this.olvClassement.BeforeCreatingGroups += new System.EventHandler<BrightIdeasSoftware.CreateGroupsEventArgs>(this.olvClassement_BeforeCreatingGroups);
            // 
            // colNom
            // 
            this.colNom.AspectName = "Nom";
            this.colNom.CellPadding = null;
            this.colNom.Sortable = false;
            this.colNom.Text = "Nom";
            this.colNom.Width = 175;
            // 
            // colCategorie
            // 
            this.colCategorie.AspectName = "CategorieTireur";
            this.colCategorie.CellPadding = null;
            this.colCategorie.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategorie.Sortable = false;
            this.colCategorie.Text = "Catégorie";
            this.colCategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategorie.Width = 69;
            // 
            // colMoyenneGrouping
            // 
            this.colMoyenneGrouping.AspectName = "ColCibleGrouping.Moyenne";
            this.colMoyenneGrouping.CellPadding = null;
            this.colMoyenneGrouping.Text = "Moyenne grouping";
            this.colMoyenneGrouping.Width = 115;
            // 
            // colMoyennePrecision
            // 
            this.colMoyennePrecision.AspectName = "ColCiblePrecision.Moyenne";
            this.colMoyennePrecision.CellPadding = null;
            this.colMoyennePrecision.Text = "Moyenne Précision";
            this.colMoyennePrecision.Width = 113;
            // 
            // cmnuRightClick
            // 
            this.cmnuRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuSortByName,
            this.cmnuSortByCategory,
            this.toolStripMenuItem1,
            this.cmnuActualiser});
            this.cmnuRightClick.Name = "cmnuSort";
            this.cmnuRightClick.Size = new System.Drawing.Size(182, 76);
            // 
            // cmnuSortByName
            // 
            this.cmnuSortByName.Name = "cmnuSortByName";
            this.cmnuSortByName.Size = new System.Drawing.Size(181, 22);
            this.cmnuSortByName.Text = "Aucune division";
            this.cmnuSortByName.Click += new System.EventHandler(this.cmnuSortByName_Click);
            // 
            // cmnuSortByCategory
            // 
            this.cmnuSortByCategory.Checked = true;
            this.cmnuSortByCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmnuSortByCategory.Name = "cmnuSortByCategory";
            this.cmnuSortByCategory.Size = new System.Drawing.Size(181, 22);
            this.cmnuSortByCategory.Text = "Diviser par catégorie";
            this.cmnuSortByCategory.Click += new System.EventHandler(this.cmnuSortByCategory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // cmnuActualiser
            // 
            this.cmnuActualiser.Name = "cmnuActualiser";
            this.cmnuActualiser.Size = new System.Drawing.Size(181, 22);
            this.cmnuActualiser.Text = "Actualiser";
            this.cmnuActualiser.Click += new System.EventHandler(this.cmnuActualiser_Click);
            // 
            // FrmClassementTireur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.olvClassement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClassementTireur";
            this.Text = "Classement des tireurs";
            ((System.ComponentModel.ISupportInitialize)(this.olvClassement)).EndInit();
            this.cmnuRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvClassement;
        private BrightIdeasSoftware.OLVColumn colNom;
        private BrightIdeasSoftware.OLVColumn colCategorie;
        private BrightIdeasSoftware.OLVColumn colMoyenneGrouping;
        private BrightIdeasSoftware.OLVColumn colMoyennePrecision;
        private System.Windows.Forms.ContextMenuStrip cmnuRightClick;
        private System.Windows.Forms.ToolStripMenuItem cmnuSortByName;
        private System.Windows.Forms.ToolStripMenuItem cmnuSortByCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmnuActualiser;


    }
}