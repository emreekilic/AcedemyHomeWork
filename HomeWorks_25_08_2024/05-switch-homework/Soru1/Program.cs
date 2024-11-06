namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gün sayısı giriniz(1-7); ");
        int dayNo = int.Parse(Console.ReadLine());
        string dayName;

        switch (dayNo)
        {
            case 1:
                dayName="Pazartesi";
                break;
            case 2:
                dayName="Salı";
                break;
            case 3:
                dayName="Çarşamba";
                break;
            case 4:
                dayName="Perşembe";
                break;
            case 5:
                dayName = "Cuma";
                break;
            case 6:
                dayName = "Caumartesi";
                break;
            case 7:
                dayName = "Pazar";
                break;                   
            default:
                dayName="Geçersiz gün sayısı";
                break;
        }
        System.Console.WriteLine("Girinlen gün: " + dayName);
    }
}
