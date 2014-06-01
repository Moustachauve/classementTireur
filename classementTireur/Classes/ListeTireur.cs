using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace classementTireur
{
    public class ListeTireur : List<Tireur>
    {
        /// <summary>
        /// Charge la liste complète de tous les tireurs depuis la base de donnée
        /// </summary>
        public void GetAllTireurs()
        {
            Clear();

            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM tireurs ORDER BY nom ASC", con))
                {
                    SqlCeDataReader objReader = com.ExecuteReader();
                    while (objReader.Read())
                    {
                        int id = objReader.GetInt32(0);
                        int idEquipe = objReader.GetInt32(1);
                        string nom = objReader.GetString(2);
                        DateTime dateDeNaissance = objReader.GetDateTime(3);

                        Add(new Tireur(id, idEquipe, nom, dateDeNaissance));
                    }
                }
            }
        }

        /// <summary>
        /// Obtient une liste de tous les joueurs dans une équipe
        /// </summary>
        /// <param name="pIdEquipe">Id de l'équipe, ou 0 pour les tireurs sans équipe</param>
        /// <returns>Liste de tireur membre de l'équipe</returns>
        public ListeTireur GetTireurDansEquipe(int pIdEquipe)
        {
            ListeTireur listeEquipe = new ListeTireur();

            foreach (Tireur tireurCourant in this)
            {
                if (tireurCourant.IdEquipe == pIdEquipe)
                    listeEquipe.Add(tireurCourant);
            }

            return listeEquipe;
        }
    }
}
