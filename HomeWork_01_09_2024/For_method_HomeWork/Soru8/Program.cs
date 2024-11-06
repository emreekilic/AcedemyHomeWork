namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        for (int i = sayi; i >=1; i--)
        {
            int kare = i*i;
            Console.WriteLine($"{i}^2 = {kare}");
        }
    }
}
