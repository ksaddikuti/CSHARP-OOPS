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

/*
“Here, Car inherits from Vehicle.
The parent’s Drive is marked virtual, and the child overrides it.
When I use a parent reference pointing to a child object, 
the child’s method runs at runtime — this is runtime polymorphism.
*/
