using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique
{
    public partial class LotCarte : UserControl
    {
        public LotCarte()
        {
            InitializeComponent();
        }

        public void SetData(string nom, string etat)
        {
            // Met à jour le nom du lot
            labelNom.Text = nom;
            // Met à jour l'état du lot
            labelEtat.Text = etat;
        }
    }
}
