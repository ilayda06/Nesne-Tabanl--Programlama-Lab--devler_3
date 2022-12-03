using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._11
{
    class Metorlar
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }

        static void Metot1(int x, int y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }

        static void Main(string[] args)
        {
            Metot1(5, 6.4f);

            Console.ReadLine();

            //metot bir çağrılır çünkü float tipinde değer verdik.
        }
    }
}
