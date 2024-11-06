namespace Soru17;

class Program
{
    static void Main(string[] args)
    {
        int[]sayilar={5,2,8,7,10,3,2,4};
        int enBuyuk1=int.MinValue;
        int enBuyuk2=int.MaxValue;

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i]>enBuyuk1)
            {
                enBuyuk2=enBuyuk1;
                enBuyuk1=sayilar[i];
            }
            else if (sayilar[i]>enBuyuk2&&sayilar[i]!= enBuyuk1)
            {
                enBuyuk2=sayilar[i];
            }
        }
        System.Console.WriteLine("En büyük iyi sayı: "+ enBuyuk1 + " ve " + enBuyuk2);
    }
}
