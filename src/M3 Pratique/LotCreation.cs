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

namespace M3_Pratique
{
    public partial class LotCreation : Form
    {

        private RecetteCreation recetteCreationForm = null;
        public LotCreation()
        {
            InitializeComponent();
        }

        // Création d'un lot
        private void btnCreer_Click(object sender, EventArgs e)
        {
            // TODO récupérer le bon état depuis la db
            int idEtat = 1;

            int recetteSelected = (int)selectRecette.SelectedValue;

            // TODO vérifier les données récupérer

            //AjouterLot((long)inputNbPiece.Value, idEtat, );

            // Ferme la fenêtre
            this.Close();
        }

        /// <summary>
        /// Ajoute un lot à la base de données
        /// </summary>
        /// <param name="quantite">quantité de pièce</param>
        /// <param name="idEtat">l'id de l'état</param>
        /// <param name="idRecette">l'id de la recette</param>
        /// <returns></returns>
        private long AjouterLot(long quantite, long idEtat, long idRecette)
        {
            DateTime date = DateTime.Now;
            // génération du nom "nombre de pièce" + "nom de la recette" + "date"
            string nom = quantite + " " + Global.Recettes[idRecette].Nom + " " + date.ToString("yy/MM/dd");

            long id = -1;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO client (LOT_Nom, LOT_Quantite, LOT_DateHeureCréation, Id_Etat, Id_Recette) " +
                    "VALUES (@nom, @quantite, @dateCreation, @idEtat, @idRecette)", DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@quantite", quantite);
                    cmd.Parameters.AddWithValue("@dateCreation", date);
                    cmd.Parameters.AddWithValue("@idEtat", idEtat);
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);

                    cmd.ExecuteNonQuery();
                    id = cmd.LastInsertedId;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Ferme la connexion
                DatabaseManager.CloseConnexion();
            }

            // TODO ajouter le lot à la liste des lots global

            return id;
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

        private void LotCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
