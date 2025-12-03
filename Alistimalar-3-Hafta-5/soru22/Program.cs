namespace soru22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 -100 arasında kaç asal sayı vardır bulunuz. 
            bool asalMi = false;
            for (int sayi = 1; sayi <= 100; sayi++)
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
                if (asalMi && sayi != 1)
                {
                    Console.Write(sayi + " ");
                }
            }
        }
    }
}
