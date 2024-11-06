namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int tesSayi= 0;
        while (sayi !=0)
        {
            int basamak = sayi%10;
            tesSayi= tesSayi*10+basamak;
            sayi/=10;
        }
        System.Console.WriteLine("Sayının tersi: " + tesSayi);
    }
}
