namespace Soru10;

class Program
{
    static int Total(int[]dizi)
    {
        int toplam=0;
        foreach (int sayi in dizi)
        {
            toplam+=sayi;
        }
        return toplam;
    }
    static void Main(string[] args)
    {
        int[]sayilar={1,2,3,4,5};
        int toplam=Total(sayilar);
        Console.WriteLine("Sayıların toplamı: "+toplam);
    }
}
