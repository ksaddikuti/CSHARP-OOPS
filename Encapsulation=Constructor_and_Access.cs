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

/*

Encapsulation: OOPS principle of wrapping code of data and behavoir together in a class.
While restricting direct access to hte data using access modifiers.

Insted of exposing variabled directly, we use constructors or methods or properties to control
how data is read or changed

Why Encapusaltion:

private string Brand; //Hidden field
public Car(string brand) {Brand = brand;} //controlled initialization
public void Drive() { Console.WriteLine($"{Brand} is driving"); }  // controlled access


Here the brand is private and it cannot be accessed doreclty so I used a constructor to 
set it and a public method to show it.

Encapsulation in C# means hiding fields using private access and exposing them through 
controlled methods or properties. This prevents misuse and enforces rules. 
In my example, I made Brand private, then used a constructor and a public method to access it 
— that’s encapsulation.
*/



/*
Without encapsulation:

public class Car
{
    public string Brand;  // directly public
}
Car c = new Car();
c.Brand = "Toyota";   // anyone can modify freely
*/
