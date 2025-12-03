namespace soru21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 ve 50 arasındaki asal sayıları bulunuz.

            bool asalMi = false;
            for (int sayi = 10; sayi <= 50; sayi++)
            {
                asalMi = true;
                for (int i = 2; i <= Math.Sqrt(sayi); i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    Console.Write(sayi+ " ");
                }
            }

        }
    }
}
