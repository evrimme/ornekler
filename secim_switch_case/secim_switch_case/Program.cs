using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secim_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dışarıdan 2 sayı giriliyor. Klavyeden 1'e basıldığında bu iki sayının toplamını, 
              2’ye basıldığında bu iki sayının farkını,
             3’e basıldığında bu iki sayının çarpımını hesaplayan ve bu işlemi switch ile yapan programı yazınız. */

            int sayi1;
            int sayi2;
            Console.Write("Sayı giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Sayı giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1:Toplam 2:Fark 3:Çarpım");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Toplam = " + (sayi1 + sayi2));
                    break;

                case 2:
                    Console.WriteLine("Fark = " + (sayi1 - sayi2));
                    break;

                case 3:
                    Console.WriteLine("Çarpım = " + (sayi1 * sayi2));
                    break;
            }
            Console.ReadKey();
        }
    }
}
