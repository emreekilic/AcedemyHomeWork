using System;

namespace Vehicle_Management_System;

public class Vehicle
{
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public string Make { get; set; }
    public string Model { get; set; }

    public int Year { get; set; }

    public virtual void DisplayCount()
    {
        System.Console.WriteLine($"Araç Markası: {Make}\nAraç Modeli: {Model}\nÜretim Yılı: {Year}");
    }
}
