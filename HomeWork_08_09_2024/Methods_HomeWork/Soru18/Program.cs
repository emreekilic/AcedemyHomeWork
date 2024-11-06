namespace Soru18;

class Program
{
    static string Oluşturma(string ad,string soyAd)
    {
        return $"{ad} {soyAd}";
    }
    static void Main(string[] args)
    {
        string ad="Emre";
        string soyAd="Kılıç";
        string tamİsim=Oluşturma(ad,soyAd);
        Console.WriteLine("Tam isim:"+tamİsim);
    }
}
