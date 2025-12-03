namespace Hafta4_Slayt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen üç sayıyı büyükten küçüğe doğru sıralayınız 

            Console.WriteLine("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2 && sayi2 > sayi3)
                Console.WriteLine($"{sayi1}>{sayi2}>{sayi3}");
            else if (sayi1 > sayi3 && sayi3 > sayi2)
                Console.WriteLine($"{sayi1}>{sayi3}>{sayi2}");
            else if (sayi2 > sayi1 && sayi1 > sayi3)
                Console.WriteLine($"{sayi2}>{sayi1}>{sayi3}");
            else if (sayi2 > sayi3 && sayi3 > sayi1)
                Console.WriteLine($"{sayi2}>{sayi3}>{sayi1}");
            else if (sayi3 > sayi1 && sayi1 > sayi2)
                Console.WriteLine($"{sayi3}>{sayi1}>{sayi2}");
            else
                Console.WriteLine($"{sayi3}>{sayi2}>{sayi1}");
        }
    }
}
