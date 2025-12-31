namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basit yapılacaklar (ToDo) listesi
            if(!Directory.Exists("C:\\Liste"))
            {
                Directory.CreateDirectory("C:\\Liste");
            }
            if (!File.Exists("C:\\Liste\\yapılacaklar.txt"))
            {
                FileStream fs = File.Create("C:\\Liste\\yapılacaklar.txt");
                fs.Close();
            }
            Console.WriteLine("Yapılacaklarınızı giriniz: ");
            int sayac = 0; 
            while (true)
            {
               
                string metin = Console.ReadLine();
                if (metin == "*")
                {
                    break;
                }
                File.AppendAllText("C:\\Liste\\yapılacaklar.txt", metin + " ");
                sayac++;
            }
            DateTime tarih = DateTime.Now;
            File.AppendAllText("C:\\Liste\\yapılacaklar.txt", tarih + " - Proje ödevi yapılacak.");
            Console.WriteLine(sayac +" adet görev listeye eklendi.");
        }
    }
}
