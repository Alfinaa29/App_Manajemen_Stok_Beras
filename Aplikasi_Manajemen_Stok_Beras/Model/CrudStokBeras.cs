using Aplikasi_Manajemen_Stok_Beras;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Aplikasi_Manajemen_Stok_Beras.Model
{
    public class CrudStokBeras
    {
        // Menambah data stok beras
        public static void TambahData(string namaBeras, decimal hargaBeli, decimal hargaJual, int jumlahStok)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO stok_beras (nama_beras, harga_beli, harga_jual, jumlah_stok) VALUES (@nama_beras, @harga_beli, @harga_jual, @jumlah_stok)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_beras", namaBeras);
                    cmd.Parameters.AddWithValue("@harga_beli", hargaBeli);
                    cmd.Parameters.AddWithValue("@harga_jual", hargaJual);
                    cmd.Parameters.AddWithValue("@jumlah_stok", jumlahStok);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Memperbarui data stok beras
        public static void PerbaruiData(string namaBeras, decimal hargaBeli, decimal hargaJual, int jumlahStok)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "UPDATE stok_beras SET harga_beli = @harga_beli, harga_jual = @harga_jual, jumlah_stok = @jumlah_stok WHERE nama_beras = @nama_beras";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_beras", namaBeras);
                    cmd.Parameters.AddWithValue("@harga_beli", hargaBeli);
                    cmd.Parameters.AddWithValue("@harga_jual", hargaJual);
                    cmd.Parameters.AddWithValue("@jumlah_stok", jumlahStok);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Menghapus data stok beras
        public static bool HapusData(string namaBeras)
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM stok_beras WHERE nama_beras = @nama_beras";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_beras", namaBeras);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Menampilkan seluruh data
        public static DataTable TampilkanData()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT nama_beras, harga_beli, harga_jual, jumlah_stok FROM stok_beras";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // Mencari data berdasarkan nama beras
        public static DataTable CariData(string kataKunci)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT nama_beras, harga_beli, harga_jual, jumlah_stok FROM stok_beras WHERE nama_beras LIKE @kataKunci";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kataKunci", "%" + kataKunci + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
