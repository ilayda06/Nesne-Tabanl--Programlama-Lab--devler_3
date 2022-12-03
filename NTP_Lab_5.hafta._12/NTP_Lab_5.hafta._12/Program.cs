using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_5.hafta._12
{
    class Program
    {
        public int tpl;
        public static int Topla(int toplam)
        { int tpl = toplam;
            return tpl;
        }
        public int Toplama
        {
            get { return tpl; }
            set { tpl = value + tpl; }
        }
        static void Main(string[] args)
        {
            Program ekle = new Program();
            Console.WriteLine("Başlangıç değeri->" + ekle.Toplama);
            for (int i = 1; i < 100; i++) ekle.Toplama = i;
            Console.WriteLine("Sayıların toplamı" + ekle.Toplama);
            Console.ReadLine();
            //çıktısı
            //    Başlangıç değeri->0
            //    Sayıların toplamı4950
            //    şeklinde olur
        } }
    }

