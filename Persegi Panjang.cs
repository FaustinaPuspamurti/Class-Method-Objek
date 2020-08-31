using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL3_15_Faustina_classBangunDatar
{
    class Persegi_Panjang
    {
        //method luas dan keliling 
        public void menghitungBangunDatar()
        {
            Console.WriteLine("Masukkan Panjang: ");
            double Panjang = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Lebar: ");
            double Lebar = Convert.ToDouble(Console.ReadLine());
            double Luas = Panjang * Lebar;
            double Keliling = 2 * (Panjang + Lebar);
            Console.WriteLine("Luas PersegiPanjangnya adalah " + Luas);
            Console.WriteLine("Keliling PersegiPanjangnya adalah " + Keliling);
            Console.ReadLine();
        }
    }
}
