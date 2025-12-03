namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan alınan iki sayı arasındaki farkın mutlak değerini hesaplayan ve ekrana 
        yazdıran bir program yazınız. Eğer fark 10'dan büyükse "Fark 10'dan büyüktür." şeklinde, 
        değilse "Fark 10'dan küçük veya eşittir." şeklinde ek bir mesaj da veriniz.*/

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 < 0 && sayi2 < 0)
            {

                if (sayi1 >= sayi2)
                {
                    int fark = (sayi1 - sayi2);
                    Console.WriteLine("Mutlak farkı:" + fark);
                    if (fark <= 10)
                        Console.WriteLine("Fark 10'dan küçüktür veya eşittir.");
                    else
                        Console.WriteLine("Fark 10'dan büyüktür.");
                }
                else
                {
                    int fark = (sayi2 - sayi1);
                    Console.WriteLine("Mutlak farkı:" + fark);

                    if (fark <= 10)
                        Console.WriteLine("Fark 10'dan küçüktür veya eşittir.");
                    else
                        Console.WriteLine("Fark 10'dan büyüktür.");
                }
            }
            else if (sayi1 < 0 && sayi2 >= 0)
            {
                int sayi1arti = sayi1 * (-1);
                int fark = (sayi1arti + sayi2);
                Console.WriteLine("Mutlak fark:" + fark);
                if (fark <= 10)
                    Console.WriteLine("Fark 10'dan küçüktür veya eşittir.");
                else
                    Console.WriteLine("Fark 10'dan büyüktür.");


            }
            else if (sayi2 <= 0 && sayi1 >= 0)
            {
                int sayi2arti = sayi2 * (-1);
                int fark = (sayi2arti + sayi1);
                Console.WriteLine("Mutlak fark:" + fark);
                if (fark <= 10)
                    Console.WriteLine("Fark 10'dan küçüktür veya eşittir.");
                else
                    Console.WriteLine("Fark 10'dan büyüktür.");
            }
            else
            {
                if (sayi1 >= sayi2)
                {
                    int fark = (sayi1 - sayi2);
                    Console.WriteLine("Mutlak fark:" + fark);
                    if (fark <= 10)
                        Console.WriteLine("Fark 10'dan küçüktür veya eşittir.");
                    else
                        Console.WriteLine("Fark 10'dan büyüktür.");
                }
                else
                {
                    int fark = (sayi2 - sayi1);
                    Console.WriteLine("Mutlak fark:" + fark);

                    if (fark <= 10)
                        Console.WriteLine("Fark 10'dan küçüktür veya eşittir.");
                    else
                        Console.WriteLine("Fark 10'dan büyüktür.");
                }
            }
        }
    }
}
