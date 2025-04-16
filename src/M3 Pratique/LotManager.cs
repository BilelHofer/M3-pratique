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

            // Mise à jour des lots
            Global.RecupererLots();
            Global.RecupererEtat();

            flowLayoutPanelLots.Controls.Clear();

            foreach (var lot in Global.Lots)
            {
                var carte = new LotCarte();
                carte.SetData(lot.Nom, Global.Etats.FirstOrDefault(etat => etat.Id == lot.IdEtat).Libelle);
                flowLayoutPanelLots.Controls.Add(carte);
            }
        }

        // Bouton pour créer un lot
        private void btnCreerLot_Click(object sender, EventArgs e)
        {
            // Vérifie si la fenêtre de création de lot est déjà ouverte
            if (lotCreationForm == null || lotCreationForm.IsDisposed)
            {

                lotCreationForm = new LotCreation();

                // Ajoute un évènement pour rafraîchir la liste des lots
                lotCreationForm.LotAjoute += (s, args) => RafraichirListeLots();

                lotCreationForm.Show();
            }
            else
            {
                lotCreationForm.BringToFront();
            }
        }

        private void LotManager_Load(object sender, EventArgs e)
        {

        }

        private void textBoxRechercheLot_TextChanged(object sender, EventArgs e)
        {
            // Récupérère le texte de la barre de recherche
            string recherche = textBoxRechercheLot.Text.ToLower();

            // Vérifie si le texte est vide
            if (string.IsNullOrEmpty(recherche))
            {
                // Si le texte est vide, recharge tous les lots
                flowLayoutPanelLots.Controls.Clear();
                foreach (var lot in Global.Lots)
                {
                    var card = new LotCarte();
                    card.SetData(lot.Nom, Global.Etats.FirstOrDefault(etat => etat.Id == lot.IdEtat).Libelle);
                    flowLayoutPanelLots.Controls.Add(card);
                }
            }
            else
            {
                // Sinon, filtre les lots en fonction du texte de recherche
                flowLayoutPanelLots.Controls.Clear();
                foreach (var lot in Global.Lots.Where(lot => lot.Nom.ToLower().Contains(recherche)))
                {
                    var card = new LotCarte();
                    card.SetData(lot.Nom, Global.Etats.FirstOrDefault(etat => etat.Id == lot.IdEtat).Libelle);
                    flowLayoutPanelLots.Controls.Add(card);
                }
            }
        }

        /// <summary>
        /// Rafraîchit la liste des lots affichés dans le FlowLayoutPanel
        /// </summary>
        private void RafraichirListeLots()
        {
            flowLayoutPanelLots.Controls.Clear();
            foreach (var lot in Global.Lots)
            {
                var carte = new LotCarte();
                carte.SetData(lot.Nom, "En attente");
                flowLayoutPanelLots.Controls.Add(carte);
            }
        }


        private void btnRechercher_Click(object sender, EventArgs e)
        {
        }
    }
}
