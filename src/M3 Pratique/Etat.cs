using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Pratique
{

    // Classe représentatnt un état
    public class Etat
    {
        private int _id;
        private string _libelle;

        public int Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }

        // Constructeur d'un état
        public Etat(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
    }
}
