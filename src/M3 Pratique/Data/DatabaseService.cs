using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique.Data
{
    /// <summary>
    /// Service dédié aux opérations de base de données
    /// </summary>
    public class DatabaseService
    {
        #region Méthodes de récupération

        /// <summary>
        /// Récupère toutes les recettes de la base de données
        /// </summary>
        /// <returns>Liste des recettes</returns>
        public static List<Recette> GetRecettes()
        {
            List<Recette> recettes = new List<Recette>();

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
                                reader.GetDateTime("REC_DateHeureCreation")
                            );

                            recettes.Add(recette);
                        }
                    }
                }
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }

            return recettes;
        }

        /// <summary>
        /// Récupère tous les événements de la base de données
        /// </summary>
        /// <returns>Liste des événements</returns>
        public static List<Evenement> GetEvenements()
        {
            List<Evenement> evenements = new List<Evenement>();

            try
            {
                DatabaseManager.ConnectDB();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM evenement", DatabaseManager.GetConnexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Evenement evenement = new Evenement(
                                reader.GetInt64("id_evenement"),
                                reader.GetString("EVE_Message"),
                                reader.GetDateTime("EVE_DateHeure"),
                                reader.GetInt64("id_Lot")
                            );
                            evenements.Add(evenement);
                        }
                    }
                }
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }

            return evenements;
        }

        /// <summary>
        /// Récupère tous les lots de la base de données
        /// </summary>
        /// <param name="recettes">Liste des recettes pour la liaison</param>
        /// <returns>Liste des lots</returns>
        public static List<Lot> GetLots(List<Recette> recettes)
        {
            List<Lot> lots = new List<Lot>();

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
                                reader.GetDateTime("LOT_DateHeureCreation"),
                                reader.GetInt64("id_Etat"),
                                reader.GetInt64("id_recette"),
                                recettes.FirstOrDefault(r => r.Id == reader.GetInt64("id_recette"))
                            );

                            lots.Add(lot);
                        }
                    }
                }
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }

            return lots;
        }

        /// <summary>
        /// Récupère tous les états de la base de données
        /// </summary>
        /// <returns>Liste des états</returns>
        public static List<Etat> GetEtats()
        {
            List<Etat> etats = new List<Etat>();

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
                            etats.Add(etat);
                        }
                    }
                }
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }

            return etats;
        }

        /// <summary>
        /// Récupère toutes les opérations de la base de données
        /// </summary>
        /// <returns>Liste des opérations</returns>
        public static List<Operation> GetOperations()
        {
            List<Operation> operations = new List<Operation>();

            try
            {
                DatabaseManager.ConnectDB();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM operation", DatabaseManager.GetConnexion()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Operation operation = new Operation(
                                reader.GetInt64("id_operation"),
                                reader.GetString("OPE_NOM"),
                                reader.GetInt32("OPE_Numero"),
                                reader.GetInt32("OPE_PositionMoteur"),
                                reader.GetInt32("OPE_TempsAttente"),
                                reader.GetBoolean("OPE_CycleVerin"),
                                reader.GetBoolean("OPE_Quittance"),
                                reader.GetBoolean("OPE_SensMoteur"),
                                reader.GetInt64("Id_Recette")
                            );

                            operations.Add(operation);
                        }
                    }
                }
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }

            return operations;
        }

        #endregion

        #region Méthodes d'insertion

        /// <summary>
        /// Ajoute un lot à la base de données
        /// </summary>
        /// <param name="quantite">Quantité de pièces</param>
        /// <param name="idEtat">ID de l'état</param>
        /// <param name="idRecette">ID de la recette</param>
        /// <param name="recetteNom">Nom de la recette</param>
        /// <returns>Le lot créé ou null en cas d'erreur</returns>
        public static Lot AjouterLot(int quantite, long idEtat, long idRecette, string recetteNom)
        {
            DateTime date = DateTime.Now;
            string nom = $"{quantite}-{recetteNom}-{date:yy/MM/dd}";
            long id = -1;

            try
            {
                DatabaseManager.ConnectDB();

                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO lot (LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) " +
                    "VALUES (@nom, @quantite, @dateCreation, @idEtat, @idRecette)",
                    DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@quantite", quantite);
                    cmd.Parameters.AddWithValue("@dateCreation", date);
                    cmd.Parameters.AddWithValue("@idEtat", idEtat);
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);

                    cmd.ExecuteNonQuery();
                    id = cmd.LastInsertedId;
                }

                // Récupère la recette associée
                Recette recette = Global.Recettes.FirstOrDefault(r => r.Id == idRecette);
                Lot nouveauLot = new Lot(id, nom, quantite, date, idEtat, idRecette, recette);

                MessageBox.Show($"Lot {nom} créé avec succès", "Création de lot", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return nouveauLot;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Création lot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Création lot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }
        }

        /// <summary>
        /// Ajoute une recette avec ses opérations à la base de données
        /// </summary>
        /// <param name="recetteNom">Nom de la recette</param>
        /// <param name="listeOperation">Liste des opérations</param>
        /// <returns>La recette créée ou null en cas d'erreur</returns>
        public static Recette AjouterRecette(string recetteNom, List<Operation> listeOperation)
        {
            DateTime date = DateTime.Now;
            long idRecette = -1;

            try
            {
                DatabaseManager.ConnectDB();

                // Insertion de la recette
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO recette (REC_Nom, REC_DateHeureCreation) VALUES (@nom, @dateCreation)",
                    DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@nom", recetteNom);
                    cmd.Parameters.AddWithValue("@dateCreation", date);
                    cmd.ExecuteNonQuery();
                    idRecette = cmd.LastInsertedId;
                }

                Recette nouvelleRecette = new Recette(idRecette, recetteNom, date);

                // Insertion des opérations
                List<Operation> operationsAjoutees = new List<Operation>();
                foreach (Operation operation in listeOperation)
                {
                    long idOperation = AjouterOperation(operation, idRecette);
                    if (idOperation != -1)
                    {
                        Operation nouvelleOperation = new Operation(
                            idOperation,
                            operation.Nom,
                            operation.Numero,
                            operation.PositionMoteur,
                            operation.TempsAttente,
                            operation.CycleVerin,
                            operation.Quittance,
                            operation.SensMoteur,
                            idRecette
                        );
                        operationsAjoutees.Add(nouvelleOperation);
                    }
                }

                MessageBox.Show($"Recette {recetteNom} créée avec succès", "Création de recette", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return nouvelleRecette;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Création recette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Création recette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }
        }

        /// <summary>
        /// Ajoute une opération à la base de données
        /// </summary>
        /// <param name="operation">Opération à ajouter</param>
        /// <param name="idRecette">ID de la recette parent</param>
        /// <returns>ID de l'opération créée ou -1 en cas d'erreur</returns>
        public static long AjouterOperation(Operation operation, long idRecette)
        {
            bool mustClose = false;
            try
            {
                // Si la connexion n'est pas ouverte, on l'ouvre
                var conn = DatabaseManager.GetConnexion();
                if (conn.State != ConnectionState.Open)
                {
                    DatabaseManager.ConnectDB();
                    mustClose = true;
                }

                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO operation (OPE_Nom, OPE_Numero, OPE_PositionMoteur, " +
                    "OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur, Id_Recette) " +
                    "VALUES (@nom, @numero, @positionMoteur, @tempsAttente, " +
                    "@cycleVerin, @quittance, @sensMoteur, @idRecette)",
                    conn))
                {
                    cmd.Parameters.AddWithValue("@nom", operation.Nom);
                    cmd.Parameters.AddWithValue("@numero", operation.Numero);
                    cmd.Parameters.AddWithValue("@positionMoteur", operation.PositionMoteur);
                    cmd.Parameters.AddWithValue("@tempsAttente", operation.TempsAttente);
                    cmd.Parameters.AddWithValue("@cycleVerin", operation.CycleVerin);
                    cmd.Parameters.AddWithValue("@quittance", operation.Quittance);
                    cmd.Parameters.AddWithValue("@sensMoteur", operation.SensMoteur);
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);

                    cmd.ExecuteNonQuery();
                    return cmd.LastInsertedId;
                }
            }
            catch (MySqlException)
            {
                return -1;
            }
            finally
            {
                // Si on avait ouvert la connexion ici, on la ferme aussi
                if (mustClose)
                    DatabaseManager.CloseConnexion();
            }
        }


        #endregion

        #region Méthodes de mise à jour

        public static void ModifierRecette(long idRecette, string nom)
        {
            try
            {
                DatabaseManager.ConnectDB();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE recette SET REC_Nom = @nom WHERE id_recette = @idRecette", DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Recette modifiée avec succès", "Modification de recette", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la modification : " + ex.Message, "Modification de recette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Modification de recette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }
        }

        #endregion

        #region Méthodes de suppression

        /// <summary>
        /// Supprime une recette et toutes les opérations associées à cette recette de la base de données.
        /// </summary>
        /// <param name="idRecette">Id de la recette à supprimer</param>
        public static void SupprimerRecette(long idRecette)
        {
            try
            {
                DatabaseManager.ConnectDB();

                // Supprimer les opérations associées à la recette
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM operation WHERE Id_Recette = @idRecette", DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.ExecuteNonQuery();
                }

                // Supprimer la recette
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM recette WHERE id_recette = @idRecette", DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Recette supprimée avec succès", "Suppression de recette", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la suppression : " + ex.Message, "Suppression de recette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Suppression de recette", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }
        }

        public static void SupprimerOperationByRecette(long idRecette)
        {
            try
            {
                DatabaseManager.ConnectDB();
                // Supprimer les opérations associées à la recette
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM operation WHERE Id_Recette = @idRecette", DatabaseManager.GetConnexion()))
                {
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la suppression des opérations : " + ex.Message, "Suppression d'opérations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie : " + ex.Message, "Suppression d'opérations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                DatabaseManager.CloseConnexion();
            }
        }

        #endregion

            #region Méthodes utilitaires

            /// <summary>
            /// Charge toutes les données depuis la base de données
            /// </summary>
            /// <returns>True si le chargement a réussi</returns>
        public static bool ChargerToutesLesDonnees()
        {
            try
            {
                Global.Etats = GetEtats();
                Global.Recettes = GetRecettes();
                Global.Operations = GetOperations();
                Global.Lots = GetLots(Global.Recettes);
                Global.Evenements = GetEvenements();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion
    }
}
