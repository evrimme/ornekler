using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_uzerinde_islemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Verilen bir dizi üzerinde aşağıdaki işlemleri yapın:
            a) Dizideki en büyük ve en küçük sayıyı bulun.
            b) Dizideki en büyük sayının karesini ve en küçük sayının küpünü hesaplayın.
            c) Dizideki tüm pozitif sayıların toplamını ekrana yazdırın */
            Random rnd = new Random();
            int[] dizi = new int[10];
            int enk = int.MaxValue;
            int karesi = 0;
            int kupu = 0;
            int enb = int.MinValue;
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = rnd.Next(-50, 51);

                if (enk > dizi[i])
                {
                    enk = dizi[i];
                }
                else if (enb < dizi[i])
                {
                    enb = dizi[i];
                }
                if (dizi[i] > 0)
                {
                    toplam = toplam + dizi[i];
                }
            }
            karesi = enb * enb;
            kupu = enk * enk * enk;           
            foreach (int i in dizi)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n Dizideki en büyük sayı= " + enb);
            Console.WriteLine("\n Dizideki en küçük sayı= " + enk);
            Console.WriteLine("\n En küçük sayının küpü= " + kupu);
            Console.WriteLine("\n En büyük sayının karesi= " + karesi);
            Console.WriteLine("\n Pozitif sayıların toplamı= " + toplam);
            Console.ReadKey();

        }
    }
}
