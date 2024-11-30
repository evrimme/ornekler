using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_kontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı alarak, bu sayının asal olup olmadığını kontrol eden bir program yazın.

            Console.Write("Bir sayı giriniz: "); // kullanıcıdan sayı alındı.
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 0;  // for döngüsünde eğer i , sayi değişkenini bölüyorsa sayac artacak
                            // ve bunun üzerinden koşulları sağlayacağız.
          for (int i=2; i<sayi; i++)
             {
                if(sayi%i==0) // i değeri sayi değişkenini tam bölüyorsa sayaci artırıyoruz.
                {
                    sayac++;
                }             
             }
            if(sayac!=0 || sayi<=1) // sayac değeri 0 kalırsa sayı asaldır fakat 0 değilse sayı asal değildir.                              
            {
              Console.WriteLine("Girdiğiniz sayı, asal sayı değildir.");
            }           
            else
            {
                Console.WriteLine("Girdiğiniz sayı, asal sayıdır.");
            }
            Console.ReadKey();
        }
    }
}
