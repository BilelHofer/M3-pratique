/*
 * Classe Global 
 * 
 */


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique
{
    static class Global
    {
        // Liste des recettes
        private static List<Recette> _recettes;

        // Liste des opération
        private static List<Operation> _operation;

        // Liste des lots
        private static List<Lot> _lots;

        // Liste des états
        private static List<Etat> _etats;

        // Liste des évenements
        private static List<Evennement> _evenements;

        public static List<Recette> Recettes { get => _recettes; set => _recettes = value; }
        public static List<Operation> Operation { get => _operation; set => _operation = value; }
        public static List<Lot> Lots { get => _lots; set => _lots = value; }
        public static List<Etat> Etats { get => _etats; set => _etats = value; }
        public static List<Evennement> Evenements { get => _evenements; set => _evenements = value; }

        /// <summary>
        /// Récupère les recette de la base de données
        /// </summary>
        public static void RecupererRecette()
        {
            // Si la liste n'est pas encore initialisé, l'initialise
            if (Recettes == null)
                Recettes = new List<Recette>();
            else
                Recettes.Clear();

            try
            {
                DatabaseManager.ConnectDB();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM recette", DatabaseManager.GetConnexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recette recette = new Recette(
                                reader.GetInt64("id_recette"),
                                reader.GetString("REC_Nom"),
                                reader.GetDateTime("REC_DateHeureCréation")
                            );

                            // Ajout de la recette à la liste
                            Recettes.Add(recette);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenu : " + ex.Message, "Récupération des recettes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Récupération des recettes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // On ferme la connexion
                DatabaseManager.CloseConnexion();
            }
        }

        /// <summary>
        /// Récupère les lots de la base de données
        /// </summary>
        public static void RecupererLots()
        {
            // Si la liste n'est pas encore initialisé, l'initialise
            if (Lots == null)
                Lots = new List<Lot>();
            else
                Lots.Clear();

            try
            {
                DatabaseManager.ConnectDB();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM lot", DatabaseManager.GetConnexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lot lot = new Lot(
                                reader.GetInt64("id_Lot"),
                                reader.GetString("LOT_Nom"),
                                reader.GetInt32("LOT_Quantite"),
                                reader.GetDateTime("LOT_DateHeureCréation"),
                                reader.GetInt64("id_Etat"),
                                reader.GetInt64("id_recette")
                            );

                            // Ajout de la recette à la liste
                            Lots.Add(lot);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenu : " + ex.Message, "Récupération des lots", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Récupération des lots", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // On ferme la connexion
                DatabaseManager.CloseConnexion();
            }
        }

        /// <summary>
        /// Récupère les Etat de la base de données
        /// </summary>
        public static void RecupererEtat()
        {
            // Si la liste n'est pas encore initialisé, l'initialise
            if (Etats == null)
                Etats = new List<Etat>();
            else
                Etats.Clear();
            try
            {
                DatabaseManager.ConnectDB();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM etat", DatabaseManager.GetConnexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Etat etat = new Etat(
                                reader.GetInt64("id_Etat"),
                                reader.GetString("ETA_Libelle")
                            );
                            // Ajout de la recette à la liste
                            Etats.Add(etat);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenu : " + ex.Message, "Récupération des états", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Récupération des états", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // On ferme la connexion
                DatabaseManager.CloseConnexion();
            }
        }

        /// <summary>
        /// Ajoute un lot à la base de données
        /// </summary>
        /// <param name="quantite">quantité de pièce</param>
        /// <param name="idEtat">l'id de l'état</param>
        /// <param name="idRecette">l'id de la recette</param>
        public static void AjouterLot(int quantite, long idEtat, long idRecette, string recetteNom)
        {
            // Si la liste n'est pas encore initialisé, l'initialise
            if (Lots == null)
                Lots = new List<Lot>();

            // Récupère la date
            DateTime date = DateTime.Now;

            // génération du nom "nombre de pièce" + "nom de la recette" + "date"
            string nom = quantite + "-" + recetteNom + "-" + date.ToString("yy/MM/dd");

            long id = -1;
            try
            {
                DatabaseManager.ConnectDB();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO lot (LOT_Nom, LOT_Quantite, LOT_DateHeureCréation, Id_Etat, Id_Recette) " +
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

                // ajout du lot à la liste des lots global
                Global.Lots.Add(new Lot(id, nom, (int)quantite, date, idEtat, idRecette));

                MessageBox.Show($"Lot {nom} créé avec succès", "Création de lot", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenu : " + ex.Message, "Création lot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Création lot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // Ferme la connexion
                DatabaseManager.CloseConnexion();
            }
         }
    }
}
