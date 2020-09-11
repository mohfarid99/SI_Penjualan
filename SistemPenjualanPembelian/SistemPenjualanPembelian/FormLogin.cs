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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Height = 50 + panelLogin.Height;

            //beri nilai awal server dan database
            textBoxServer.Text = "localhost";
            textBoxDatabase.Text = "si_jual_beli";
        }

        private void linkLabelPengaturan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Height = 50 + panelLogin.Height + panelPengaturan.Height;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            this.Height = 50 + panelLogin.Height;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != "")
                {
                    //create objek bertipe Koneksi dengan memanggil constructor berparameter
                    Koneksi koneksi = new Koneksi(textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

                    //ujicoba create objek bertipe Koneksi menggunakan default constructor
                    Koneksi koneksi2 = new Koneksi();

                    MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi.", "Informasi");

                    this.Owner.Enabled = true; //agar Owner dari FormLogin (FormUtama) bisa diakses

                    this.Close();  //tutup FormLogin
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

    }
}
