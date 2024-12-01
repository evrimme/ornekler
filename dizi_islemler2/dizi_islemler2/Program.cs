using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_islemler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 ile 50 arasında rastgele sayılar içeren bir dizi oluşturun ve aşağıdaki işlemleri yapın:
            a) 15'ten küçük olan sayıların çarpımını hesaplayın. 
            b) 25'ten büyük olan sayıların sayısını bulun.
            c) Dizideki tüm sayıların karelerinin toplamını ekrana yazdırın. */

            Random rand = new Random();
            int[] dizi = new int[50]; // rastgele 50 sayıyı tutan diziyi oluşturdum         
            int sayac = 0; // adet sorulduğu için sayac tutuldu
            int karesi;
            int karesi_toplam = 0;
            int carpim = 1;
            for (int i = 0; i < 50; i++)
            {
                dizi[i] = rand.Next(1, 51); // 50 adet sayının 1 ile 50 arasında rastgele sayılara ataması yapıldı
                if (dizi[i] < 15) // a şıkkının koşulunu yazıldı
                {
                    carpim = carpim * dizi[i];
                }
                if (dizi[i] > 25) // b şıkkının koşulu yazıldı
                {
                    sayac++; // bu koşul sağlanırsa sayac artırılır
                }
                karesi = dizi[i] * dizi[i];
                karesi_toplam = karesi_toplam + karesi;
            }
            foreach (int i in dizi)
            {
                Console.Write(i);
                Console.Write(' ');
            }
            Console.WriteLine("\n Tüm sayıların karelerinin toplamı= " + karesi_toplam);
            Console.WriteLine(" 25'ten büyük olan sayı adedi= " + sayac);
            Console.WriteLine(" 15'ten küçük olan sayıların çarpımı= " + carpim);
            Console.ReadKey();
        }
    }
}
