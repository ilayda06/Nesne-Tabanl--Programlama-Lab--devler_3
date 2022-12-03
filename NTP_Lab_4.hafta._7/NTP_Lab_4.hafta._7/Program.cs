using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._7
{
    class metotlar_4
    {
        static int BuyukBul(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;

        }

        static int BuyukBul3(int a, int b, int c)
        {
            return BuyukBul(a, BuyukBul(b, c));
        }
        static void Main(string[] args)
        {
            int s1, s2, s3;
            Console.WriteLine("1. sayıyı girin: ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı girin: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sayıyı girin: ");
            s3 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = BuyukBul3(s1, s2, s3);

            Console.WriteLine("en büyük: {0}'dir.", enBuyuk);

            Console.ReadKey();
            //program girilen üç sayıdan en büyüğünü çıktı olarak veriyor.
        }
    }
}
