namespace Soru15;

class Program
{
    static double OrtalamaHesap(int[]dizi)
    {
        int toplam=0;
        foreach (int sayi in dizi)
        {
            toplam+=sayi;
        }
        return(double)toplam/dizi.Length;
    }
    
    
    static void Main(string[] args)
    {
        int [] sayilar={10,20,30,40,50};
        double ortalama=OrtalamaHesap(sayilar);
        Console.WriteLine("Sayıların ortalaması: "+ ortalama);
    }
}
