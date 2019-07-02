using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAsosiasi
{
    class Kartu
    {
        public bool IsValid(Karyawan karyawan)
        {
            return karyawan.Status == true;
        }
    }
}
