using System.Diagnostics.Metrics;

namespace soru14
{
    internal class Program
    {
        /*Bir üçgenin iki dik kenarını parametre olarak alan ve hipotenüsünü hesaplayan bir metot
        yazınız.*/
        static void hipotenusHesapla(int dik1,int dik2)
        {
            int hipokare = dik1 * dik1 + dik2 * dik2;
            double hipo=Math.Sqrt(hipokare);
            Console.WriteLine("Hipotenüs: "+ hipo);
        }
        static void Main(string[] args)
        {
            Console.Write("1. dik kenarı giriniz:");
            int dik1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2. dik kenarı giriniz:");
            int dik2 = Convert.ToInt32(Console.ReadLine());
            hipotenusHesapla(dik1,dik2);
        }
    }
}
