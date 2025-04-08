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

        private RecetteCreation recetteCreationForm = null;
        public LotCreation()
        {
            InitializeComponent();

            // Récupération de la liste des recette
            Global.RecupererRecette();

            int nbRectte = Global.Recettes.Count;

            // Ajout des recettes à la selection
            BindingList<Recette> recettes = new BindingList<Recette>();
            for (int i = 0; i < Global.Recettes.Count; i++)
            {
                recettes.Add(new Recette(Global.Recettes[i].Id, Global.Recettes[i].Nom, Global.Recettes[i].DateCreation));
            }
            selectRecette.ValueMember = null;
            selectRecette.DisplayMember = "Nom";
            selectRecette.DataSource = recettes;
        }

        // Création d'un lot
        private void btnCreer_Click(object sender, EventArgs e)
        {
            // TODO récupérer le bon état depuis la db
            int idEtat = 1;


            // TODO vérifier les données récupérer

            Global.AjouterLot((int)inputNbPiece.Value, idEtat, ((Recette)selectRecette.SelectedItem).Id, ((Recette)selectRecette.SelectedItem).Nom);

            // Ferme la fenêtre
            this.Close();
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
                recetteCreationForm.Show();
            }
            else
            {
                recetteCreationForm.BringToFront();
            }
        }
    }
}
