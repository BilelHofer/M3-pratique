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
    public partial class RecetteCreation : Form
    {
        public RecetteCreation()
        {
            InitializeComponent();

            flowLayoutPanelOperation.Controls.Clear();

        }

        private void RecetteCreation_Load(object sender, EventArgs e)
        {

        }

        private void labelTextRecette_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrerRecette_Click(object sender, EventArgs e)
        {

        }

        private void labelNomRecette_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomRecette_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelOperation_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSupprimerOperation_Click(object sender, EventArgs e)
        {
            var carte = new OperationCarte();
            if (flowLayoutPanelOperation.Controls.Count > 0)
            {
                flowLayoutPanelOperation.Controls.Remove(flowLayoutPanelOperation.Controls[flowLayoutPanelOperation.Controls.Count - 1]);
            }
            
        }

        private void btnAjoutOperation_Click(object sender, EventArgs e)
        {
            var carte = new OperationCarte();
            if(flowLayoutPanelOperation.Controls.Count < 10)
            {
                flowLayoutPanelOperation.Controls.Add(carte);
            }
            
        }

        private void labelOperation_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre
            this.Close();
        }
    }
}
