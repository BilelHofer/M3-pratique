using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique.UI.Components
{
    public partial class OperationCarte : UserControl
    {
        public OperationCarte(Operation operation)
        {
            InitializeComponent();

            // Ajout des champs
            labelNumero.Text = operation.Numero.ToString();
            labelNom.Text = operation.Nom;
            labelPositionMoteur.Text = operation.PositionMoteur.ToString();
            labelTempsAttente.Text  = operation.TempsAttente.ToString();
            checkBoxCycleVerin.Checked = operation.CycleVerin;
            checkBoxQuittance.Checked = operation.Quittance;
            checkBoxSensMoteur.Checked = operation.SensMoteur;
        }
    }
}
