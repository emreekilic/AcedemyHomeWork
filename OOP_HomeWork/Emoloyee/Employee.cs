using System;
using System.Runtime.ConstrainedExecution;

namespace Emoloyee;

public class Employee
{
    public Employee(string names, int id, decimal salary)
    {
        Names = names;
        İd = id;
        Salary = salary;
    }

    public string Names { get; set; }
    public int İd { get; set; }
    public decimal Salary { get; set; }

    public virtual void Count()
    {
        System.Console.WriteLine($"İsim: {Names}\nİd: {İd}\nMaaş: {Salary}");
    }
}
