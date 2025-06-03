using M3_Pratique.Data;
using System.Collections.Generic;
using System.Linq;

namespace M3_Pratique
{
    /// <summary>
    /// Listes des données local de la db
    /// et délégation vers la base de données
    /// </summary>
    static class Global
    {
        #region Listes de données
        // Liste des recettes
        private static List<Recette> _recettes = new List<Recette>();

        // Liste des opérations
        private static List<Operation> _operations = new List<Operation>();

        // Liste des lots
        private static List<Lot> _lots = new List<Lot>();

        // Liste des états
        private static List<Etat> _etats = new List<Etat>();

        // Liste des événements
        private static List<Evenement> _evenements = new List<Evenement>();

        // Propriétés publiques
        public static List<Recette> Recettes { get => _recettes; set => _recettes = value; }
        public static List<Operation> Operations { get => _operations; set => _operations = value; }
        public static List<Lot> Lots { get => _lots; set => _lots = value; }
        public static List<Etat> Etats { get => _etats; set => _etats = value; }
        public static List<Evenement> Evenements { get => _evenements; set => _evenements = value; }
        #endregion

        #region Méthodes de récupération

        /// <summary>
        /// Récupère les opérations de la base de données
        /// </summary>
        public static void RecupererOperation()
        {
            Operations = DatabaseService.GetOperations();
        }

        /// <summary>
        /// Récupère les données de la base de données 
        /// </summary>
        /// <returns>True si le chargement a réussi</returns>
        public static bool RecupererTout()
        {
            return DatabaseService.ChargerToutesLesDonnees();
        }

        #endregion

        #region Méthodes d'ajout

        /// <summary>
        /// Ajoute un lot à la base de données
        /// </summary>
        /// <param name="quantite">Quantité de pièces</param>
        /// <param name="idEtat">ID de l'état</param>
        /// <param name="idRecette">ID de la recette</param>
        /// <param name="recetteNom">Nom de la recette</param>
        public static void AjouterLot(int quantite, long idEtat, long idRecette, string recetteNom)
        {
            Lot nouveauLot = DatabaseService.AjouterLot(quantite, idEtat, idRecette, recetteNom);
            if (nouveauLot != null)
            {
                Lots.Add(nouveauLot);
            }
        }

        /// <summary>
        /// Ajoute une recette à la base de données
        /// </summary>
        /// <param name="recetteNom">Nom de la recette</param>
        /// <param name="listeOperation">Liste des opérations</param>
        public static void AjouterRecette(string recetteNom, List<Operation> listeOperation)
        {
            Recette nouvelleRecette = DatabaseService.AjouterRecette(recetteNom, listeOperation);
            if (nouvelleRecette != null)
            {
                Recettes.Add(nouvelleRecette);

                // Recharger les opérations pour avoir les IDs corrects
                RecupererOperation();
            }
        }

        #endregion

        #region Méthodes de suppression

        public static void SupprimerRecette(long idRecette)
        {
            // Supprime la recette de la base de données
            DatabaseService.SupprimerRecette(idRecette);
            // Supprime la recette de la liste en mémoire
            Recettes.RemoveAll(r => r.Id == idRecette);
        }

        #endregion

        #region Méthodes utilitaires

        /// <summary>
        /// Obtient les opérations d'une recette spécifique
        /// </summary>
        /// <param name="idRecette">ID de la recette</param>
        /// <returns>Liste des opérations de la recette</returns>
        public static List<Operation> GetOperationsByRecette(long idRecette)
        {
            return Operations.Where(o => o.IdRecette == idRecette).OrderBy(o => o.Numero).ToList();
        }

        /// <summary>
        /// Obtient les événements d'un lot spécifique
        /// </summary>
        /// <param name="idLot">ID du lot</param>
        /// <returns>Liste des événements du lot</returns>
        public static List<Evenement> GetEvenementsByLot(long idLot)
        {
            return Evenements.Where(e => e.IdLot == idLot).OrderByDescending(e => e.Date).ToList();
        }

        #endregion
    }
}