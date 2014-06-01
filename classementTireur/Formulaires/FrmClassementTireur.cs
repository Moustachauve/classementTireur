using System;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace classementTireur
{
    public partial class FrmClassementTireur : Form
    {
        ObjectListView m_olvTireur;

        public ObjectListView OlvClassement
        {
            get { return olvClassement; }
        }

        /// <summary>
        /// Affiche le classement des tireurs
        /// </summary>
        /// <param name="pOlvTireur">Liste des tireurs</param>
        public FrmClassementTireur(ObjectListView pOlvTireur)
        {
            InitializeComponent();
            OlvFormatage();

            m_olvTireur = pOlvTireur;

            olvClassement.Objects = pOlvTireur.Objects;

            olvClassement.Sort(colMoyenneGrouping, SortOrder.Ascending);
        }

        /// <summary>
        /// Met à jour les données dans l'objectlistview
        /// </summary>
        private void cmnuActualiser_Click(object sender, EventArgs e)
        {
            olvClassement.Objects = m_olvTireur.Objects;
        }

        /// <summary>
        /// Méthode pour formater les valeurs dans l'objectlistview
        /// </summary>
        private void OlvFormatage()
        {
            this.colMoyenneGrouping.AspectToStringConverter = delegate(object x)
            {
                if (x == null)
                    return String.Empty;

                float moyenne = float.Parse(x.ToString());

                if (moyenne > 6)
                    return "-";
                else
                    return String.Format("{0:F}", moyenne); ;
            };
            this.colMoyennePrecision.AspectToStringConverter = delegate(object x)
            {
                if (x == null)
                    return String.Empty;

                float moyenne = float.Parse(x.ToString());

                if (moyenne < 0)
                    return "-";
                else
                    return String.Format("{0:F}%", moyenne); ;

            };
            this.colNom.GroupKeyGetter = delegate(object rowObject)
            {
                return 1;
            };
            this.colNom.GroupKeyToTitleConverter = delegate(object groupKey)
            {
                return "Tireurs";
            };
        }

        /// <summary>
        /// Évènement créant les groupes selon l'option sélectionné
        /// </summary>
        private void olvClassement_BeforeCreatingGroups(object sender, CreateGroupsEventArgs e)
        {
            if (cmnuSortByCategory.Checked)
                e.Parameters.GroupByColumn = colCategorie;
            else
                e.Parameters.GroupByColumn = colNom;

            e.Parameters.GroupByOrder = SortOrder.Ascending;
        }

        /// <summary>
        /// Changement d'option pour les groupes: division par catégorie
        /// </summary>
        private void cmnuSortByCategory_Click(object sender, EventArgs e)
        {
            cmnuSortByCategory.Checked = true;
            cmnuSortByName.Checked = false;

            olvClassement.BuildGroups();
        }

        /// <summary>
        /// Changement d'option pour les groupes: aucune division
        /// </summary>
        private void cmnuSortByName_Click(object sender, EventArgs e)
        {
            cmnuSortByName.Checked = true;
            cmnuSortByCategory.Checked = false;

            olvClassement.BuildGroups();
        }
    }
}
