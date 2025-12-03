namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sınavda başarılı olanların adını ve kaç puanla başarılı 
        olduğunu yazan programı yazınız(geçme notu 60)*/

            int[] puan = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int i = 0; i < puan.Length; i++)
            {
                if (puan[i] >= 60)
                    Console.WriteLine(i + ". öğrenci başarılı olmuştur ve " + puan[i] + " almıştır");

            }
        }
    }
}
