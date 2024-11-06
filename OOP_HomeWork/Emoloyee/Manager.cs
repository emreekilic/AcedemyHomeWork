using System;

namespace Emoloyee;

public class Manager : Employee

{
    public Manager(string names, int id, decimal salary, int numbersOfTeams) : base(names, id, salary)
    {
        NumbersOfTeams = numbersOfTeams;
    }
    public int NumbersOfTeams { get; set; } 

    public override void Count()
    {
        base.Count();
        System.Console.WriteLine($"Takım sayısı: {NumbersOfTeams}");
    }
}
