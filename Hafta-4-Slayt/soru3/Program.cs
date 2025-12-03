namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir üçgene ait 3 kenar klavyeden giriliyor. Bu üçgenin eşkenar,
        çeşitkenar, ikizkenar olduğunu ekrana yazdıran kodu yazınız ama
        mutlaka switch case kullanınız.*/

            Console.Write("1. Kenarı giriniz:");
            int knr1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Kenarı giriniz:");
            int knr2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Kenarı giriniz:");
            int knr3 = Convert.ToInt32(Console.ReadLine());
            int fks = 0;

            if (knr1 != knr2)
                fks++;
            if (knr1 != knr3)
                fks++;
            if (knr2 != knr3)
                fks++;
            switch (fks)
            {
                case 0:
                    Console.WriteLine("Çeşitkenar");
                    break;
                case 1:
                    Console.WriteLine("İkizkenar");
                    break;
                case 2:
                    Console.WriteLine("İkizkenar");
                    break;
                case 3:
                    Console.WriteLine("Eşkenar");
                    break;
                default:
                    break;
            }
        }
    }
}
