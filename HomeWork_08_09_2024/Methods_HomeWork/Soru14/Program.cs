using System.Diagnostics.Contracts;

namespace Soru14;

class Program
{
    static int Gün(DateTime başlangic,DateTime bitis)
    {
        TimeSpan fark = bitis-başlangic;
        return fark.Days;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Başlangıç tarihi(YYYY-AA-GG): ");
        DateTime baslangicTarih=DateTime.Parse(Console.ReadLine());
        Console.Write("Bitiş tarihi(YYYY-AA-GG): ");
        DateTime bitisTarihi=DateTime.Parse(Console.ReadLine());
        int gunSayisi=Gün(baslangicTarih,bitisTarihi);
        Console.WriteLine("İki tarih arasında {0} gün var.",gunSayisi);
    }
}
