using System.Runtime.InteropServices;

namespace Soru7;

class Program
{
    static string Times(int saat, int dakika, int saniye)
    {
        return string.Format("{0:00}:{1:00}:{2:00}", saat, dakika, saniye);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Times(11, 6, 26));
    }
}
