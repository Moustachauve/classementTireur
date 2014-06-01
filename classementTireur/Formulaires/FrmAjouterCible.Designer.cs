namespace classementTireur
{
    partial class FrmAjouterCible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjouterCible));
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.dtpDateTir = new System.Windows.Forms.DateTimePicker();
            this.lblScore = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(42, 112);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(60, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(108, 112);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(81, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Location = new System.Drawing.Point(12, 53);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(56, 13);
            this.lblDateDeNaissance.TabIndex = 9;
            this.lblDateDeNaissance.Text = "Date du tir";
            // 
            // dtpDateTir
            // 
            this.dtpDateTir.Location = new System.Drawing.Point(15, 69);
            this.dtpDateTir.MaxDate = new System.DateTime(2014, 4, 6, 2, 43, 26, 71);
            this.dtpDateTir.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateTir.Name = "dtpDateTir";
            this.dtpDateTir.Size = new System.Drawing.Size(174, 20);
            this.dtpDateTir.TabIndex = 8;
            this.dtpDateTir.Value = new System.DateTime(2014, 4, 6, 2, 43, 26, 70);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score";
            // 
            // numScore
            // 
            this.numScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numScore.DecimalPlaces = 1;
            this.numScore.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScore.Location = new System.Drawing.Point(15, 25);
            this.numScore.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(174, 20);
            this.numScore.TabIndex = 12;
            this.numScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmAjouterCible
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(201, 147);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblDateDeNaissance);
            this.Controls.Add(this.dtpDateTir);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAjouterCible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cible de grouping";
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblDateDeNaissance;
        private System.Windows.Forms.DateTimePicker dtpDateTir;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.NumericUpDown numScore;
    }
}