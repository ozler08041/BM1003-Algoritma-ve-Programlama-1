namespace soru16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Belirli bir karakterin ASCII değerini bulan bir C# Sharp programı yazın. 
            ASCII tablosu: https://tr.wikipedia.org/wiki/ASCII 
            Örnek Çıktı: 
            1'in Ascii değeri: 49 
            A'nın Ascii değeri: 65 
            a'nın Ascii değeri: 97 
            #'nin Ascii değeri: 35 */
            Console.WriteLine("Bir karakter giriniz:");
            char karakter = Convert.ToChar(Console.ReadLine());
            int asciiDegeri = (int)karakter;
            Console.WriteLine(karakter + " karakterinin ASCII değeri: " + asciiDegeri);

        }
    }
}
