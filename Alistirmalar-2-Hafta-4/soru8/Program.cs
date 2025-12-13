namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir tam sayının rakamlarının toplamını hesaplayan programı yazınız. 
            Giriş Verileri: 
            Bir tamsayı girin: 253
            Beklenen çıktı: 
            Rakamların toplamı: 10*/
            Console.Write("Bir tamsayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            while (sayi != 0)
            {
                toplam += sayi % 10;
                sayi /= 10;
            }
            Console.WriteLine("Rakamların toplamı: " + toplam);
        }
    }
}
