using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JualBeli_LIB
{
    public class NotaJual
    {
        private string noNota;
        private DateTime tanggal;

        public NotaJualDetil NotaJualDetil
        {
            get => default(NotaJualDetil);
            set
            {
            }
        }

        public Pelanggan Pelanggan
        {
            get => default(Pelanggan);
            set
            {
            }
        }
    }
}