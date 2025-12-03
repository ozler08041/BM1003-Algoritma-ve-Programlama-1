namespace soru27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir üçgenin geçerli olup olmadığını kontrol ediniz (üçgen eşitsizliği). Geçerli değilse 
        “Geçersiz üçgen” yazdırınız (alan/tür hesaplaması yok).*/

            Console.WriteLine("1. kenar:");
            int knr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. kenar:");
            int knr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. kenar:");
            int knr3 = Convert.ToInt32(Console.ReadLine());
            if (knr1 > 0 && knr2 > 0 && knr3 > 0)
                if ((knr1 + knr2) > knr3 && (knr1 + knr3) > knr2 && (knr2 + knr3) > knr1)
                    Console.WriteLine("Bu değerlere sahip üçgen vardır.");
                else
                    Console.WriteLine("Geçersiz üçgen!");
            else
                Console.WriteLine("Uzunluk eksi olamaz!");
        }
    }
}
