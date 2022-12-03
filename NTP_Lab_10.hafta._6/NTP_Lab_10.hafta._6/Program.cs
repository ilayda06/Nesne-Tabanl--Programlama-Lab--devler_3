﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_10.hafta._6
{
    delegate void OlayYoneticisi();
    class Buton
    {
        OlayYoneticisi[] olay = new OlayYoneticisi[2];
        public event OlayYoneticisi ButonKlik
        {
            add
            {
                int i;
                for (i = 0; i < 2; ++i)
                    if (olay[i] == null)
                    {
                        olay[i] = value; break;
                    }
                if (i == 2) Console.WriteLine("Olaya en fazla iki metot eklenebilir.");
            }
            remove
            {
                int i;
                for (i = 0; i < 2; ++i)
                    if (olay[i] == value)
                    {
                        olay[i] = null; break;
                    }
                if (i == 2)
                    Console.WriteLine("Metot bulunamadı");
            }
        }
        public void Kliklendi()
        {
            for (int i = 0; i < 2; ++i)
                if (olay[i] != null)
                    olay[i]();
        }
    }
    class Pencere
    {
        int PencereNo;
        public Pencere(int no)
        {
            PencereNo = no;
        }
        public void ButonKlik()
        {
            Console.WriteLine("{0} nolu pencere olayı algıladı.", PencereNo);
        }
    }
    public class OlayTest
    {
        static void Main()
        {
            Buton buton = new Buton();
            Pencere p1 = new Pencere(1);

            Pencere p2 = new Pencere(2);
            buton.ButonKlik += new OlayYoneticisi(ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();
            buton.ButonKlik += new OlayYoneticisi(p1.ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();

            buton.ButonKlik += new OlayYoneticisi(p2.ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();
            buton.ButonKlik -= new OlayYoneticisi(p1.ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();
            buton.ButonKlik -= new OlayYoneticisi(ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();
            buton.ButonKlik -= new OlayYoneticisi(ButonKlik);
            buton.Kliklendi();

            Console.ReadKey();
        }
        public static void ButonKlik()
        {
            Console.WriteLine("Buton kliklendi");
            //programın çıktısı
            //Buton kliklendi

            //Buton kliklendi
            //1 nolu pencere olayı algıladı.

            //Olaya en fazla iki metot eklenebilir.
            //Buton kliklendi
            //1 nolu pencere olayı algıladı.

            //Buton kliklendi


            //Metot bulunamadı
        }
    }
}


