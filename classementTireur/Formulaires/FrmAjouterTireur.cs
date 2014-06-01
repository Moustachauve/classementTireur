using System;
using System.Windows.Forms;

namespace classementTireur
{
    public partial class FrmAjouterTireur : Form
    {
        BrightIdeasSoftware.ObjectListView olvParent;
        Tireur m_tireur;

        #region Constructeurs

        /// <summary>
        /// Crée un formulaire permettant d'ajouter un tireur
        /// </summary>
        /// <param name="pParent">Formulaire principal</param>
        public FrmAjouterTireur(BrightIdeasSoftware.ObjectListView pOlvParent)
        {
            InitializeComponent();
            dtpDateDeNaissance.Value = System.DateTime.Today.AddYears(-15);
            dtpDateDeNaissance.MaxDate = System.DateTime.Today;

            txtNom.SelectAll();

            olvParent = pOlvParent;
        }

        /// <summary>
        /// Crée un formulaire permettant d'éditer un tireur
        /// </summary>
        /// <param name="pParent">Formulaire principal</param>
        /// <param name="pTireur">Tireur à éditer</param>
        public FrmAjouterTireur(BrightIdeasSoftware.ObjectListView pOlvParent, Tireur pTireur)
        {
            InitializeComponent();

            txtNom.Text = pTireur.Nom;
            dtpDateDeNaissance.Value = pTireur.DateDeNaissance;

            olvParent = pOlvParent;
            m_tireur = pTireur;

            this.Text = "Modifier un tireur";
            btnAjouter.Text = "Modifier";
        }

        #endregion Constructeurs

        /// <summary>
        /// Ajoute un tireur dans la liste si le formulaire est bien rempli
        /// </summary>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            errError.Clear();

            if (txtNom.Text == string.Empty)
            {
                errError.SetError(txtNom, "Le nom du tireur ne peut pas être vide");
                this.errError.SetIconPadding(txtNom, -20);
                return;
            }

            if (m_tireur == null)
            {
                olvParent.AddObject(new Tireur(txtNom.Text, dtpDateDeNaissance.Value));
            }
            else
            {
                m_tireur.Nom = txtNom.Text;
                m_tireur.DateDeNaissance = dtpDateDeNaissance.Value;
                olvParent.UpdateObject(m_tireur);
            }

            this.Close();
        }
    }
}
