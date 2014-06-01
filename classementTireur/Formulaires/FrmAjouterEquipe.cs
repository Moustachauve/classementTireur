using System;
using System.Windows.Forms;

namespace classementTireur
{
    public partial class FrmAjouterEquipe : Form
    {
        FrmEquipe m_frmEquipe;

        /// <summary>
        /// Crée un nouveau formulaire permettant de créer une équipe
        /// </summary>
        /// <param name="pFrmEquipe">Formulaire parent</param>
        public FrmAjouterEquipe(FrmEquipe pFrmEquipe)
        {
            InitializeComponent();

            m_frmEquipe = pFrmEquipe;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNomEquipe.Text == string.Empty)
                return;
            Equipe nouvEquipe = new Equipe(txtNomEquipe.Text);
            m_frmEquipe.AjouterEquipe(nouvEquipe);

            this.Close();
        }
    }
}
