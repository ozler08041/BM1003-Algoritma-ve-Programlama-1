using System.Security.Cryptography;

namespace soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*C dizininde Deneme isimli bir klasör olup olmadığı kontrol edilecek.
            • Eğer klasör varsa kullanıcıdan izin alınarak silinecek ve yeni klasör
            oluşturacak.
            • Eğer klasör yoksa doğrudan Deneme isimli bir klasör oluşturacak
            uygulamayı yazınız.*/
            if (Directory.Exists("C:\\Deneme"))
            {
                Console.WriteLine("Klasör mevcut.");
                Console.WriteLine("Klasör silinsin mi?(E yada H)");
                char izin = Convert.ToChar(Console.ReadLine());
                if (izin == 'E')
                {
                    Directory.Delete("C:\\Deneme", true);
                    Directory.CreateDirectory("C:\\Deneme2");
                }
                else if (izin !='E' && izin!='H')
                    Console.WriteLine("Geçersiz giriş!");
            }
            else
            {
                Console.WriteLine("Klasör mevcut değil. Oluşturuluyor...");
                Directory.CreateDirectory("C:\\Deneme");
            }
        }
    }
}
