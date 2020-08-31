using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_15_Faustina_classBangunDatar
{
    class Jajargenjang
    {
        //method luas dan keliling
        public void menghitungBangunDatar()
        {
            Console.WriteLine("Masukkan Alas: ");
            double Alas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Tinggi: ");
            double Tinggi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Sisi Miring: ");
            double SM = Convert.ToDouble(Console.ReadLine());
            double Luas = Alas * Tinggi;
            double Keliling = 2 * Alas + 2 * SM;
            Console.WriteLine("Luas Jajargenjangnya adalah " + Luas);
            Console.WriteLine("Keliling Jajargenjangnya adalah " + Keliling);
            Console.ReadLine();
        }
    }
}
