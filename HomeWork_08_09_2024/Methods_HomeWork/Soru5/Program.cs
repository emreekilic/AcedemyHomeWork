namespace Soru5;

class Program
{
    static string[] BigNames(string[] name)
    {
        for (int i = 0; i < name.Length; i++)
        {
            name[i]= name[i].ToUpper();
        }
        return name;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(BigNames);
    }
}
