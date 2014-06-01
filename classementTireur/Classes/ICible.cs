using System;

namespace classementTireur
{
    public interface ICible
    {
        /// <summary>
        /// Obtient l'identifiant de la cible
        /// </summary>
        int Id
        {
            get;
        }

        /// <summary>
        /// Obtient l'identifiant du joueur qui a tiré la cible
        /// </summary>
        int IdTireur
        {
            get;
        }

        /// <summary>
        /// Obtient le tireur de la cible
        /// </summary>
        Tireur Tireur
        {
            get;
        }

        /// <summary>
        /// Obtient le score de la cible
        /// </summary>
        float Score
        {
            get;
        }

        /// <summary>
        /// Obtient la date à laquelle la cible a été tiré
        /// </summary>
        DateTime Date
        {
            get;
        }

        /// <summary>
        /// Retire une cible de la base de donnée
        /// </summary>
        void Remove();
    }
}
