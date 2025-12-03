namespace soru13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tam sayılardan oluşan bir dizide aranan elemanın olup olmadığını bulan bir programı yazınız.
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 ,16, 17, 18, 19, 20 };
            Console.Write("Aranacak sayıyı giriniz: ");
            int aranacak = Convert.ToInt32(Console.ReadLine());
            bool bulundu = false;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == aranacak)
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu)
            {
                Console.WriteLine("Sayı dizide bulundu.");
            }
            else
            {
                Console.WriteLine("Sayı dizide bulunamadı.");
            }
        }
    }
}
