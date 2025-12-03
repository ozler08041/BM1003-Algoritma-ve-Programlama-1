namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sınavda başarılı olanların adını ve kaç puanla başarılı 
        olduğunu yazan programı yazınız*/

            string[] isim = { "Ali", "Ayşe", "Ahmet", "Aylin", "Adem", "Ayla", "Atike", "Asya", "Aslan", "Ayhan" };
            int[] puan = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };


            for (int i = 0; i < puan.Length; i++)
                if (puan[i] >= 60)
                    Console.WriteLine(isim[i] + " başarılı olmuştur ve puanı " + puan[i]);
        }
    }
}
