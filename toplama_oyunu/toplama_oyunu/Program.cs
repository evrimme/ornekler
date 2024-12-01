using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplama_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Toplama işlemini öğretmeye çalışan bir oyun programı yazılacaktır. 
             Oyun başladığı zaman rastgele 2 tane 1 - 100 arasında sayı tutulacak,
            tutulan sayılar ekrana gösterilecek ve kullanıcıya bu sayıların toplamı nedir diye sorulacaktır.
            Eğer kullanıcı doğru cevap verirse
            “Tebrikler Bildiniz” değil ise “Üzgünüm Bilemediniz” diye mesaj verecektir.
            Her cevaptan sonra “Tekrar Oynamak istiyormusunuz(h - H / e - E) ?”
            şeklinde bir soru sorulacak ve eğer kullanıcı “h” veya “H” ile karşılık verirse oyun sonlanacaktır 
            aksi durumda oyun tekrar başlayacaktır.
            Kullanıcının puanı her doğru cevap için 5 puan artacak, her yanlış cevap için ise 2 puan azalacaktır.
            Oyun sonlandığında kullanıcının verdiği doğru cevap sayısı, yanlış cevap sayısı ve puanı ekranda listelenmelidir.
            Bu işlemleri yapan programın kodlarını yazınız. */
            Random rnd = new Random();
            int sayi1 = 0;
            int sayi2 = 0;
            int dogru_sayisi = 0;
            int yanlis_sayisi = 0;
            int puan = 0;
            for (; ; )
            {
                for (int i = 0; i < 2; i++)
                {
                    sayi1 = rnd.Next(1, 101);
                    sayi2 = rnd.Next(1, 101);
                }
                Console.WriteLine("\n Tutulan sayılar: {0} ve {1} ", sayi1, sayi2);
                int toplam = sayi1 + sayi2;
                Console.WriteLine("Bu sayıların toplamı nedir?");
                int cevap = int.Parse(Console.ReadLine());
                if (cevap == toplam)
                {
                    Console.WriteLine("Tebrikler Bildiniz");
                    puan = puan + 5;
                    dogru_sayisi++;
                }
                else
                {
                    Console.WriteLine("Üzgünüz Bilemediniz");
                    puan = puan - 2;
                    yanlis_sayisi++;
                }
                Console.WriteLine("\n Tekrar oynamak istiyor musunuz?(h-H)/(e-E)");
                char secim = Console.ReadKey().KeyChar;
                if (secim == 'h' || secim == 'h')
                {
                    break;
                }
            }
            Console.WriteLine("\nKullanıcının verdiği doğru cevap sayısı= " + dogru_sayisi);
            Console.WriteLine("Kullanıcının verdiği yanlış cevap sayısı= " + yanlis_sayisi);
            Console.WriteLine("\n Son puan durumu: " + puan);
            Console.ReadKey();
        }
    }
}
