using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace diziler_islemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /* İki farklı tam sayı dizisi oluşturun. 
          Bu diziler üzerinde aşağıdaki işlemleri gerçekleştirin:
          a) Her iki dizinin aynı indeksli elemanlarının çarpımlarını hesaplayın ve bu değerleri yeni bir diziye aktarın.
          b) Yeni dizideki elemanların toplamını bulun.
          c) Yeni dizideki elemanların ortalamasını hesaplayın ve ekrana yazdırın.*/

            int[] dizi1 = new int[10];
            int[] dizi2 = new int[10];
            ArrayList dizi3 = new ArrayList();
            int carpim;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                dizi1[i] = rnd.Next(1, 11);
                dizi2[i] = rnd.Next(1, 11);
                carpim = dizi1[i] * dizi2[i];
                dizi3.Add(carpim);
            }
            int toplam = 0;
            foreach (int i in dizi3)
            {
                toplam = toplam + i;
            }
            int ortalama = toplam / dizi3.Count;
            Console.WriteLine(" İlk dizi");
            foreach (int i in dizi1)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n İkinci dizi");
            foreach (int i in dizi2)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n Son dizi");
            foreach (int i in dizi3)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\nToplam= " + toplam);
            Console.WriteLine("Ortalama= " + ortalama);
            Console.ReadKey();
        }
    }
}
