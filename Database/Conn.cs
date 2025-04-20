using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MVCSharp.Database
{
    internal class Conn
    {
        // Configurações de conexão
        private string DB_HOST = "";
        private string DB_NAME = "";
        private string DB_USER = "";
        private string DB_PASSWORD = "";
        private string DB_PORT = "";

        private string connectionString;

        public Conn()
        {
            // Lê os valores do App.config
            DB_HOST = ConfigurationManager.AppSettings["DB_HOST"] ?? "localhost";
            DB_NAME = ConfigurationManager.AppSettings["DB_NAME"] ?? "db_name";
            DB_USER = ConfigurationManager.AppSettings["DB_USER"] ?? "db_user";
            DB_PASSWORD = ConfigurationManager.AppSettings["DB_PASSWORD"] ?? "db_password";
            DB_PORT = ConfigurationManager.AppSettings["DB_PORT"] ?? "3306";

            connectionString = $"Server={DB_HOST};Port={DB_PORT};Database={DB_NAME};Uid={DB_USER};Pwd={DB_PASSWORD};";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Método de teste de conexão
        public void TestConnection()
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar: {ex.Message}");
                }
            }
        }
    }
}
