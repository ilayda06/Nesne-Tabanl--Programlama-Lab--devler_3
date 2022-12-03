using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_NTP_Lab_9.hafta._3
{
    abstract class A
    {
        public int x;
        abstract public int y
        {
            set;
            get;
        }
        public A(int x)
        {
            this.x = x;
        }
        abstract public void Metot();
    }
    class S : A
    {
        int z;
        public S(int x) : base(x) { }
        public override int y
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public override void Metot()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            S s = new S(5);
            s.y = 2 * s.x;
            s.Metot();
            Console.ReadLine();
            //çıktısı
            //    5
            //    10
            //    şeklinde olur
            }
        }
    }

