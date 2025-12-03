namespace soru14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir tam sayı dizisinde yan yana olan iki 5'in sayısını sayan bir C# programı yazın. 
            Örnek Giriş : 
            { 5, 5, 2 } 
            { 5, 5, 2, 5, 5 } 
            { 5, 6, 2, 9} 
            Beklenen Çıkış : 
            1 
            2 
            0*/
            int[] dizi1 = { 5, 5, 2 };
            int[] dizi2 = { 5, 5, 2, 5, 5 };
            int[] dizi3 = { 5, 6, 2, 9 };           
            
            int sayac1 = 0;
            int sayac2 = 0;
            int sayac3 = 0;
            for (int i = 0; i < dizi1.Length - 1; i++)
            {
                if (dizi1[i] == 5 && dizi1[i + 1] == 5)
                {
                    sayac1++;
                }
            }
            for (int i = 0; i < dizi2.Length - 1; i++)
            {               
                if (dizi2[i] == 5 && dizi2[i + 1] == 5)
                {
                    sayac2++;
                }                
            }
            for (int i = 0; i < dizi3.Length - 1; i++)
            {               
                if (dizi3[i] == 5 && dizi3[i + 1] == 5)
                {
                    sayac3++;
                }
            }
            Console.WriteLine(sayac1);
            Console.WriteLine(sayac2);
            Console.WriteLine(sayac3);
        }
    }
}
