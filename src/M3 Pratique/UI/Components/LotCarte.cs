using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique
{
    public partial class LotCarte : UserControl
    {
        private Lot _lot;

        public Lot Lot { get => _lot; set => _lot = value; }
        public LotCarte(Lot lot)
        {
            InitializeComponent();

            _lot = lot;

            // Met à jour le nom du lot
            labelNom.Text = lot.Nom;
            // Met à jour l'état du lot
            labelEtat.Text = Global.Etats.FirstOrDefault(etat => etat.Id == lot.IdEtat).Libelle;

            // Ajout des événements de clic sur chaque contrôle de la carte
            foreach (Control control in this.Controls)
            {
                control.Click += LotCarte_Click;
            }
        }

        public event EventHandler<long> LotSelectionne;

        private void LotCarte_Click(object sender, EventArgs e)
        {
            LotSelectionne?.Invoke(this, _lot.Id);
        }
    }
}
