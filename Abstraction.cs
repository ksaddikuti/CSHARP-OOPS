using System;

public abstract class Vehicke
{
    public string Brnad { get; set; }
    
    public abstract void Drive();
    
    public void Start() 
    {
        Console.WriteLine($"{Brand is starting...}");
    }
}

public interface IRefuelable
{
    void Refuel();
}

public class Car: Vehicle, IRefulable
{
     public override void Drive()   // implementing abstract method
    {
        Console.WriteLine($"{Brand} is driving...");
    }

    public void Refuel()   // implementing interface method
    {
        Console.WriteLine($"{Brand} is refueling...");
    }
}

public class Program
{
    public static void Main()
    {
        // Cannot do: Vehicle v = new Vehicle(); ❌ (abstract class cannot be instantiated)

        Car c = new Car { Brand = "Toyota" };
        c.Start();      // from abstract class (concrete method)
        c.Drive();      // from abstract class (abstract → overridden)
        c.Refuel();     // from interface
    }
}

/* 
Abstract class: Vehicle cannot be instantiated, cna havae abstract methods that
must be implemented and 
normal methods (reusable).

Interface: IRefuelable is a pure contract (only signatures).

Car is a concrete class that inherits form both Vehicle and IRefuelable.

This shows Absstraction - exposes only essential behavior (Drive, Refuel), hiding implementation details

In an abstract class or interfce only defines what must be done, not how.

Vehicle defines Drive() but does not give the explanation.
Child has actual logic
To the user, details are hidden. He just calls Drive() without knowing what happened inside.
*/
