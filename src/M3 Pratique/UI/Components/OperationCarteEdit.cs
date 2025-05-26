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
        public OperationCarteEdit()
        {
            InitializeComponent();
        }

        private void numericUpDownTempsAttente_ValueChanged(object sender, EventArgs e)
        {

        }

        public Operation GetOperation()
        {
            // Récupération de l'opération
            Operation operation = new Operation(-1, textBoxNomOperation.Text, (int)numericUpDownNumeroOperation.Value, (int)numericUpDownPositionMoteur.Value, (int)numericUpDownTempsAttente.Value, checkBoxCycleVerin.Checked, checkBoxQuittance.Checked, checkBoxSensHoraire.Checked, -1);
            return operation;
        }

        public void SetOperation(Operation operation)
        {
            // Mise à jour des champs avec les données de l'opération
            textBoxNomOperation.Text = operation.Nom;
            numericUpDownNumeroOperation.Value = operation.Numero;
            numericUpDownPositionMoteur.Value = operation.PositionMoteur;
            numericUpDownTempsAttente.Value = operation.TempsAttente;
            checkBoxCycleVerin.Checked = operation.CycleVerin;
            checkBoxQuittance.Checked = operation.Quittance;
            checkBoxSensHoraire.Checked = operation.SensMoteur;
        }
    }
}
