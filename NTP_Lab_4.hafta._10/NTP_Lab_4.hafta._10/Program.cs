using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._10
{
    class Metotlar
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }

        static void Metot1(double x, double y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }

        static void Main(string[] args)
        {
            Metot1(5, 6);

            Console.ReadKey();
        }
        // iki parametre de eşit ancak çalışan 1. metot. çünkü daha az kapasitesi olan metot çalıştırılır.
    }
}

