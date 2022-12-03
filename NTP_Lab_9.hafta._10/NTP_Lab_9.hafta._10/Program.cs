using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_9.hafta._10
{
    class Kedi
    {
        protected int ayakSayisi = 4;

        public void yakalaAv()
        {
            Console.WriteLine("Kedi sinifi Av yakaladi");
        }
    }

    class Kaplan : Kedi
    {
        public Kaplan()
        {
            Console.WriteLine("Ayak Sayisi= " + ayakSayisi);
        }
    }

    class deneme
    {
        public static void Main(string[] args)
        {
            Kedi kd = new Kedi();
            kd.yakalaAv();
            Kaplan kp = new Kaplan();
            Console.ReadLine();
            //çıktısı
            //    Kedi sinifi Av yakaladi
            //    Ayak Sayisi = 4
            //    şeklinde olur

        }
    }
}
