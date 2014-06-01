using System;
using System.Data.SqlServerCe;

namespace classementTireur
{
    public class CibleGrouping : ICible
    {
        #region Variables membres & propriétés

        private int m_id;
        private int m_indexTireur;
        private float m_score;
        private DateTime m_date;

        #region Propriétés

        /// <summary>
        /// Obtient l'identifiant unique de la cible
        /// </summary>
        public int Id
        {
            get { return m_id; }
        }

        /// <summary>
        /// Obtient l'index du tireur
        /// </summary>
        public int IdTireur
        {
            get { return m_indexTireur; }
        }

        /// <summary>
        /// Obtient le tireur de la cible
        /// </summary>
        public Tireur Tireur
        {
            get
            {
                return new Tireur(IdTireur);
            }
        }

        /// <summary>
        /// Obtient le score de la cible
        /// </summary>
        public float Score
        {
            get { return m_score; }
            private set
            {
                if (value < 1 || value > 6)
                    throw new ArgumentOutOfRangeException("Le score d'une cible de précision doit être compris entre 1 et 6");

                m_score = value;
            }
        }

        /// <summary>
        /// Obtient la date à laquelle la cible a été tiré
        /// </summary>
        public DateTime Date
        {
            get { return m_date; }
        }

        #endregion Propriétés

        #endregion Variables membres & propriétés

        #region Constructeurs

        /// <summary>
        /// Charge une cible de grouping existante
        /// </summary>
        /// <param name="pId">Identifiant unique de la cible</param>
        /// <param name="pIndexTireur">Identifiant du tireur</param>
        /// <param name="pScore">Score de la cible</param>
        /// <param name="pDate">Date à laquelle la cible a été tiré</param>
        public CibleGrouping(int pId, int pIndexTireur, float pScore, DateTime pDate)
        {
            m_id = pId;
            m_indexTireur = pIndexTireur;
            Score = pScore;
            m_date = pDate;
        }

        /// <summary>
        /// Crée une nouvelle cible de grouping et l'insère dans la base de donnée
        /// </summary>
        /// <param name="pIndexTireur">Identifiant du tireur</param>
        /// <param name="pScore">Score de la cible</param>
        /// <param name="pDate">Date à laquelle la cible a été tiré</param>
        public CibleGrouping(int pIndexTireur, float pScore, DateTime pDate)
        {
            m_indexTireur = pIndexTireur;
            Score = pScore;
            m_date = pDate;

            AjouterCible();
        }

        #endregion

        #region Enregistrement

        /// <summary>
        /// Ajoute la cible dans la base de donnée
        /// </summary>
        private void AjouterCible()
        {
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO cibleGrouping (idTireur, score, dateTir) VALUES(@idTireur, @score, @dateTir);", con))
                {
                    com.Parameters.AddWithValue("@idTireur", IdTireur);
                    com.Parameters.AddWithValue("@score", Score);
                    com.Parameters.AddWithValue("@dateTir", Date);
                    com.ExecuteNonQuery();

                    com.CommandText = "SELECT @@IDENTITY";
                    object test = com.ExecuteScalar();
                    m_id = int.Parse(test.ToString());
                }
            }
        }

        /// <summary>
        /// Retire une cible de la base de donnée
        /// </summary>
        public void Remove()
        {
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM cibleGrouping WHERE id=@idCible", con))
                {
                    com.Parameters.AddWithValue("@idCible", m_id);
                    com.ExecuteNonQuery();
                }
            }
        }

        #endregion Enregistrement
    }
}
