using System.Diagnostics.Metrics;

namespace soru17
{
    internal class Program
    {
        //Kendisine parametre olarak gönderilen bir tamsayı diziyi ekrana yazdıran bir metot yazınız.
        static void diziYaz(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rsgl = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rsgl.Next(0, 11);
                Console.Write(dizi[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");            
            diziYaz(dizi);
        }
    }
}
