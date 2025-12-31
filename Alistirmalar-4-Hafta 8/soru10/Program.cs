using System.Diagnostics.Metrics;

namespace soru10
{
    internal class Program
    {
        /*Girilen 3 basamaklı bir sayının basamaklarının küplerinin toplamının kendisine eşit olup 
        olmadığını kontrol eden bir metot yazınız.*/
        static void esitMi(int sayi)
        {
            if(sayi<1000 && sayi>99)
            {
                int birler=sayi%10;
                int onlar=(sayi/10)%10;
                int yuzler=sayi/100;
                int kuptoplam=yuzler*yuzler*yuzler+onlar*onlar*onlar+birler*birler*birler;
                if (kuptoplam==sayi)
                {
                    Console.WriteLine($"{sayi}'nın basmaklarının küpleri kendisine eşittir.");
                }
                else
                {
                    Console.WriteLine($"{sayi}'nın basmaklarının küpleri kendisine eşit değildir.");
                }
            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("3 basamaklı bir sayı giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            esitMi(sayi);
        }
    }
}
