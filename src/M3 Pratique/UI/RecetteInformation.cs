using M3_Pratique.UI.Components;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique
{
    public partial class RecetteInformation : Form
    {
        private Recette _recette;

        public RecetteInformation(Recette recette)
        {
            InitializeComponent();

            _recette = recette;

            MiseAJourInformation(recette);
        }

        private void AfficherOperation(IEnumerable<Operation> operations)
        {
            flowLayoutPanelOperations.Controls.Clear();

            var operationsTries = operations.OrderBy(operation => operation.Numero);

            foreach (var operation in operationsTries)
            {
                var carte = new OperationCarte(operation);
                flowLayoutPanelOperations.Controls.Add(carte);
            }
        }

        public void MiseAJourInformation(Recette recette)
        {
            _recette = recette;
            labelNomRecette.Text = recette.Nom;
            labelDate.Text = recette.DateCreation.ToString();

            // Récupère tous les opération qui ont l'id de la recette
            var operations = Global.GetOperationsByRecette(recette.Id);

            // Affiche les opérations dans le FlowLayoutPanel
            AfficherOperation(operations);
        }
    }
}
