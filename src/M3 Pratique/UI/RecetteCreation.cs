using M3_Pratique.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace M3_Pratique
{
    /// <summary>
    /// Classe représentant une fenêtre de création ou de modification d'une recette.
    /// </summary>
    public partial class RecetteCreation : Form
    {
        public event EventHandler RecetteAjoute;
        private Recette _recette = null;

        private int nombreOperation = 0;

        List<OperationCarteCreation> operationCartes = new List<OperationCarteCreation>();

        /// <summary>
        /// Constructeur de la fenêtre de création d'une recette.
        /// </summary>
        public RecetteCreation()
        {
            InitializeComponent();
            flowLayoutPanelOperation.Controls.Clear();

            btnCreerRecette.Visible = true;
            btnEnregistrerRecette.Visible = false;

        }

        /// <summary>
        /// Constructeur de la fenêtre de modification d'une recette
        /// </summary>
        /// <param name="recette">La recette a modifier</param>
        public RecetteCreation(Recette recette)
        {
            InitializeComponent();
            flowLayoutPanelOperation.Controls.Clear();
            btnCreerRecette.Visible = false;
            btnEnregistrerRecette.Visible = true;
            _recette = recette;

            // Affiche les opérations de la recette
            foreach (var operation in Global.GetOperationsByRecette(recette.Id))
            {
                var carte = new OperationCarteCreation(operation.Numero);
                carte.SetOperation(operation);

                flowLayoutPanelOperation.Controls.Add(carte);
                operationCartes.Add(carte);
            }
            textBoxNomRecette.Text = recette.Nom;
        }

        /// <summary>
        /// Créer une recette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Enregistre une recette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                FormManager.ManagerForm.AfficherRecettes(Global.Recettes);
                FormManager.OuvrirRecetteInformation(_recette);

                this.Close();
            }
        }

        /// <summary>
        /// Valide les champs de la recette
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Supprime la dernière opération
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerOperation_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelOperation.Controls.Count > 0)
            {
                flowLayoutPanelOperation.Controls.Remove(flowLayoutPanelOperation.Controls[flowLayoutPanelOperation.Controls.Count - 1]);
                operationCartes.RemoveAt(operationCartes.Count - 1);
            }

            nombreOperation--;
        }

        /// <summary>
        /// Ajoute une nouvelle opération
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutOperation_Click(object sender, EventArgs e)
        {
            var carte = new OperationCarteCreation(nombreOperation);
            nombreOperation++;
            if (flowLayoutPanelOperation.Controls.Count < 10)
            {
                flowLayoutPanelOperation.Controls.Add(carte);
                operationCartes.Add(carte);
            }

        }

        /// <summary>
        /// ferme la fenêtre sans enregistrer les modifications.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre
            this.Close();
        }

        /// <summary>
        /// Monte le contrôle d'une position dans le FlowLayoutPanel.
        /// </summary>
        /// <param name="control">Opération à déplacer vers le haut.</param>
        public void OperationMonter(OperationCarteCreation control)
        {
            // Index courant dans la collection
            int index = flowLayoutPanelOperation.Controls.GetChildIndex(control);

            // Si on est déjà tout en haut, on ne fait rien
            if (index <= 0)
                return;

            // Change l'index position des position
            control.Position--;
            var other = flowLayoutPanelOperation.Controls[index - 1] as OperationCarteCreation;
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

        /// <summary>
        /// Descent l'opération d'une position dans le FlowLayoutPanel.
        /// </summary>
        /// <param name="control">Opération à descendre</param>
        public void OperationDescendre(OperationCarteCreation control)
        {
            // Index courant dans la collection
            int index = flowLayoutPanelOperation.Controls.GetChildIndex(control);

            // Si on est déjà tout en bas, on ne fait rien
            if (index >= flowLayoutPanelOperation.Controls.Count - 1)
                return;

            // Change l'index position des position
            control.Position++;
            var other = flowLayoutPanelOperation.Controls[index + 1] as OperationCarteCreation;
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

        /// <summary>
        /// Supprime une opération précise de la recette.
        /// </summary>
        /// <param name="control">Opération à supprimer</param>
        public void OperationSupprimer(OperationCarteCreation control)
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
