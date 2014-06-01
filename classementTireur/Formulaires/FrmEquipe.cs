using System;
using System.Windows.Forms;

namespace classementTireur
{
    public partial class FrmEquipe : Form
    {
        ListeTireur m_colTireur;
        ListeEquipe m_colEquipe;

        BrightIdeasSoftware.ObjectListView m_olvPrincipal;

        /// <summary>
        /// Crée un formulaire pour modifier les équipes
        /// </summary>
        /// <param name="pColTireurs">Collection de tous les tireurs</param>
        /// <param name="pColEquipe">Collection de toutes les équipes</param>
        public FrmEquipe(BrightIdeasSoftware.ObjectListView PolvPrincipal, ListeTireur pColTireurs, ListeEquipe pColEquipe)
        {
            InitializeComponent();

            m_olvPrincipal = PolvPrincipal;

            m_colTireur = pColTireurs;
            m_colEquipe = pColEquipe;

            OlvFormatage();

            AfficherTireurs();
            AfficherEquipes();
        }

        /// <summary>
        /// Format les moyenne des tireurs dans la liste
        /// </summary>
        private void OlvFormatage()
        {
            this.colGrouping.AspectToStringConverter = delegate(object x)
            {
                if (x == null)
                    return String.Empty;

                float moyenne = float.Parse(x.ToString());

                if (moyenne > 6)
                    return "-";
                else
                    return String.Format("{0:F}", moyenne); ;
            };
            this.colPrecision.AspectToStringConverter = delegate(object x)
            {
                if (x == null)
                    return String.Empty;

                float moyenne = float.Parse(x.ToString());

                if (moyenne < 0)
                    return "-";
                else
                    return String.Format("{0:F}%", moyenne); ;

            };
        }

        /// <summary>
        /// Affiche les tireurs sans équipe dans le listbox
        /// </summary>
        private void AfficherTireurs()
        {
            lsbTireurs.Items.Clear();
            foreach (Tireur tireurCourant in m_colTireur.GetTireurDansEquipe(0))
            {
                lsbTireurs.Items.Add(tireurCourant.Nom);
            }
        }

        /// <summary>
        /// Affiche les équipes dans la combobox
        /// </summary>
        private void AfficherEquipes()
        {
            cboEquipeAfficher.Items.Clear();
            foreach (Equipe equipeCourante in m_colEquipe)
            {
                cboEquipeAfficher.Items.Add(equipeCourante.Nom);
            }
        }

        /// <summary>
        /// Ajoute une équipe dans le formulaire et la sélectionne
        /// </summary>
        /// <param name="pEquipe">Équipe à ajouter</param>
        public void AjouterEquipe(Equipe pEquipe)
        {
            m_colEquipe.Add(pEquipe);
            AfficherEquipes();
            cboEquipeAfficher.SelectedIndex = m_colEquipe.Count - 1;
        }

        /// <summary>
        /// Bouton pour ajouter une équipe
        /// </summary>
        private void btnAjouterEquipe_Click(object sender, EventArgs e)
        {
            new FrmAjouterEquipe(this).ShowDialog();
        }

        /// <summary>
        /// Évènement lorsque l'index sélectionné du cboBox change
        /// </summary>
        private void cboEquipeAfficher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEquipeAfficher.SelectedIndex == -1)
            {
                txtNom.Clear();
                olvTireur.Objects = null;
                grpDetails.Enabled = false;
            }
            else
            {
                txtNom.Text = m_colEquipe[cboEquipeAfficher.SelectedIndex].Nom;

                Equipe equipeSel = m_colEquipe.EquipeAt(txtNom.Text);

                olvTireur.SetObjects(m_colTireur.GetTireurDansEquipe(equipeSel.Id));
                grpDetails.Enabled = true;
            }
        }

        /// <summary>
        /// Lorsque l'on double click sur un joueur sans équipe
        /// </summary>
        private void lsbTireurs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lsbTireurs.SelectedIndex == -1)
                return;
            if(cboEquipeAfficher.SelectedIndex == -1)
                return;

            ListeTireur colTireur = m_colTireur.GetTireurDansEquipe(0);
            Equipe equipeSel = m_colEquipe.EquipeAt(cboEquipeAfficher.SelectedItem.ToString());

            colTireur[lsbTireurs.SelectedIndex].IdEquipe = equipeSel.Id;

            olvTireur.AddObject(colTireur[lsbTireurs.SelectedIndex]);

            m_olvPrincipal.UpdateObject(colTireur[lsbTireurs.SelectedIndex]);

            AfficherTireurs();
        }

        /// <summary>
        /// Sauvegarde le nom de l'équipe après modification
        /// </summary>
        private void txtNom_Leave(object sender, EventArgs e)
        {
            m_colEquipe.EquipeAt(cboEquipeAfficher.SelectedItem.ToString()).Nom = txtNom.Text;
            AfficherEquipes();
        }

        /// <summary>
        /// Actualise la liste après la fermeture de la fenêtre
        /// </summary>
        private void FrmEquipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_olvPrincipal.BuildList(true);
        }

        /// <summary>
        /// Se produit lorsque doubleclick sur un joueur dans une équipe
        /// </summary>
        private void olvTireur_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (olvTireur.SelectedObject == null)
                return;
            if (cboEquipeAfficher.SelectedIndex == -1)
                return;

            ((Tireur)olvTireur.SelectedObject).IdEquipe = 0;
            m_olvPrincipal.UpdateObject((Tireur)olvTireur.SelectedObject);
            olvTireur.RemoveObject(olvTireur.SelectedObject);
            AfficherTireurs();

        }

        /// <summary>
        /// Bouton pour supprimer une équipe
        /// </summary>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Equipe equipeSel = m_colEquipe.EquipeAt(cboEquipeAfficher.SelectedItem.ToString());
            m_colEquipe.Remove(equipeSel);

            equipeSel.Delete(m_colTireur);

            cboEquipeAfficher.SelectedIndex = -1;
            AfficherEquipes();
            AfficherTireurs();
        }
    }
}
