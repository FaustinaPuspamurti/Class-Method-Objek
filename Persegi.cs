using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_15_Faustina_classBangunDatar
{
    class Persegi
    {
        //method luas dan keliling
        public void menghitungBangunDatar()
        {
            Console.WriteLine("Masukkan Sisi: ");
            double Sisi = Convert.ToDouble(Console.ReadLine());
            double Luas = Sisi * Sisi;
            double Keliling = 4 * Sisi;
            Console.WriteLine("Luas Perseginya adalah " + Luas);
            Console.WriteLine("Keliling Perseginya adalah " + Keliling);
            Console.ReadLine();
        }
    }
}
