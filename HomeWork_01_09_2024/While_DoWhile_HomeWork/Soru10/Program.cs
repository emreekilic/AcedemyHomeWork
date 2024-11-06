namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1. Sayıyı giriniz: ");
        int ilkSayi = int.Parse(Console.ReadLine());
        Console.Write("2. sayıyı giriniz: ");
        int ikinciSayi = int.Parse(Console.ReadLine());
        long carpim = 1;
        int sayi = ilkSayi;
       while (sayi <= ikinciSayi)
       {
        carpim *=sayi;
        sayi++;
       }
       System.Console.WriteLine($"{ilkSayi} ile {ikinciSayi} arasındaki sayıların çarpımı: {carpim}");
    }
}
