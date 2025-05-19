using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Pratique
{

    // Classe représentant une opération
    public class Operation
    {
        private long _id =-1;
        private string _nom;
        private int _numero;
        private int _positionMoteur;
        private int _TempsAttente;
        private bool _CycleVerin;
        private bool _quittance;
        private bool SensMoteur;
        private long _idRecette;

        public long Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public int PositionMoteur { get => _positionMoteur; set => _positionMoteur = value; }
        public int TempsAttente { get => _TempsAttente; set => _TempsAttente = value; }
        public bool CycleVerin { get => _CycleVerin; set => _CycleVerin = value; }
        public bool Quittance { get => _quittance; set => _quittance = value; }
        public bool SensMoteur1 { get => SensMoteur; set => SensMoteur = value; }
        public long IdRecette { get => _idRecette; set => _idRecette = value; }


        // Constructeur d'une opération
        public Operation(long id, string nom, int numero, int positionMoteur, int tempsAttente, bool cycleVerin, bool quittance, bool sensMoteur1, long idRecette)
        {
            Id = id;
            Nom = nom;
            Numero = numero;
            PositionMoteur = positionMoteur;
            TempsAttente = tempsAttente;
            CycleVerin = cycleVerin;
            Quittance = quittance;
            SensMoteur1 = sensMoteur1;
            IdRecette = idRecette;
        }
    }
}
