namespace soru3
{
    internal class Program
    {
        static void yakin(int sayi1, int sayi2)
        {
            int sayi1yakin = 100 - sayi1;
            int sayi2yakin = 100 - sayi2;
            if (sayi1 == sayi2)
                Console.WriteLine("0");
            else if (sayi1yakin < sayi2yakin)
                Console.WriteLine(sayi2yakin);
            else
                Console.WriteLine(sayi1yakin);

        }
        static void Main(string[] args)
        {
            /*Verilen iki tam sayıdan 100 değerine en yakın sayıyı kontrol eden bir metot yazınız.İki sayı
            eşitse 0 dönsün.
            Örnek Giriş : 
            78, 95
            95, 95
            99, 70
            Beklenen Çıkış : 
            95
            0
            99*/
            
            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            yakin(sayi1, sayi2);
        }
    }
}
