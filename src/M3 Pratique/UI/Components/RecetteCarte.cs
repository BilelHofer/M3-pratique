using System;
using System.Windows.Forms;

namespace M3_Pratique.UI.Components
{
    /// <summary>
    /// Classe représentant une carte de recette dans l'interface utilisateur.
    /// </summary>
    public partial class RecetteCarte : UserControl
    {
        private Recette _recette;

        /// <summary>
        /// Constructeur de la carte de recette.
        /// </summary>
        /// <param name="recette"></param>
        public RecetteCarte(Recette recette)
        {
            InitializeComponent();

            _recette = recette;
            labelNom.Text = recette.Nom;

            // Ajout des événements de clic sur chaque contrôle de la carte
            foreach (Control control in this.Controls)
            {
                control.Click += RecetteCarte_Click;
            }
        }

        /// <summary>
        /// Événement déclenché lors du clic sur la carte de la recette.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecetteCarte_Click(object sender, EventArgs e)
        {
            FormManager.OuvrirRecetteInformation(_recette);
        }
    }
}
