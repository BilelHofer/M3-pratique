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
        private long _id;
        private string _nom;
        private int _quantite;
        private DateTime _date;
        private long _idEtat;
        private long _idRecette;
        private Recette _recette;

        public long Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public long IdEtat { get => _idEtat; set => _idEtat = value; }
        public long IdRecette { get => _idRecette; set => _idRecette = value; }
        public Recette Recette { get => _recette; set => _recette = value; }

        /// <summary>
        /// Constructeur par défaut de la classe Lot.
        /// </summary>
        /// <param name="id">Id du lot</param>
        /// <param name="nom">Nom du lot</param>
        /// <param name="quantite">Quantité du lot</param>
        /// <param name="date">Date du lot</param>
        /// <param name="idEtat">Id de l'état</param>
        /// <param name="idRecette">Id de la recette</param>
        /// <param name="recette">Recette complete</param>
        public Lot(long id, string nom, int quantite, DateTime date, long idEtat, long idRecette, Recette recette)
        {
            Id = id;
            Nom = nom;
            Quantite = quantite;
            Date = date;
            IdEtat = idEtat;
            IdRecette = idRecette;
            Recette = recette;
        }
    }
}
