namespace soru18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Onluk tabanda bir sayıyı ikilik tabanda sayıya çeviren bir program yazınız. 
            Giriş Verileri: 
            Bir Sayı Girin : 5 
            Beklenen çıktı: 
            İkili sayı: 101*/
            Console.Write("Bir Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string ikilik = "";
            while (sayi > 0)
            {
                int kalan = sayi % 2;
                ikilik = kalan + ikilik;
                sayi = sayi / 2;
            }
            Console.WriteLine("İkili sayı: " + ikilik);
        }
    }
}
