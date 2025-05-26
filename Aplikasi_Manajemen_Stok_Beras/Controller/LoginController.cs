using System;
using MySql.Data.MySqlClient;
using Aplikasi_Manajemen_Stok_Beras.Model;

namespace Aplikasi_Manajemen_Stok_Beras.Controller
{
    public class LoginController
    {
        public enum LoginStatus
        {
            BerhasilLogin,
            PasswordSalah,
            UsernameBaruBerhasilDaftar,
            GagalMenyimpan,
            KesalahanKoneksi
        }

        public (LoginStatus status, string pesan) ProsesLogin(string username, string password)
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // Cek apakah username ada
                    string checkQuery = "SELECT * FROM login WHERE username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Username ada, cek password
                            reader.Close();

                            string loginQuery = "SELECT * FROM login WHERE username = @username AND password = @password";
                            MySqlCommand loginCmd = new MySqlCommand(loginQuery, conn);
                            loginCmd.Parameters.AddWithValue("@username", username);
                            loginCmd.Parameters.AddWithValue("@password", password);

                            using (MySqlDataReader loginReader = loginCmd.ExecuteReader())
                            {
                                if (loginReader.HasRows)
                                {
                                    return (LoginStatus.BerhasilLogin, "Login berhasil!");
                                }
                                else
                                {
                                    return (LoginStatus.PasswordSalah, "Password salah!");
                                }
                            }
                        }
                        else
                        {
                            // Username belum ada, lakukan insert
                            reader.Close();

                            string insertQuery = "INSERT INTO login (username, password) VALUES (@username, @password)";
                            MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                            insertCmd.Parameters.AddWithValue("@username", username);
                            insertCmd.Parameters.AddWithValue("@password", password);

                            int result = insertCmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                return (LoginStatus.UsernameBaruBerhasilDaftar, "Registrasi dan Login berhasil!");
                            }
                            else
                            {
                                return (LoginStatus.GagalMenyimpan, "Gagal menyimpan data!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (LoginStatus.KesalahanKoneksi, "Kesalahan koneksi: " + ex.Message);
            }
        }
    }
}
