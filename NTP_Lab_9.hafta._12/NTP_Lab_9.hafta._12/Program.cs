using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_9.hafta._12
{
    class A
    {
        public int a;
        public A() { a = 1; }
    }

    class T : A
    {
        public int a;
        public T() { a = 2; }
    }

    class Program
    {
        static void Main()
        {
            T t = new T();
            Console.WriteLine(t.a);
            Console.Read();
            //çıktısı
            //    2
            //    şeklinde olur
        }

    }
}
