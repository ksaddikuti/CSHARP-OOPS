using System;

public class Car
{
    private string brand;
    private string color;

    // Allowed colors
    private static readonly string[] allowedColors = { "black", "blue", "white", "grey" };

    // Constructor
    public Car(string brand, string color)
    {
        Brand = brand;
        Color = color;   // uses setter (validation happens here)
    }

    // Brand property (simple)
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    // Color property with validation
    public string Color
    {
        get { return color; }
        set
        {
            // check if entered color is in allowedColors list
            if (Array.Exists(allowedColors, c => c == value.ToLower()))
                color = value;
            else
                Console.WriteLine($"Invalid color '{value}'. Allowed: {string.Join(", ", allowedColors)}");
        }
    }

    // Method to show car details
    public void Drive() => Console.WriteLine($"{Brand} is driving in {Color} color");
}

public class Program
{
    public static void Main()
    {
        Car c = new Car("Toyota", "blue");   // valid
        c.Drive();

        c.Color = "black";   // valid update
        c.Drive();

        c.Color = "red";     // invalid, rejected
        c.Drive();
    }
}
