using System;
using System.Data.SqlServerCe;

namespace classementTireur
{
    class CiblePrecision : ICible
    {
        #region Variables membres & constantes

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
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Obtient le résultat de la cible
        /// </summary>
        public float Score
        {
            get { return m_score; }
            private set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Le score d'une cible de précision doit être compris entre 0 et 100");

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

        #endregion Variables membres & constantes

        #region Constructeurs

        /// <summary>
        /// Charge une cible de précision existante
        /// </summary>
        /// <param name="pId">Identifiant unique de la cible</param>
        /// <param name="pIndexTireur">Identifiant du tireur</param>
        /// <param name="pScore">Score de la cible</param>
        /// <param name="pDate">Date à laquelle la cible a été tiré</param>
        public CiblePrecision(int pId, int pIndexTireur, float pScore, DateTime pDate)
        {
            m_id = pId;
            m_indexTireur = pIndexTireur;
            Score = pScore;
            m_date = pDate;
        }

        /// <summary>
        /// Crée une nouvelle cible de précision et l'insère dans la base de donnée
        /// </summary>
        /// <param name="pIndexTireur">Identifiant du tireur</param>
        /// <param name="pScore">Score de la cible</param>
        /// <param name="pDate">Date à laquelle la cible a été tiré</param>
        public CiblePrecision(int pIndexTireur, float pScore, DateTime pDate)
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

                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO ciblePrecision (idTireur, score, dateTir) VALUES(@idTireur, @score, @dateTir);", con))
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
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM ciblePrecision WHERE id=@idCible", con))
                {
                    com.Parameters.AddWithValue("@idCible", m_id);
                    com.ExecuteNonQuery();
                }

            }
        }

        #endregion Enregistrement
    }
}
