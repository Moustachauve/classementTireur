using System;
using System.IO;
using System.Windows.Forms;
using BrightIdeasSoftware;
using System.Data;

namespace classementTireur
{
    public partial class FrmPrincipal : Form
    {

        #region Variables membres et propriétés

        BaseDeDonnee m_baseDeDonnee;
        ListeEquipe m_colEquipe;

        FrmClassementEquipe m_classementEquipe;
        FrmClassementTireur m_classementIndividuel;

        #endregion Variables membres et propriétés
        
        #region Constructeur

        /// <summary>
        /// Crée le formulaire principal
        /// </summary>
        /// <param name="pCheminFichier">Base de donnée à charger</param>
        public FrmPrincipal(string pCheminFichier)
        {
            InitializeComponent();

            OlvApplyAllSettings();

            try
            {
                if (pCheminFichier != String.Empty)
                    m_baseDeDonnee = new BaseDeDonnee(pCheminFichier);
                else
                    m_baseDeDonnee = new BaseDeDonnee();

                ChargerListeEquipe();
                ChargerListeTireurs();
            }
            catch
            {
                MessageBox.Show("Le fichier n'est pas compatible avec la version courante du logiciel", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_baseDeDonnee.Creer();
            }


            MajMenu();
            MettreAJourInterface();
        }

        #endregion Constructeur

        #region olvTireur

        #region Settings

        /// <summary>
        /// Applique tous les réglages demandant un delegate à la liste
        /// </summary>
        private void OlvApplyAllSettings()
        {
            OlvFormatage();
            OlvGroupies();
        }

        /// <summary>
        /// Crée les delegates pour formatter les chiffres et les équipes dans la olv
        /// </summary>
        private void OlvFormatage()
        {
            //Pointage grouping
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
            //Pointage précision
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
            //Nom d'équipe
            this.colEquipe.AspectToStringConverter = delegate(object x)
            {
                Equipe equipeJoueur = m_colEquipe.EquipeAt((int)x);
                if(equipeJoueur != null)
                    return m_colEquipe.EquipeAt((int)x).Nom;

                return "Aucune";
            };
            //Date de naissance
            this.colDateDeNaissance.GroupKeyGetter = delegate(object x)
            {
                return ((Tireur)x).DateDeNaissance.Year;
            };
            this.colDateDeNaissance.GroupKeyToTitleConverter = delegate(object x)
            {
                return x.ToString();
            };
        }

        /// <summary>
        /// Crée les groupement pour les catégorie dans la olv
        /// </summary>
        private void OlvGroupies()
        {
            this.colGrouping.MakeGroupies(
                new float[] { 2, 4, 6 },
                new string[] { "1 - 2", "3 - 4", "5 - 6", "Sans résultats" }
            );

            this.colPrecision.MakeGroupies(
                new float[] { 0, 39, 69 },
                new string[] { "Sans résultats", "0% à 39%", "40% à 69%", "70% à 100%" }
            );
        }

        #endregion Settings

        #region Events du menu

        /// <summary>
        /// Menu pour ajouter un tireur
        /// </summary>
        private void mnuSupprimerTireur_Click(object sender, EventArgs e)
        {
            Tireur tireurSelectionne = (Tireur)olvTireur.SelectedObject;
            DialogResult confirmation = MessageBox.Show("Voulez-vous vraiment supprimer \"" + tireurSelectionne.Nom + "\"? \n Cet action est irréversible.", "Supprimer un tireur", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                tireurSelectionne.Delete();
                olvTireur.RemoveObject(tireurSelectionne);
            }
        }

        /// <summary>
        /// Fait apparaitre le menu contextuelle lors du clique droit sur un tireur
        /// </summary>
        private void olvTireur_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (olvTireur.SelectedObject != null)
                    {
                        cmnuItemListview.Show(Cursor.Position);
                    }
                }
            }
        }

        /// <summary>
        /// Menu pour ajouter un tireur dans la base de donnée
        /// </summary>
        private void ajouterUnTireurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAjouterTireur(olvTireur).ShowDialog();
        }

        /// <summary>
        /// Menu pour modifier un tireur
        /// </summary>
        private void mnuModifierTireur_Click(object sender, EventArgs e)
        {
            new FrmAjouterTireur(olvTireur, (Tireur)olvTireur.SelectedObject).ShowDialog();
        }

        /// <summary>
        /// Menu pour voir les détails d'un tireur
        /// </summary>
        private void mnuDetailsTireur_Click(object sender, EventArgs e)
        {
            new FrmTireur((Tireur)olvTireur.SelectedObject, olvTireur).Show();
        }

        /// <summary>
        /// Menu pour ajouter une cible de grouping à un tireur
        /// </summary>
        private void mnuAjouterCibleGrouping_Click(object sender, EventArgs e)
        {
            new FrmAjouterCible(enuTypeCible.Grouping, (Tireur)olvTireur.SelectedObject, olvTireur).ShowDialog();
        }

        /// <summary>
        /// Menu pour ajouter une cible de précision à un tireur
        /// </summary>
        private void mnuAjouterCiblePrecision_Click(object sender, EventArgs e)
        {
            new FrmAjouterCible(enuTypeCible.Precision, (Tireur)olvTireur.SelectedObject, olvTireur).ShowDialog();
        }

        #endregion Events du menu

        #region Events du olv

        /// <summary>
        /// Changement d'index sélectionner dans le Object list view
        /// </summary>
        private void olvTireur_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuTireurSelectionne.Enabled = olvTireur.SelectedObject != null;
        }

        #endregion Events du olv

        #endregion olvTireur

        #region Évènements divers

        #region Listview

        /// <summary>
        /// Se déclenche lorsque l'index sélectionné du Listview change
        /// </summary>
        private void lsvTireurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            MajMenu();
        }


        #endregion Listview

        #region Menus

        //Menu pour afficher le classement général
        private void mnuClassement_Click(object sender, EventArgs e)
        {
            //m_classement.Show();
        }

        #endregion Menus

        #endregion Évènements divers

        #region Méthodes

        #region Mise à jour du formulaire

        /// <summary>
        /// Met à jour la barre de menu
        /// </summary>
        private void MajMenu()
        {
            mnuTireurSelectionne.Enabled = olvTireur.SelectedObject != null;
        }

        #endregion Mise à jour du formulaire


        #endregion Méthodes

        #region Gestions des fichiers

        /// <summary>
        /// Menu pour ouvrir une base de donnée
        /// </summary>
        private void mnuOuvrir_Click(object sender, EventArgs e)
        {
            sfdSauvegarde.FileName = string.Empty;

            if (ofdOuverture.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_baseDeDonnee.Charger(ofdOuverture.FileName);
                    MettreAJourInterface();
                    ChargerListeEquipe();
                    ChargerListeTireurs();
                    
                }
                catch
                {
                    MessageBox.Show("Le fichier sélectionné n'est pas compatible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        /// <summary>
        /// Menu pour créer une base de donnée
        /// </summary>
        private void mnuNouveau_Click(object sender, EventArgs e)
        {
            sfdSauvegarde.FileName = "Sans Nom";

            if (sfdSauvegarde.ShowDialog() == DialogResult.OK)
            {
                m_baseDeDonnee.Creer(sfdSauvegarde.FileName);
                m_baseDeDonnee.Charger(sfdSauvegarde.FileName);
                MettreAJourInterface();
                ChargerListeTireurs();
            }
        }

        /// <summary>
        /// Menu pour enregistrer la base de donnée sous un autre nom
        /// </summary>
        private void mnuEnregistrer_Click(object sender, EventArgs e)
        {
            sfdSauvegarde.FileName = "Sans Nom";

            if (sfdSauvegarde.ShowDialog() == DialogResult.OK)
            {
                m_baseDeDonnee.Deplacer(sfdSauvegarde.FileName);
                MettreAJourInterface();
            }
        }

        #endregion Gestions des fichiers

        #region Mises à jour et chargement

        /// <summary>
        /// Met à jour des éléments de l'interface
        /// </summary>
        private void MettreAJourInterface()
        {
            string nomFichier = Path.GetFileNameWithoutExtension(m_baseDeDonnee.CheminFichierCourant);
            this.Text = nomFichier;
        }

        /// <summary>
        /// Charge la liste des tireurs et l'insère dans l'olv
        /// </summary>
        private void ChargerListeTireurs()
        {
            ListeTireur listeTireur = new ListeTireur();
            listeTireur.GetAllTireurs();

            olvTireur.SetObjects(listeTireur);
        }

        private void ChargerListeEquipe()
        {
            m_colEquipe = new ListeEquipe();
            m_colEquipe.ChargerEquipes();
        }

        #endregion Mises à jour et chargement


        /// <summary>
        /// Evenement pour fermer l'app
        /// </summary>
        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuEquipes_Click(object sender, EventArgs e)
        {
            ListeTireur colTireur = new ListeTireur();

            foreach (Tireur tireurCourant in olvTireur.Objects)
            {
                colTireur.Add(tireurCourant);
            }

            new FrmEquipe(olvTireur, colTireur, m_colEquipe).ShowDialog();
        }

        private void individuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_classementIndividuel == null)
            {
                m_classementIndividuel = new FrmClassementTireur(olvTireur);
                m_classementIndividuel.Show();
                m_classementIndividuel.FormClosed += m_classementIndividuel_FormClosed;
            }
        }

        void m_classementIndividuel_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_classementIndividuel = null;
        }

        private void mnuClassementEquipes_Click(object sender, EventArgs e)
        {
            if (m_classementEquipe == null)
            {
                m_classementEquipe = new FrmClassementEquipe(olvTireur, m_colEquipe);
                m_classementEquipe.Show();
                m_classementEquipe.FormClosed += m_classementEquipe_FormClosed;
            }
        }

        void m_classementEquipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_classementEquipe = null;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmParametre(olvTireur).ShowDialog();
        }

        private void olvTireur_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            if (m_classementIndividuel != null)
                m_classementIndividuel.OlvClassement.BuildList(true);
            if (m_classementEquipe != null)
                m_classementEquipe.OlvClassement.BuildList(true);
        }
    }
}
