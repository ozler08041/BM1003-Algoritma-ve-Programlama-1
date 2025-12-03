namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İki tam sayıyı kabul eden ve eşit olup olmadıklarını kontrol eden programı yazın.

            Console.Write("1. tamsayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. tamsayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 != sayi2)
                Console.WriteLine("Tamsayılar eşit değildir.");
            else
                Console.WriteLine("Tamsayılar eşittir.");
        }
    }
}
