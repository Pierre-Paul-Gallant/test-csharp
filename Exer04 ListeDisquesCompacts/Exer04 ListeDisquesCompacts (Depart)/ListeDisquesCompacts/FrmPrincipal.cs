using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Librairie1N6; //Contient la définition de DisqueCompact

namespace ListeDisquesCompacts
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        #region Champs et propriété du formulaire principal
        //================================================================
        private const int MAX_NB_DISQUES = 20;

        //================================================================
        private List<DisqueCompact> m_colDisques;

        //================================================================
        /// <summary>
        /// Obtient l'index du 1er élément sélectionné dans la liste View
        /// </summary>
        /// //------------------------------------------------------------
        private int IndexDisqueSélectionné
        {
            get
            {
                if (lsvMaCollection.SelectedIndices.Count > 0)
                {
                    return lsvMaCollection.SelectedIndices[0];
                }
                else
                {
                    return -1; //si rien de sélectionné
                }
            }
        }
        #endregion

        #region Constructeur du formulaire et menu quitter
        //===============================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            //=====================

            m_colDisques = new List<DisqueCompact>();
            RemplirMaCollection();
            AfficherMaCollection();
        }
        //===============================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region RemplirMaCollection (À COMPLÉTER)

        /// =======================================================================
        /// <summary>
        /// TODO 01 : Remplir la collection de disques de la sorte : Normal.
        /// </summary>
        /// ----------------------------------------------------------------------
        private void RemplirMaCollection()
        {
            // À COMPLÉTER...
        }
        #endregion

        #region AfficherMaCollection (À COMPLÉTER)
        /// ==========================================================================================================
        /// <summary>
        /// TODO 02 : Affiche ma collection de disques dans une ListView.
        /// </summary>
        /// ----------------------------------------------------------------------------------------------------------
        private void AfficherMaCollection()
        {
            // À COMPLÉTER...
        }
        #endregion

        #region SelectedIndexChanged (À COMPLÉTER)
        //====================================================================================
        /// <summary>
        /// TODO 03 : Affiche dans un message Box la durée de chacune des pistes du disque sélectionné.
        /// </summary>
        /// ----------------------------------------------------------------------------------
        private void lsvMaCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }
        #endregion
    }
}
