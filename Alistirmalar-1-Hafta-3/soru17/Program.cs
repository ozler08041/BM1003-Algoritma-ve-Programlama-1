namespace soru17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan kullanıcı adı ve şifre alınsın.
        Eğer kullanıcı adı = "admin" ve şifre = "1234" ise “Giriş başarılı”
        Aksi halde “Hatalı giriş” yazan programı yapınız.*/

            Console.Write("Kullanıcı adı:");
            string ad = Console.ReadLine();
            Console.Write("Şifre:");
            int sifre = Convert.ToInt32(Console.ReadLine());

            if (ad == "admin" && sifre == 1234)
                Console.WriteLine("Giriş başarılı.");
            else
                Console.WriteLine("Hatalı giriş!");
        }
    }
}
