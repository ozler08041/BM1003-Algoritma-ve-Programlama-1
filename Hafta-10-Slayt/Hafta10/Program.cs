using System.Data;
using System.Security.Cryptography;

namespace Hafta10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Derste çözdüğümüz soru...
            string yapılacaklar = "C://Klasör";
            if(!Directory.Exists(yapılacaklar))
            {
                Directory.CreateDirectory("C://Klasör");
            }

            if (!File.Exists("C://Klasör//yapılacaklar.txt"))
            {
                FileStream yap = File.Create("C://Klasör//yapılacaklar.txt");
                yap.Close();
            }
            
            Console.WriteLine("Yapılacak işlerinizi giriniz:");
           
            int sayac = 0;
            while (true)
            {
                string yapılacak = Console.ReadLine();
                if (yapılacak=="2")
                    break;
                File.AppendAllText("C://Klasör//yapılacaklar.txt", yapılacak);
                File.AppendAllText("C://Klasör//yapılacaklar.txt", DateTime.Now.ToString("yyyy-M-d HH:mm/n"));
                sayac++;
            }
            Console.WriteLine(sayac + " adet görev listeye eklendi.");
            
        }
    }
    
}
