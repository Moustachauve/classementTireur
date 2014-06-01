using System;
using System.Windows.Forms;

namespace classementTireur
{
    public partial class FrmAjouterCible : Form
    {
        Tireur m_tireur;
        enuTypeCible m_typeCible;

        BrightIdeasSoftware.ObjectListView m_olvTireur;
        FrmTireur m_frmTireur;

        #region Constructeurs

        /// <summary>
        /// Crée une nouvelle fenêtre pour ajouter une cible
        /// </summary>
        /// <param name="pTypeCible">Type de cible à ajouter</param>
        /// <param name="pTireur">Tireur de la cible</param>
        /// <param name="pOlvTireur">Collection de tireur</param>
        public FrmAjouterCible(enuTypeCible pTypeCible, Tireur pTireur, BrightIdeasSoftware.ObjectListView pOlvTireur)
        {
            InitializeComponent();
            dtpDateTir.MaxDate = System.DateTime.Now;
            dtpDateTir.Value = System.DateTime.Now.AddMilliseconds(-1);

            m_olvTireur = pOlvTireur;

            m_tireur = pTireur;
            m_typeCible = pTypeCible;

            numScore.Select();
            numScore.Select(0, numScore.Text.Length);

            if (m_typeCible == enuTypeCible.Precision)
            {
                this.Text = "Cible de précision";
                numScore.Maximum = 100;
                numScore.Minimum = 0;
            }
        }

        public FrmAjouterCible(enuTypeCible pTypeCible, Tireur pTireur, BrightIdeasSoftware.ObjectListView pOlvTireur, FrmTireur pFrmTireur)
        {
            InitializeComponent();

            dtpDateTir.MaxDate = System.DateTime.Now;
            dtpDateTir.Value = System.DateTime.Now.AddMilliseconds(-1);

            m_olvTireur = pOlvTireur;
            m_frmTireur = pFrmTireur;

            m_tireur = pTireur;
            m_typeCible = pTypeCible;

            numScore.Select();
            numScore.Select(0, numScore.Text.Length);

            if (m_typeCible == enuTypeCible.Precision)
            {
                this.Text = "Cible de précision";
                numScore.Maximum = 100;
                numScore.Minimum = 0;
            }
        }

        #endregion Constructeurs

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            switch (m_typeCible)
            {
                case enuTypeCible.Grouping:
                    ICible cible = new CibleGrouping(m_tireur.Id, (float)numScore.Value, dtpDateTir.Value);
                    m_tireur.ColCibleGrouping.Add(cible);
                    if (m_frmTireur != null)
                    {
                        m_frmTireur.ListeGrouping.AddObject(cible);
                        m_frmTireur.UpdateInfosGrouping();
                    }
                    break;
                case enuTypeCible.Precision:
                default:
                    cible = new CiblePrecision(m_tireur.Id, (float)numScore.Value, dtpDateTir.Value);
                    m_tireur.ColCiblePrecision.Add(cible);
                    if (m_frmTireur != null)
                    {
                        m_frmTireur.ListePrecision.AddObject(cible);
                        m_frmTireur.UpdateInfosPrecision();
                    }
                    break;
            }
            m_olvTireur.UpdateObject(m_tireur);

            this.Close();
        }
    }
}
