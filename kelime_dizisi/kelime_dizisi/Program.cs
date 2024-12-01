using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelime_dizisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elemanları kullanıcının girdiği 5 elemanlı string bir dizide en uzun metni,
             en uzun metnin karakter sayısını 
             ve en uzun metnin index numarasını bulan programı yazınız.*/

            string[] dizi = new string[5];          
            int en_uzun=0;
            int index=0;
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Kelime giriniz:");
                string kelime=Console.ReadLine();
                dizi[i] = kelime;
                if (dizi[i].Length>en_uzun)
                {
                    en_uzun = dizi[i].Length;
                    index = i;
                }                   
            }
            Console.WriteLine("En uzun kelime: " + dizi[index]);
            Console.WriteLine("En uzun kelimenin harf sayısı: " + en_uzun);
            Console.WriteLine("En uzun kelimenin indexi: " + index);
            Console.ReadKey();
        }
    }
}
