using System.Diagnostics.Metrics;

namespace soru7
{
    internal class Program
    {
            /*• Bir programda eleman sayısı başlangıçta bilinmediği durumlarda
            kullanılan dinamik dizi yapısını modelleyen bir metot yazınız.
             • Bu metot aşağıdaki özellikleri sağlamalıdır:
             • Dizi başlangıçta belirli bir kapasite ile oluşturulmalıdır.
             • Dizi dolduğunda kapasite otomatik olarak artırılmalıdır(örneğin
             kapasite iki katına çıkarılabilir).
             • Kapasite artırıldığında daha büyük bir dizi oluşturulmalı ve mevcut
             elemanlar bu yeni diziye kopyalanmalıdır.
             • Metot, yeni elemanların diziye eklenmesini sağlamalıdır*/
            static int[] diziyeElemanEkle(int[] dizi, int indis, int eleman)
            {
                if (indis >= dizi.Length)
                {
                    int[] yeniDizi = new int[dizi.Length];

                    for (int i = 0; i < dizi.Length; i++)
                    {
                        yeniDizi[i] = dizi[i];
                    }
                    dizi = yeniDizi;
                }
                dizi[indis] = eleman;
                return dizi;
            }
            static void Main(string[] args)
            {
                int[] dizi= new int[3];
                for (int i = 0; i < 10; i++)
                {
                    dizi = diziyeElemanEkle(dizi, i, i * 10);
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(dizi[i] + " ");
                }
                Console.WriteLine();

            }

        
    }
}
