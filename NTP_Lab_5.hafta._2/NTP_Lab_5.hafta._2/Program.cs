using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_5.hafta._2
{
    class Ogrenci
    {
        public ulong OgrenciNo=215541001;
        public string Ad="İlayda";
        public string Soyad="Can";
        public string Bolum="Yazılım Mühendisliği";
        public byte Sinif=2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine(ogr.OgrenciNo);
            Console.WriteLine(ogr.Ad);
            Console.WriteLine(ogr.Soyad);
            Console.WriteLine(ogr.Bolum);
            Console.WriteLine(ogr.Sinif);
            Console.ReadLine();
            //  çıktısı;
            //215541001
            //İlayda
            //Can
            //Yazılım Mühendisliği
            //2
            //    şeklinde oldu



        }
    }
}
