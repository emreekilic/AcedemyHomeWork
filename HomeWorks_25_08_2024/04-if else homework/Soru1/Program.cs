namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if(0 < number)
        {
            Console.WriteLine("Girilen sayı pozitiftir.");
        }
        else if (number < 0)
        {
            System.Console.WriteLine("Girilen sayı negatiftir.");
        }
        else 
        {
            System.Console.WriteLine("Girilen sayı sıfırdır.");
        }
    }
}
