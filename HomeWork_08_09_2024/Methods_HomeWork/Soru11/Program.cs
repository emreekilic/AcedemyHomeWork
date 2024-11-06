namespace Soru11;

class Program
{
    static int SesliHarf(string kelime)
    {
        string sesliHarfler="aeıioöuü";
        int sayac=0;
        foreach (char harf in kelime.ToLower())
        {
            if (sesliHarfler.Contains(harf))
            {
                sayac++;
            }
        }
        return sayac;
    }
    static void Main(string[] args)
    {
        Console.Write("Bir kelime giriniz: ");
        string kelime=Console.ReadLine();
        int harfSayisi=SesliHarf(kelime);
        System.Console.WriteLine("Kelimede {0} tane sesli harf var.",harfSayisi);
    }
}
