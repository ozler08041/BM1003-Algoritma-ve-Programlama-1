namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1′den 100′e kadar olan 5’in katlarını ve en son toplamlarını ekrana
        yazan C# kodunu yazınız. (while döngüsü)*/

            int toplam = 0;
            int sayi = 1;

            while (sayi <= 100)
            {
                if (sayi % 5 == 0)
                {
                    Console.Write(sayi + " ");
                    toplam += sayi;
                }
                sayi++;
            }
            Console.WriteLine();
            Console.WriteLine("Toplam:" + toplam);
        }
    }
}
