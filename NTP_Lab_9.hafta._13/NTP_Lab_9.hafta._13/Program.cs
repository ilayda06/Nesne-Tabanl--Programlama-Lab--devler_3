using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_9.hafta._13
{
    class A
    {
        public int a;
        public A(int a)
        {
            Console.WriteLine("a kurucusu");
            this.a = a;
        }
    }
    class B : A
    {
        public int b;
        public B(int a, int b) : base(a)
        {
            Console.WriteLine("b kurucusu");
            this.b = b;
        }
    }

    class C : B
    {
        public int c;

        public void yaz()
        {
            Console.WriteLine(" a b c" + a + b + c);
        }

        public C(int a, int b, int c) : base(a, b)
        {
            Console.WriteLine("c kurucusu");
            this.c = c;
        }
    }

    class deneme
    {

        static void Main(string[] args)
        {
            C cc = new C(3, 4, 5);
            cc.yaz();
            Console.ReadKey();
            //çıktısı
            //    a kurucusu
            //    b kurucusu
            //    c kurucusu
            //    a b c345
            //    şeklinde olur
        }
    }
}

