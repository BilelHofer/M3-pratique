/*
 * Classe Global 
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
