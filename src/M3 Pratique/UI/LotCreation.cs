using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace M3_Pratique
{
    public partial class LotCreation : Form
    {
        public event EventHandler LotAjoute;

        private RecetteCreation recetteCreationForm = null;
        public LotCreation()
        {
            InitializeComponent();

            // Ajout des recettes à la selection
            BindingList<Recette> recettes = new BindingList<Recette>();
            for (int i = 0; i < Global.Recettes.Count; i++)
            {
                recettes.Add(new Recette(Global.Recettes[i].Id, Global.Recettes[i].Nom, Global.Recettes[i].DateCreation));
            }
            comboBoxRecette.ValueMember = null;
            comboBoxRecette.DisplayMember = "Nom";
            comboBoxRecette.DataSource = recettes;
        }

        // Création d'un lot
        private void btnCreer_Click(object sender, EventArgs e)
        {
            // Vérification des champs
            if (numericUpDownNbPiece.Value <= 0)
            {
                MessageBox.Show("Le nombre de pièce doit être supérieur à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (comboBoxRecette.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une recette", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                // TODO récupérer le bon id état depuis la db
                int idEtat = 1;

                Global.AjouterLot((int)numericUpDownNbPiece.Value, idEtat, ((Recette)comboBoxRecette.SelectedItem).Id, ((Recette)comboBoxRecette.SelectedItem).Nom);

                // Ajout de l'évènement
                LotAjoute?.Invoke(this, EventArgs.Empty);

                // Ferme la fenêtre
                this.Close();
            }
        }

        // Bouton annuler 
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre
            this.Close();
        }

        private void btnCreerRecette_Click(object sender, EventArgs e)
        {
            // Vérifie si la fenêtre de création de recette est déjà ouverte
            if (recetteCreationForm == null || recetteCreationForm.IsDisposed)
            {
                recetteCreationForm = new RecetteCreation();
                recetteCreationForm.RecetteAjoute += (s, args) =>
                {
                    // Met à jour la liste des recettes après la création d'une nouvelle recette
                    BindingList<Recette> recettes = new BindingList<Recette>();
                    for (int i = 0; i < Global.Recettes.Count; i++)
                    {
                        recettes.Add(new Recette(Global.Recettes[i].Id, Global.Recettes[i].Nom, Global.Recettes[i].DateCreation));
                    }
                    comboBoxRecette.DataSource = recettes;
                };

                recetteCreationForm.Show();
            }
            else
            {
                recetteCreationForm.BringToFront();
            }
        }

        private void LotCreation_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxRecette_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
