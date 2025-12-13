namespace soru14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 10 adet tamsayı sınav notuna göre, ortalamanın üstünde olanları ekrana
            yazan programı yazınız.Örnek: 
            10 adet notu giriniz:
            56
            42
            … 
            75
            13
            Çıktı:
            Sınıfın ortalaması = 53.25
            ortalamadan yüksek olan notlar: 
            56
            75*/
            int toplam = 0;
            int[] notlar = new int[10];
            Console.WriteLine("10 adet notu giriniz:");
            for (int i = 0; i < 10; i++)
            {
                notlar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += notlar[i];
            }
            double ortalama = toplam / 10.0;
            Console.WriteLine("Sınıfın ortalaması = " + ortalama);
            Console.WriteLine("Ortamadan yüksek olan notlar:");
            for (int i = 0; i < 10; i++)
            {
                if (notlar[i] > ortalama)
                {
                    Console.WriteLine(notlar[i]);
                }
            }

        }
    }
}
