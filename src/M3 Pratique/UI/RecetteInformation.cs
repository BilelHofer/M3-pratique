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

        /// <summary>
        /// Affiche les opérations associées à une recette dans le FlowLayoutPanel.
        /// </summary>
        /// <param name="operations">Opération à afficher</param>
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

        /// <summary>
        /// Met à jour les informations de la recette affichée dans la fenêtre.
        /// </summary>
        /// <param name="recette">Recette à afficher</param>
        public void MiseAJourInformation(Recette recette)
        {
            _recette = recette;
            labelNomRecette.Text = recette.Nom;
            labelDate.Text = recette.DateCreation.ToString();

            // Affiche les boutons modifier et supprimer si la recette n'est utilisée par aucun lot
            buttonModifierRecette.Visible = !Global.Lots.Any(lot => lot.IdRecette == recette.Id);
            buttonSupprimerRecette.Visible = !Global.Lots.Any(lot => lot.IdRecette == recette.Id);

            // Récupère tous les opération qui ont l'id de la recette
            var operations = Global.GetOperationsByRecette(recette.Id);

            // Affiche les opérations dans le FlowLayoutPanel
            AfficherOperation(operations);
        }

        /// <summary>
        /// Suppression d'une recette.
        /// </summary>
        private void buttonSupprimerRecette_Click(object sender, EventArgs e)
        {
            // Affiche une boîte de dialogue de confirmation
            var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette recette ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Supprime la recette
                Global.SupprimerRecette(_recette.Id);

                // Met à jour l'affichage des recettes
                FormManager.ManagerForm.AfficherRecettes(Global.Recettes);

                // Ferme la fenêtre
                this.Close();
            }
        }

        /// <summary>
        /// Ouvre le formulaire de création de recette et fournis la recette à modifier
        /// </summary>
        private void buttonModifierRecette_Click(object sender, EventArgs e)
        {
            FormManager.OuvrirRecetteCreation(_recette);
        }
    }
}

