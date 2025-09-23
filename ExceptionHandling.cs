using System;

public class Program 
{
    public static void Main() 
    {
        try 
        {
            int x = 20;
            int y = 0;
            int result = x/y;
            Console.WriteLine(result);
        }
        
        catch (DivideByZeroException ex) 
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Details: {ex.Message}");        
        }
        
        finally
        {
            Console.WriteLine("Finally block always runs (cleanup).");
        }
    }
}

/*
Error: Division by zero is not allowed.
Details: Attempted to divide by zero.
Finally block always runs (cleanup).

In C# exceptions are handled with a try-catch-finally block.
If something goes wring inside try, control move to catch.
finally always runs for cleanup.
*/
