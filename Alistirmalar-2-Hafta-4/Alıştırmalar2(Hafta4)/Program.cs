namespace Alıştırmalar2_Hafta4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İlk 10 doğal sayının toplamını bulan bir C# programı yazın.
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);
        }
    }
}
