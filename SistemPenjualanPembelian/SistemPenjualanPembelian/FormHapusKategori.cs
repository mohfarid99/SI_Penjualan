﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JualBeli_LIB;

namespace SistemPenjualanPembelian
{
    public partial class FormHapusKategori : Form
    {

        List<Kategori> listKategori = new List<Kategori>();
        public FormHapusKategori()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data kategori akan terhapus. Apakah anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Kategori k = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);

                    Kategori.HapusData(k);
                    
                    MessageBox.Show("Data kategori telah terhapus", "info");

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Penghapusan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
                }
                
            }
        }

        private void textBoxKodeKategori_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodeKategori.Text.Length == textBoxKodeKategori.MaxLength)
            {
                listKategori = Kategori.BacaData("KodeKategori", textBoxKodeKategori.Text);
                if (listKategori.Count > 0)
                {
                    textBoxNamaKategori.Text = listKategori[0].Nama;
                    textBoxNamaKategori.Enabled = false;
                    textBoxNamaKategori.Focus();
                }
                else
                {
                    MessageBox.Show("Kode kategori tidak ditemukan.", "Kesalahan");
                    textBoxNamaKategori.Text = "";
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHapusKategori_Load(object sender, EventArgs e)
        {
            textBoxKodeKategori.MaxLength = 2;
        }
    }
}
