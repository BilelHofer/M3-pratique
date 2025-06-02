using System;
using System.Linq;
using System.Windows.Forms;

namespace M3_Pratique
{
    /// <summary>
    /// Classe représentant une carte de lot dans l'interface utilisateur.
    /// </summary>
    public partial class LotCarte : UserControl
    {
        private Lot _lot;
        public event EventHandler<long> LotSelectionne;

        public Lot Lot { get => _lot; set => _lot = value; }

        /// <summary>
        /// Constructeur de la carte de lot.
        /// </summary>
        /// <param name="lot">Lot afficher</param>
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

        /// <summary>
        /// Événement déclenché lors du clic sur la carte du lot.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LotCarte_Click(object sender, EventArgs e)
        {
            LotSelectionne?.Invoke(this, _lot.Id);
        }
    }
}
