using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Mahasiswa
    {
        public string NIM { get; set; }
        public string Nama { get; set; }
        public float Ipk { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("NIM: {0}", NIM);
            Console.WriteLine("IPK: {0}", Ipk);
            Console.WriteLine("Telah melakukan registrasi");

        }
        public void isiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses Krs\n", Nama);
        }
        
    }

}
