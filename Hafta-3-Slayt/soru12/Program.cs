namespace soru12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan iki sayı ve işlem türü (+, -, *, /, %) alınsın. İşleme göre 
        sonucu bulan programı if/else yapısını kullanarak yazınız.*/

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşlem türünü giriniz:");
            char islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+')//char olduğu için '' kullandık.
                Console.WriteLine("Sonuç:" + (sayi1 + sayi2));
            else if (islem == '-')
                Console.WriteLine("Sonuç:" + (sayi1 - sayi2));
            else if (islem == '*')
                Console.WriteLine("Sonuç:" + (sayi1 * sayi2));
            else if (islem == '/')
                Console.WriteLine("Sonuç:" + (sayi1 / sayi2));
            else if (islem == '%')
                Console.WriteLine("Sonuç:" + (sayi1 % sayi2));
            else
                Console.WriteLine("Geçersiz giriş!");
        }
    }
}
