using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_NTP_Lab_9.hafta._2
{
    class Program
    {
        class X
        {
            protected int a;
            public X(int a)
            {
                Console.WriteLine("X " + a);
                this.a = a;
            }
            public int A
            {
                get
                {
                    Console.WriteLine("X Sınıfı=" + a);
                    return a;
                }
            }
        }
        class Y : X
        {
            protected int b;
            public Y(int a) : base(a)
            {
                Console.WriteLine("Y " + a);
                this.b = a;
            }
            new public int A
            {
                get
                {
                    Console.WriteLine("Y sınıfı=" + b);
                    return b;
                }
            }
        }        class tarih
        {
            static void Main(string[] args)
            {
                Y y = new Y(5);
                X yy = new X(6);
                int deneme = y.A;
                int deneme2 = yy.A;
                Console.ReadLine();
                //çıktısı
                //    X 5
                //    Y 5
                //    X 6
                //    Y sınıfı = 5
                //    X Sınıfı = 6
                //    şeklinde olur
            }
        }
    }
}
