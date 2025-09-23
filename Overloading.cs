use System;

public class Calculator
{
    
    public int Add(int a, int b) 
    {
        return a + b;
    }
    
    public double Add(double a, double b)
    {
        return a + b;
    }
    
    public int Add(int a, int b, int c) 
    {
        return a + b + c;
    }
}

public class Program 
{
    public static void Main()
    {
        Calculator calc = new Calculator();
        
        Console.WriteLine(calc.Add(2, 3));           // calls int Add(int, int)
        Console.WriteLine(calc.Add(2.5, 3.5));       // calls double Add(double, double)
        Console.WriteLine(calc.Add(1, 2, 3));        // calls int Add(int, int, int)
      }
}


/*
Overloading = same method name, differenr signatures (different parametrs in number or type).
Decided at compile time: compiler chooses right version.

In C#, overloading is compile-time polymorphism - dame method name, different parameter lists.
Overriding is runtime polymorphism - child overrides parents method marked virtual.

Here Add is overloaded with different signatures and the compiler picls the right one.
*/
