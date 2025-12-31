using System;
using System.Drawing;
using System.Security.Cryptography;

namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*• Tekerleme.txt isimli bir dosya Deneme isimli klasöre yazılacaktır. Eğer
            zaten varsa kullanıcıdan onay alarak silinecek ve dosya yeniden
            oluşturulacaktır.
            • Console ekranından kullanıcıdan tekerleme istenilecek ve kullanıcı:
            • (Adem madene gitmiş. Adem madende badem yemiş. Madem ki
            Adem madende badem yemiş, niye bize getirmemiş) yazacaktır.
            • Sonra kullanıcıdan araması istenilen kelime istenecek ve kaç adet
            kelime bulunduğu hem konsol ekranına hem de yeni oluşturulacak
            Sonuc.txt dosyasına yazılacaktır.*/
;
            if (File.Exists("C:\\Deneme\\Tekerleme.txt"))
            {
                Console.WriteLine("Silinsin mi?(E yada H)");
                char izin=Convert.ToChar(Console.ReadLine());
                if (izin == 'E')
                {
                    File.Delete("C:\\Deneme\\Tekerleme.txt");
                    FileStream fs = File.Create("C:\\Deneme\\Tekerleme2.txt");
                    fs.Close();
                    Console.WriteLine("Tekerleme giriniz:");
                    string tekerleme = Console.ReadLine();
                    Console.WriteLine("Aramak istediğiniz kelimeyi giriniz:");
                    string kelime =Console.ReadLine();
                    string[] kelimeler = tekerleme.Split(' ');
                    int sayac = 0;
                    for(int i = 0; i < kelimeler.Length;i++)
                    {
                        if (kelimeler[i]==kelime)
                            sayac++;
                    }
                    Console.WriteLine($"Kelime {sayac} kere geçmektedir.");
                    FileStream fss = File.Create("C:\\Deneme\\Sonuc.txt");
                    fss.Close();
                    File.WriteAllText("C:\\Deneme\\Sonuc.txt", Convert.ToString(sayac));
                }
                else if (izin != 'H' && izin !='E')
                {
                    Console.WriteLine("Geçersiz giriş!");
                }
               
            }
            else
                Console.WriteLine("Dosya mevcut değil!");

        }
    }
}
