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
            // Vérifie si la fenêtre de création de recette est déjà ouverte
            if (Global.recetteInformationForm == null || Global.recetteInformationForm.IsDisposed)
            {
                Global.recetteInformationForm = new RecetteInformation(_recette);
            } else
            {
                Global.recetteInformationForm.MiseAJourInformation(_recette);
            }

            // Si la fenêtre est minimusée, on la restaure
            if (Global.recetteInformationForm.WindowState == FormWindowState.Minimized)
                Global.recetteInformationForm.WindowState = FormWindowState.Normal;

            Global.recetteInformationForm.Show();
            Global.recetteInformationForm.BringToFront();
            Global.recetteInformationForm.Activate();
        }

        private void RecetteCarte_Load(object sender, EventArgs e)
        {

        }
    }
}
