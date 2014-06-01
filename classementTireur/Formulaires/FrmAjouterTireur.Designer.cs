namespace classementTireur
{
    partial class FrmAjouterTireur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjouterTireur));
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dtpDateDeNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(70, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom du tireur";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.Window;
            this.txtNom.Location = new System.Drawing.Point(15, 25);
            this.txtNom.MaxLength = 35;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(191, 20);
            this.txtNom.TabIndex = 1;
            // 
            // dtpDateDeNaissance
            // 
            this.dtpDateDeNaissance.Location = new System.Drawing.Point(15, 69);
            this.dtpDateDeNaissance.MaxDate = new System.DateTime(2014, 4, 22, 21, 41, 9, 418);
            this.dtpDateDeNaissance.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateDeNaissance.Name = "dtpDateDeNaissance";
            this.dtpDateDeNaissance.Size = new System.Drawing.Size(191, 20);
            this.dtpDateDeNaissance.TabIndex = 2;
            this.dtpDateDeNaissance.Value = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Location = new System.Drawing.Point(12, 53);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(96, 13);
            this.lblDateDeNaissance.TabIndex = 3;
            this.lblDateDeNaissance.Text = "Date de naissance";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(125, 112);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(81, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(59, 112);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(60, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // errError
            // 
            this.errError.ContainerControl = this;
            // 
            // FrmAjouterTireur
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(218, 147);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblDateDeNaissance);
            this.Controls.Add(this.dtpDateDeNaissance);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAjouterTireur";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un tireur";
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dtpDateDeNaissance;
        private System.Windows.Forms.Label lblDateDeNaissance;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ErrorProvider errError;
    }
}