using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Pratique
{
    /// <summary>
    /// Classe représentant une recette.
    /// </summary>
    public class Recette
    {
        private long _id;
        private string _nom;
        private DateTime _dateCreation;

        public long Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public DateTime DateCreation { get => _dateCreation; set => _dateCreation = value; }

        // Constructeur de la classe Recette
        public Recette(int id, string nom, DateTime dateCreation)
        {
            Id = id;
            Nom = nom;
            DateCreation = dateCreation;
        }
    }
}
