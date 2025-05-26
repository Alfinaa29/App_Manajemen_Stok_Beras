using System;
using System.Data;
using System.Windows.Forms;
using Aplikasi_Manajemen_Stok_Beras.Model;

namespace Aplikasi_Manajemen_Stok_Beras.View
{
    public partial class FormDaftarStokBeras2 : Form
    {
        public FormDaftarStokBeras2()
        {
            InitializeComponent();
            TampilkanDataStokBeras();
        }

        private void TampilkanDataStokBeras()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                DataTable dt = CrudStokBeras.TampilkanData();
                dgvStokBeras.DataSource = null;
                dgvStokBeras.Columns.Clear();
                dgvStokBeras.DataSource = dt;

                dgvStokBeras.Columns[0].HeaderText = "Nama Beras";
                dgvStokBeras.Columns[1].HeaderText = "Harga Beli";
                dgvStokBeras.Columns[2].HeaderText = "Harga Jual";
                dgvStokBeras.Columns[3].HeaderText = "Jumlah Stok";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        public void LoadData()
        {
            TampilkanDataStokBeras();
        }

        private void FormDaftarStokBeras2_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gbDataStokBeras_Enter(object sender, EventArgs e)
        {
            // Kosongkan jika memang tidak ada fungsinya
        }

        private void FormDaftarStokBeras2_Load(object sender, EventArgs e)
        {
            // Tidak digunakan saat ini
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            FormInputDataBeras formInput = new FormInputDataBeras(this);
            formInput.ShowDialog();
        }

        private void btnPerbaruiData_Click(object sender, EventArgs e)
        {
            if (dgvStokBeras.SelectedRows.Count == 1)
            {
                var namaBeras = dgvStokBeras.SelectedRows[0].Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(namaBeras))
                {
                    FormInputDataBeras formInput = new FormInputDataBeras(this, namaBeras);
                    formInput.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Pilih data yang valid untuk diperbarui.", "Informasi");
                }
            }
            else
            {
                MessageBox.Show("Pilih satu data yang valid untuk diperbarui.", "Informasi");
            }
        }

        private void btnHapusData_Click(object sender, EventArgs e)
        {
            if (dgvStokBeras.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string namaBeras = dgvStokBeras.SelectedRows[0].Cells["nama_beras"].Value.ToString();
                    bool sukses = CrudStokBeras.HapusData(namaBeras);

                    if (sukses)
                    {
                        MessageBox.Show("Data berhasil dihapus.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string kataKunci = txtCari.Text.Trim();

            if (string.IsNullOrEmpty(kataKunci))
            {
                TampilkanDataStokBeras();
                return;
            }

            try
            {
                DataTable hasil = CrudStokBeras.CariData(kataKunci);
                dgvStokBeras.DataSource = hasil;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message);
            }
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCari.PerformClick();
            }
        }
    }
}
