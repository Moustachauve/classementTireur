namespace classementTireur
{
    partial class FrmClassementEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassementEquipe));
            this.olvClassement = new BrightIdeasSoftware.ObjectListView();
            this.colNom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colMoyenneGrouping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colMoyennePrecision = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmnuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuActualiser = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.olvClassement)).BeginInit();
            this.cmnuRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvClassement
            // 
            this.olvClassement.AllColumns.Add(this.colNom);
            this.olvClassement.AllColumns.Add(this.colMoyenneGrouping);
            this.olvClassement.AllColumns.Add(this.colMoyennePrecision);
            this.olvClassement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNom,
            this.colMoyenneGrouping,
            this.colMoyennePrecision});
            this.olvClassement.ContextMenuStrip = this.cmnuRightClick;
            this.olvClassement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvClassement.FullRowSelect = true;
            this.olvClassement.Location = new System.Drawing.Point(0, 0);
            this.olvClassement.Name = "olvClassement";
            this.olvClassement.ShowFilterMenuOnRightClick = false;
            this.olvClassement.ShowGroups = false;
            this.olvClassement.Size = new System.Drawing.Size(484, 441);
            this.olvClassement.SortGroupItemsByPrimaryColumn = false;
            this.olvClassement.TabIndex = 0;
            this.olvClassement.UseCompatibleStateImageBehavior = false;
            this.olvClassement.View = System.Windows.Forms.View.Details;
            // 
            // colNom
            // 
            this.colNom.AspectName = "Nom";
            this.colNom.CellPadding = null;
            this.colNom.Text = "Nom";
            this.colNom.Width = 227;
            // 
            // colMoyenneGrouping
            // 
            this.colMoyenneGrouping.AspectName = "ColCibleGrouping.Moyenne";
            this.colMoyenneGrouping.CellPadding = null;
            this.colMoyenneGrouping.Text = "Moyenne grouping";
            this.colMoyenneGrouping.Width = 119;
            // 
            // colMoyennePrecision
            // 
            this.colMoyennePrecision.AspectName = "ColCiblePrecision.Moyenne";
            this.colMoyennePrecision.CellPadding = null;
            this.colMoyennePrecision.Text = "Moyenne Précision";
            this.colMoyennePrecision.Width = 123;
            // 
            // cmnuRightClick
            // 
            this.cmnuRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuActualiser});
            this.cmnuRightClick.Name = "cmnuRightClick";
            this.cmnuRightClick.Size = new System.Drawing.Size(127, 26);
            // 
            // cmnuActualiser
            // 
            this.cmnuActualiser.Name = "cmnuActualiser";
            this.cmnuActualiser.Size = new System.Drawing.Size(126, 22);
            this.cmnuActualiser.Text = "Actualiser";
            this.cmnuActualiser.Click += new System.EventHandler(this.cmnuActualiser_Click);
            // 
            // FrmClassementEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.olvClassement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClassementEquipe";
            this.Text = "Classement des équipes";
            ((System.ComponentModel.ISupportInitialize)(this.olvClassement)).EndInit();
            this.cmnuRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvClassement;
        private BrightIdeasSoftware.OLVColumn colNom;
        private BrightIdeasSoftware.OLVColumn colMoyenneGrouping;
        private BrightIdeasSoftware.OLVColumn colMoyennePrecision;
        private System.Windows.Forms.ContextMenuStrip cmnuRightClick;
        private System.Windows.Forms.ToolStripMenuItem cmnuActualiser;


    }
}