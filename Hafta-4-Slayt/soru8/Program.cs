namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan iki sayı alın (örneğin 3 ve 9).
        Bu iki sayı dahil olmak üzere aradaki sayıların toplamını bulan 
        programı yazınız.
        Beklenen çıktı: 3 + 4 + 5 + 6 + 7 + 8 + 9 = 42*/

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            if (sayi1 < sayi2)
            {
                for (int i = 0; i < sayi2; sayi1++)
                {
                    i = sayi1;
                    toplam += sayi1;
                    if (sayi1 == sayi2)
                        Console.Write(sayi1 + "=");
                    else
                        Console.Write(sayi1 + " + ");
                }
                Console.Write(" " + toplam);
            }
            else
            {
                for (int i = 0; i < sayi1; sayi2++)
                {
                    i = sayi2;
                    toplam += sayi2;
                    if (sayi2 == sayi1)
                        Console.Write(sayi2 + "=");
                    else
                        Console.Write(sayi2 + " + ");
                }
                Console.Write(" " + toplam);
            }
        }
    }
}
