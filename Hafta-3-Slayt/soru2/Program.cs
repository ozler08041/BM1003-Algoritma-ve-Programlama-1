namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan iki sayı alınsın ve toplamı, farkı, çarpımı, bölümü, modu ekrana yazılsın.
            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int carpim = sayi1 * sayi2;
            int bolum = sayi1 / sayi2;
            int mod = sayi1 % sayi2;
            Console.WriteLine("Toplamı:" + toplam);
            Console.WriteLine("Farkı:" + fark);
            Console.WriteLine("Çarpımı:" + carpim);
            Console.WriteLine("Bölümü:" + bolum);
            Console.WriteLine("Modu:" + mod);
            //Küsüratlı değerler için double kullanılabilirdi...
        }
    }
}
