using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAsosiasi
{
    class Karyawan
    {
        public string Nama { get; set; }
        public bool Status { get; set; }

        public bool Login(Kartu kartu)
        {
            //hubungan asosiasi
            return kartu.IsValid(this);
        }
    }
}
