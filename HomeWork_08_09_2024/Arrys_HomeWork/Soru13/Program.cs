namespace Soru13;

class Program
{
    static void Main(string[] args)
    {
        int[]sayilar={2,5,9,3,4,6,11,15,8};
        int toplam=0;
        foreach (int sayi in sayilar)
        {
            if (sayi % 2 !=0)
            {
                toplam+=sayi;
            }
        }
        if (toplam % 2 == 0)
        {
            System.Console.WriteLine("Toplam .çift sayı:  " + toplam);
        }
        else
        {
            System.Console.WriteLine("Toplam tek sayı: " + toplam);
        }
    }
}
