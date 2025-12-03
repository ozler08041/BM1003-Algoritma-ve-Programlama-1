namespace soru20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan iki sayı alın. Eğer ikinci sayı sıfır değilse bölme işlemini yapıp sonucu 
        yazdırın, aksi halde “Hata: Sıfıra bölme yapılamaz” mesajı veriniz.*/

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi2 != 0)
                Console.WriteLine($"Bölümü {(double)sayi1 / sayi2}'dir.");
            else
                Console.WriteLine("Hata: Sıfıra bölünemez!");
        }
    }
}
