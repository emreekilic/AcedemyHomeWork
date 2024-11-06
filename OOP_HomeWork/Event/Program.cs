namespace Event;

class Program
{
    static void Main(string[] args)
    {
        Birthday birthday= new Birthday("Beyzanın Doğum günü",new DateTime(2002,12,16),"Ordu");
        birthday.Count();
        birthday.BirthOfComplete();
        System.Console.WriteLine("**************");
        Meeting meeting= new Meeting("İş Toplantısı",new DateTime(2026,8,22),"Almanya");
        meeting.Count();
        meeting.MeetinOfComple();
        System.Console.WriteLine("***************");
        Task task = new Task("Home Work",new DateTime(2024,9,22),"Trabzon");
        task.Count();
        task.MarkAsComplete();
    }
}
