using System;
using System.Globalization;
using System.Windows.Forms;

namespace classementTireur
{
    public partial class FrmTireur : Form
    {
        #region Variables membres et propriétés

        private Tireur m_tireur;
        private BrightIdeasSoftware.ObjectListView m_olvTireur;

        /// <summary>
        /// Obtient l'Olv de grouping
        /// </summary>
        public BrightIdeasSoftware.ObjectListView ListeGrouping
        {
            get { return olvCibleGrouping; }
        }

        /// <summary>
        /// Obtient l'Olv de précision
        /// </summary>
        public BrightIdeasSoftware.ObjectListView ListePrecision
        {
            get { return olvCiblePrecision; }
        }

        #endregion Variables membres et propriétés

        #region Constructeur

        /// <summary>
        /// Crée un nouveau formulaire affichant les infos d'un tireur
        /// </summary>
        /// <param name="pTireur">Tireur à afficher</param>
        public FrmTireur(Tireur pTireur, BrightIdeasSoftware.ObjectListView pOlvTireur)
        {
            InitializeComponent();

            m_olvTireur = pOlvTireur;
            m_tireur = pTireur;

            this.Text = m_tireur.Nom;
            lblNom.Text = m_tireur.Nom;
            lblDateDeNaissance.Text = m_tireur.DateDeNaissance.ToString("d MMMM yyyy", new CultureInfo("fr-FR"));

            SetOlvDelegates();
            olvCibleGrouping.SetObjects(m_tireur.ColCibleGrouping);
            olvCiblePrecision.SetObjects(m_tireur.ColCiblePrecision);

            UpdateInfosGrouping();
            UpdateInfosPrecision();
        }

        #endregion Constructeur

        #region ObjectListView

        private void SetOlvDelegates()
        {
            //Groupe les cibles par journée de tir
            this.colDateGrouping.GroupKeyGetter = delegate(object rowObject)
            {
                ICible cible = (ICible)rowObject;
                return new DateTime(cible.Date.Year, cible.Date.Month, cible.Date.Day);
            };

            this.colDatePrecision.GroupKeyGetter = delegate(object rowObject)
            {
                ICible cible = (ICible)rowObject;
                return new DateTime(cible.Date.Year, cible.Date.Month, cible.Date.Day);
            };
            //Affiche les groupes en format "humain"
            this.colDateGrouping.GroupKeyToTitleConverter = delegate(object groupKey)
            {
                return ((DateTime)groupKey).ToString("d MMMM yyyy");
            };

            this.colDatePrecision.GroupKeyToTitleConverter = delegate(object groupKey)
            {
                return ((DateTime)groupKey).ToString("d MMMM yyyy");
            };
        }

        #endregion ObjectListView

        #region Grouping

        /// <summary>
        /// Met à jour les informations sur la collection de cible de grouping
        /// </summary>
        public void UpdateInfosGrouping()
        {
            lblMoyenneGrouping.Text = m_tireur.ColCibleGrouping.Moyenne().ToString("F");
            lblMinGrouping.Text = m_tireur.ColCibleGrouping.Min().ToString("F1");
            lblMaxGrouping.Text = m_tireur.ColCibleGrouping.Max().ToString("F1");
        }

        #region Events

        /// <summary>
        /// Changement d'index dans le objectListView de cible de grouping
        /// </summary>
        private void olvCibleGrouping_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSuppGrouping.Enabled = olvCibleGrouping.SelectedObject != null;
        }

        /// <summary>
        /// Ajouter une cible de grouping
        /// </summary>
        private void btnAjouterGrouping_Click(object sender, EventArgs e)
        {
            new FrmAjouterCible(enuTypeCible.Grouping, m_tireur, m_olvTireur, this).ShowDialog();
        }

        /// <summary>
        /// Supprimer une cible de grouping
        /// </summary>
        private void btnSuppGrouping_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette cible?", "Supprimer une cible", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ICible cibleARetirer = (ICible)olvCibleGrouping.SelectedObject;
                cibleARetirer.Remove();
                olvCibleGrouping.RemoveObject(cibleARetirer);
                m_tireur.ColCibleGrouping.Remove(cibleARetirer);

                m_olvTireur.UpdateObject(m_tireur);
                btnSuppGrouping.Enabled = false;
            }
        }

        #endregion Events

        #endregion Grouping

        #region Précision

        /// <summary>
        /// Met à jour les informations sur la collection de cible de précision
        /// </summary>
        public void UpdateInfosPrecision()
        {
            lblMoyennePrecision.Text = m_tireur.ColCiblePrecision.Moyenne().ToString("F%");
            lblMinPrecision.Text = m_tireur.ColCiblePrecision.Min() + "%";
            lblMaxPrecision.Text = m_tireur.ColCiblePrecision.Max() + "%";
        }

        #region Events

        /// <summary>
        /// Ajoute une cible de précision
        /// </summary>
        private void btnAjouterPrecision_Click(object sender, EventArgs e)
        {
            new FrmAjouterCible(enuTypeCible.Precision, m_tireur, m_olvTireur, this);
        }

        /// <summary>
        /// Supprime une cible de précision
        /// </summary>
        private void btnSuppPrecision_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette cible?", "Supprimer une cible", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ICible cibleARetirer = (ICible)olvCiblePrecision.SelectedObject;
                cibleARetirer.Remove();
                olvCiblePrecision.RemoveObject(cibleARetirer);
                m_tireur.ColCiblePrecision.Remove(cibleARetirer);

                m_olvTireur.UpdateObject(m_tireur);
                btnSuppPrecision.Enabled = false;
            }

        }

        #endregion Events

        #endregion Précision

    }
}
