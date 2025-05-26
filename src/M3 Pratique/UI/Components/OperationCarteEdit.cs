using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique
{
    public partial class OperationCarteEdit : UserControl
    {

        private int position;
        public int Position { get => position; set => position = value; }

        public OperationCarteEdit(int pos)
        {
            InitializeComponent();

            Position = pos;
        }

        private void numericUpDownTempsAttente_ValueChanged(object sender, EventArgs e)
        {

        }

        public Operation GetOperation()
        {
            // Récupération de l'opération
            Operation operation = new Operation(-1, textBoxNomOperation.Text, Position, (int)numericUpDownPositionMoteur.Value, (int)numericUpDownTempsAttente.Value, checkBoxCycleVerin.Checked, checkBoxQuittance.Checked, checkBoxSensHoraire.Checked, -1);
            return operation;
        }

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

        private void labelIconCroix_Click(object sender, EventArgs e)
        {
            FormManager.RecetteCreationForm.OperationSupprimer(this);
        }

        private void labelMonter_Click(object sender, EventArgs e)
        {
            FormManager.RecetteCreationForm.OperationMonter(this);
        }

        private void labelDescendre_Click(object sender, EventArgs e)
        {
           FormManager.RecetteCreationForm.OperationDescendre(this);
        }
    }
}
