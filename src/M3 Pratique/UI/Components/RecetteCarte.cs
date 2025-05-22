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
        private Recette _recette;
        public RecetteCarte(Recette recette)
        {
            InitializeComponent();

            _recette = recette;
            labelNom.Text = recette.Nom;


            // Ajout des événements de clic sur chaque contrôle de la carte
            foreach (Control control in this.Controls)
            {
                control.Click += RecetteCarte_Click;
            }
        }

        private void RecetteCarte_Click(object sender, EventArgs e)
        {
            FormManager.OuvrirRecetteInformation(_recette);
        }

        private void RecetteCarte_Load(object sender, EventArgs e)
        {

        }
    }
}
