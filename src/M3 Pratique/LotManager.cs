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

            flowLayoutPanelLots.Controls.Clear();

            foreach (var lot in Global.Lots)
            {
                var card = new LotCard();
                // TODO récupérer le nom de l'état
                //string etatNom = GetEtatName(lot.IdEtat);
                card.SetData(lot.Nom, "En attente");
                flowLayoutPanelLots.Controls.Add(card);
            }
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
                    var card = new LotCard();
                    // TODO récupérer le nom de l'état
                    //string etatNom = GetEtatName(lot.IdEtat);
                    card.SetData(lot.Nom, "En attente");
                    flowLayoutPanelLots.Controls.Add(card);
                }
            }
            else
            {
                // Sinon, filtre les lots en fonction du texte de recherche
                flowLayoutPanelLots.Controls.Clear();
                foreach (var lot in Global.Lots.Where(l => l.Nom.ToLower().Contains(recherche)))
                {
                    var card = new LotCard();
                    // TODO récupérer le nom de l'état
                    //string etatNom = GetEtatName(lot.IdEtat);
                    card.SetData(lot.Nom, "En attente");
                    flowLayoutPanelLots.Controls.Add(card);
                }
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }
    }
}
