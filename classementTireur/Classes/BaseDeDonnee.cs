using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Reflection;

namespace classementTireur
{
    class BaseDeDonnee
    {
        #region Constantes et statiques

        /// <summary>
        /// Nom du fichier par défaut
        /// </summary>
        public const string NOM_FICHIER_DEFAUT = "Sans Nom";
        public const string EXTENSION_DEFAUT = ".dtir";

        /// <summary>
        /// Obtient la chaine de connexion pour la base de donnée active
        /// </summary>
        public static string InfoConnexion
        {
            get;
            private set;
        }

        #endregion Constantes et statiques

        #region Propriétés et variables membres

        private string m_dossierSauvegarde;
        private string m_cheminFichierCourant;

        /// <summary>
        /// Obtient le dossier de sauvegarde par défaut
        /// </summary>
        public string DossierSauvegarde
        {
            get { return m_dossierSauvegarde; }
        }

        /// <summary>
        /// Obtient le chemin de la base de donnée chargée
        /// </summary>
        public string CheminFichierCourant
        {
            get { return m_cheminFichierCourant; }
        }

        #endregion Propriétés et variables membres

        #region Constructeurs

        /// <summary>
        /// Instancie l'objet base de donnée en chargeant la base de donnée par défaut
        /// Si elle n'existe pas, on la crée
        /// </summary>
        public BaseDeDonnee()
        {
            m_dossierSauvegarde = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SauvegardesTir";

            if (!Directory.Exists(m_dossierSauvegarde))
                Directory.CreateDirectory(m_dossierSauvegarde);

            m_cheminFichierCourant = System.IO.Path.Combine(m_dossierSauvegarde, NOM_FICHIER_DEFAUT + EXTENSION_DEFAUT);

            if (!File.Exists(m_cheminFichierCourant))
                Creer(m_cheminFichierCourant);

            Charger(m_cheminFichierCourant);
        }

        /// <summary>
        /// Instancie l'objet base de donnée en chargeant la base de donnée en paramètre
        /// </summary>
        /// <param name="pChemin">Chemin de la base de donnée</param>
        public BaseDeDonnee(string pChemin)
        {
            m_dossierSauvegarde = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SauvegardesTir";

            m_cheminFichierCourant = pChemin;

            Charger(pChemin);
        }

        #endregion Constructeurs

        #region Créer une base de donnée

        /// <summary>
        /// Crée une base de donnée avec un chemin par défaut
        /// </summary>
        public void Creer()
        {
            Creer(System.IO.Path.Combine(m_dossierSauvegarde, NOM_FICHIER_DEFAUT + EXTENSION_DEFAUT));
        }

        /// <summary>
        /// Crée une nouvelle base de donnée
        /// </summary>
        /// <param name="pChemin">chemin du fichier</param>
        public void Creer(string pChemin)
        {
            if (!Directory.Exists(m_dossierSauvegarde))
            {
                Directory.CreateDirectory(m_dossierSauvegarde);
            }

            if (File.Exists(pChemin))
            {
                File.Delete(pChemin);
            }

            string connStr = @"Data Source = " + pChemin;

            SqlCeEngine engine = new SqlCeEngine(connStr);
            engine.CreateDatabase();

            using (SqlCeConnection conn = new SqlCeConnection(connStr))
            {
                conn.Open();
                using (SqlCeCommand cmd = new SqlCeCommand(@"CREATE TABLE tireurs (id INT IDENTITY NOT NULL PRIMARY KEY, idEquipe INT NOT NULL DEFAULT(0), nom NVARCHAR(35), dateDeNaissance DATETIME)", conn))
                {
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE cibleGrouping (id int IDENTITY NOT NULL PRIMARY KEY, idTireur int, score float, dateTir datetime)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE ciblePrecision (id int IDENTITY NOT NULL PRIMARY KEY, idTireur int, score float, dateTir datetime)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE equipes (id int IDENTITY NOT NULL PRIMARY KEY, nom NVARCHAR(35))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE settings (dateAge datetime)";
                    cmd.ExecuteNonQuery();
                }
                using (SqlCeCommand cmd = new SqlCeCommand(@"INSERT INTO settings VALUES (@dateNow)", conn))
                {
                    cmd.Parameters.AddWithValue("@dateNow", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion Créer une base de donnée

        #region Charger/déplacer une base de donnée

        /// <summary>
        /// Charge une base de donnée et la rend active
        /// </summary>
        /// <param name="pChemin">Chemin de la base de donnée</param>
        public void Charger(string pChemin)
        {
            if (!File.Exists(pChemin))
                throw new InvalidOperationException("Chargement d'une base de donnée inexistante impossible");

            InfoConnexion = @"Data Source = " + pChemin;
            m_cheminFichierCourant = pChemin;
        }

        /// <summary>
        /// Déplace la base de donnée actuel vers un nouveau chemin
        /// </summary>
        /// <param name="pNouveauChemin">Nouveau chemin de la base de donnée</param>
        public void Deplacer(string pNouveauChemin)
        {
            if (File.Exists(pNouveauChemin))
                File.Delete(pNouveauChemin);
            File.Move(m_cheminFichierCourant, pNouveauChemin);
            Charger(pNouveauChemin);
        }

        #endregion Charger une base de donnée

    }
}
