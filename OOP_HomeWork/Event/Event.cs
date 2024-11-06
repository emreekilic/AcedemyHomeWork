using System;

namespace Event;

public class Event
{
    public Event(string name, DateTime date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }

    public virtual void Count()
    {
        System.Console.WriteLine($"Etkinlik Adı: {Name}\nEtkinlik Tarihi: {Date}\nEtkinlik Yeri: {Location}");
    }
}
