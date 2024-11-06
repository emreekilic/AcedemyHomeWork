namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        int sayi ,toplam =0,sayac=0;
        double ortalama;
        System.Console.WriteLine("Lütfen bir sayı giriniz: ");
        while (true)
        {
            sayi =int.Parse(Console.ReadLine());
            if (sayi>100)
            
             break;
             toplam+=sayi;
             sayac++;   
            
        }
        if (sayac>0)
        {
             ortalama=(double)toplam/sayac;
             System.Console.WriteLine("Girilen sayı adeti: "+ sayac);
             System.Console.WriteLine("Girilen sayıların toplamı: " + toplam);
             System.Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);
        }
        
    }
}
