namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int result = int.Parse(Console.ReadLine());
        for (int i = 1; i <= result; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();
        }
        
    }
}
