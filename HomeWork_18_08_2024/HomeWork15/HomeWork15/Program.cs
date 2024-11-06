namespace HomeWork15;

class Program
{
    static void Main(string[] args)
    {
        string isTrue = "True";
        bool numberBoool;

        bool result = bool.TryParse(isTrue, out result);
        Console.Write(result);
    }
}
