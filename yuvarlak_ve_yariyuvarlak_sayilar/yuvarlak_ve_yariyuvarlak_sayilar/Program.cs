using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuvarlak_ve_yariyuvarlak_sayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Bir sayı giriniz: ");
            int m = int.Parse(Console.ReadLine());

            ArrayList yuvarlakSayilar = new ArrayList();
            ArrayList yariyuvarlakSayilar = new ArrayList();
            int sayac1 = 0;
            int sayac2 = 0;
            for (int i = n; i <= m; i++)
            {
                int toplam = 0;
                int carpim = 1;
                int sayi = i;

                while (sayi > 0)
                {
                    int basamak = sayi % 10;
                    toplam = toplam + basamak;
                    carpim = carpim * basamak;
                    sayi /= 10;
                }
                if (toplam == carpim)
                {
                    yuvarlakSayilar.Add(i);
                    sayac1++;
                }
                else if (toplam * 2 == carpim)
                {
                    yariyuvarlakSayilar.Add(i);
                    sayac2++;
                }
            }
            if (sayac1 != 0)
            {
                Console.WriteLine("\nYuvarlak sayılar");
                foreach (int eleman in yuvarlakSayilar)
                {
                    Console.WriteLine(eleman);
                }
            }
            else
            {
                Console.WriteLine("\nBu aralıkta yuvarlak sayı yoktur.");
            }
            if (sayac2 != 0)
            {
                Console.WriteLine("\nYarı yuvarlak sayılar");
                foreach (int eleman in yariyuvarlakSayilar)
                {
                    Console.WriteLine(eleman);
                }
            }
            else
            {
                Console.WriteLine("\nBu aralıkta yarı yuvarlak sayı yoktur.");
            }
            Console.ReadKey();
        }
    }
}
