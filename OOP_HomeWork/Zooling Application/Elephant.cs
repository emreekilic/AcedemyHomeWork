using System;

namespace Zooling_Application;

public class Elephant : Animal
{
    public Elephant(string names, int age, string tür) : base(names, age, tür)
    {
    }
    public override void MakeSound()
    {
        Console.Write("Fil boru sesi çıkardı");
        base.MakeSound();
    }
}
