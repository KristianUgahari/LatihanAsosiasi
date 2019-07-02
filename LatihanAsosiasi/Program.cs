using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAsosiasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek kartu
            Kartu kartu = new Kartu();

            //membuat objek karyawan
            Karyawan karyawan = new Karyawan();
            karyawan.Nama = "Manut";
            karyawan.Status = false; //aktif

            //hubungan asosiasi
            if (karyawan.Login(kartu))
            {
                Console.WriteLine("Data Karyawan Sangat Super Valid Sekali");
            }
            else
            {
                Console.WriteLine("Maaf Data Karyawan Sangat Super Tidak Valid Sekali");
            }

            Console.ReadKey();
        }
    }
}
