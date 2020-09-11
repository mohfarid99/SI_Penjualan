using System;
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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarKategori frmDaftarkategori = (FormDaftarKategori)this.Owner;
            frmDaftarkategori.FormDaftarKategori_Load(buttonKeluar, e);
            this.Close();
        }
        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Text = "";
            textBoxNamaKategori.Text = "";
            textBoxKodeKategori.Focus();
        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);

                Kategori.TambahData(k);

                MessageBox.Show("Data kategori telah tersimpan", "info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {
            string kodeTerbaru = Kategori.GenerateKode();

            textBoxKodeKategori.Text = kodeTerbaru;
            textBoxKodeKategori.Enabled = false;
            textBoxNamaKategori.Focus();
        }
    }
}
