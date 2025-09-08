/*
========================================
 Problem: Returning Strings
========================================
Create a function that accepts a parameter representing a name 
and returns the message exactly like this:

"Hello, <name> how are you doing today?"

----------------------------------------
 Explanation
----------------------------------------
- We define a method `Greet` that takes a string parameter `name`.
- We use **string interpolation** ($"...") to insert the name directly into the message.
- The function returns the greeting string.
*/

using System;

public class Kata
{
    public static string Greet(string name)
    {
        return $"Hello, {name} how are you doing today?";
    }
}

class Program
{
    static void Main()
    {
        // Testing the function with sample inputs
        Console.WriteLine(Kata.Greet("Ibrahim"));
        // Output: Hello, Ibrahim how are you doing today?

  
    }
}
