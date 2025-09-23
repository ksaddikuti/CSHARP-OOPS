using System;

public class Vehicle 
{
    public string Brand { get; set; }
    public virtual void Drive() 
    {
        Console.WriteLine($"Vehicle {Brand} is driving");
    }
}

public class Car: Vehicle 
{
    public override void Drive()
    {
        Console.WriteLine($"Car {Brand} is driving");
    }
}

public class Program 
{
    public static void Main() 
    {
        Vehicle v = new Vehicle { Brand = "Generic" };
        v.Drive();

        Car c = new Car { Brand = "Toyota" };
        c.Drive();

        // Polymorphism (parent reference, child object)
        Vehicle poly = new Car { Brand = "Honda" };
        poly.Drive();
        
    }
}
