namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı yazınız: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        bool asalMi=true;
        for (int i = 2; i < sayi; i++)
        {
            if(sayi %i ==0)
            {
                asalMi=false;
                break;
            }
        }
        if(asalMi)
        {
            Console.WriteLine($"{sayi} asal sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} asal sayı değildir.");
        }
    }
}
