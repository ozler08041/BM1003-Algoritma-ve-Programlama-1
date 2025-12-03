namespace soru15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Belirli bir tamsayı dizisindeki maksimum öğeyi bulan, tüm öğeleri maksimum öğeyle 
            değiştiren bir C# programı yazın. 
            Örnek Giriş : 
            { 10, 20, -30, -40 } 
            Beklenen Çıkış : 
            Yeni dizi: 20 20 20 20*/
            int[] dizi = { 11 , 20 , 39 , 47 , 55 , -50, - 43};
            Console.WriteLine("Dizimiz:");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine();
            int enb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > enb)
                {
                    enb = dizi[i];
                }
            }
            int[] enbdizi = new int[dizi.Length];
            Console.Write("Yeni dizi:");
            for (int i = 0; i < dizi.Length; i++)
            {
                enbdizi[i] = enb;
                Console.Write(enbdizi[i]+ " ");
            }
            
        }
    }
}
