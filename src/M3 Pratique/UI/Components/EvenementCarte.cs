using System.Windows.Forms;

namespace M3_Pratique
{
    /// <summary>
    /// Classe représentant une carte d'événement dans l'interface utilisateur.
    /// </summary>
    public partial class EvenementCarte : UserControl
    {
        /// <summary>
        /// Constructeur de la carte d'événement.
        /// </summary>
        /// <param name="evenement">Événement afficher</param>
        public EvenementCarte(Evenement evenement)
        {
            InitializeComponent();

            // Met à jour les label de la carte
            labelMessage.Text = evenement.Message;
            labelDate.Text = evenement.Date.ToString("dd/MM/yyyy hh:m");
        }
    }
}
