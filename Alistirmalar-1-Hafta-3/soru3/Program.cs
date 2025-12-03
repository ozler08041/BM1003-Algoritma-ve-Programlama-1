namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen gün adına göre haftanın kaçıncı günü olduğunu bulan programı yazınız. 

            Console.Write("Gün adını giriniz:");
            string gun = Console.ReadLine();
            //Küçük büyük harf uyumu nasıl yapılır? Tr deki harfler olmadığı için yapamadim.
            switch (gun)
            {
                case "pazartesi":
                case "Pazartesi":
                    Console.WriteLine("1");
                    break;
                case "salı":
                case "Salı":
                    Console.WriteLine("2");
                    break;
                case "çarşamba":
                case "Çarşamba":
                    Console.WriteLine("3");
                    break;
                case "perşembe":
                case "Perşembe":
                    Console.WriteLine("4");
                    break;
                case "cuma":
                case "Cuma":
                    Console.WriteLine("5");
                    break;
                case "cumartesi":
                case "Cumartesi":
                    Console.WriteLine("6");
                    break;
                case "pazar":
                case "Pazar":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş!");
                    break;
            }
        }
    }
}
