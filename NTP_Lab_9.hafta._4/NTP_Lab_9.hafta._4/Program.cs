using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_9.hafta._4
{
    class A
    {
        public void Metot1()
        { Metot2(); }
        public void Metot2()
        { Console.WriteLine("A sınıfı"); }
    }
    class B : A
    {
        public new void Metot2()
        { Console.WriteLine("B sınıfı"); }
    }
    class Ana
    {
        class Program
        {
            static void Main(string[] args)
            {
                B b = new B();
                b.Metot1();
                Console.ReadLine();
                //çıktısı
                //    A sınıfı
                //    şeklinde olur
            }
        }
    }
}
