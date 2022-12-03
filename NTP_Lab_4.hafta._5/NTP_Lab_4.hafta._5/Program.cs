using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" };
            Console.WriteLine("aranan isim= ");

            string aranan = Console.ReadLine();
            foreach (string ss in isimler)
            {
                if (aranan.Equals(isimler[0]))
                    Console.WriteLine("aranan isim bulundu...");

                else Console.WriteLine("isim yok");
            }

            Console.ReadKey();
            //dizide tanımladığımız isimlerden birini girersek:
            //aranan isim bulundu.... çıktısını veriyor
            //eğer girmezsek:
            //isim yok çıktısını veriyor
        }
    }
}
