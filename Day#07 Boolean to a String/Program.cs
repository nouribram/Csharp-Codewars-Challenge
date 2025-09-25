/*
    Convert a Boolean to a String
    --------------------------------------------
    Problem:
    Write a function that takes a boolean value (true or false) 
    and returns it as a string ("True" or "False").

    Examples:
    Input: true   → Output: "True"
    Input: false  → Output: "False"
    
    --------------------------------------------
    Solution Approach:
    1. Accept a boolean as input.
    2. Call .ToString() on it.
    3. Return the resulting string.
  
*/

using System;

public class Program
{
    public static string BooleanToString(bool b)
    {
        // Convert boolean directly to string
        return b.ToString();
    }

    public static void Main()
    {
        // Test cases
        Console.WriteLine(BooleanToString(true));   // Output: "True"
        Console.WriteLine(BooleanToString(false));  // Output: "False"
    }
}
