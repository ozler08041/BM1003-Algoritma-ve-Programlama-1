using System;
using System.Numerics;

namespace soru13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Girilen bir k sayısı tek ise 3 ile çarpılıp 1 ekleniyor, çift ise 2 ile bölünüyor. Bu işlem k sayısı 1
            olana kadar devam ediyor. Bu işlemin kaç adım sürdüğünü ve işlem sırasında k sayısının aldığı
            maksimum değeri ve k sayısının hangi sayıdan sonra hep çift olarak bire ulaştığını bulan C# 
            kodunu yazınız.*/
            Console.WriteLine("Bir k sayısı giriniz:");
            int k = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            int maxDeger = k;
            int ciftBaslangic = -1;
            while (k != 1)
            {
                if (k % 2 == 0)
                {
                    if (ciftBaslangic == -1)
                    {
                        ciftBaslangic = sayac;
                    }
                    k /= 2;
                }
                else
                {
                    k = 3 * k + 1;
                }
                if (k > maxDeger)
                {
                    maxDeger = k;
                }
                sayac++;
            }
            Console.WriteLine("İşlem " + sayac + " adım sürdü.");
            Console.WriteLine("İşlem sırasında k sayısının aldığı maksimum değer: " + maxDeger);
            if (ciftBaslangic != -1)
            {
                Console.WriteLine("k sayısının hep çift olarak 1'e ulaştığı adım: " + ciftBaslangic);
            }
            else
            {
                Console.WriteLine("k sayısı hiç çift olmadı.");
            }

        }
    }
}
