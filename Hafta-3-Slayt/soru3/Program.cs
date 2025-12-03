namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ders geçme notu 60 olan Algoritma ve Programlama dersinde; geçme 
        notu hesaplanırken Vizenin %40’ı Finalin %60’ı alındığına göre. 
        Öğrencinin algoritma dersinden geçmesi için finalden en az kaç puan 
        alması gerekmektedir? (Dinamik olarak kodlayınız) (quiz olabilirdi)
        Vize notu kullanıcı tarafından girilecek, geçmek için alınması 
        gereken minimum final notu hesaplanacak.*/

            Console.Write("Vize notunuzu giriniz:");
            double vize = Convert.ToDouble(Console.ReadLine());
            /* Finali hesaplamak için final notuna F diyelim vize de V olsun
            (V * 40 / 100) + (F * 60 / 100 = 60) olmalıdır. Gerkli sadeleştirmeler
            ile F yi yanlız bırakırsak şu şekilde olur.*/

            double final = (300 - (2 * vize)) / 3;
            Console.WriteLine("Finalden en az " + final + " almalısınız.");
        }
    }
}
