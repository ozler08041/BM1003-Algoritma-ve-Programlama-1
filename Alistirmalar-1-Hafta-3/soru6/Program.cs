namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sıcaklığı santigrat cinsinden okumak ve aşağıdaki sıcaklık durumuna göre uygun bir mesaj 
        görüntülemek için programı yazın:
        Sıcaklık < 0, ardından Dondurucu hava
        Sıcaklık 0-10, ardından Çok Soğuk hava
        Sıcaklık 10-20, ardından Soğuk hava
        Sıcaklık 20-30 ve ardından Normal Sıcaklık
        Sıcaklık 30-40 sonra Sıcak
        Sıcaklığı >=40 sonra Çok Sıcak*/

            Console.Write("Sıcaklık değerini giriniz:");
            int sicak = Convert.ToInt32(Console.ReadLine());

            if (sicak <= 0)
                Console.WriteLine("Dondurucu hava");
            else if (0 < sicak && sicak <= 10)
                Console.WriteLine("Çok soğuk hava");
            else if (10 < sicak && sicak <= 20)
                Console.WriteLine("Soğuk hava");
            else if (20 < sicak && sicak <= 30)
                Console.WriteLine("Normal sıcaklık");
            else if (30 < sicak && sicak <= 40)
                Console.WriteLine("Sıcak");
            else
                Console.WriteLine("Çok sıcak");
        }
    }
}
