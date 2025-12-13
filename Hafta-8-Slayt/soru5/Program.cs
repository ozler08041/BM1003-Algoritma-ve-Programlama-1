namespace soru5
{
    internal class Program
    {
        // Klavyeden integer değer okuyan metot yazınız.
        static int sayiOku()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
                int sayi1 = sayiOku();
                int sayi2 = sayiOku();
                Console.WriteLine(sayi1 + sayi2);
        }
    }
}
