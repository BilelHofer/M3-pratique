using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique.UI.Components
{
    public partial class RecetteCarte : UserControl
    {
        public RecetteCarte(Recette recette)
        {
            InitializeComponent();


            labelNom.Text = recette.Nom;
        }
    }
}
