namespace soru16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan adını ve saati (0–23 arası tam sayı) girmesini isteyiniz. 
        Girilen saat bilgisine göre ekrana uygun selamlama mesajını yazdırınız:
        Eğer saat 0 ile 11 arasındaysa → “Günaydın [İsim]”
        Eğer saat 12 ile 17 arasındaysa → “Tünaydın [İsim]”
        Eğer saat 18 ile 23 arasındaysa → “İyi akşamlar [İsim]”*/

            Console.Write("Adınızı giriniz:");
            string ad = Console.ReadLine();
            Console.Write("Saati giriniz(0-23 arası tam sayı):");
            int saat = Convert.ToInt32(Console.ReadLine());

            if (0 <= saat && saat <= 11)
                Console.WriteLine("Günaydın " + ad);
            else if (12 <= saat && saat <= 17)
                Console.WriteLine("Tünaydın " + ad);
            else if (18 <= saat && saat <= 23)
                Console.WriteLine("İyi akşamlar " + ad);
            else
                Console.WriteLine("Geçersiz saat girdiniz!");
        }
    }
}
