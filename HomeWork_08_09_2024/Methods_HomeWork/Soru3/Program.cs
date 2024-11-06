namespace Soru3;

class Program
{
    static string Kelimeler(string kelime)
    {
        char[] karaterDisizi = kelime.ToCharArray();
        Array.Reverse(karaterDisizi);
        return new string(karaterDisizi);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Kelimeler("Merhaba ben emre"));
    }
}
