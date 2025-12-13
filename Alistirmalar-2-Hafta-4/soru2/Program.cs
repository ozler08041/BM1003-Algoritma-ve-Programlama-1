namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 sayıyı kullanıcıdan alıp bunların ortalamasını ve toplamını bulan bir C# programı yazın.

            Console.Write("10 sayı giriniz:");
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            Console.WriteLine("Toplam: " + toplam);
        }
    }
}
