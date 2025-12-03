namespace soru35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan vize ve final notlarını alınız.
        Ortalama, vize × 0.4 + final × 0.6 formülüyle hesaplanacaktır.
        Hesaplanan ortalamaya göre harf notunu belirleyiniz:
        90 ve üzeri → AA
        80–89 → BA
        70–79 → BB
        60–69 → CB
        50–59 → CC
        50’den düşük → FF
        Sonuç olarak ekrana “Ortalama = …, Harf Notu = …” şeklinde yazdırınız.*/

            Console.Write("Vize notunuz:");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final notunuz:");
            double final = Convert.ToDouble(Console.ReadLine());

            double ort = (vize * 0.4) + (final * 0.6);

            if (ort >= 90)
                Console.WriteLine($"Ortalama = {ort}, Harf Notu = AA");
            else if (ort < 90 && ort >= 80)
                Console.WriteLine($"Ortalama = {ort}, Harf Notu = BA");
            else if (ort < 80 && ort >= 70)
                Console.WriteLine($"Ortalama = {ort}, Harf Notu = BB");
            else if (ort < 70 && ort >= 60)
                Console.WriteLine($"Ortalama = {ort}, Harf Notu = CB");
            else if (ort < 60 && ort >= 50)
                Console.WriteLine($"Ortalama = {ort}, Harf Notu = CC");
            else
                Console.WriteLine($"Ortalama = {ort}, Harf Notu = FF");
        }
    }
}
