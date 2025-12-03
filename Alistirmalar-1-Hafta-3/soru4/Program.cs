namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Giriş olarak bir karakteri alan ve bunun sesli harf, rakam veya başka bir sembol olup 
        olmadığını kontrol eden programı yazın.*/
            Console.Write("Karakterinizi giriniz:");
            char krktr = Convert.ToChar(Console.ReadLine());

            switch (krktr)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'u':
                case 'U':
                case 'ü':
                case 'Ü':
                case 'o':
                case 'O':
                case 'ö':
                case 'Ö':
                case 'ı':
                case 'I':
                case 'i':
                case 'İ':
                    Console.WriteLine(krktr + " bir sesli harftir.");
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine(krktr + " bir rakamdır.");
                    break;
                default:
                    Console.WriteLine(krktr + " farklı bir semboldür.");
                    break;
            }
        }
    }
}
