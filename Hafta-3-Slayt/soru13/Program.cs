namespace soru13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan iki sayı ve işlem türü (+, -, *, /, %) alınsın. İşleme göre 
            //sonucu bulan programı switch-case yapısını kullanarak yazınız.

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşlem türünü giriniz:");
            char islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '+':
                    Console.WriteLine("Sonuç:" + (sayi1 + sayi2));
                    break;
                case '-':
                    Console.WriteLine("Sonuç:" + (sayi1 - sayi2));
                    break;
                case '*':
                    Console.WriteLine("Sonuç:" + (sayi1 * sayi2));
                    break;
                case '/':
                    Console.WriteLine("Sonuç:" + (sayi1 / sayi2));
                    break;
                case '%':
                    Console.WriteLine("Sonuç:" + (sayi1 % sayi2));
                    break;
                default:
                    Console.WriteLine("Geçersiz değer girdiniz!");
                    break;
            }
        }
    }
}
