using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._6
{
    class metotler_3
    {
        static int BuyukBul(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            int s1, s2;

            Console.WriteLine("1.sayıyı girin: ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı girin: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = BuyukBul(s1, s2);

            Console.WriteLine("en büyük {0}'dir. ", enBuyuk);

            Console.ReadKey();
            //klavyeden iki sayı giriyoruz 
            //girdiğimiz sayılardan hangisi büyükse
            //en büyük sayi ...'dir çıktısını veriyor.

        }
    }
}
