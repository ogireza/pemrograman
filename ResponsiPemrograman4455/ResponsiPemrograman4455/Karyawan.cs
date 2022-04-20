using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4455
{
    public class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, float gaji)
        {
            this.Nik = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                gaji = 0;
            }
            this.GajiBulanan = gaji;
        }
        public void naikgaji(float kenaikan)
        {
            this.GajiBulanan = kenaikan / 100 * this.GajiBulanan + this.GajiBulanan;
        }
    }
}
