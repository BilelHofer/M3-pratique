using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Pratique
{
    /// <summary>
    /// Classe représentant un lot.
    /// </summary>
    public class Lot
    {
        private int _id;
        private string _nom;
        private int _quantite;
        private DateTime _date;
        private int _idEtat;
        private int _idRecette;

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int IdEtat { get => _idEtat; set => _idEtat = value; }
        public int IdRecette { get => _idRecette; set => _idRecette = value; }

        // Constructure d'un lot
        public Lot(int id, string nom, int quantite, DateTime date, int idEtat, int idRecette)
        {
            Id = id;
            Nom = nom;
            Quantite = quantite;
            Date = date;
            IdEtat = idEtat;
            IdRecette = idRecette;
        }
    }
}
