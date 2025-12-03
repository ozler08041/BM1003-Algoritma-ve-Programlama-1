namespace soru29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan iki kesir alınız: birinci kesir için a ve b, ikinci kesir için c ve d değerlerini (pay 
        ve payda) giriniz. Paydalar 0 olamaz. Girilen iki kesri karşılaştırarak, birinci kesir büyükse 
        "a/b > c/d", küçükse "a/b < c/d", eşitse "a/b = c/d" şeklinde sonucu ekrana yazdırınız.*/

            Console.WriteLine("İlk kesirin payını giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İlk kesirin paydasını giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkınci kesirin payını giriniz:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci kesirin paydasını giriniz:");
            int d = Convert.ToInt32(Console.ReadLine());

            if (a / b > c / d)
                Console.WriteLine($"{a} / {b} > {c} / {d} dir.");
            else if (a / b < c / d)
                Console.WriteLine($"{a} / {b} < {c} / {d} dir.");
            else
                Console.WriteLine($"{a} / {b} = {c} / {d} dir.");
        }
    }
}
