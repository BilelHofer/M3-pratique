using M3_Pratique.Data;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace M3_Pratique
{
    public partial class RecetteCreation : Form
    {
        public event EventHandler RecetteAjoute;

        private bool enModification = false;

        private Recette _recette = null;

        private int nombreOperation = 0;

        List<OperationCarteEdit> operationCartes = new List<OperationCarteEdit>();
        public RecetteCreation()
        {
            InitializeComponent();
            enModification = false;
            flowLayoutPanelOperation.Controls.Clear();

            btnCreerRecette.Visible = true;
            btnEnregistrerRecette.Visible = false;

        }

        public RecetteCreation(Recette recette)
        {
            InitializeComponent();
            flowLayoutPanelOperation.Controls.Clear();
            enModification = true;
            btnCreerRecette.Visible = false;
            btnEnregistrerRecette.Visible = true;
            _recette = recette;

            // Affiche les opérations de la recette
            foreach (var operation in Global.GetOperationsByRecette(recette.Id))
            {
                var carte = new OperationCarteEdit(operation.Numero);
                carte.SetOperation(operation);

                flowLayoutPanelOperation.Controls.Add(carte);
                operationCartes.Add(carte);
            }
            textBoxNomRecette.Text = recette.Nom;
        }

        private void RecetteCreation_Load(object sender, EventArgs e)
        {

        }

        private void labelTextRecette_Click(object sender, EventArgs e)
        {

        }
        // Création d'une recette
        private void btnCreerRecette_Click(object sender, EventArgs e)
        {
            if (validationChamp())
            {
                // Récupération des opérations
                List<Operation> listeOperations = operationCartes.Select(carte => carte.GetOperation()).ToList();

                Global.AjouterRecette(textBoxNomRecette.Text, listeOperations);

                // Ajout de l'évènement
                RecetteAjoute?.Invoke(this, EventArgs.Empty);

                // Ferme la fenêtre
                this.Close();
            }
        }

        private void buttonEnregistrerRecette_Click(object sender, EventArgs e)
        {
            if (validationChamp())
            {
                // Suppression des opérations existantes
                DatabaseService.SupprimerOperationByRecette(_recette.Id);

                // Suppression des opérations associé à la recette dans la liste global
                Global.Operations.RemoveAll(op => op.IdRecette == _recette.Id);

                // Création de la liste des opérations
                List<Operation> listeOperations = operationCartes.Select(carte => carte.GetOperation()).ToList();

                // Modication du nom de la recette
                DatabaseService.ModifierRecette(_recette.Id, textBoxNomRecette.Text);

                // Modifcation du nom de la recette dans la liste global
                Global.Recettes.Where(r => r.Id == _recette.Id).ToList().ForEach(r => r.Nom = textBoxNomRecette.Text);
                _recette.Nom = textBoxNomRecette.Text;

                // Ajout des opérations à la recette
                foreach (Operation operation in listeOperations)
                {
                    long idOperation = DatabaseService.AjouterOperation(operation, _recette.Id);
                    if (idOperation != -1)
                    {
                        Global.Operations.Add(new Operation(
                            idOperation,
                            operation.Nom,
                            operation.Numero,
                            operation.PositionMoteur,
                            operation.TempsAttente,
                            operation.CycleVerin,
                            operation.Quittance,
                            operation.SensMoteur,
                            _recette.Id));
                    }
                }

                // Mise à jours des formulaires
                // TODO FormManager.RecetteManagerForm.AfficherRecettes(Global.Recettes);
                FormManager.OuvrirRecetteInformation(_recette);

                this.Close();
            }
        }

        private bool validationChamp()
        {
            // Vérification des champs (Regex pour enlever les espaces)
            if (Regex.Replace(textBoxNomRecette.Text, @"\s+", "") == "")
            {
                MessageBox.Show("Veuillez entrer un nom de recette", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (flowLayoutPanelOperation.Controls.Count <= 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une opération", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void labelNomRecette_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomRecette_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelOperation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSupprimerOperation_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelOperation.Controls.Count > 0)
            {
                flowLayoutPanelOperation.Controls.Remove(flowLayoutPanelOperation.Controls[flowLayoutPanelOperation.Controls.Count - 1]);
                operationCartes.RemoveAt(operationCartes.Count - 1);
            }

            nombreOperation--;
        }

        private void btnAjoutOperation_Click(object sender, EventArgs e)
        {
            var carte = new OperationCarteEdit(nombreOperation);
            nombreOperation++;
            if (flowLayoutPanelOperation.Controls.Count < 10)
            {
                flowLayoutPanelOperation.Controls.Add(carte);
                operationCartes.Add(carte);
            }

        }

        private void labelOperation_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre
            this.Close();
        }

        /// <summary>
        /// Monte le contrôle d'une position dans le FlowLayoutPanel.
        /// </summary>
        /// <param name="control">Le contrôle à déplacer vers le haut.</param>
        public void OperationMonter(OperationCarteEdit control)
        {
            // Index courant dans la collection
            int index = flowLayoutPanelOperation.Controls.GetChildIndex(control);

            // Si on est déjà tout en haut, on ne fait rien
            if (index <= 0)
                return;

            // Change l'index position des position
            control.Position--;
            var other = flowLayoutPanelOperation.Controls[index - 1] as OperationCarteEdit;
            if (other != null)
            {
                // On incrémente sa Position
                other.Position++;
            }

            // Change l'index : déplace vers l'avant d'une position
            flowLayoutPanelOperation.Controls.SetChildIndex(control, index - 1);

            // force le redraw/layout
            flowLayoutPanelOperation.PerformLayout();
        }

        public void OperationDescendre(OperationCarteEdit control)
        {
            // Index courant dans la collection
            int index = flowLayoutPanelOperation.Controls.GetChildIndex(control);

            // Si on est déjà tout en bas, on ne fait rien
            if (index >= flowLayoutPanelOperation.Controls.Count - 1)
                return;

            // Change l'index position des position
            control.Position++;
            var other = flowLayoutPanelOperation.Controls[index + 1] as OperationCarteEdit;
            if (other != null)
            {
                // On décrémente sa Position
                other.Position--;
            }

            // Change l'index : déplace vers l'arrière d'une position
            flowLayoutPanelOperation.Controls.SetChildIndex(control, index + 1);

            // force le redraw/layout
            flowLayoutPanelOperation.PerformLayout();
        }

        public void OperationSupprimer(OperationCarteEdit control)
        {
            // Supprime le contrôle du FlowLayoutPanel
            flowLayoutPanelOperation.Controls.Remove(control);
            operationCartes.Remove(control);
            // Réajuste les positions des opérations restantes
            for (int i = 0; i < operationCartes.Count; i++)
            {
                operationCartes[i].Position = i;
            }
            // force le redraw/layout
            flowLayoutPanelOperation.PerformLayout();

            nombreOperation--;
        }
    }
}
