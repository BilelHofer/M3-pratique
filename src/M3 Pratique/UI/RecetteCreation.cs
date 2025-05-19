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

namespace M3_Pratique
{
    public partial class RecetteCreation : Form
    {
        public event EventHandler RecetteAjoute;

        List<OperationCarteEdit> operationCartes = new List<OperationCarteEdit>();
        public RecetteCreation()
        {
            InitializeComponent();

            flowLayoutPanelOperation.Controls.Clear();

        }

        private void RecetteCreation_Load(object sender, EventArgs e)
        {

        }

        private void labelTextRecette_Click(object sender, EventArgs e)
        {

        }
        // Création d'une recette
        private void btnEnregistrerRecette_Click(object sender, EventArgs e)
        {
            // Vérification des champs (Regex pour enlever les espaces)
            if (Regex.Replace(textBoxNomRecette.Text, @"\s+", "") == "")
            {
                MessageBox.Show("Veuillez entrer un nom de recette", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flowLayoutPanelOperation.Controls.Count <= 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une opération", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Création de la liste des opérations
                List<Operation> listeOperations = new List<Operation>();

                // Récupération des opérations
                listeOperations = operationCartes.Select(carte => carte.GetOperation()).ToList();

                Global.AjouterRecette(textBoxNomRecette.Text, listeOperations);

                // Ajout de l'évènement
                RecetteAjoute?.Invoke(this, EventArgs.Empty);

                // Ferme la fenêtre
                this.Close();
            }
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
            var carte = new OperationCarteEdit();
            if (flowLayoutPanelOperation.Controls.Count > 0)
            {
                flowLayoutPanelOperation.Controls.Remove(flowLayoutPanelOperation.Controls[flowLayoutPanelOperation.Controls.Count - 1]);
                operationCartes.RemoveAt(operationCartes.Count - 1);
            }
            
        }

        private void btnAjoutOperation_Click(object sender, EventArgs e)
        {
            var carte = new OperationCarteEdit();
            if(flowLayoutPanelOperation.Controls.Count < 10)
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
    }
}
