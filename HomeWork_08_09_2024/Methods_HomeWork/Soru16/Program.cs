namespace Soru16;

class Program
{
    static bool Polidrom(string kelime)
    {
        kelime=kelime.ToLower();
        int bas=0;
        int son=kelime.Length-1;
        while (bas<son)
        {
            if (kelime[bas]!=kelime[son])
            {
                return false;
            }
            bas++;
            son--;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.Write("Bir kelime giriniz: ");
        string kelime=Console.ReadLine();
        if (Polidrom(kelime))
        {
            System.Console.WriteLine("{o} kelimesi polidromdur.",kelime);
        }
        else
        {
            System.Console.WriteLine("{0} kelimesi polidrom değildir.",kelime);
        }
        
    }
}
