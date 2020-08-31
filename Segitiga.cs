using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_15_Faustina_classBangunDatar
{
    class Segitiga
    {
        //method luas dan keliling
        public void menghitungBangunDatar()
        {
            Console.WriteLine("Masukkan Alas: ");
            double Alas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Tinggi: ");
            double Tinggi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Sisi: ");
            double Sisi = Convert.ToDouble(Console.ReadLine());
            double Luas = 0.5 * Alas * Tinggi;
            double Keliling = 3 * Sisi;
            Console.WriteLine("Luas Segitiganya adalah " + Luas);
            Console.WriteLine("Keliling Segitiganya adalah " + Keliling);
            Console.ReadLine();
        }
    }
}
