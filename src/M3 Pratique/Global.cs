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
        private static List<Recette> _recettes = new List<Recette>();

        // Liste des opération
        private static List<Operation> _operation = new List<Operation>();

        // Liste des lots
        private static List<Lot> _lots = new List<Lot>();

        // Liste des états
        private static List<Etat> _etats = new List<Etat>();

        // Liste des évenements
        private static List<Evenement> _evenements = new List<Evenement>();

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
            finally
            {
                // On ferme la connexion
                DatabaseManager.CloseConnexion();
            }
        }

        /// <summary>
        /// Récupère les données de la base de données 
        /// </summary>
        public static void RecupererTout()
        {
            // Récupère les données depuis la base de données
            try
            {
                RecupererEtat();
                RecupererLots();
                RecupererRecette();
                recupererEvenement();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public static void AjouterRecette(string recetteNom, List<Operation> listeOperation)
        {
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

                        // Ajout de l'opération à la liste des opérations global
                        Global.Operation.Add(new Operation(cmd.LastInsertedId, operation.Nom, operation.Numero, operation.PositionMoteur, operation.TempsAttente, operation.CycleVerin, operation.Quittance, operation.SensMoteur1, id));
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
        /// <summary>
        /// Ajoute une opération à la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="numero"></param>
        /// <param name="positionMoteur"></param>
        /// <param name="tempsAttente"></param>
        /// <param name="cycleVerin"></param>
        /// <param name="quittance"></param>
        /// <param name="sensMoteur1"></param>
        /// <param name="idRecette"></param>
        public static void AjouterOperation(string nom, int numero, int positionMoteur, int tempsAttente, bool cycleVerin, bool quittance, bool sensMoteur1, long idRecette)
        {
            long id = -1;
            try
            {
                DatabaseManager.ConnectDB();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO opération (OPE_Nom, OPE_Numero, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) " +
                    "VALUES (@nom, @numero, @positionMoteur, @tempsAttente, @cycleVerin, @quittance, @sensMoteur1, @idRecette)", DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@positionMoteur", positionMoteur);
                    cmd.Parameters.AddWithValue("@tempsAttente", tempsAttente);
                    cmd.Parameters.AddWithValue("@cycleVerin", cycleVerin);
                    cmd.Parameters.AddWithValue("@quittance", quittance);
                    cmd.Parameters.AddWithValue("@sensMoteur1", sensMoteur1);
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.ExecuteNonQuery();
                    id = cmd.LastInsertedId;
                }
                // Ajout de la recette à la liste des recettes global
                Global.Operation.Add(new Operation(id, nom, numero, positionMoteur, tempsAttente, cycleVerin, quittance, sensMoteur1, idRecette));
                MessageBox.Show($"Opération {nom} créé avec succès", "Création d'opération", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenu : " + ex.Message, "Création d'opération", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Création d'opération", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // Ferme la connexion
                DatabaseManager.CloseConnexion();
            }
        }
    }
}
