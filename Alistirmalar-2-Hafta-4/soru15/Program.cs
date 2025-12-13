using static System.Net.Mime.MediaTypeNames;

namespace soru15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*İki sayıyı değiştirmek için bir C# programı yazınız. 
            Test Verileri: 
            İlk Sayıyı Girin: 5
            İkinci Sayıyı Girin: 6
            Beklenen Çıktı: 
            Değiştirmeden Sonra : 
            İlk Sayı : 6
            İkinci Sayı : 5*/
            Console.Write("İlk sayıyı girin:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Değiştirmeden Sonra:");
            int yenisayi1 = sayi1;
            int yenisayi2 = sayi2;
            yenisayi1 = sayi2;
            yenisayi2 = sayi1;
            Console.WriteLine("Birinci Sayı: " + yenisayi1);
            Console.WriteLine("İkinci Sayı: " + yenisayi2);
        }
    }
}
