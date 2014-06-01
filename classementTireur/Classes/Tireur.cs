using System;
using System.Data.SqlServerCe;
using System.ComponentModel;

namespace classementTireur
{
    public class Tireur : INotifyPropertyChanged
    {
        #region Variables membres et propriétés

        private int m_id;
        private int m_idEquipe;
        private string m_nom;
        private DateTime m_dateDeNaissance;

        private ListeCible m_colCibleGrouping;
        private ListeCible m_colCiblePrecision;

        private bool m_doSave;

        #region Propriétés

        /// <summary>
        /// Obtient l'identifiant unique du tireur
        /// </summary>
        public int Id
        {
            get { return m_id; }
        }

        /// <summary>
        /// Obtient ou définit l'identifiant de l'équipe du tireur
        /// </summary>
        public int IdEquipe
        {
            get { return m_idEquipe; }
            set
            {
                if (value <= 0)
                    value = 0;

                m_idEquipe = value;
                
                if (m_doSave)
                {
                    using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
                    {
                        con.Open();

                        using (SqlCeCommand com = new SqlCeCommand("UPDATE tireurs SET idEquipe=@idEquipe WHERE id=@idTireur", con))
                        {
                            com.Parameters.AddWithValue("@idEquipe", m_idEquipe);
                            com.Parameters.AddWithValue("@idTireur", m_id);

                            com.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Obtient ou définit le nom du tireur
        /// </summary>
        public string Nom
        {
            get { return m_nom; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Le nom du tireur ne peut pas être vide");
                if (value == string.Empty)
                    throw new ArgumentNullException("Le nom du tireur ne peut pas être vide");

                m_nom = value;
                if (m_doSave)
                {
                    using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
                    {
                        con.Open();

                        using (SqlCeCommand com = new SqlCeCommand("UPDATE tireurs SET nom=@nom WHERE id=@idTireur", con))
                        {
                            com.Parameters.AddWithValue("@nom", m_nom);
                            com.Parameters.AddWithValue("@idTireur", m_id);

                            com.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Obtient ou définit la date de naissance du tireur
        /// </summary>
        public DateTime DateDeNaissance
        {
            get { return m_dateDeNaissance; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("La date de naissance ne peut pas être vide");

                m_dateDeNaissance = value;
                if (m_doSave)
                {
                    using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
                    {
                        con.Open();

                        using (SqlCeCommand com = new SqlCeCommand("UPDATE tireurs SET dateDeNaissance=@dateDeNaissance WHERE id=@idTireur", con))
                        {
                            com.Parameters.AddWithValue("@dateDeNaissance", m_dateDeNaissance);
                            com.Parameters.AddWithValue("@idTireur", m_id);

                            com.ExecuteNonQuery();
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Obtient l'age du tireur à la date limite pour les compétitions
        /// </summary>
        public int Age
        {
            get
            {
                DateTime dateCalculeAge;
                using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
                {
                    con.Open();

                    using (SqlCeCommand com = new SqlCeCommand("SELECT dateAge FROM settings", con))
                    {
                        SqlCeDataReader objReader = com.ExecuteReader();

                        objReader.Read();

                        dateCalculeAge = objReader.GetDateTime(0);
                    }
                }

                int age = dateCalculeAge.Year - m_dateDeNaissance.Year;
                if (dateCalculeAge < m_dateDeNaissance.AddYears(age))
                    age--;

                return age;
            }
        }

        ///<summary>
        ///Obtient la catégorie dans laquelle le tireur se classe
        ///</summary>
        public enuCategorieTireur CategorieTireur
        {
            get
            {
                if (Age < 15)
                    return enuCategorieTireur.Junior;
                else if (Age < 19)
                    return enuCategorieTireur.Senior;
                else
                    return enuCategorieTireur.Adulte;
            }
        }

        /// <summary>
        /// Obtient la collection de cible de grouping du tireur
        /// </summary>
        public ListeCible ColCibleGrouping
        {
            get
            { return m_colCibleGrouping; }
        }

        /// <summary>
        /// Obtient la collection de cible de précision du tireur
        /// </summary>
        public ListeCible ColCiblePrecision
        {
            get
            { return m_colCiblePrecision; }

        }

        #endregion Propriétés

        #endregion Variables membres et propriétés

        #region Constructeurs

        /// <summary>
        /// Charge un tireur depuis la base de donnée
        /// </summary>
        /// <param name="pId">Identifiant du tireur</param>
        public Tireur(int pId)
        {
            m_doSave = false;

            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM tireurs WHERE id=@id", con))
                {
                    com.Parameters.AddWithValue("@id", pId);
                    SqlCeDataReader objReader = com.ExecuteReader();

                    objReader.Read();

                    m_id = objReader.GetInt32(0);
                    m_idEquipe = objReader.GetInt32(1);
                    m_nom = objReader.GetString(2);
                    m_dateDeNaissance = objReader.GetDateTime(3);
                }
            }

            m_colCibleGrouping = new ListeCible(enuTypeCible.Grouping);
            m_colCiblePrecision = new ListeCible(enuTypeCible.Precision);

            ChargerCibleGrouping();
            ChargerCiblePrecision();

            m_doSave = true;
        }

        /// <summary>
        /// Crée une nouvelle instance de tireur à partir d'un tireur existant
        /// </summary>
        /// <param name="pId">Identifiant du tireur</param>
        /// <param name="pIdEquipe">Identifiant de l'équipe du tireur (-1 s'il n'est pas dans une équipe)</param>
        /// <param name="pNom">Nom du tireur</param>
        /// <param name="pDateDeNaissance">Date de naissance du tireur</param>
        public Tireur(int pId, int pIdEquipe, string pNom, DateTime pDateDeNaissance)
        {
            m_doSave = false;

            m_id = pId;
            m_idEquipe = pIdEquipe;
            Nom = pNom;
            DateDeNaissance = pDateDeNaissance;

            m_colCibleGrouping = new ListeCible(enuTypeCible.Grouping);
            m_colCiblePrecision = new ListeCible(enuTypeCible.Precision);

            ChargerCibleGrouping();
            ChargerCiblePrecision();

            m_doSave = true;
        }

        /// <summary>
        /// Crée un nouveau tireur et l'insère dans la base de donnée
        /// </summary>
        /// <param name="pId">Identifiant du tireur</param>
        /// <param name="pNom">Nom du tireur</param>
        /// <param name="pDateDeNaissance">Date de naissance du tireur</param>
        public Tireur(string pNom, DateTime pDateDeNaissance)
        {
            m_doSave = false;

            Nom = pNom;
            DateDeNaissance = pDateDeNaissance;

            AjouterTireur();

            m_colCibleGrouping = new ListeCible(enuTypeCible.Grouping);
            m_colCiblePrecision = new ListeCible(enuTypeCible.Precision);

            m_doSave = true;
        }

        #endregion Constructeurs

        #region Méthodes

        #region Privées

        /// <summary>
        /// Ajoute le tireur dans la base de donnée
        /// </summary>
        private void AjouterTireur()
        {
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO tireurs (nom, dateDeNaissance, idEquipe) VALUES(@nom, @dateDeNaissance, @idEquipe)", con))
                {
                    com.Parameters.AddWithValue("@nom", Nom);
                    com.Parameters.AddWithValue("@dateDeNaissance", DateDeNaissance);
                    com.Parameters.AddWithValue("@idEquipe", IdEquipe);
                    com.ExecuteNonQuery();

                    com.CommandText = "SELECT @@IDENTITY";
                    object test = com.ExecuteScalar();
                    m_id = int.Parse(test.ToString());
                }
            }
        }

        /// <summary>
        /// Charge la liste des cibles de grouping du tireur
        /// </summary>
        private void ChargerCibleGrouping()
        {
            m_colCibleGrouping.Clear();

            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM cibleGrouping WHERE idTireur = @idTireur ORDER BY dateTir DESC", con))
                {
                    com.Parameters.AddWithValue("@idTireur", m_id);
                    SqlCeDataReader objReader = com.ExecuteReader();
                    while (objReader.Read())
                    {
                        int idCible = objReader.GetInt32(0);
                        int idTireur = objReader.GetInt32(1);
                        float score = (float)objReader.GetDouble(2);
                        DateTime dateTir = objReader.GetDateTime(3);

                        m_colCibleGrouping.Add(new CibleGrouping(idCible, idTireur, score, dateTir));
                    }
                }
            }

        }

        /// <summary>
        /// Charge la liste des cibles de précision du tireur
        /// </summary>
        private void ChargerCiblePrecision()
        {
            m_colCiblePrecision.Clear();

            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM ciblePrecision WHERE idTireur = @idTireur ORDER BY dateTir DESC", con))
                {
                    com.Parameters.AddWithValue("@idTireur", m_id);
                    SqlCeDataReader objReader = com.ExecuteReader();
                    while (objReader.Read())
                    {
                        int idCible = objReader.GetInt32(0);
                        int idTireur = objReader.GetInt32(1);
                        float score = (float)objReader.GetDouble(2);
                        DateTime dateTir = objReader.GetDateTime(3);

                        m_colCiblePrecision.Add(new CiblePrecision(idCible, idTireur, score, dateTir));
                    }
                }
            }
        }

        #endregion Privées

        #region Publiques

        /// <summary>
        /// Supprime un tireur ainsi que toute ses cibles
        /// </summary>
        public void Delete()
        {
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                //Retire le tireur de la base de donnée
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM tireurs WHERE id=@idTireur", con))
                {
                    com.Parameters.AddWithValue("@idTireur", m_id);
                    com.ExecuteNonQuery();
                }
                //Retire les cibles de grouping du tireur
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM cibleGrouping WHERE idTireur=@idTireur", con))
                {
                    com.Parameters.AddWithValue("@idTireur", m_id);
                    com.ExecuteNonQuery();
                }
                //Retire les cibles de précision du tireur
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM ciblePrecision WHERE idTireur=@idTireur", con))
                {
                    com.Parameters.AddWithValue("@idTireur", m_id);
                    com.ExecuteNonQuery();
                }
            }
        }

        #endregion Publiques

        #endregion Méthodes

        #region Implémentation de INotifyPropertyChanged

        // L'implémentation de INotifyPropertyChanged permet aux grilles de se mettre à jour lorsqu'un objet
        // qu'elle contient est mis à jour

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion Implémentation de INotifyPropertyChanged
    }
}
