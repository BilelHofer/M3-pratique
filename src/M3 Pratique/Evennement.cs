using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Pratique
{
    /// <summary>
    /// Classe représentant une evennement.
    /// </summary>
    public class Evennement
    {
        private int _id;
        private string _message;
        private DateTime _date;
        private int _idLot;

        public int Id { get => _id; set => _id = value; }
        public string Message { get => _message; set => _message = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int IdLot { get => _idLot; set => _idLot = value; }

        // Constructeur de la calsse evennement.
        public Evennement(int id, string message, DateTime date, int idLot)
        {
            Id = id;
            Message = message;
            Date = date;
            IdLot = idLot;
        }
    }
}
