using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Pratique
{

    /// <summary>
    /// Classe représentant un état.
    /// </summary>
    public class Etat
    {
        private long _id;
        private string _libelle;

        public long Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }

        /// <summary>
        /// Constructeur par défaut de la classe Etat.
        /// </summary>
        /// <param name="id">Id de l'état</param>
        /// <param name="libelle">Libellé de l'état</param>
        public Etat(long id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
    }
}
