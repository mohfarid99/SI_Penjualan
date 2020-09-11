using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JualBeli_LIB
{
    public class NotaBeli
    {
        private string noNota;
        private DateTime tanggal;

        public Supplier Supplier
        {
            get => default(Supplier);
            set
            {
            }
        }

        public NotaBeliDetil NotaBeliDetil
        {
            get => default(NotaBeliDetil);
            set
            {
            }
        }

        public Pegawai Pegawai
        {
            get => default(Pegawai);
            set
            {
            }
        }
    }
}