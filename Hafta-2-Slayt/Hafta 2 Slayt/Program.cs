namespace Hafta_2_Slayt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınız:");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız:");
            string soyad = Console.ReadLine();

            Console.WriteLine("Merhaba " + ad + " " + soyad + ", Tokat Gaziosmanpaşa Üniversitesine Hoşgeldin.");
            Console.WriteLine("Başarılar!");
        }
    }
}
