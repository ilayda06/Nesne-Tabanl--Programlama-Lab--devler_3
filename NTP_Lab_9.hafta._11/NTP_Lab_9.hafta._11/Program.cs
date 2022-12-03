using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_9.hafta._11
{
    public class Hayvan
    {
        protected String a = "Hayvan.a";
        String b = "Hayvan.b"; //friendly
        private String c = "Hayvan.c";
        public String d = "Hayvan.d";
    }

    public class Kedi : Hayvan
    {

        public Kedi()
        {

            Console.WriteLine("Kedi olusturuluyor");
            Console.WriteLine(a);
            //Console.WriteLine(b); 
            //Console.WriteLine(c);  b ve c erişilemez
            Console.WriteLine(d);
        }
    }

    class deneme
    {
        public static void Main(string[] args)
        {
            Kedi k = new Kedi();
            Console.Read();
            //çıktısı
            //    Kedi olusturuluyor
            //    Hayvan.a
            //    Hayvan.d
            //şeklinde olur
        }
    }
    }
