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
    // Fenêtre pour le management des lots
    public partial class LotManager : Form
    {
        // Instance de fenetre pour la création d'un lot
        private LotCreation lotCreationForm = null;

        public LotManager()
        {
            InitializeComponent();
        }

        private void LotManager_Load(object sender, EventArgs e)
        {

        }

        // Bouton pour créer un lot
        private void btnCreerLot_Click(object sender, EventArgs e)
        {
            // Vérifie si la fenêtre de création de lot est déjà ouverte
            if (lotCreationForm == null || lotCreationForm.IsDisposed)
            {
                lotCreationForm = new LotCreation();
                lotCreationForm.Show();
            }
            else
            {
                lotCreationForm.BringToFront();
            }
        }
    }
}
