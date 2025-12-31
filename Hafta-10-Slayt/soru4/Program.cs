namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"DersNotları" klasörü hazırlama

            if (!Directory.Exists("C:\\DersNotları"))
            {
                Directory.CreateDirectory("C:\\DersNotları");
            }
            if (!Directory.Exists("C:\\DersNotları\\Hafta1"))
            {
                Directory.CreateDirectory("C:\\DersNotları\\Hafta1");
            }
            if (!Directory.Exists("C:\\DersNotları\\Hafta2"))
            {
                Directory.CreateDirectory("C:\\DersNotları\\Hafta2");
            }
            if (!Directory.Exists("C:\\DersNotları\\Hafta3"))
            {
                 Directory.CreateDirectory("C:\\DersNotları\\Hafta3");
            }
            Console.WriteLine("DersNotlai klasörü hazır. Oluşturulan alt klasör sayısı: 3");
        }
    }
}
