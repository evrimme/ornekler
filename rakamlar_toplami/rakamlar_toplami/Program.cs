using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rakamlar_toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan bir sayı alarak bu sayının basamaklarındaki rakamların toplamını
              hesaplayan programı yazın.*/
            Console.Write("Sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int basamak_toplam = 0;
            int birler;
            while (sayi != 0)
            {
                birler = sayi % 10; //birler basamağı değeri alındı
                basamak_toplam = basamak_toplam + birler; // birler basamağı değeri toplama eklendi
                sayi /= 10; //sayı bir basamak sağa kaydırıldı
            }
            Console.WriteLine("Basamak Toplamları = " + basamak_toplam);
            Console.ReadKey();
        }
    }
}
