using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_4.hafta._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] d = { { 2, 3 }, { 4, 5 }, { 6, 7 } };

            d[2, 1] = 33;

            //d[2][1] = 33;
            Console.WriteLine(d.GetValue(2, 1));

            int[][] dd = new int[2][];

            dd[0] = new int[2];
            dd[1] = new int[1];

            dd[0][0] = 23;
            dd[0][1] = 234;
            dd[1][0] = 44;

            Random rnd = new Random();
            int[] dizi = new int[3];

            dizi[0] = rnd.Next(2, 10);
            dizi[1] = rnd.Next(50);
            dizi[2] = rnd.Next();

            Console.WriteLine(dizi.GetValue(2));

            Console.WriteLine(dd[1][0]);

            Console.ReadKey();
            //3x2'lik bir dizi oluşturuldu
            //d[2][1] = 33; satırı hata verir.

            //düzensiz dizi oluşturuldu

            //random metodu ile 3 tane rasgele sayı oluşturuldu
            //get.value ile dizi değişkeninin 2. indis elemanını (3.eleman) yazdı.

            //program çıktısı random 3 tane sayı
        }
    }
}
