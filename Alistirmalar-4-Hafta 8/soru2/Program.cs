using System.Diagnostics.Metrics;

namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*Verilen üç tamsayı arasından en büyük sayıyı kontrol eden bir metot yazın. 
            Örnek Giriş : 
            1,2,3
            1,3,2
            1,1,1
            1,2,2
            Beklenen Çıkış : 
            3
            3
            1
            2*/
            
            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(enBuyuk(sayi1, sayi2, sayi3));
        }
        static int enBuyuk(int sayi1, int sayi2, int sayi3)
        {
            if (sayi1 >= sayi2 && sayi1 >= sayi3)
                return sayi1;
            else if (sayi2 >= sayi1 && sayi2 >= sayi3)
                return sayi2;
            else
                return sayi3;
        }
    }
}
