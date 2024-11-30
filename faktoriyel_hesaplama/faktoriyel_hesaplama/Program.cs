using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan bir sayı alarak, bu sayının faktöriyelini hesaplayan bir program yazın. */

            Console.Write("Bir sayı girin: "); //kullanıcıdan sayı alındı
            int sayi = int.Parse(Console.ReadLine());
            int faktoriyel = 1;
            for(int i=1; i<=sayi; i++) //faktöriyel hesaplaması için döngü açıldı
            {
                faktoriyel = faktoriyel * i; // i'yi artırıp faktoriyel değişkeniyle çarpıldı ve sonuç faktoriyel değişkeninde tutuldu
            }
            Console.WriteLine("Sonuç = " + faktoriyel); // sonuç ekrana yazdırıldı
            Console.ReadKey();
        }
    }
}
