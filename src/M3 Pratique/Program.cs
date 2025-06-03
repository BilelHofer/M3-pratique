/**
 * Date : 07.04.2025
 * Auteur : Bilel Hofer, Lucas Domon
 * Description : Programme de l'application pour la pratique du Module 3
 * 
 */

using System;
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
            // récupération des données de la base de données
            Global.RecupererTout();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Création de l'instance de la fenêtre principal
            Manager lotManager = new Manager();

            FormManager.ManagerForm = lotManager;
            Application.Run(lotManager);
        }
    }
}
