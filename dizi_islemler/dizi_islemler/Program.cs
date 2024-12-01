using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_islemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           20 elemanlı A dizisine [1-100] arasında rastgele sayılar atanıyor.
           Bu dizideki 50’den küçük sayıları ve kaç tane olduğunu ekrana yazdıran programı yazın */
            int[] A = new int[20];
            Random rnd = new Random();
            int sayac = 0;
            for (int i = 0; i < 20; i++)
            {
                A[i] = rnd.Next(1, 101);
                if (A[i] < 50)
                {
                    Console.Write(A[i]);
                    Console.Write(" ");
                    sayac++;
                }
            }
            Console.WriteLine("\n 50'den küçük {0} tane sayı vardır", sayac);
            Console.ReadKey();

        }
    }
}
