using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2276
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No    Nik/Nama      Gaji Bulanan");
            Console.WriteLine("--------------------------------- ");
            Karyawan krywn1 = new Karyawan("190302123", "Paijo", 3000000);
            CetakHasil(krywn1);

            Console.WriteLine();
 
            Karyawan krywn2 = new Karyawan("190302124", "Jono", 2000000);
            CetakHasil(krywn2);


            Console.WriteLine();
            Console.WriteLine("Asik Gaji Naik 10% nih!");
            //Console.WriteLine( ); 

            Console.WriteLine("No    Nik/Nama      Gaji Bulanan");
            Console.WriteLine("--------------------------------- ");
            Karyawan krywn3 = new Karyawan("190302123", "Paijo", 3300000);
            CetakHasil(krywn3);
            Console.WriteLine();

            Karyawan krywn4 = new Karyawan("190302124", "Jono", 2200000);
            CetakHasil(krywn4);


            Console.ReadKey();
        }

        static void CetakHasil(Karyawan krywn)
        {
            Console.WriteLine("nik = {0}", krywn.Nik);
            Console.WriteLine("nama = {0}", krywn.Nama);
            Console.WriteLine("gajiBulanan = {0}", krywn.GajiBulanan);
        }
    }
}
