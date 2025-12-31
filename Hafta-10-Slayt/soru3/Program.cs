namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*• Bir not defteri yapılacak.
            • Bunun için not_defteri isimli klasör oluşturulacak.
            • İçeresine bugünün tarihi isimli bir metin dosyası oluşturulacak.
            • Program her çalıştığında saati yazacak sonra kullanıcının notunu yazacak bir uygulama yapılacak.
            • DateTime tumTarih = DateTime.Now;
            • string tarih = tumTarih.ToShortDateString();//sadece tarih aldı
            • string saat = tumTarih.ToLongTimeString();//sadece saat aldı*/

            Directory.CreateDirectory("C:\\not_defteri");
            DateTime  tumTarih = DateTime.Now;
            string tarih = tumTarih.ToShortDateString();
            FileStream fs = File.Create($"C:\\not_defteri\\{tarih}.txt");
            fs.Close();
            Console.WriteLine("Girmek istediğiniz notu giriniz:");
            string not = Console.ReadLine();
            File.AppendAllText($"C:\\not_defteri\\{tarih}.txt", not);
        }
    }
}
