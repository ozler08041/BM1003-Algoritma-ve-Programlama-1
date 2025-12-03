namespace soru11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) seçmesini isteyen, buna göre sonucu 
         hesaplayan programı yazınız.*/

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşlem türünü giriniz:");
            char islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '+':
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case '-':
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case '*':
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case '/':
                    Console.WriteLine(sayi1 / sayi2);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    break;
            }
        }
    }
}
