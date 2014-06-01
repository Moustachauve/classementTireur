using System.Data.SqlServerCe;

namespace classementTireur
{
    public class Equipe
    {
        #region Variables membres et propriétés

        private int m_id;
        private string m_nom;
        private bool m_doSave;

        /// <summary>
        /// Obtient l'identificateur de l'équipe
        /// </summary>
        public int Id
        {
            get { return m_id; }
        }

        /// <summary>
        /// Obtient ou définit le nom de l'équipe
        /// </summary>
        public string Nom
        {
            get { return m_nom; }
            set
            {
                if (m_doSave)
                {
                    using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
                    {
                        con.Open();

                        using (SqlCeCommand com = new SqlCeCommand("UPDATE equipes SET nom=@nomEquipe WHERE id=@idEquipe", con))
                        {
                            com.Parameters.AddWithValue("@nomEquipe", value);
                            com.Parameters.AddWithValue("@idEquipe", m_id);

                            com.ExecuteNonQuery();
                        }
                    }
                }

                m_nom = value;
            }
        }

        #endregion Variables membres et propriétés

        #region Constructeurs

        /// <summary>
        /// Charge une équipe existante depuis la base de donnée
        /// </summary>
        /// <param name="pId">Identifiant de l'équipe</param>
        public Equipe(int pId)
        {
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM equipes WHERE id=@id", con))
                {
                    com.Parameters.AddWithValue("@id", pId);
                    SqlCeDataReader objReader = com.ExecuteReader();

                    objReader.Read();

                    m_id = objReader.GetInt32(0);
                    m_nom = objReader.GetString(1);
                }
            }
        }

        /// <summary>
        /// Crée une nouvelle instance d'équipe existante
        /// </summary>
        /// <param name="pId">Identifiant de l'équipe</param>
        /// <param name="pNom">Nom de l'équipe</param>
        public Equipe(int pId, string pNom)
        {
            m_doSave = false;
            m_id = pId;
            Nom = pNom;
            m_doSave = true;
        }

        public Equipe(string pNom)
        {
            m_doSave = false;
            Nom = pNom;
            AjouterEquipe();
            m_doSave = true;
        }

        #endregion Constructeurs

        #region Insérer dans la base de donnée

        /// <summary>
        /// Ajoute l'équipe dans la base de donnée
        /// </summary>
        private void AjouterEquipe()
        {
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO equipes (nom) VALUES(@nom)", con))
                {
                    com.Parameters.AddWithValue("@nom", Nom);
                    com.ExecuteNonQuery();

                    com.CommandText = "SELECT @@IDENTITY";
                    object test = com.ExecuteScalar();
                    m_id = int.Parse(test.ToString());
                }
            }
        }

        #endregion Insérer dans la base de donnée

        #region Supprimer

        /// <summary>
        /// Supprime l'équipe de la base de donnée et retire les tireurs de l'équipe
        /// </summary>
        /// <param name="pListeTireurs">Liste de tous les tireurs</param>
        public void Delete(ListeTireur pListeTireurs)
        {
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                //Retire le tireur de la base de donnée
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM equipes WHERE id=@idEquipe", con))
                {
                    com.Parameters.AddWithValue("@idEquipe", m_id);
                    com.ExecuteNonQuery();
                }
            }
            foreach (Tireur tireurCourant in pListeTireurs)
            {
                if (tireurCourant.IdEquipe == Id)
                    tireurCourant.IdEquipe = 0;
            }
        }

        #endregion Supprimer

        /// <summary>
        /// Calcule la moyenne de grouping pour l'équipe
        /// </summary>
        /// <param name="pColTireur">Collection de joueurs</param>
        /// <returns>Moyenne des cibles de grouping</returns>
        public float MoyenneGrouping(ListeTireur pColTireur)
        {
            float total = 0;
            float nbTireurs = 0;

            foreach (Tireur tireurCourant in pColTireur)
            {
                if (tireurCourant.IdEquipe == Id)
                {
                    float moyenneTireur = tireurCourant.ColCibleGrouping.Moyenne();
                    if (moyenneTireur < 7)
                        total += moyenneTireur;
                    nbTireurs++;
                }
            }
            if (nbTireurs == 0)
                return 7;

            return total / nbTireurs;
        }
        /// <summary>
        /// Calcule la moyenne de précision pour l'équipe
        /// </summary>
        /// <param name="pColTireur">Collection de joueurs</param>
        /// <returns>Moyenne des cibles de précision</returns>
        public float MoyennePrecision(ListeTireur pColTireur)
        {
            float total = 0;
            float nbTireurs = 0;

            foreach (Tireur tireurCourant in pColTireur)
            {
                if (tireurCourant.IdEquipe == Id)
                {
                    float moyenneTireur = tireurCourant.ColCiblePrecision.Moyenne();
                    if (moyenneTireur > -1)
                        total += moyenneTireur;
                    nbTireurs++;
                }
            }
            if (nbTireurs == 0)
                return -1;

            return total / nbTireurs;
        }
    }
}
