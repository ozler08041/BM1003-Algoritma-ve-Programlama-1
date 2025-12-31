namespace soru8
{
    internal class Program
    {
        static void faktoriyel(int sayi)
        {
            if (sayi < 0)
            {
                Console.WriteLine("Geçersiz giriş!");
                
            }
            int fak = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fak *= i;
            }
            Console.WriteLine("Sonuç: " + fak);


        }
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int sayi =Convert.ToInt32(Console.ReadLine());
            faktoriyel(sayi);
        }
    }
}
