using System;
using System.Windows.Forms;

namespace classementTireur
{
    public partial class FrmClassementEquipe : Form
    {
        BrightIdeasSoftware.ObjectListView m_olvTireur;
        ListeEquipe m_colEquipe;

        public BrightIdeasSoftware.ObjectListView OlvClassement
        {
            get { return olvClassement; }
        }

        public FrmClassementEquipe(BrightIdeasSoftware.ObjectListView pOlvTireur, ListeEquipe pColEquipe)
        {
            InitializeComponent();
            OlvFormatage();

            m_olvTireur = pOlvTireur;
            m_colEquipe = pColEquipe;

            olvClassement.Objects = m_colEquipe;
        }

        /// <summary>
        /// Met à jour les données dans l'objectlistview
        /// </summary>
        private void cmnuActualiser_Click(object sender, EventArgs e)
        {
            olvClassement.Objects = m_colEquipe;
        }

        private void OlvFormatage()
        {
            //Formatte la moyenne de grouping
            this.colMoyenneGrouping.AspectGetter = delegate(object x)
            {
                Equipe equipeCourante = (Equipe)x;

                ListeTireur listeTireur = new ListeTireur();

                foreach (Tireur tireurCourant in m_olvTireur.Objects)
                {
                    if (tireurCourant.IdEquipe == equipeCourante.Id)
                        listeTireur.Add(tireurCourant);
                }

                float moyenne = equipeCourante.MoyenneGrouping(listeTireur);

                if (moyenne > 6)
                    return "-";
                else
                    return String.Format("{0:F}", moyenne);
            };
            //Format la moyenne de précision
            this.colMoyennePrecision.AspectGetter = delegate(object x)
            {
                Equipe equipeCourante = (Equipe)x;

                ListeTireur listeTireur = new ListeTireur();

                foreach (Tireur tireurCourant in m_olvTireur.Objects)
                {
                    if (tireurCourant.IdEquipe == equipeCourante.Id)
                        listeTireur.Add(tireurCourant);
                }

                float moyenne = equipeCourante.MoyennePrecision(listeTireur);

                if (moyenne < 0)
                    return "-";
                else
                    return String.Format("{0:F}%", moyenne);
            };
        }
    }
}
