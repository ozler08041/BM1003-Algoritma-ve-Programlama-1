namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Üç kenarı kullanıcı tarafından girilen üçgenin EŞKANAR, İKİZKENAR 
        yada ÇEŞİTKENAR bilgisini ekrana bastırınız.*/

            //3 kenarı kullanıcıdan alalım.
            Console.WriteLine("1. kenar uzunluğunu giriniz:");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. kenar uzunluğunu giriniz:");
            int k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. kenar uzunluğunu giriniz:");
            int k3 = Convert.ToInt32(Console.ReadLine());
            //Hafta 3 şablondaki bilgiler ile...

            if ((k1 + k2) >= k3 && (k3 + k2) >= k1 && (k3 + k1) >= k2)//Üçgen olma kuralı...
            {
                if (k1 == k2 && k2 == k3)
                    Console.WriteLine("Bu üçgen eşkenardır.");
                else if (k1 == k2 || k2 == k3 || k1 == k3)
                    Console.WriteLine("Bu üçgen ikizkenardır.");
                else
                    Console.WriteLine("Bu üçgen çeşit kenardır.");
            }
            else
                Console.WriteLine("Geçersiz değer girdiniz!");
        }
    }
}
