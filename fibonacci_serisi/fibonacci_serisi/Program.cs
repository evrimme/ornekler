using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_serisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı alarak, bu sayıya kadar olan Fibonacci serisini yazdıran bir program oluşturun.
            // fibonacci kuralı sayının kendisinden önceki iki sayının toplamından oluşmasıdır. (0 1 1 2 3 5 8 13...)
            Console.Write("Sayı giriniz: "); //kullanıcıdan sayı alındı
            int sayi = int.Parse(Console.ReadLine());            
            int[] dizi = new int[sayi];  //kullanıcıdan alınan sayıya kadar olan sayıları
                                         // tutmak için dizi oluşturuldu
            dizi[0] = 0; // fibonacci kuralına göre ilk eleman 0'dır
            if(sayi>1)
            {
                dizi[1] = 1; //fibonacci kuralına göre ikinci eleman 1'dir
            }
            for(int i=2; i<sayi; i++) // fibonacci serisini sağlayacak döngü açıldı
            {
                dizi[i] = dizi[i - 1] + dizi[i - 2];
                
            }
            Console.Write("Fibonacci Serisi: "); 
            for (int i = 0; i < sayi; i++) // kullanıcının girdiği sayıya kadar olan fibonacci serisi yazdırıldı
            {
                Console.Write(dizi[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
