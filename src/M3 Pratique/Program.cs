/**
 * Date : 07.04.2025
 * Auteur : Bilel Hofer, Lucas Domon
 * Description : Programme de l'application pour la pratique du Module 3
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Récupère les données depuis la base de données
            try
            {
                Global.RecupererEtat();
                Global.RecupererLots();
                Global.RecupererRecette();
                Global.recupererEvenement();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LotManager());
        }
    }
}
