namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan harf alınız ve 
        sesli mi yoksa sessiz mi olduğunu 
        bulunuz(switch case ile).*/
            Console.Write("Bir harf giriniz:");
            char harf = Convert.ToChar(Console.ReadLine());

            switch (harf)
            {
                case 'a':
                case 'e':
                case 'ı':
                case 'i':
                case 'o':
                case 'ö':
                case 'u':
                case 'ü':
                case 'A':
                case 'E':
                case 'I':
                case 'İ':
                case 'O':
                case 'Ö':
                case 'U':
                case 'Ü':
                    Console.WriteLine(harf + " harfi sesli harftir.");
                    break;
                default:
                    Console.WriteLine("Sesli harf değildir!");
                    break;
            }
        }
    }
}
