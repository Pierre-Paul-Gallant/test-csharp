using System;
using System.Windows.Forms;

namespace ManipulationDates
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFOS = "(Matériel)";
        public FrmPrincipal()
        {
            InitializeComponent();
            //-------------------------------
            Text += APP_INFOS;
            cboMoments.SelectedIndex = 0;
            CalculerDurees();
        }

        #region SelectedIndexChanged (À COMPLÉTER...)
        /// -------------------------------------------------------------------------------------------
        /// <summary>
        /// Dès que l'on sélectionne un choix dans la boîte combo,
        /// on modifie la date et on affiche la date en format yyyy-MM-dd et l'heure en format HH:mm:ss
        /// Valeur contenue dans la boîte combo:
        ///     0-Maintenant
        ///     1-Ajourd'hui, dans une heure
        ///     2-Hier, même heure
        ///     3-Demain, une heure de plus
        ///     4-Il y a 4 semaines (28 jours)
        ///     5-Dans 2 mois
        ///     6-Il y a 10 ans
        ///     7-Dans 20 ans, même jour, même heure
        /// </summary>
        /// --------------------------------------------------------------------------------------------
        private void cboMoments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cette variable contient la date actuelle, vous devez l'utiliser dans vos calculs
            DateTime dateAModifier = DateTime.Now;
            
            switch (cboMoments.SelectedIndex)
            {
                case 1: // TODO 01 : Aujourd'hui, dans une heure
                    dateAModifier.AddHours(1);
                    break;
                case 2: // TODO 02 : Hier, même heure
                    dateAModifier.AddDays(-1);

                    break;    
                case 3: // TODO 03 : Demain, une heure de plus
                    dateAModifier.AddHours(1);
                    dateAModifier.AddDays(1);
                    break;
                case 4: // TODO 04 : Il y a 4 semaines (-28 jours)
                    dateAModifier.AddDays(-28);
                    break; 
                case 5: // TODO 05 : Dans 2 mois
                    dateAModifier.AddMonths(2);
                    break;   
                case 6: // TODO 06 : Il y a 10 ans
                    dateAModifier.AddYears(10);
                    break;
                case 7: // TODO 07 : Dans 20 ans, même jour, même heure
                    dateAModifier.AddYears(20);
                    break;
            }
            // TODO 08 : Afficher la nouvelle date en respectant le format d'affichage de la démo
            txtDateFormattee.Text = dateAModifier.ToString();
        }
        #endregion

        #region CalculerDurees (À COMPLÉTER...)
        /// <summary>
        /// TODO 09 : Vous devez calculer et afficher l'intervalle de temps entre les deux dates (voir démo)
        /// </summary>
        private void CalculerDurees()
        {
            // À COMPLÉTER...


        }

        private void dtpDateFin_ValueChanged(object sender, EventArgs e)
        {
            CalculerDurees();
        }

        #endregion

    }
}