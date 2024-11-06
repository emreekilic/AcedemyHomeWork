using System;

namespace Vehicle_Management_System;

public class Motorcyle : Vehicle
{
    public Motorcyle(string make, string model, int year, string hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }

    public string HasSidecar { get; set; }
    public override void DisplayCount()
    {
        
        base.DisplayCount();
        Console.WriteLine($"{HasSidecar} var");
    }
}
