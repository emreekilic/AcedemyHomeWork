namespace Soru2;

class Program
{
    static int Numbers(int number1,int number2)
    {
        if (number1<number2)
        {
            return number2;
        }
        else
        {
            return number1;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Numbers(5,4));
    }
}
