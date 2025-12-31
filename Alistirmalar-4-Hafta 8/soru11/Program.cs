namespace soru11
{
    internal class Program
    {
        static int UsunuAl(int taban, int us)
        {
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            Console.WriteLine($"{taban} sayısının {us}. kuvveti {sonuc}'dir.");
            return sonuc;
        }

        static void Main(string[] args)
        {
            /*Herhangi bir sayının herhangi bir dereceden kuvvetini(üssünü) bulan metodu yazınız.
            Örnek: 
            metot(2, 3)-> 2 ^ 3 = 8*/
            Random rnd = new Random();
            int us = rnd.Next(1, 11);           
            int taban = rnd.Next(1, 11);
            UsunuAl(taban, us);
        }
    }
}
