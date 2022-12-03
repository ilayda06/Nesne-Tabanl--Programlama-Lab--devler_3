using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_Ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pozitifler = new int[60] ;
            int[] negatifler = new int[60] ;
            Random r = new Random();
            int sayı;
            
            
            for(int i = 0; i <60; i++)
            {
                sayı = r.Next(-100, 100);
                if (sayı < 0)
                {
                    
                    negatifler[i] = sayı;
                    
                }
                else if (sayı == 0)
                {
                    
                }
                else
                {
                    
                    pozitifler[i] = sayı;
                    
                }

              
            }
            Console.WriteLine("Pozitif olanlar");
            foreach (int a in pozitifler)
            {
                if (a != 0)
                {
                    Console.Write(a + " ");
                }
                else
                {

                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("Negatif olanlar");
            foreach (int b in negatifler)
            {
                if (b != 0)
                {
                    Console.Write(b + " ");
                }
                else
                {

                }

            }
            Console.WriteLine("\n");
            
            Console.ReadLine();
        }
    }
}
