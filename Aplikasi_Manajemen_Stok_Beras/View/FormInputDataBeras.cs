using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Aplikasi_Manajemen_Stok_Beras.View;
using Aplikasi_Manajemen_Stok_Beras.Model;


namespace Aplikasi_Manajemen_Stok_Beras.View
{
    public partial class FormInputDataBeras : Form
    {
        private Aplikasi_Manajemen_Stok_Beras.View.FormDaftarStokBeras2 formUtama;
        private string namaBerasUntukEdit;

        public FormInputDataBeras(Aplikasi_Manajemen_Stok_Beras.View.FormDaftarStokBeras2 formUtamaRef)
        {
            InitializeComponent();
            IsiComboBox();
            this.formUtama = formUtamaRef;

            btnSimpan.Visible = false;
           
        }

        public FormInputDataBeras(FormDaftarStokBeras2 formUtamaRef, string namaBeras)
        {
            InitializeComponent();
            IsiComboBox();
            this.formUtama = formUtamaRef;
            this.namaBerasUntukEdit = namaBeras;

            LoadDataUntukEdit();

            // Sembunyikan tombol tambah, tampilkan simpan dan hapus
            btnTambahBeras.Visible = false;
            btnSimpan.Visible = true;
            
        }

        private void LoadDataUntukEdit()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT harga_beli, harga_jual, jumlah_stok FROM stok_beras WHERE nama_beras = @namaBeras";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@namaBeras", namaBerasUntukEdit);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtHargaBeli.Text = reader["harga_beli"].ToString();
                                txtHargaJual.Text = reader["harga_jual"].ToString();
                                txtJumlahStok.Text = reader["jumlah_stok"].ToString();
                                cmbNamaBeras.SelectedItem = namaBerasUntukEdit;
                            }
                            else
                            {
                                MessageBox.Show("Data beras tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IsiComboBox()
        {
            cmbNamaBeras.Items.Clear();
            cmbNamaBeras.Items.Add("Bramo");
            cmbNamaBeras.Items.Add("Serang");
            cmbNamaBeras.Items.Add("64");
            cmbNamaBeras.Items.Add("Wangi");

            cmbSatuanBeli.Items.Clear();
            cmbSatuanBeli.Items.Add("Kg");
            cmbSatuanBeli.Items.Add("Ton");
            cmbSatuanBeli.Items.Add("Karung");

            cmbSatuanStok.Items.Clear();
            cmbSatuanStok.Items.Add("Kg");
            cmbSatuanStok.Items.Add("Ton");
            cmbSatuanStok.Items.Add("Karung");
        }

        private void btnTambahBeras_Click(object sender, EventArgs e)
        {
            if (cmbNamaBeras.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtHargaBeli.Text) ||
                string.IsNullOrWhiteSpace(txtHargaJual.Text) ||
                string.IsNullOrWhiteSpace(txtJumlahStok.Text))
            {
                MessageBox.Show("Harap lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaBeras = cmbNamaBeras.SelectedItem.ToString();

            if (!decimal.TryParse(txtHargaBeli.Text, out decimal hargaBeli) ||
                !decimal.TryParse(txtHargaJual.Text, out decimal hargaJual) ||
                !int.TryParse(txtJumlahStok.Text, out int jumlahStok))
            {
                MessageBox.Show("Harga dan jumlah stok harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTambahBeras.Enabled = false;

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO stok_beras (nama_beras, harga_beli, harga_jual, jumlah_stok) " +
                                   "VALUES (@nama, @beli, @jual, @stok)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", namaBeras);
                        cmd.Parameters.AddWithValue("@beli", hargaBeli);
                        cmd.Parameters.AddWithValue("@jual", hargaJual);
                        cmd.Parameters.AddWithValue("@stok", jumlahStok);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formUtama.LoadData();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal ditambahkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnTambahBeras.Enabled = true;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbNamaBeras.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtHargaBeli.Text) ||
                string.IsNullOrWhiteSpace(txtHargaJual.Text) ||
                string.IsNullOrWhiteSpace(txtJumlahStok.Text))
            {
                MessageBox.Show("Harap lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaBeras = cmbNamaBeras.SelectedItem.ToString();

            if (!decimal.TryParse(txtHargaBeli.Text, out decimal hargaBeli) ||
                !decimal.TryParse(txtHargaJual.Text, out decimal hargaJual) ||
                !int.TryParse(txtJumlahStok.Text, out int jumlahStok))
            {
                MessageBox.Show("Harga dan jumlah stok harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hargaBeli < 0 || hargaJual < 0 || jumlahStok < 0)
            {
                MessageBox.Show("Harga dan jumlah stok tidak boleh kurang dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE stok_beras SET harga_beli = @beli, harga_jual = @jual, jumlah_stok = @stok WHERE nama_beras = @namaBeras";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@namaBeras", MySqlDbType.VarChar).Value = namaBeras;
                        cmd.Parameters.Add("@beli", MySqlDbType.Decimal).Value = hargaBeli;
                        cmd.Parameters.Add("@jual", MySqlDbType.Decimal).Value = hargaJual;
                        cmd.Parameters.Add("@stok", MySqlDbType.Int32).Value = jumlahStok;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formUtama.LoadData();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan atau gagal diperbarui!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (cmbNamaBeras.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih nama beras yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaBeras = cmbNamaBeras.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM stok_beras WHERE nama_beras = @nama";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", namaBeras);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                formUtama.LoadData();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Data gagal dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormInputDataBeras_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menutup form ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

private void gbInputDataBeras_Enter(object sender, EventArgs e)
        {
            // Placeholder, bisa ditambahkan fungsi jika dib
        }

        private void FormInputDataBeras_Load(object sender, EventArgs e)
        {
            // Tidak ada kode saat form load
        }
    }
}
