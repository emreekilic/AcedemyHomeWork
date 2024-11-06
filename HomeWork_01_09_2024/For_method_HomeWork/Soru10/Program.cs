internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("1. sayıyı giriniz:");
        int number1=Convert.ToInt32(Console.ReadLine());
        Console.Write("2. sayıyı giriniz: ");
        int number2=Convert.ToInt32(Console.ReadLine());
        long result=1;
        for (int i = number1; i <=number2; i++)
        {
            result *=i;
        }
        System.Console.WriteLine($"{number1}'den {number2}'e kadar olan sayıların çarpımı: {result}");
        
    }
}