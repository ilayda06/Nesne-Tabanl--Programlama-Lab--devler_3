using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._13
{
    class Metotlar
    {
        static void Metot1(int x, int y, int z)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }

        static void Metot1(int x, int y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }

        static void Metot1(float x, int y)
        {
            Console.WriteLine("3. metot çağrıldı.");
        }
        static void Main(string[] args)
        {
            Metot1(3, 3, 6);
            Metot1(3.4f, 3);
            Metot1(1, 'h');

            Console.ReadKey();
            //sırasıyla 1., 3. ve 2. metotlar çağrılır.
        }
    }
}
