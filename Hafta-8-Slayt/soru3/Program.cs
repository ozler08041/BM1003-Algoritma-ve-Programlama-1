namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir sayının faktöriyelini hesaplayan bir metot yazınız (void metot).
            static void faktoriel(int sayi)
            {
                if (sayi < 0)
                {
                    Console.WriteLine("Negatif sayıların faktöriyeli alınamaz!");
                    return;
                }
                int faktoriel = 1;
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriel *= i;
                    
                }
                Console.WriteLine($"{sayi}! = {faktoriel}");
            }
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            faktoriel(sayi);

        }
    }
}
