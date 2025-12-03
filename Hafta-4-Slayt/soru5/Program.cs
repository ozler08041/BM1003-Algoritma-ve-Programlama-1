namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1′den 100′e kadar olan 5’in katlarını ve en son toplamlarını ekrana
        yazan C# kodunu yazınız. (for döngüsü)*/

            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    toplam += i;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Toplam:" + toplam);
        }
    }
}
