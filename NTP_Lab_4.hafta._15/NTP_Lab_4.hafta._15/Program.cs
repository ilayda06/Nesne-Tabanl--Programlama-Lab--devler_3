using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._15
{
    class Program
    {
        static void Yaz(object o)
        {
            Console.WriteLine("1.Metot:" + o);
        }

        static void Yaz(params object[] o)
        {
            if (o.Length == 0) return;
            Console.Write("2.Metot:");
            foreach (object n in o)
                Console.Write(n.ToString() + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Yaz(25);
            Yaz("Deneme1", "Deneme2");
            Yaz('a');
            Yaz('z', 1, 23f, 4, 56, "abc");

            Console.ReadKey();
            //program çıktısı sırasıyla

            //  1.Metot:25
            //  2.Metot:Deneme1 Deneme2
            //  1.Metot:a
            //  2.Metot:z 1 23 4 56 abc
        }
    }
}
