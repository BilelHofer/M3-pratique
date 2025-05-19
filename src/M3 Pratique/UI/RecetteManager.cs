using M3_Pratique.UI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace M3_Pratique
{
    /// <summary>
    /// Classe de gestion de l'interface utilisateur pour la gestion des recettes.
    /// </summary>
    public partial class RecetteManager : Form
    {
        /// <summary>
        /// Constructeur de la classe RecetteManager.
        /// </summary>
        public RecetteManager()
        {
            InitializeComponent();

            AfficherRecettes(Global.Recettes);
        }

        /// <summary>
        /// Affiche une collection de lots dans le FlowLayoutPanel.
        /// </summary>
        private void AfficherRecettes(IEnumerable<Recette> recettes)
        {
            flowLayoutPanelRecettes.Controls.Clear();

            foreach (var recette in recettes)
            {
                var carte = new RecetteCarte(recette);
                // TODO gérer la selection d'une carte
                //carte.LotSelectionne += SelectionCarte;
                flowLayoutPanelRecettes.Controls.Add(carte);
            }
        }

        /// <summary>
        /// Applique un filtre sur les recettes en fonction du texte saisi
        /// </summary>
        private void FiltrerLots()
        {
            var recherche = textBoxRechercheRecette.Text.ToLower();

            var recettesFiltres = Global.Recettes
                .Where(recette =>
                    (string.IsNullOrWhiteSpace(recherche) || recette.Nom.ToLower().Contains(recherche)));

            AfficherRecettes(recettesFiltres);
        }

        /// <summary>
        /// Réagit à la modification du texte de recherche pour filtrer les recettes.
        /// </summary>
        private void textBoxRechercheRecette_TextChanged(object sender, EventArgs e)
        {
            FiltrerLots();
        }
    }
}
