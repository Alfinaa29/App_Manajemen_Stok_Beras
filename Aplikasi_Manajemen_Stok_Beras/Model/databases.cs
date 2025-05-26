using MySql.Data.MySqlClient;

namespace Aplikasi_Manajemen_Stok_Beras.Model
{
    public static class Database
    {
        private static string connectionString = "server=localhost;database=aplikasi_manajemen_stok_beras;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
