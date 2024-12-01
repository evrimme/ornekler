using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_islemler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /* Belirli bir aralıkta rastgele sayılar içeren bir dizi oluşturun ve bu dizide 
            aşağıdaki işlemleri gerçekleştirin:
            a) Çift sayıların ortalamasını hesaplayın.
            b) Tek sayıların toplamını bulun.
            c) Pozitif ve negatif sayıların miktarını ekrana yazdırın. */

            Random rand = new Random();
            int[] dizi = new int[50];
            int toplam = 0;
            int adet = 0;
            int tek_toplam = 0;
            int pozitif_sayac = 0;
            int negatif_sayac = 0;
            ArrayList cift_sayilar = new ArrayList();
            ArrayList tek_sayilar = new ArrayList();
            for (int i = 0; i < 50; i++)
            {
                dizi[i] = rand.Next(-100, 101);
                if (dizi[i] % 2 == 0)
                {
                    cift_sayilar.Add(dizi[i]);
                    toplam = toplam + dizi[i];
                    adet++;
                }
                if (dizi[i] % 2 != 0)
                {
                    tek_sayilar.Add(dizi[i]);
                    tek_toplam = tek_toplam + dizi[i];
                }
                if (dizi[i] < 0)
                {
                    negatif_sayac++;
                }
                if (dizi[i] > 0)
                {
                    pozitif_sayac++;
                }
            }
            int ortalama = toplam / adet;
            Array.Sort(dizi);
            foreach (int eleman in dizi)
            {
                Console.Write(eleman);
                Console.Write(" ");
            }
            Console.WriteLine("\n\n Çift sayılar dizisi\n");
            foreach (int eleman in cift_sayilar)
            {
                Console.Write(eleman);
                Console.Write(" ");
            }
            Console.WriteLine("\n\n Tek sayılar dizisi\n");
            foreach (int eleman in tek_sayilar)
            {
                Console.Write(eleman);
                Console.Write(" ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Çift sayıların ortalaması= " + ortalama);
            Console.WriteLine("Tek sayıların toplamı= " + tek_toplam);
            Console.WriteLine("Pozitif sayı miktarı= " + pozitif_sayac);
            Console.WriteLine("Negatif sayı miktarı= " + negatif_sayac);
            Console.ReadKey();
        
    }
    }
}
