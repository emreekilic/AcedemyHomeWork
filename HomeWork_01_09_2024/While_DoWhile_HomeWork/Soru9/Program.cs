namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir pozitif sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 2;
        System.Console.WriteLine("1 den " + sayi + "' ye kadar olan asal sayılar");

        while (sayac <= sayi)
        {
            bool asalMi =true;
            int bolen =2;
            while (bolen <= Math.Sqrt(sayac))
            {
                if (sayac % bolen ==0)
                {
                    asalMi = false;
                    break;
                }
                bolen++;
            }
            System.Console.WriteLine(sayac + "-" +(asalMi? "Asal" : "Asal değil"));
            sayac++;
        }
    }
}
