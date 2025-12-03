namespace soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan bir sayı alınız. 1’den bu sayıya kadar olan sayıları aynı 
        satırda, aralarına virgül koyarak yazdırınız.
        Giriş: 5 → Çıkış: 1, 2, 3, 4, 5*/

            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (i == sayi)
                    Console.Write(i);
                else
                    Console.Write(i + ", ");
            }
        }
    }
}
