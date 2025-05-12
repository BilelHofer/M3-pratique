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
        private static List<Evenement> _evenements;

        public static List<Recette> Recettes { get => _recettes; set => _recettes = value; }
        public static List<Operation> Operation { get => _operation; set => _operation = value; }
        public static List<Lot> Lots { get => _lots; set => _lots = value; }
        public static List<Etat> Etats { get => _etats; set => _etats = value; }
        public static List<Evenement> Evenements { get => _evenements; set => _evenements = value; }

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
        /// Récupère les évenements de la base de données
        /// </summary>
        public static void recupererEvenement()
        {
            // Si la liste n'est pas encore initialisé, l'initialise
            if (Evenements == null)
                Evenements = new List<Evenement>();
            else
                Evenements.Clear();
            try
            {
                DatabaseManager.ConnectDB();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM evénement", DatabaseManager.GetConnexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Evenement evennement = new Evenement(
                                reader.GetInt64("id_evénement"),
                                reader.GetString("EVE_Message"),
                                reader.GetDateTime("EVE_DateHeure"),
                                reader.GetInt64("id_Lot")
                            );
                            // Ajout de la recette à la liste
                            Evenements.Add(evennement);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenu : " + ex.Message, "Récupération des évennements", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Récupération des évennements", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        /// <param name="recetteNom">le nom de la recette</param>
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
        /// <summary>
        /// Ajoute une recette à la base de données
        /// </summary>
        /// <param name="recetteNom"> le nom de la recette </param>
        /// <param name="listeOperation"> la liste des opérations </param>
        /// <param name=""></param>
        public static void AjouterRecette(string recetteNom, List<Operation>listeOperation)
        {
            // Si la liste n'est pas encore initialisé, l'initialise
            if (Recettes == null)
                Recettes = new List<Recette>();

            // Récupère la date
            DateTime date = DateTime.Now;
            long id = -1;
            try
            {
                DatabaseManager.ConnectDB();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO recette (REC_Nom, REC_DateHeureCréation) " +
                    "VALUES (@nom, @dateCreation)", DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@nom", recetteNom);
                    cmd.Parameters.AddWithValue("@dateCreation", date);
                    cmd.ExecuteNonQuery();
                    id = cmd.LastInsertedId;
                }
                // ajout de la recette à la liste des recettes global
                Global.Recettes.Add(new Recette(id, recetteNom, date));

                // Pour chaque opération, on l'ajoute à la base de données
                foreach (Operation operation in listeOperation)
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO opération (OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) " +
                        "VALUES (@nom, @numero, @positionMoteur, @tempsAttente, @cycleVerin, @quittance, @sensMoteur1, @idRecette)", DatabaseManager.GetConnexion()))
                    {
                        cmd.Parameters.AddWithValue("@nom", operation.Nom);
                        cmd.Parameters.AddWithValue("@numero", operation.Numero);
                        cmd.Parameters.AddWithValue("@positionMoteur", operation.PositionMoteur);
                        cmd.Parameters.AddWithValue("@tempsAttente", operation.TempsAttente);
                        cmd.Parameters.AddWithValue("@cycleVerin", operation.CycleVerin);
                        cmd.Parameters.AddWithValue("@quittance", operation.Quittance);
                        cmd.Parameters.AddWithValue("@sensMoteur1", operation.SensMoteur1);
                        cmd.Parameters.AddWithValue("@idRecette", id);
                        cmd.ExecuteNonQuery();
                    }
                }


                MessageBox.Show($"Recette {recetteNom} créé avec succès", "Création de recette", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenu : " + ex.Message, "Création recette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Création recette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // Ferme la connexion
                DatabaseManager.CloseConnexion();
            }
        }
    }
}
