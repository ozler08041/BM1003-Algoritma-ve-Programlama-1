using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace soru6
{
    internal class Program
    {
        /*Parametre olarak 2 tam sayıyı alan ve farklarının mutlak değerini geri döndüren bir metot
        tanımlayınız.*/
        static int mutlakfark(int sayi1, int sayi2)
        {
            int mutlak = Math.Abs(sayi1 - sayi2);
            return mutlak;
        }
        static void Main(string[] args)
        {
            Console.Write("1. sayı:");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayı:");
            int sayi2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç:" + mutlakfark(sayi1,sayi2));
        }
    }
}
