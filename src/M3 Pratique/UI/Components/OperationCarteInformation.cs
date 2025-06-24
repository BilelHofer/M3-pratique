using System.Windows.Forms;

namespace M3_Pratique.UI.Components
{
    /// <summary>
    /// Classe représentant une opération dans l'interface utilisateur.
    /// </summary>
    public partial class OperationCarteInformation : UserControl
    {
        /// <summary>
        /// Constructeur de la carte d'opération.
        /// </summary>
        /// <param name="operation">Opération afficher</param>
        public OperationCarteInformation(Operation operation)
        {
            InitializeComponent();

            // Ajout des champs
            labelNumero.Text = operation.Numero.ToString();
            labelNom.Text = operation.Nom;
            labelPositionMoteur.Text = operation.PositionMoteur.ToString();
            labelTempsAttente.Text = operation.TempsAttente.ToString();
            checkBoxCycleVerin.Checked = operation.CycleVerin;
            checkBoxQuittance.Checked = operation.Quittance;
            checkBoxSensMoteur.Checked = operation.SensMoteur;
        }
    }
}
