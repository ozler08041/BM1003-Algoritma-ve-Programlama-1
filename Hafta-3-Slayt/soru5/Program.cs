namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen iki sayıdan büyük olanı ekrana yazdıran 
         kodu yazınız.*/
            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
                Console.WriteLine("Büyük sayı:" + sayi1);
            else if (sayi2 > sayi1)
                Console.WriteLine("Büyük sayı:" + sayi2);
            else
                Console.WriteLine("Sayılar eşittir!");
        }
    }
}
