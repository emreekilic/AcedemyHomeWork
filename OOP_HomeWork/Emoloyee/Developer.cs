using System;

namespace Emoloyee;

public class Developer : Employee
{
    public Developer(string names, int id, decimal salary, string programmingLanguage) : base(names, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public string ProgrammingLanguage { get; set; }
    public override void Count()
    {
        base.Count();
        System.Console.WriteLine($"Proglama Dili: {ProgrammingLanguage}");
    }
}
