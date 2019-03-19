using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.NIM = "11111";
            saya.Nama = "Jono";
            saya.Ipk = 6.77f;

            kamu.NIM = "33333";
            kamu.Nama = "Paijo";
            kamu.Ipk = 8.90f;

            saya.Registrasi();
            saya.isiKrs();

            kamu.Registrasi();
            kamu.isiKrs();

            Console.ReadKey();
        }
    }
}
