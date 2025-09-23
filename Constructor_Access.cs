using System;

// Blueprint for Car has (Brand + Drive)
public class Car
{
    // private field (hidden from outside)
    private string Brand;
    
    //Constructor (rund when object is created)
    public Car(string brand) 
    {
        Brand = brand;
    }
    
    // public method to access private field
    public void Drive() => Console.WriteLine($"{Brand} is driving");
}

public class Program
{
    public static void Main()
    {
        Car c = new Car("Toyota");   // object creation using constructor
        c.Drive();  
    }
}
