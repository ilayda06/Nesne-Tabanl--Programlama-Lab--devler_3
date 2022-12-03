using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._16
{
    class faktoriyel
    {
        static int Faktoriyel(int a)
        {
            if (a == 0)
                return 1;
            return a * Faktoriyel(a - 1); //fonksiyon kendi içerisinde çağrıldı
        }
        static void Main(string[] args)
        {
            Console.Write("Faktöriyelini alacağınız sayıyı giriniz :");
            int fak_değeri = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Girmiş olduğunuz sayının faktöriyeli :" + Faktoriyel(fak_değeri));

            Console.ReadKey();
            //programın çıktısı

            // Faktöriyelini alacağınız sayıyı giriniz : 

            // Girmiş olduğunuz sayının faktöriyeli :
        }
    }


}
