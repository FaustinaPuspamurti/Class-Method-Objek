using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_15_Faustina_classBangunDatar
{
    class Trapesium
    {
        //metod luas dan keliling
        public void menghitungBangunDatar()
        {
            Console.WriteLine("Masukkan Alas 1: ");
            double A1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Alas 2: ");
            double A2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Tinggi: ");
            double Tinggi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Sisi Miring: ");
            double SM = Convert.ToDouble(Console.ReadLine());
            double Luas = 0.5 * (A1 + A2) * Tinggi;
            double Keliling = A1 + A2 + SM + SM;
            Console.WriteLine("Luas Trapesiumnya adalah " + Luas);
            Console.WriteLine("Keliling Trapesiumnya adalah " + Keliling);
            Console.ReadLine();
        }
    }
}
