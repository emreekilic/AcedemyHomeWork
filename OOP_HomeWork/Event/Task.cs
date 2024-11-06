using System;

namespace Event;

public class Task : Event
{
    public Task(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public void MarkAsComplete()
    {
        System.Console.WriteLine("Görev Tamamlandı !!");
    }
}
