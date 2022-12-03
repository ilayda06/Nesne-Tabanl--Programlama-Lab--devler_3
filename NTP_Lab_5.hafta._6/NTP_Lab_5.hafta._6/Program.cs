using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_5.hafta._6
{
    class Dortgen
    {
        public static int En = 20;
        public static int Boy = 5;
        public static int Alan()
        { int Alan = En * Boy;
            return Alan; }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("***************");
                Console.WriteLine("En:{0,5}", En);
                Console.WriteLine("Boy:{0,5}", Boy);
                Console.WriteLine("Alan:{0,5}", Alan());
                Console.WriteLine("***************");
                Console.ReadLine();
                //Boy, en değişkenlerini ve alan metotunu nesne kullanmadan çağırabilmek için static olmaları gerekir.
                //çıktısı 
                //***************
                //En:   20
                //Boy: 5
                //Alan: 100
                //***************
                //    şeklinde olur
            }
        }
    }
}
