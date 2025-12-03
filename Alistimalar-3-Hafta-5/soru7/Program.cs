namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10 elemanlı bir sayı dizisinde en küçük elemanının bu dizinin kaçıncı elemanı olduğunu bulan 
            programı yazınız.*/

            int[] dizi = new int[10];
            Random rsgl = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rsgl.Next(0, 101);
            }
            int enk = dizi[0];
            int enksira = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (enk > dizi[i])
                {
                    enk = dizi[i];
                    enksira = i;
                }
            }

            Console.WriteLine($"Bu dizinin en küçük elemanı {enk}'dür ve sırası da {enksira}'dır.");
        }
    }
}
