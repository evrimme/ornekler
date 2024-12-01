using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aranan_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elemanları 0-50 arasında olan ve kullanıcının girmiş olduğu 5 elemanlı bir dizide 
     yine kullanıcının girmiş olduğu sayının bulunup bulunmadığı eğer varsa kaç adet olduğunu bulan programı yazınız.*/
           
            int[] dizi = new int[5]; // sabit boyutlu dizi tanımlandı
            int sayac = 0; // kaç adet sorulduğu için sayac tutuldu
            for (int i = 0; i<5; i++)
            {
                Console.Write("Sayı giriniz: ");
               int sayi=int.Parse(Console.ReadLine());
                dizi[i] = sayi;
            }
            Console.Write("Aranacak sayıyı giriniz: ");
            int aranacak_sayi=int.Parse(Console.ReadLine());                    
            for(int i = 0; i<5; i++)
            {
                if (aranacak_sayi == dizi[i]) //aranan sayı dizide mevcutsa sayac 1 artırılır
                {
                    sayac++;
                }              
            }
            if(sayac==0) //sayac 0 a eşitse aranan sayı dizide yoktur 
            {
                Console.WriteLine("Aradığınız sayı dizide mevcut değildir.");
            }
            else 
            {
                Console.WriteLine("Aranan sayı {0}'dan {1} tane vardır.",aranacak_sayi,sayac);
            }
            Console.ReadKey();
        }
    }
}
