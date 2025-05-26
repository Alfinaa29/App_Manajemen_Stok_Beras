namespace Aplikasi_Manajemen_Stok_Beras.View
{
    partial class FormDaftarStokBeras2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDataStokBeras = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnHapusData = new System.Windows.Forms.Button();
            this.btnPerbaruiData = new System.Windows.Forms.Button();
            this.btnTambahData = new System.Windows.Forms.Button();
            this.dgvStokBeras = new System.Windows.Forms.DataGridView();
            this.namaberas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahstok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDataStokBeras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokBeras)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDataStokBeras
            // 
            this.gbDataStokBeras.Controls.Add(this.btnCari);
            this.gbDataStokBeras.Controls.Add(this.txtCari);
            this.gbDataStokBeras.Controls.Add(this.btnHapusData);
            this.gbDataStokBeras.Controls.Add(this.btnPerbaruiData);
            this.gbDataStokBeras.Controls.Add(this.btnTambahData);
            this.gbDataStokBeras.Controls.Add(this.dgvStokBeras);
            this.gbDataStokBeras.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataStokBeras.Location = new System.Drawing.Point(46, 45);
            this.gbDataStokBeras.Name = "gbDataStokBeras";
            this.gbDataStokBeras.Size = new System.Drawing.Size(780, 550);
            this.gbDataStokBeras.TabIndex = 0;
            this.gbDataStokBeras.TabStop = false;
            this.gbDataStokBeras.Text = "Daftar Stok Beras";
            this.gbDataStokBeras.Enter += new System.EventHandler(this.gbDataStokBeras_Enter);
            // 
            // btnCari
            // 
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(309, 65);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(127, 51);
            this.btnCari.TabIndex = 5;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(32, 68);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(205, 45);
            this.txtCari.TabIndex = 4;
            this.txtCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyDown);
            // 
            // btnHapusData
            // 
            this.btnHapusData.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusData.Location = new System.Drawing.Point(579, 463);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(174, 57);
            this.btnHapusData.TabIndex = 3;
            this.btnHapusData.Text = "Hapus";
            this.btnHapusData.UseVisualStyleBackColor = true;
            this.btnHapusData.Click += new System.EventHandler(this.btnHapusData_Click);
            // 
            // btnPerbaruiData
            // 
            this.btnPerbaruiData.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerbaruiData.Location = new System.Drawing.Point(309, 463);
            this.btnPerbaruiData.Name = "btnPerbaruiData";
            this.btnPerbaruiData.Size = new System.Drawing.Size(192, 57);
            this.btnPerbaruiData.TabIndex = 2;
            this.btnPerbaruiData.Text = "Perbarui";
            this.btnPerbaruiData.UseVisualStyleBackColor = true;
            this.btnPerbaruiData.Click += new System.EventHandler(this.btnPerbaruiData_Click);
            // 
            // btnTambahData
            // 
            this.btnTambahData.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahData.Location = new System.Drawing.Point(32, 463);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(205, 57);
            this.btnTambahData.TabIndex = 1;
            this.btnTambahData.Text = "Tambah Data";
            this.btnTambahData.UseVisualStyleBackColor = true;
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // dgvStokBeras
            // 
            this.dgvStokBeras.AllowUserToAddRows = false;
            this.dgvStokBeras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStokBeras.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokBeras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStokBeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokBeras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaberas,
            this.hargabeli,
            this.hargajual,
            this.jumlahstok});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStokBeras.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStokBeras.Location = new System.Drawing.Point(32, 125);
            this.dgvStokBeras.Name = "dgvStokBeras";
            this.dgvStokBeras.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokBeras.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStokBeras.RowHeadersWidth = 62;
            this.dgvStokBeras.RowTemplate.Height = 28;
            this.dgvStokBeras.Size = new System.Drawing.Size(721, 312);
            this.dgvStokBeras.TabIndex = 0;
            // 
            // namaberas
            // 
            this.namaberas.HeaderText = "Nama Beras";
            this.namaberas.MinimumWidth = 8;
            this.namaberas.Name = "namaberas";
            this.namaberas.ReadOnly = true;
            // 
            // hargabeli
            // 
            this.hargabeli.HeaderText = "Harga Beli";
            this.hargabeli.MinimumWidth = 8;
            this.hargabeli.Name = "hargabeli";
            this.hargabeli.ReadOnly = true;
            // 
            // hargajual
            // 
            this.hargajual.HeaderText = "Harga Jual";
            this.hargajual.MinimumWidth = 8;
            this.hargajual.Name = "hargajual";
            this.hargajual.ReadOnly = true;
            // 
            // jumlahstok
            // 
            this.jumlahstok.HeaderText = "Jumlah Stok";
            this.jumlahstok.MinimumWidth = 8;
            this.jumlahstok.Name = "jumlahstok";
            this.jumlahstok.ReadOnly = true;
            // 
            // FormDaftarStokBeras2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 629);
            this.Controls.Add(this.gbDataStokBeras);
            this.Name = "FormDaftarStokBeras2";
            this.Text = "FormDaftarStokBeras2";
            this.Load += new System.EventHandler(this.FormDaftarStokBeras2_Load);
            this.gbDataStokBeras.ResumeLayout(false);
            this.gbDataStokBeras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokBeras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataStokBeras;
        private System.Windows.Forms.DataGridView dgvStokBeras;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaberas;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajual;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahstok;
        private System.Windows.Forms.Button btnTambahData;
        private System.Windows.Forms.Button btnPerbaruiData;
        private System.Windows.Forms.Button btnHapusData;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
    }
}