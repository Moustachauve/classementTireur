using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace classementTireur
{
    public class ListeEquipe : List<Equipe>
    {
        /// <summary>
        /// Charge la liste complète des équipes depuis la base de donnée
        /// </summary>
        public void ChargerEquipes()
        {
            this.Clear();
            using (SqlCeConnection con = new SqlCeConnection(BaseDeDonnee.InfoConnexion))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM equipes", con))
                {
                    SqlCeDataReader objReader = com.ExecuteReader();
                    while (objReader.Read())
                    {
                        int id = objReader.GetInt32(0);
                        string nom = objReader.GetString(1);

                        Add(new Equipe(id, nom));
                    }
                }
            }
        }

        /// <summary>
        /// Obtient l'équipe depuis son identifiant
        /// </summary>
        /// <param name="pId">Identifiant de l'équipe à chercher</param>
        /// <returns>Équipe trouvée, sinon null</returns>
        public Equipe EquipeAt(int pId)
        {
            if (pId == 0)
                return null;
            foreach (Equipe equipeCourante in this)
            {
                if (equipeCourante.Id == pId)
                    return equipeCourante;
            }

            return null;
        }

        /// <summary>
        /// Obtient l'équipe depuis son nom
        /// </summary>
        /// <param name="pNom">Nom de l'équipe à chercher</param>
        /// <returns>Équipe trouvée, sinon null</returns>
        public Equipe EquipeAt(string pNom)
        {
            if (pNom == String.Empty)
                return null;

            foreach (Equipe equipeCourante in this)
            {
                if (equipeCourante.Nom == pNom)
                    return equipeCourante;
            }

            return null;
        }
    }
}
