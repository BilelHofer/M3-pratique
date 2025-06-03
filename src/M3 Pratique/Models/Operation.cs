using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Pratique
{

    /// <summary>
    /// Classe représentant une opération.
    /// </summary>
    public class Operation
    {
        private long _id =-1;
        private string _nom;
        private int _numero;
        private int _positionMoteur;
        private int _tempsAttente;
        private bool _cycleVerin;
        private bool _quittance;
        private bool _sensMoteur;
        private long _idRecette;

        public long Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public int PositionMoteur { get => _positionMoteur; set => _positionMoteur = value; }
        public int TempsAttente { get => _tempsAttente; set => _tempsAttente = value; }
        public bool CycleVerin { get => _cycleVerin; set => _cycleVerin = value; }
        public bool Quittance { get => _quittance; set => _quittance = value; }
        public bool SensMoteur { get => _sensMoteur; set => _sensMoteur = value; }
        public long IdRecette { get => _idRecette; set => _idRecette = value; }


        /// <summary>
        /// Constructeur par défaut de la classe Operation.
        /// </summary>
        /// <param name="id">Id de l'opération</param>
        /// <param name="nom">Nom de l'opération</param>
        /// <param name="numero">Numéro de l'opération</param>
        /// <param name="positionMoteur">Position du moteur</param>
        /// <param name="tempsAttente">Temps d'attente</param>
        /// <param name="cycleVerin">Cycle vérin</param>
        /// <param name="quittance">Quittance</param>
        /// <param name="sensMoteur">Sens du moteur</param>
        /// <param name="idRecette">id de la recette liée</param>
        public Operation(long id, string nom, int numero, int positionMoteur, int tempsAttente, bool cycleVerin, bool quittance, bool sensMoteur, long idRecette)
        {
            Id = id;
            Nom = nom;
            Numero = numero;
            PositionMoteur = positionMoteur;
            TempsAttente = tempsAttente;
            CycleVerin = cycleVerin;
            Quittance = quittance;
            SensMoteur = sensMoteur;
            IdRecette = idRecette;
        }
    }
}
