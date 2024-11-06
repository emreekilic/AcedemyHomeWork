namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir tarih giriniz(gg.aa.yyyy): ");
        string inputDate = Console.ReadLine();

        if (DateTime.TryParse(inputDate, out DateTime date))
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            System.Console.WriteLine($"Tarih: {date.ToShortDateString()}");
           System.Console.WriteLine($"Haftanın günü: {dayOfWeek}");
        }
        else
        {
            System.Console.WriteLine("Geçersiz tarih formatı");
        }
    }
}
