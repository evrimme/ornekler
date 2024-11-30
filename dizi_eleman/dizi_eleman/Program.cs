using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_eleman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir dizi uzunluğu ve ardından dizi elemanlarını alarak,
            //dizideki en büyük ve en küçük sayıyı bulan bir program yazın.

            int enk = 0; // dizinin en küçük elemanını atayacağım değişkeni tanımladım.
            int enb = 0; // dizinin en büyük elemanını atayacağım değişkeni tanımladım.          
            Console.Write("Dizi uzunluk değeri giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Dizinin {0}. elemanını giriniz: ",i+1);
                int eleman = int.Parse(Console.ReadLine());
                dizi[i] = eleman;
            }
            Array.Sort(dizi); //diziyi küçükten büyüğe doğru sıralayarak en küçük ve en büyük elemana daha kolay ulaşabiliyoruz.
            enk = dizi[0];
            enb = dizi[n - 1];
            foreach(int i in dizi)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("Dizinin en küçük elemanı: " + enk);
            Console.WriteLine("Dizinin en büyük elemanı: " + enb);
            Console.ReadKey();

        }
    }
}
