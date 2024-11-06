using System;

namespace Event;

public class Meeting : Event
{
    public Meeting(string name, DateTime date, string location) : base(name, date, location)
    {
    }

    public void MeetinOfComple()
    {
        System.Console.WriteLine("Toplantı Yapıldı !!");
    }
}
