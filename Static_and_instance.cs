/*
1. Instance Members:
Belong to each object.
each object has its own copy of instance fields
need to use new keyword to access them
*/

public class Car
{
    public string Brand;  // instance field
    
    public void Drive()   // instance method
    {
        Console.WriteLine("The car is driving");    
    }
}

/*
Usage:

Car c1 = new Car { Brand = "Toyota" };
Car c2 = new Car { Brand = "Honda" };
c1.Drive();  // Toyota is driving
c2.Drive();  // Honda is driving

*/


/*
2. Static Members
Belong to the class, not the object
Only on ecpoy exists for all the objects
Accessed using the class name
*/


public class Car
{
    public string Brand;
    
    public static int Wheels = 4;
    
    public static void ShowWheels()
    {
        Console.WriteLIne("this is wheels")
    }
}

/*
Usage:

Car.showWheels();

*/


/*
3. Static class
Declared with static
cannot be instantiated with new
can only have static members
*/

public static class Utility
{
    public static double Add(double a, double b) => a + b;
}

/*
Usage:
Console.WriteLine(Utility.Add(2, 3)); // 5
*/

/*
4. Singleton Pattern 

Ensures that only on eobject of the class exists
uses a private constructor and a static instance 
*/


public class Singleton 
{
    private static Singleton instance;
    
    private Singleton() {}
    {
        if(instance == null) {
            instance = new Singleton();
        }
        return instance;
    }
}

/*
Usage:

var obj1 = Singleton.GetInstance();
var obj2 = Singleton.GetInstance();
Console.WriteLine(obj1 == obj2);  // True (same object)
*/

/*Instance members belong to the object, each object has its own copy.
Static menbers belong to the class, there is only one copy for all the objects.
Static classes cannot be instantiated and a singleton uses static + private ocnstructor to enduse only one instance exists.
*/
