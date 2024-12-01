using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tek_cift_dizileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* 10 adet 1 ile 99 arasında rastgele üretilen sayıların tek olanlarını
           tek adlı diziye çift olanlarını çift adlı diziye aktaran ve bu iki diziyi
           ekrana yazdıran programı yazınız. (ArrayList ile)*/

            Random rnd = new Random();
            int[] dizi = new int[10];
            ArrayList tek = new ArrayList();
            ArrayList cift = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                dizi[i] = rnd.Next(1, 100);
                if (dizi[i] % 2 == 0)
                {
                    cift.Add(dizi[i]);
                }
                else
                {
                    tek.Add(dizi[i]);
                }
            }
            foreach (int i in dizi)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n Tek sayılar");
            foreach (int i in tek)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n Çift sayılar");
            foreach (int i in cift)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.ReadKey();

        }
    }
}
