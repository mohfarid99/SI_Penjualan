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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;

            this.Enabled = false; //agar FormUtama tidak bisa diakses sebelum login

            //tampilkan FormLogin terlebih dahulu sebelum bisa mengakses FormUtama
            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;  //FormLogin BUKAN MdiChild dari FormUtama
            formLogin.Show(); 
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarKategori"];

            if (form == null)
            {
                FormDaftarKategori formDaftarKategori = new FormDaftarKategori();
                formDaftarKategori.MdiParent = this;
                formDaftarKategori.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarBarang"];

            if (form == null)
            {
                FormDaftarBarang formDaftarBarang = new FormDaftarBarang();
                formDaftarBarang.MdiParent = this;
                formDaftarBarang.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
