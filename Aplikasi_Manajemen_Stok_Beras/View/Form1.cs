using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Aplikasi_Manajemen_Stok_Beras.Model;
using Aplikasi_Manajemen_Stok_Beras.View;
using Aplikasi_Manajemen_Stok_Beras.Controller;


namespace Aplikasi_Manajemen_Stok_Beras.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblErrorMessage.Text = "Username atau Password tidak boleh kosong!";
                lblErrorMessage.ForeColor = Color.Red;
                return;
            }

            // Panggil LoginController
            LoginController loginController = new LoginController();
            var (status, pesan) = loginController.ProsesLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            switch (status)
            {
                case LoginController.LoginStatus.BerhasilLogin:
                case LoginController.LoginStatus.UsernameBaruBerhasilDaftar:
                    MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormDaftarStokBeras2 formStok = new FormDaftarStokBeras2();
                    formStok.Show();
                    break;

                case LoginController.LoginStatus.PasswordSalah:
                case LoginController.LoginStatus.GagalMenyimpan:
                    lblErrorMessage.Text = pesan;
                    lblErrorMessage.ForeColor = Color.Red;
                    break;

                case LoginController.LoginStatus.KesalahanKoneksi:
                    MessageBox.Show(pesan, "Kesalahan Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}