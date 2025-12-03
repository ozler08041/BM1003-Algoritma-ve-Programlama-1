namespace soru23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Girilen bir sayının yaklaşık olarak kare kökünü hesaplayan programı yazınız.Örnek:
        5 -> yaklaşık karekökü 2.25*/

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (double i = 0; i <= sayi; i += 0.01)
            {
                if (i * i >= sayi)
                {
                    Console.WriteLine($"{sayi} sayısının yaklaşık karekökü {i} dir.");
                    break;
                }
            }
        }
    }
}
