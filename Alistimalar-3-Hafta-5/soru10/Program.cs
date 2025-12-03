namespace soru10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen maksimum 20 karakterli bir kelimedeki sesli harflerin sayısının toplam 
            karakter sayısına göre oranını hesaplayınız.*/
            Console.WriteLine("Lütfen maksimum 20 karakterli bir kelime giriniz:");
            string kelime = Console.ReadLine();
            if (kelime.Length > 20)
            {
                Console.WriteLine("Girdiğiniz kelime 20 karakterden uzun olamaz.");
                return;
            }
            int sesliHarfSayisi = 0;
            string sesliHarfler = "aeıioöuüAEIİOÖUÜ";
            for (int i = 0; i < kelime.Length; i++)
            {
                if (sesliHarfler.Contains(kelime[i]))
                {
                    sesliHarfSayisi++;
                }
            }
            double oran = (double)sesliHarfSayisi / kelime.Length * 100;
            Console.WriteLine($"Kelimedeki sesli harflerin oranı: %{oran}");
        }
    }
}
