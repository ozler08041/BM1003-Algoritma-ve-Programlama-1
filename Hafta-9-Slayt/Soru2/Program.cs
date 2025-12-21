namespace Soru2
{
    internal class Program
    {
        static string[] esyalar = { "Kitap", "Laptop", "Telefon", "Kamera", "Tablet" };
        static int[] agırlıklar = { 5, 25, 10, 27, 17 };
        static string[] esyalar2 = new string[esyalar.Length + 1];
        static int[] agırlıklar2 = new int[agırlıklar.Length + 1];
        static void EsyaEkle(string item, int agırlık)
        {
            for (int i = 0; i < esyalar.Length; i++)
            {
                esyalar2[i] = esyalar[i];
                agırlıklar2[i] = agırlıklar[i];
            }
            esyalar2[esyalar2.Length - 1] = item;
            agırlıklar2[agırlıklar2.Length - 1] = agırlık;

        }
        static void EsyaSil(string item2)
        {
            for (int i = 0; i < esyalar2.Length; i++)
            {
                if (esyalar2[i] == item2)
                {
                    esyalar2[i] = null;
                    agırlıklar[i] = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("Silmek istediğiniz eşya bulunamadı.");
                }
            }

        }
        static void esyaListele()
        {
            for (int i = 0; i < esyalar2.Length; i++)
            {
                if (esyalar2[i] != null)
                {
                    Console.WriteLine($"{esyalar2[i]} - {agırlıklar2[i]} kg");
                }
            }
        }
        static int esyalarınToplamAgırlığı()
        {
            int toplam = 0;
            for (int i = 0; i < agırlıklar2.Length; i++)
            {
                toplam += agırlıklar2[i];
            }
            return toplam;
        }
        static int enAgırBul()
        {
            int enAgır = agırlıklar2[0];
            for (int i = 1; i < agırlıklar2.Length; i++)
            {
                if (agırlıklar2[i] > enAgır)
                {
                    enAgır = agırlıklar2[i];
                }
            }
            return enAgır;
        }
        static int enHafifBul()
        {
            int enHafif = agırlıklar2[0];
            for (int i = 1; i < agırlıklar2.Length; i++)
            {
                if (agırlıklar2[i] < enHafif)
                {
                    enHafif = agırlıklar2[i];
                }
            }
            return enHafif;
        }
        static void EsyaAra(string arananEsya)
        {
            bool bulundu = false;
            for (int i = 0; i < esyalar2.Length; i++)
            {
                if (esyalar2[i] == arananEsya)
                {
                    Console.WriteLine($"{arananEsya} bulundu ve ağırlığı {agırlıklar2[i]} kg.");
                    bulundu = true;
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Eklmek istediğiniz eşyayı giriniz:");
            string item = Console.ReadLine();
            Console.WriteLine("Eklediğiniz eşyanın ağırlığını giriniz:");
            int agırlık = Convert.ToInt32(Console.ReadLine());
            EsyaEkle(item, agırlık);
            Console.WriteLine("Silmek istediğiniz eşyayı giriniz:");
            string item2 = Console.ReadLine();
            EsyaSil(item2);
            esyaListele();
            int toplamAgırlık = esyalarınToplamAgırlığı();
            Console.WriteLine($"Esyaların toplam ağırlığı {toplamAgırlık} tır.");
            int enAgır = enAgırBul();
            Console.WriteLine($"En ağır eşya {enAgır} kg ağırlığındadır.");
            int enHafif = enHafifBul();
            Console.WriteLine($"En hafif eşya {enHafif} kg ağırlığındadır.");
            Console.WriteLine("Aramak istediğiniz eşyayı giriniz:");
            string arananEsya = Console.ReadLine();
            EsyaAra(arananEsya);
        }
    }
}
