using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_eleman_siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dışarıdan bir n sayısı giriliyor. Bu n elemanlı dizinin rastgele (0,100) atanan 
             elemanlarını sıralayarak ekrana yazdıran programı yazınız */
            int n;
            Console.Write("n sayısı:");
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                dizi[i] = rnd.Next(0, 101);
            }
            Array.Sort(dizi);
            foreach (int i in dizi)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
