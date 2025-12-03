namespace soru20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Girilen bir sayının 5’in kuvveti olup olmadığını hesaplayınız. 
            Örnek: 
            125 -> 5’in kuvvetidir. 
            10 -> 5’in kuvveti değildir.*/
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool kuvvetMi = false;
            if (sayi < 1)
                kuvvetMi = false;
            else
            {
                while (sayi % 5 == 0)
                    sayi /= 5;
                if (sayi == 1)
                    kuvvetMi = true;
            }
            if (kuvvetMi)
                Console.WriteLine("5'in kuvvetidir.");
            else
                Console.WriteLine("5'in kuvveti değildir.");
        }
    }
}
