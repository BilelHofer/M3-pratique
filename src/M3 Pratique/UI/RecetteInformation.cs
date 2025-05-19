using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique
{
    public partial class RecetteInformation : Form
    {
        private Recette _recette;

        public RecetteInformation(Recette recette)
        {
            InitializeComponent();

            _recette = recette;

            MiseAJourInformation(recette);
        }

        public void MiseAJourInformation(Recette recette)
        {
            _recette = recette;
            labelNomRecette.Text = recette.Nom;
            labelDate.Text = recette.DateCreation.ToString();
        }
    }
}
