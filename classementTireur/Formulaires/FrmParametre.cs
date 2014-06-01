using System;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace classementTireur
{
    public partial class FrmParametre : Form
    {
        private BrightIdeasSoftware.ObjectListView m_olvTireur;

        /// <summary>
        /// Crée un formulaire pour modifier les paramètres de la compétition
        /// </summary>
        /// <param name="pOlvTireur">Liste à mettre à jour (Met à jour l'âge des tireurs)</param>
        public FrmParametre(BrightIdeasSoftware.ObjectListView pOlvTireur)
        {
            InitializeComponent();
            m_olvTireur = pOlvTireur;
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("UPDATE settings SET dateAge=@date", con))
                {
                    com.Parameters.AddWithValue("@date", dtpDate.Value);

                    com.ExecuteNonQuery();
                }
            }
            m_olvTireur.BuildList(true);
            Close();
        }

    }
}
