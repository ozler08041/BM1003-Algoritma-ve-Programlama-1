namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1 ile 1000 arasındaki sayılardan 12 ye tam bölünenlerin ortalamasını hesaplayıp ekrana
            yazdıran programı yazınız.*/
            int toplam = 0;
            int sayac = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 12 == 0)
                {
                    toplam += i;
                    sayac++;
                }
            }
            double ortalama = (double)toplam / sayac;
            Console.WriteLine("12'ye tam bölünenlerin ortalaması:" + ortalama);
        }
    }
}
