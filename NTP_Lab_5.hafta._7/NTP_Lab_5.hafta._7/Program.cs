using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_5.hafta._7
{
    class Dortgen
    {
        public static int En = 30;
        public static int Boy = 23;
        public static int Alan()
        { int Alan = En * Boy; return Alan; }
        static void Main()
        { yaz d1 = new yaz(); d1.Yaz(); }
    }
    class yaz
    {
        public void Yaz()
        {
            Console.WriteLine
            ("En:{0,5}", Dortgen.En);
            Console.WriteLine
            ("Boy:{0,5}", Dortgen.Boy);
            Console.WriteLine
            ("Alan:{0,5}", Dortgen.Alan());
            Console.ReadLine();
        //    çıktısı
        //En: 30
        //Boy: 23
        //Alan: 690
        //        şeklinde olur
        }
    }
   
}
