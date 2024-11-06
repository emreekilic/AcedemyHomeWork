using System;

namespace Vehicle_Management_System;

public class Car : Vehicle
{
    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public int NumberOfDoors { get; set; }
    public override void DisplayCount()
    {
        
        base.DisplayCount(); 
        Console.WriteLine($"{NumberOfDoors} kapısı var.");
    }
}
