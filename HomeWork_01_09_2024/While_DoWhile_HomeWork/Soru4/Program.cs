namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int toplam=0;
        while (sayi>0)
        {
            toplam += sayi%10;
            sayi /= 10;
        }
        System.Console.WriteLine("Rakamların toplamı: " + toplam);
    }
}
