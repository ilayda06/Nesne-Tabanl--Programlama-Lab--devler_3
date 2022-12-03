﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._14
{
    class Metotlar
    {
        static int Islem(string a, params int[] sayilar)
        {
            if (a == "carp")
            {
                if (sayilar.Length == 0) return 1;
                int carpim = 1;
                foreach (int i in sayilar) carpim *= i;
                return carpim;
            }
            else if (a == "topla")
            {
                if (sayilar.Length == 0) return 0;
                int toplam = 0;
                foreach (int i in sayilar) toplam += i;
                return toplam;
            }
            else
                return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Islem("topla", 3, 4, 7, 8));
            Console.WriteLine(Islem("carp", 5, 23, 6));

            Console.ReadKey();
            //programın çıktısı
            //22
            //690
        }
    }
}
