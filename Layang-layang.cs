using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_15_Faustina_classBangunDatar
{
    class Layang_layang
    {
        //method luas dan keliling
        public void menghitungBangunDatar()
        {
            Console.WriteLine("Masukkan Sisi 1: ");
            double S1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Sisi 2: ");
            double S2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Diagonal 1: ");
            double D1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Diagonal 2: ");
            double D2 = Convert.ToDouble(Console.ReadLine());
            double Luas = 0.5 * D1 * D2;
            double Keliling = 2 * (S1 + S2);
            Console.WriteLine("Luas Layang Layangnya adalah " + Luas);
            Console.WriteLine("Keliling Layang Layangnya adalah " + Keliling);
            Console.ReadLine();
        }
    }
}
