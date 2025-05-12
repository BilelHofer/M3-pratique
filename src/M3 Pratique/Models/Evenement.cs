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
    public class Evenement
    {
        private long _id;
        private string _message;
        private DateTime _date;
        private long _idLot;

        public long Id { get => _id; set => _id = value; }
        public string Message { get => _message; set => _message = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public long IdLot { get => _idLot; set => _idLot = value; }

        // Constructeur de la calsse evennement.
        public Evenement(long id, string message, DateTime date, long idLot)
        {
            Id = id;
            Message = message;
            Date = date;
            IdLot = idLot;
        }
    }
}
