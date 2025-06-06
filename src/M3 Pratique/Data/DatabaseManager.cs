﻿using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace M3_Pratique
{
    /// <summary>
    /// Classe de gestion de la base de données.
    /// </summary>
    public class DatabaseManager
    {
        private static MySqlConnection _connection;

        /// <summary>
        /// Méthode pour établir la connexion à la base de données.
        /// </summary>
        public static void ConnectDB()
        {
            try
            {
                _connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServerMySQL"].ConnectionString);
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                _connection = null;
            }
        }

        /// <summary>
        /// Méthode pour récupérer la connexion à la base de données.
        /// Si la connexion est null, ouvre la connexion
        /// </summary>
        /// <returns>La connexion</returns>
        public static MySqlConnection GetConnexion()
        {
            if (_connection == null)
                ConnectDB();
            return _connection;
        }

        /// <summary>
        /// Méthode pour fermer la connexion à la base de données.
        /// </summary>
        public static void CloseConnexion()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}

