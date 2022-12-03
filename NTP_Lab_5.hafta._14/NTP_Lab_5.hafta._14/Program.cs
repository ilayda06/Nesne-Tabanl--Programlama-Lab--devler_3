using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_5.hafta._14
{
    class Program
    {
        public int Zar()
 {      Random rnd = new Random(); return rnd.Next(1,7); }
        public static void metotlar(int a, int b, int c)
 {      Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
            Console.ReadLine();
        }
        static void Main(string[] args) {
            Program a = new Program();
             metotlar(a.Zar(), a.Zar(), a.Zar());
            //çıktısı
            //    a = 4 b = 4 c = 4
            //şeklinde olur
        }
    }
}
