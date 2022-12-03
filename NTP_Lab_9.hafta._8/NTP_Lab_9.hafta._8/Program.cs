using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_9.hafta._8
{
    class oto
    {
        protected double motorgucu = 5;
        protected double tork = 800;
        protected string renk = "Sars";

        public oto(double guc, double tork, string renk)
        {
            motorgucu = guc;
            this.tork = tork;
            this.renk = renk;
        }

        public void ozellikgoster()
        {
            Console.WriteLine("Motor gücü = " + motorgucu);
            Console.WriteLine("Tork=" + tork);
            Console.WriteLine("Renk = " + renk);
        }

        public double MotorGucu
        {
            get { return motorgucu; }
            set { motorgucu = value; }
        }

        public double Tork
        {
            get { return tork; }
            set { tork = value; }

        }


        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }
    }

    class model1 : oto
    {
        public string Tur;
        public model1(string tur, double guc, double tork, string renk) : base(guc, tork, renk)
        {
            Tur = tur;
        }
        public void TurGoster()
        {
            Console.WriteLine("Tara" + Tur);
        }
    }

    class model2 : oto
    {
        public string Tur;
        public model2(string tur, double guc, double tork, string renk) : base(guc, tork, renk)
        {
            Tur = tur;
        }
        public void TurGoster()
        {
            Console.WriteLine("Türü" + Tur);
        }
    }

    class Program
    {
        public static void Goster(oto Oto)
        {
            // Console.WriteLine(Oto.Tur); ulaşamaz
            Console.WriteLine(Oto.MotorGucu);
            Console.WriteLine(Oto.Tork);
            Console.WriteLine(Oto.Renk);
        }

        static void Main(string[] args)
        {
            oto oto1 = new oto(75, 100, "Kırmızı");
            Goster(oto1);

            Console.WriteLine("----------");

            model1 oto2 = new model1("Fiat", 100, 110, "Beyaz");
            Goster(oto2);

            Console.WriteLine("----------");

            model2 oto3 = new model2("Renault", 100, 120, "Siyah");
            Goster(oto3);
            Console.ReadLine();
//            çıktısı
//                75
//                100
//                Kırmızı
//              ----------
//                100
//                110
//                Beyaz
//               ----------
//                100
//                120
//                Siyah
//                şeklinde olur
        }
    }

}
