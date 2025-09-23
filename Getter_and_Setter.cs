using System;

public class Vehicle
{
    // 1. Public field (❌ not recommended, breaks encapsulation)
    public string PublicField;

    // 2. Auto-property (shortest form, compiler creates private backing field)
    public string Brand { get; set; }

    // 3. Auto-property with restricted setter
    public string Model { get; private set; }

    // 4. Full property with private backing field
    private string color;
    public string Color
    {
        get { return color; }          // getter
        set { color = value; }         // setter
    }

    // 5. Full property with validation
    private string fuel;
    public string Fuel
    {
        get { return fuel; }
        set
        {
            if (value.ToLower() == "petrol" || value.ToLower() == "diesel")
                fuel = value;
            else
                Console.WriteLine($"Invalid fuel: {value}");
        }
    }

    // Constructor to set restricted property (Model)
    public Vehicle(string model)
    {
        Model = model;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"PublicField: {PublicField}, Brand: {Brand}, Model: {Model}, Color: {Color}, Fuel: {Fuel}");
    }
}

public class Program
{
    public static void Main()
    {
        // Using different styles
        Vehicle v = new Vehicle("Civic")
        {
            PublicField = "Not Safe Example",
            Brand = "Honda",
            Color = "Red",
            Fuel = "Petrol"
        };

        v.ShowInfo();

        // Demonstrating validation
        v.Fuel = "Water"; // invalid
        v.ShowInfo();
    }
}


/*
Output: 
PublicField: Not Safe Example, Brand: Honda, Model: Civic, Color: Red, Fuel: Petrol
Invalid fuel: Water
PublicField: Not Safe Example, Brand: Honda, Model: Civic, Color: Red, Fuel: Petrol
*/

/*
Explanation

Public field → accessible directly, no control. (Not recommended in OOP.)

Auto-property → public string Brand { get; set; } → simplest, compiler hides private field.

Auto-property with restricted setter → public string Model { get; private set; } → read outside, set only inside.

Full property → manually write getter and setter around a private field.

Full property with validation → setter includes logic (e.g., allowed values only).
*/

/*
In C#, properties can be written in different ways.
The simplest is an auto-property (Brand).
If I need rules, I use a full property (Fuel) with validation.
If I want read-only from outside, I make the setter private.
This is all about encapsulation and controlling access to data.
*/
