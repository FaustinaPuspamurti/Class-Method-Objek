using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_15_Faustina_classBangunDatar
{
    class Belah_Ketupat
    {
        //method luas dan keliling
        public void menghitungBangunDatar()
        {
            Console.WriteLine("Masukkan Diagonal 1: ");
            double D1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Diagonal 2: ");
            double D2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Sisi: ");
            double Sisi = Convert.ToDouble(Console.ReadLine());
            double Luas = 0.5 * D1 * D2;
            double Keliling = 4 * Sisi;
            Console.WriteLine("Luas BelahKetupatnya adalah " + Luas);
            Console.WriteLine("Keliling Belah Ketupatnya adalah " + Keliling);
            Console.ReadLine();
        }
    }
}
