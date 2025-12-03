namespace Hafta5_Slayt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İf else kullanarak bir hesap makinesi tasarlayınız.

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşlem türünü giriniz:");
            char islem = Convert.ToChar(Console.Read());

            if (islem == '+')
                Console.WriteLine(sayi1 + sayi2);
            else if (islem == '-')
                Console.WriteLine(sayi1 - sayi2);
            else if (islem == '*')
                Console.WriteLine(sayi1 * sayi2);
            else if (islem == '/')
                Console.WriteLine(sayi1 / sayi2);
            else
                Console.WriteLine("Hatalı işlem girdiniz!");
        }
    }
}
