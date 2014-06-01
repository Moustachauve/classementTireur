using System.Collections.Generic;

namespace classementTireur
{

    public class ListeCible : List<ICible>
    {
        enuTypeCible m_typeDeCible;
        /// <summary>
        /// Crée une liste de cible
        /// </summary>
        /// <param name="pTypeDeCible">Type de cible dans la liste</param>
        public ListeCible(enuTypeCible pTypeDeCible)
            : base()
        {
            m_typeDeCible = pTypeDeCible;
        }

        #region Méthodes privées

        /// <summary>
        /// Obtient la valeur la plus petite dans la liste
        /// </summary>
        /// <returns>Valeur la plus petite</returns>
        private float Lowest()
        {
            if (this.Count == 0)
                return -1;

            float min = int.MaxValue;
            foreach (ICible cibleCourante in this)
            {
                if (cibleCourante.Score < min)
                    min = cibleCourante.Score;
            }

            return min;
        }

        /// <summary>
        /// Obtient la valeur la plus grande dans la liste
        /// </summary>
        /// <returns>Valeur la plus grande</returns>
        private float Highest()
        {
            if (this.Count == 0)
                return -1;

            float max = 0;
            foreach (ICible cibleCourante in this)
            {
                if (cibleCourante.Score > max)
                    max = cibleCourante.Score;
            }

            return max;

        }

        #endregion Méthodes privées

        #region Publiques

        /// <summary>
        /// Calcule la moyenne du score des cibles contenue dans la liste
        /// </summary>
        /// <returns>Moyenne du score</returns>
        public float Moyenne()
        {
            int nbCible = this.Count;
            if (nbCible == 0)
            {
                if (m_typeDeCible == enuTypeCible.Grouping)
                    return 7;
                else
                    return -1;
            }

            float moyenne = 0;

            for (int index = 0; index < nbCible; index++)
            {
                moyenne += this[index].Score;
            }

            return moyenne / nbCible;
        }

        /// <summary>
        /// Obtient le plus bas score parmis les cibles de la liste
        /// </summary>
        /// <returns></returns>
        public float Min()
        {
            switch (m_typeDeCible)
            {
                case enuTypeCible.Grouping:
                    return Lowest();
                case enuTypeCible.Precision:
                    return Highest();
            }
            return 0;
        }

        /// <summary>
        /// Obtient le meilleur score parmis les cibles de la liste
        /// </summary>
        /// <returns></returns>
        public float Max()
        {
            switch (m_typeDeCible)
            {
                case enuTypeCible.Grouping:
                    return Highest();
                case enuTypeCible.Precision:
                    return Lowest();
            }
            return 0;
        }

        #endregion Publiques
    }
}
