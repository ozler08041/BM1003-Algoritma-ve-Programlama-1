namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir üçgenin Eşkenar, İkizkenar veya Çeşitkenar olup olmadığını kontrol eden programı yazın.

            Console.Write("1. kenarı giriniz:");
            int knr1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. kenarı giriniz:");
            int knr2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. kenarı giriniz:");
            int knr3 = Convert.ToInt32(Console.ReadLine());

            if (knr1 < (knr2 + knr3) && knr2 < (knr1 + knr3) && knr3 < (knr1 + knr3))
            {
                if (knr1 == knr2 && knr2 == knr3)
                    Console.WriteLine("Üçgeniniz eşkenardır.");
                else if (knr1 == knr2 && knr2 != knr3 || knr1 == knr3 && knr3 != knr2 || knr2 == knr3 && knr3 != knr1)
                    Console.WriteLine("Üçgeniniz ikizkenardır.");
                else
                    Console.WriteLine("Üçgeniniz çeşitkenardır.");
            }
            else
                Console.WriteLine("Hatalı değerler girdiniz!");
        }
    }
}
