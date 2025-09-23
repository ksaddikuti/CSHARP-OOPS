using System;

// Blueprint for Car has (Brand + Drive)
public class Car
{
    public string Brand;
    public void Drive() => Console.WriteLine($"{Brand} is driving");
}

public class Program
{
    public static void Main()
    {
        // C is an object that is instantiated using Car class
        Car c = new Car();   // object creation
        
        // dot . operator for using fields and methods
        c.Brand = "Toyota";  // set field
        c.Drive();           // call method
    }
}
