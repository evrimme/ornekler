using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_islemler_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*100'er elemanlı ve 1-200 aralığında rastgele tam sayılar içeren iki dizi (C1 ve C2) veriliyor
            Aşağıdaki adımları gerçekleştirin:
            Her iki dizinin aynı indeksli elemanlarının çarpımı, D1 adında bir diziye yerleştirilsin.
            D1 dizisinin elemanlarının ortalamasını hesaplayın
            ve bu ortalamadan küçük olan elemanları E1 isimli bir diziye aktarın.
            E1 dizisini büyükten küçüğe sıralayın ve tüm dizilerin içeriklerini ekrana yazdırın. */

            Random rnd = new Random();
            int[] C1 = new int[100];
            int[] C2 = new int[100];
            int[] D1 = new int[100];
            ArrayList E1 = new ArrayList();
            int ortalama = 0;
            int toplam = 0;
            for (int i = 0; i < 100; i++)
            {
                C1[i] = rnd.Next(1, 201);
                C2[i] = rnd.Next(1, 201);
                D1[i] = C1[i] * C2[i];
                toplam = toplam + D1[i];
            }
            ortalama = toplam / 100;
            for (int i = 0; i < 100; i++)
            {
                if (ortalama > D1[i])
                {
                    E1.Add(D1[i]);
                }
            }
            E1.Sort();
            E1.Reverse();
            Console.WriteLine("E1 dizisi: ");          
            foreach (int eleman in E1)
            {
                Console.Write(eleman);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
