namespace Soru1;

class Program
{
    static string KontrolEt(int age)
    {

        if (age > 65)
        {
            return "Emeklilik Yaşında";
        }
        else
        {
            return "Çalışmaya devam";
        }
    }
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine(KontrolEt(75));
    }
}
