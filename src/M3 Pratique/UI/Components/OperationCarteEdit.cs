using System;
using System.Windows.Forms;

namespace M3_Pratique
{
    /// <summary>
    /// Classe représentant une carte d'édition d'opération dans l'interface utilisateur.
    /// </summary>
    public partial class OperationCarteEdit : UserControl
    {

        private int position;
        public int Position { get => position; set => position = value; }

        /// <summary>
        /// Constructeur de la carte d'édition d'opération.
        /// </summary>
        /// <param name="pos"></param>
        public OperationCarteEdit(int pos)
        {
            InitializeComponent();

            Position = pos;
        }

        /// <summary>
        /// Récupère l'opération à partir des champs de la carte d'édition.
        /// </summary>
        /// <returns></returns>
        public Operation GetOperation()
        {
            // Récupération de l'opération
            Operation operation = new Operation(-1, textBoxNomOperation.Text, Position, (int)numericUpDownPositionMoteur.Value, (int)numericUpDownTempsAttente.Value, checkBoxCycleVerin.Checked, checkBoxQuittance.Checked, checkBoxSensHoraire.Checked, -1);
            return operation;
        }

        /// <summary>
        /// Met à jour les champs de la carte d'édition avec les données de l'opération fournie.
        /// </summary>
        /// <param name="operation"></param>
        public void SetOperation(Operation operation)
        {
            // Mise à jour des champs avec les données de l'opération
            textBoxNomOperation.Text = operation.Nom;
            numericUpDownPositionMoteur.Value = operation.PositionMoteur;
            numericUpDownTempsAttente.Value = operation.TempsAttente;
            checkBoxCycleVerin.Checked = operation.CycleVerin;
            checkBoxQuittance.Checked = operation.Quittance;
            checkBoxSensHoraire.Checked = operation.SensMoteur;
        }

        /// <summary>
        /// Événement déclenché lors du clic sur l'icône de suppression de la carte d'édition d'opération.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelIconCroix_Click(object sender, EventArgs e)
        {
            FormManager.RecetteCreationForm.OperationSupprimer(this);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur l'icône de montée de la carte d'édition d'opération.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelMonter_Click(object sender, EventArgs e)
        {
            FormManager.RecetteCreationForm.OperationMonter(this);
        }

        /// <summary>
        /// Événement déclenché lors du clic sur l'icône de descente de la carte d'édition d'opération.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDescendre_Click(object sender, EventArgs e)
        {
           FormManager.RecetteCreationForm.OperationDescendre(this);
        }
    }
}
