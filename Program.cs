using System;

namespace XIRPL3_15_Faustina_classBangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("=========MENGHITUNG BANGUN DATAR=========");
            Console.WriteLine("=========================================");
            Console.WriteLine("Pilih Bangun Datar: ");
            Console.WriteLine("1. Persegi: ");
            Console.WriteLine("2. Persegi Panjang: ");
            Console.WriteLine("3. Segitiga: ");
            Console.WriteLine("4. Jajargenjang: ");
            Console.WriteLine("5. Trapesium: ");
            Console.WriteLine("6. Layang Layang: ");
            Console.WriteLine("7. Belah Ketupat: ");
            Console.WriteLine("Bangun Datar Yang Dipilih: ");
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Persegi a = new Persegi();
                        a.menghitungBangunDatar();
                        break;
                    case 2:
                        Persegi_Panjang b = new Persegi_Panjang();
                        b.menghitungBangunDatar();
                        break;
                    case 3:
                        Segitiga c = new Segitiga();
                        c.menghitungBangunDatar();
                        break;
                    case 4:
                        Jajargenjang d = new Jajargenjang();
                        d.menghitungBangunDatar();
                        break;
                    case 5:
                        Trapesium e = new Trapesium();
                        e.menghitungBangunDatar();
                        break;
                    case 6:
                        Layang_layang f = new Layang_layang();
                        f.menghitungBangunDatar();
                        break;
                    case 7:
                        Belah_Ketupat g = new Belah_Ketupat();
                        g.menghitungBangunDatar();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
