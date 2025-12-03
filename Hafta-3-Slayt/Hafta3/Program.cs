namespace Hafta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcının adını, soyadını, doğduğu  şehri ve doğum yılını alın. Bu bilgileri ve 
            içinde bulunduğumuz yılı kullanarak kullanıcıya aşağıdaki formatla kişisel bir 
            mesaj yazdırın:
            • "Merhaba Ahmet Kara, İstanbul’da doğmuşsun ve şu anda 23 yaşındasın!*/

            Console.Write("Adınız ve soyadınız:");//Birlikte kullanıldığı için birlikte alalım.
            string isim = Convert.ToString(Console.ReadLine());
            Console.Write("Doğduğunuz şehri giriniz:");
            string sehir = Convert.ToString(Console.ReadLine());
            Console.Write("Doğum yılınızı giriniz:");
            int dogum = Convert.ToInt32(Console.ReadLine());

            //int yas = 2025 - yil;//Yaşını hesapladık.
            //Verilen ipucu ile hesaplama...
            int yil = DateTime.Now.Year;
            int yas = yil - dogum;

            Console.WriteLine("Merhaba " + isim + ", " + sehir + "'da doğmuşsun ve şu an " + yas + " yaşındasın!");
        }
    }
}
