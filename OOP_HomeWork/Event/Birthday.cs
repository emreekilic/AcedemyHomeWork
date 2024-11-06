using System;

namespace Event;

public class Birthday : Event
{
    public Birthday(string name, DateTime date, string location) : base(name, date, location)
    {
    }

    public void BirthOfComplete()
    {
        System.Console.WriteLine("Doğum günü Kutlandı !!!!");
    }
}
