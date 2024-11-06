namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı yazınız: ");
        int number = Convert.ToInt32(Console.ReadLine());
     System.Console.WriteLine($"{number} sayısını tam bölenler");
        for (int i = 1; i < number; i++)
        {
            if(number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
         
    }
}
