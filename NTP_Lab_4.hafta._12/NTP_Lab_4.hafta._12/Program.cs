using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._12
{
    class Metotlar
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
            Metot1('f', 'g');
            Console.ReadKey();
            // 2. metot çağırılır. int daha az kapasiteli.
        }
    }
}
