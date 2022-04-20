using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4455
{
    class Program
    {
        public static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("190302123", "Paijo", 3000000);

            Karyawan karyawan2 = new Karyawan("190302124", "Jono", 2000000);


            Console.WriteLine("No. Nik/Nama              Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" 1  {0} {1}          {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 1  {0} {1}           {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
           
            Console.WriteLine();
            Console.WriteLine("Setelah Gaji naik 10%");
            Console.WriteLine();

            karyawan1.naikgaji(10);
            karyawan2.naikgaji(10);

            Console.WriteLine("No. Nik/Nama              Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" 1  {0} {1}           {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 1  {0} {1}            {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
        }
    }
}