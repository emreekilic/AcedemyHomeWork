namespace Soru9;

class Program
{
    static int SmallNumber(int[]dizi)
    {
        int enKucuk=dizi[0];
        for (int i = 1; i <dizi.Length; i++)
        {
            if (dizi[i]<enKucuk)
            {
                enKucuk=dizi[i];
            }
        }
        return enKucuk;
    }
    static void Main(string[] args)
    {
        int[]sayilar={5,2,6,1,3,8};
        int enKucuk=SmallNumber(sayilar);
        System.Console.WriteLine("En küçük sayı: " + enKucuk);
    }
}
