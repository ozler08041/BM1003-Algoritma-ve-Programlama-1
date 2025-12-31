using System.Reflection.Metadata;

namespace soru7
{
    internal class Program
    {
        /*Bir kişinin doğum tarihini yıl olarak parametre alan ve kişinin yaşını hesaplayıp ekrana
        yazdıran bir metot tanımlayınız.*/
        static void yasHesapla(int yil)
        {
            int yas = DateTime.Now.Year - yil;
            Console.WriteLine(yas + " yaşındasınız.");
        }
        static void Main(string[] args)
        {
            Console.Write("Doğum yılınızı giriniz:");
            int yil = Convert.ToInt32 (Console.ReadLine());
            yasHesapla(yil);
        }
    }
}
