using System.Globalization;

namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
       int number ,toplam =0;
       while (true)
       {
          System.Console.WriteLine("Bir sayı giriniz");
          int sayi =Convert.ToInt32(Console.ReadLine());

          if (sayi==0)
          {
            break;
          }
          toplam+=sayi;
          System.Console.WriteLine("Şu ana kadarki: {0}",toplam);
        }
        System.Console.WriteLine("Girilen sayıların toplamı: {0} ",toplam);
      
    }
}
