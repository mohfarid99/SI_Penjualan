using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JualBeli_LIB
{
    public class Barang
    {
        
        private string kodeBarang;
        private string barcode;
        private string nama;
        private int hargaJual;
        private int stok;

        #region Properties
        public string KodeBarang { get => KodeBarang; set => KodeBarang = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Nama { get => nama; set => nama = value; }
        public int HargaJual { get => hargaJual; set => hargaJual = value; }
        public int Stok { get => stok; set => stok = value; }

        #endregion

        public Kategori Kategori
        {
            get => default(Kategori);
            set
            {
            }
        }
    }
}