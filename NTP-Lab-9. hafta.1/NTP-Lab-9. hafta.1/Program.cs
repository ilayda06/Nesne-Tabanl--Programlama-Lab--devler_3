using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_9.hafta._1
{class A
    {
        public int x;
        public int y;
        protected int z;
        public A()
        {
            x = 1;
            y = 2;
            z = 3;
            Console.WriteLine("A yapıcısı çalıştı...");
        }
    
        public void Listele()
        {
            Console.WriteLine("x={0}; y={1}; z={2} ;", x, y, z);
        }
    }
    class T : A
    {
        public string s;
        public T()
        {
            s = "Türemiş Sınıf";
            Console.WriteLine("T yapıcısı çalıştı ");

        }
        public void Yaz()
        {
            Console.WriteLine("s={0};x={1};z={2};",s,x,z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            T t = new T();
            t.Listele();
            t.Yaz();
            Console.ReadLine();
            //çıktısı
            //    A yapıcısı çalıştı...
            //    T yapıcısı çalıştı
            //    x = 1; y = 2; z = 3;
            //    s = Türemiş Sınıf; x = 1; z = 3;
            //şeklinde oldu
        }
    }
}
